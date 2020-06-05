Public Class p1_StartWindow

    Event zdStart()
    Private mLUTQCards As Integer() = New Integer(CARDS_QSTEPS) {}

    Private Function IsValidChar(ByVal aInput As Char) As Boolean

        If Char.IsSeparator(aInput) = True Then Return False
        If Char.IsControl(aInput) = True Then Return False
        Return True

    End Function
    Private Function Chars_EraseRedundant(ByRef aInput As Char()) As Char()

        If aInput Is Nothing Then Return Nothing

        Dim IsDouble As Boolean() = New Boolean(aInput.Length) {}
        Dim cntr As Integer = 0
        Dim chrArr1 As Char() = New Char(aInput.Length - 1) {}

        For i As Integer = 0 To aInput.Length - 1
            If IsDouble(i) = True Then Continue For

            For j As Integer = i + 1 To aInput.Length - 1
                If aInput(i) = aInput(j) Then IsDouble(j) = True
            Next

            chrArr1(cntr) = aInput(i)
            cntr += 1
        Next

        ReDim Preserve chrArr1(cntr - 1)
        Return chrArr1

    End Function
    Private Function Chars_EraseInvalid(ByVal aInput As Char()) As Char()

        If aInput Is Nothing Then Return Nothing

        Dim cntr As Integer = 0
        Dim chrArr1 As Char() = New Char(aInput.Length - 1) {}
        Dim chrV As Char

        For i As Integer = 0 To aInput.Length - 1
            chrV = aInput(i)
            If IsValidChar(chrV) = False Then Continue For

            chrArr1(cntr) = chrV
            cntr += 1
        Next

        If cntr <> 0 Then
            ReDim Preserve chrArr1(cntr - 1)
            Return chrArr1
        Else
            Return Nothing
        End If

    End Function
    
    Private Function GetChars() As Char()

        Dim txt1 As String = RichTextBox1.Text.ToUpper()
        Dim chr1 As Char() = txt1.ToCharArray()
        Dim chr2 As Char() = Chars_EraseInvalid(chr1)

        If chr2 IsNot Nothing Then
            Return Chars_EraseRedundant(chr2)
        Else
            Return Nothing
        End If

    End Function
    Private Function GetQChars() As Integer

        Dim chrsInput As Char() = GetChars()
        Dim q As Integer = 0

        If chrsInput IsNot Nothing Then q = chrsInput.Length
        Return q

    End Function
    Private Function GetQCards() As Integer

        Return mLUTQCards(TrackBar1.Value)

    End Function

    Public ReadOnly Property z1Chars() As Char()
        Get
            Return GetChars()
        End Get
    End Property
    Public ReadOnly Property z2QCards() As Integer
        Get
            Return GetQCards()
        End Get
    End Property

    Private Sub hRTB1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles RichTextBox1.TextChanged

        Dim q As Integer = GetQChars()

        Label1.Text = q & " chars identified"
        NavigationBar1.zButtonR_Enabled = CBool(q)

    End Sub   
    Private Sub hTrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        LabelInd1.Text = GetQCards()

    End Sub
    Private Sub hBtnClicked_Start() Handles NavigationBar1.zdButtonR_Clicked

        RaiseEvent zdStart()

    End Sub

    Public Sub zInitLayout()

        PanelMain.Location = New Point((Me.Width - PanelMain.Width) / 2, _
                                       (Me.Height - NavigationBar1.Height - PanelMain.Height) / 2)
        NavigationBar1.zInitLayout()

    End Sub
    Private Sub InitializeLUT()

        mLUTQCards(1) = CARDS_MINIMUM

        For i As Integer = 2 To CARDS_QSTEPS
            mLUTQCards(i) = mLUTQCards(i - 1) + CARDS_STEP
        Next

    End Sub

    Sub New()

        InitializeComponent()
        InitializeLUT()

        NavigationBar1.zButtonR_Enabled = False
        TrackBar1.Maximum = CARDS_QSTEPS
        LabelInd1.Text = GetQCards()

    End Sub
    
End Class
