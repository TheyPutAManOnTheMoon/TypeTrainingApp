Public Class p2_Exercise

    Event zdIsFinished()
    Event zdExit()

    Private mStw1 As New Stopwatch
    Private WithEvents mTicker1 As New Timer
    Private WithEvents mTicker2 As New Timer

    Private mQErrors As Integer = 0
    Private mTotalCards As Integer = 1000
    Private mTypedCards As Integer = 0
    Private mChars As Char() = New Char() {"G", "H", "F", "J"}
    Private mCurrentCard As Char = "G"

    Private Function GetRandom(ByVal min As Integer, ByVal max As Integer)
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(min, max)
    End Function
    Private Function GetKeysMin() As Integer

        Dim s As Integer = 1
        Dim c As Integer = 1
        Dim cs As Double

        If mStw1.Elapsed.TotalSeconds > 1 Then s = mStw1.Elapsed.TotalSeconds
        If mTypedCards > 1 Then c = mTypedCards

        cs = c / s
        cs = cs * 60
        cs = Math.Floor(cs)

        Return CInt(cs)

    End Function

    Private Sub UpdateLCardCnt()

        Label2.Text = mTotalCards - mTypedCards
        Label3.Text = mTypedCards

    End Sub
    Private Sub UpdateLErrorCnt()

        Label5.Text = "Errors: " & mQErrors

    End Sub
    Private Sub UpdateLStw()

        With mStw1.Elapsed

            Label4.Text = .Minutes.ToString("00") & ":" & _
            .Seconds.ToString("00")

        End With

    End Sub
    Private Sub UpdateLKeysMin()

        Label6.Text = GetKeysMin() & " keys/min"

    End Sub
    Private Sub UpdateCard()

        ZCard1.zText = mCurrentCard

    End Sub   

    Public Sub zStart()

        mStw1.Reset()
        mStw1.Start()
        mTicker1.Start()
        mTicker2.Start()

        mQErrors = 0
        mTypedCards = 0
        mCurrentCard = mChars(0)

        UpdateCard()
        UpdateLCardCnt()
        UpdateLErrorCnt()
        UpdateLStw()
        UpdateLKeysMin()

    End Sub
    Private Sub Finish()

        mStw1.Stop()
        mTicker1.Stop()
        mTicker2.Stop()
        ZCard1.zKillAnimation()

    End Sub
    Private Function NextCard() As Boolean

        Dim v As Integer = GetRandom(0, mChars.Length)

        mTypedCards += 1
        UpdateLCardCnt()

        If mTypedCards >= mTotalCards Then Return False

        mCurrentCard = mChars(v)
        UpdateCard()

        Return True

    End Function

    Friend WriteOnly Property zIN_Chars() As Char()
        Set(ByVal value As Char())
            Erase mChars
            mChars = value.Clone
        End Set
    End Property
    Friend WriteOnly Property zIN_QCards() As Integer
        Set(ByVal value As Integer)
            mTotalCards = value
        End Set
    End Property
    Friend ReadOnly Property zOUT_Result() As zuResult
        Get

            Dim r As New zuResult

            r.z0Date = Date.Now
            r.z1Time = mStw1.Elapsed
            r.z2Cards = mTotalCards
            r.z3KeysMin = GetKeysMin()
            r.z4Errors = mQErrors

            Return r

        End Get
    End Property

    Private Sub hTick1() Handles mTicker1.Tick

        UpdateLStw()

    End Sub
    Private Sub hTick2() Handles mTicker2.Tick

        UpdateLKeysMin()

    End Sub

    Public Sub zEnterKey(ByVal aChar As Char)

        If ZCard1.zIsBlocked = True Then Exit Sub
        If Me.Visible = False Then Exit Sub

        If aChar = mCurrentCard Then
            NextCard()
            ZCard1.zAnimateConfirm()
        Else
            mQErrors += 1
            UpdateLErrorCnt()
            ZCard1.zAnimateWrong()
        End If

        If mTypedCards >= mTotalCards Then
            Finish()
            RaiseEvent zdIsFinished()
        End If

    End Sub
    Private Sub hButton1_Click() Handles NavigationBar1.zdButtonL_Clicked

        Finish()
        RaiseEvent zdExit()

    End Sub

    Public Sub zInitLayout()

        NavigationBar1.zInitLayout()

        Dim x As Integer = (Me.Width - ZCard1.Width) / 2
        Dim y As Integer = (Me.Height - NavigationBar1.Height - TLP1.Height) / 2
        y -= TLP1.Height

        ZCard1.Location = New Point(x, y)

    End Sub
    Sub New()

        InitializeComponent()

        mTicker1.Interval = 100
        mTicker2.Interval = 1000

        UpdateLCardCnt()
        UpdateLErrorCnt()
        UpdateLStw()
        UpdateLKeysMin()
        UpdateCard()

    End Sub
    
End Class
