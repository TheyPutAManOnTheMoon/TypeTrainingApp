Module Consts

    Public Enum zeTabs

        P0_Message = 0
        P1_Initial
        P2_Exercise
        P3_Results

    End Enum

    Public Const TABS_QUANTITY As Integer = 4
    Public Const TABS_LASTINDEX As Integer = 3
    Public Const RESULTS_QUANTITY As Integer = 5

    Public FILE_FOLDER As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TypeTraining_Cache"
    Public FILE_NAME As String = "SaveData"
    Public FILE_PATH As String = FILE_FOLDER & "\" & FILE_NAME & ".bin"

    Public Const CARDS_MINIMUM As Integer = 10
    Public Const CARDS_STEP As Integer = 100
    Public Const CARDS_QSTEPS As Integer = 20
    Public Const CARDS_MAXIMUM As Integer = CARDS_STEP * CARDS_QSTEPS

End Module