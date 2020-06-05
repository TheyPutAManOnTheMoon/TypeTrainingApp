Public Class Form1

    Private mCurrentTab As zeTabs = zeTabs.P1_Initial
    Private mTabs As Control()
    Private mResults As zuResult()

    <System.Runtime.InteropServices.DllImport("user32.dll", SetLastError:=True)> _
    Shared Function SetProcessDPIAware() As Boolean
    End Function

    Private Sub InitializeResultArr()

        mResults = New zuResult(RESULTS_QUANTITY) {}

        For i As Integer = 1 To RESULTS_QUANTITY
            mResults(i) = New zuResult
        Next

    End Sub
    Private Function CheckRefIntegrity(ByRef r As zuResult()) As Boolean

        For i As Integer = 1 To RESULTS_QUANTITY
            For j As Integer = i + 1 To RESULTS_QUANTITY

                If zuResult.ReferenceEquals(r(i), r(j)) = True Then Return False

            Next
        Next

        Return True

    End Function
    Private Sub RefreshResults()

        Dim r As zuResult() = zuResult.zOpenFile(FILE_PATH)

        If r Is Nothing Then
            InitializeResultArr()
        ElseIf CheckRefIntegrity(r) = False Then
            InitializeResultArr()
        Else
            mResults = r.Clone
        End If

        For i As Integer = RESULTS_QUANTITY To 2 Step -1
            mResults(i - 1).CopyTo(mResults(i))
        Next

        P2_Exercise1.zOUT_Result.CopyTo(mResults(1))
        zuResult.zSaveToFile(FILE_PATH, mResults)

    End Sub

    Private Property zCurrentTab() As zeTabs
        Get
            Return mCurrentTab
        End Get
        Set(ByVal value As zeTabs)

            For i As Integer = 0 To TABS_LASTINDEX
                If value = i Then
                    mTabs(i).Focus()
                    mTabs(i).BringToFront()
                End If
            Next

        End Set
    End Property

    Private Sub P0_Message1_zdClose() Handles P0_Message1.zdClose

        zCurrentTab = zeTabs.P1_Initial

    End Sub
    Private Sub P1_StartWindow1_zdBtnClicked_Start() Handles P1_StartWindow1.zdStart

        With P2_Exercise1
            .zIN_Chars = P1_StartWindow1.z1Chars
            .zIN_QCards = P1_StartWindow1.z2QCards
            .zStart()
        End With

        zCurrentTab = zeTabs.P2_Exercise

    End Sub
    Private Sub P2_Exercise1_zdExit() Handles P2_Exercise1.zdExit

        zCurrentTab = zeTabs.P1_Initial

    End Sub
    Private Sub P2_Exercise1_zdIsFinished() Handles P2_Exercise1.zdIsFinished

        zCurrentTab = zeTabs.P3_Results
        RefreshResults()

        With P3_Results1
            For i As Integer = 1 To RESULTS_QUANTITY
                .zRow_Input(i) = mResults(i)
            Next
        End With

    End Sub
    Private Sub P3_Results1_zdBtnClicked_Exit() Handles P3_Results1.zdBtnClicked_Exit

        zCurrentTab = zeTabs.P1_Initial

    End Sub
    Private Sub P3_Results1_zdBtnClicked_Repeat() Handles P3_Results1.zdBtnClicked_Repeat

        With P2_Exercise1
            .zIN_Chars = P1_StartWindow1.z1Chars
            .zIN_QCards = P1_StartWindow1.z2QCards
            .zStart()
        End With

        zCurrentTab = zeTabs.P2_Exercise

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        If P2_Exercise1.Visible = False Then Exit Sub

        Dim KeyChar As Char = e.KeyChar
        KeyChar = Char.ToUpper(KeyChar)

        P2_Exercise1.zEnterKey(KeyChar)

    End Sub

    Sub New()

        SetProcessDPIAware()
        InitializeComponent()

        mTabs = New Control() {P0_Message1, P1_StartWindow1, P2_Exercise1, P3_Results1}
        P0_Message1.BringToFront()

        P0_Message1.zInitLayout()
        P1_StartWindow1.zInitLayout()
        P2_Exercise1.zInitLayout()
        P3_Results1.zInitLayout()

    End Sub

End Class
