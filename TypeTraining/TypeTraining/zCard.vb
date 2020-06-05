Imports System.Drawing.Drawing2D

Public Class zCard
    Inherits Control

    Private Const yeLength As Integer = 200
    Private Const yeInterval As Integer = 50
    Private Const yeUnits As Integer = yeLength / yeInterval

    Private Const noLength As Integer = 1500
    Private Const noInterval As Integer = 40
    Private Const noUnits As Integer = 360 / (noLength / noInterval)

    Private WithEvents yeTicker1 As New Timer
    Private WithEvents noTicker1 As New Timer

    Private mStrF As New StringFormat

    Private mColorNormal As Color = Color.Gainsboro
    Private mColorCorrect As Color = Color.DarkSeaGreen
    Private mColorFade As Color()
    Private mColorWrong As Color = Color.Red
    Private mColorPie As Color = Color.Firebrick
    Private mColorBorder As Color = Color.Black

    Private mBackColor As Color = mColorNormal
    Private mText As String = ""
    Private mPieAngle As Integer = 0
    Private mPieRect As Rectangle
    Private mFadeCnt As Integer = 0

    Public Function zGenGradiant(ByVal aColor1 As Color, ByVal aColor2 As Color, _
                                 ByVal aQTones As Integer, _
                                 Optional ByVal aSkewProc_Pos As Integer = 50, _
                                 Optional ByVal aSkewProc_Fac As Integer = 50) As Color()

        If aSkewProc_Pos < 2 Or aSkewProc_Pos > 99 Then Return Nothing
        If aSkewProc_Fac < 2 Or aSkewProc_Fac > 99 Then Return Nothing

        Dim p1 As Point = New Point(0, 10)
        Dim p2 As Point = New Point(aQTones * 5, 10)
        Dim linGrBrush As New LinearGradientBrush(p1, p2, aColor1, aColor2)

        Dim bl As New Blend()
        bl.Positions = New Single() {0.0F, aSkewProc_Pos / 100, 1.0F}
        bl.Factors = New Single() {0.0F, aSkewProc_Fac / 100, 1.0F}
        linGrBrush.Blend = bl

        Dim pic As New Bitmap(aQTones * 5, 10)
        Dim g As Graphics = Graphics.FromImage(pic)
        g.FillRectangle(linGrBrush, New Rectangle(0, 0, pic.Width, pic.Height))

        Dim arr As Color() = New Color(aQTones) {}
        Dim pos As Integer = 1

        For i As Integer = 1 To pic.Width Step 5
            arr(pos) = pic.GetPixel(i - 1, 1)
            pos += 1
        Next

        Return arr

    End Function
    Private Function GetDrawSurface() As Rectangle

        Dim w As Integer = Me.Width - Me.Padding.Left - Me.Padding.Right
        Dim h As Integer = Me.Height - Me.Padding.Top - Me.Padding.Bottom
        Dim x As Integer = Me.Padding.Left
        Dim y As Integer = Me.Padding.Top

        Return New Rectangle(x, y, w, h)

    End Function

    Private Sub RefreshPieR()

        Dim r As Rectangle = GetDrawSurface()
        Dim l As Integer = r.Width / 2

        If r.Width > r.Height Then l = r.Height / 2

        mPieRect.Size = New Size(l, l)
        mPieRect.Location = New Point((r.Width - l + r.Location.X) / 2, _
                                      (r.Height - l + r.Location.Y) / 2)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintBackground(pevent)

        Dim r As Rectangle = New Rectangle(New Point(0, 0), Me.Size)

        With pevent.Graphics

            .InterpolationMode = InterpolationMode.Low
            .SmoothingMode = SmoothingMode.HighSpeed

            .FillRectangle(New SolidBrush(mColorBorder), r)
            .FillRectangle(New SolidBrush(mBackColor), GetDrawSurface)

        End With

    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        RefreshPieR()

        With e.Graphics

            Dim r As Rectangle = GetDrawSurface()

            .InterpolationMode = InterpolationMode.High
            .SmoothingMode = SmoothingMode.HighQuality

            .FillPie(New SolidBrush(mColorPie), mPieRect, 0, mPieAngle)
            .DrawString(mText, Me.Font, Brushes.Black, r, mStrF)

        End With

    End Sub

    Private Sub hrTick1() Handles yeTicker1.Tick

        mFadeCnt += 1

        If mFadeCnt > yeUnits Then
            yeTicker1.Enabled = False
            mBackColor = mColorNormal
        Else
            mBackColor = mColorFade(mFadeCnt)
        End If

        Me.Invalidate()
        Me.Update()

    End Sub
    Private Sub hfTick1() Handles noTicker1.Tick

        mPieAngle += noUnits

        If mPieAngle > 360 Then
            noTicker1.Enabled = False
            mBackColor = mColorNormal
            mPieAngle = 0
        End If

        Me.Invalidate()
        Me.Update()

    End Sub

    Public Sub zAnimateConfirm()

        If noTicker1.Enabled = True Then Exit Sub

        mFadeCnt = 0
        yeTicker1.Enabled = True

    End Sub
    Public Sub zAnimateWrong()

        If noTicker1.Enabled = True Then Exit Sub
        If yeTicker1.Enabled = True Then yeTicker1.Enabled = False

        mBackColor = mColorWrong
        mPieAngle = 0
        noTicker1.Enabled = True

    End Sub
    Public Sub zKillAnimation()

    End Sub

    Public ReadOnly Property zIsBlocked() As Boolean
        Get
            Return noTicker1.Enabled
        End Get
    End Property
    Public Property zText() As String
        Get
            Return mText
        End Get
        Set(ByVal value As String)

            If zIsBlocked = True Then Exit Property
            If mText = value Then Exit Property

            mText = value
            Me.Invalidate()
            Me.Refresh()

        End Set
    End Property

    Sub New()

        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        mStrF.Alignment = StringAlignment.Center
        mStrF.LineAlignment = StringAlignment.Center

        mColorFade = zGenGradiant(mColorCorrect, mColorNormal, yeUnits)

        yeTicker1.Interval = yeInterval
        noTicker1.Interval = noInterval

    End Sub

End Class
