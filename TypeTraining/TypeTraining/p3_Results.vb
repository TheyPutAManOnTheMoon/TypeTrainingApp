Public Class p3_Results

    Event zdBtnClicked_Exit()
    Event zdBtnClicked_Repeat()

    Private Sub hBtnClicked_Exit() Handles NavigationBar1.zdButtonL_Clicked

        RaiseEvent zdBtnClicked_Exit()

    End Sub
    Private Sub hBtnClicked_Repeat() Handles NavigationBar1.zdButtonR_Clicked

        RaiseEvent zdBtnClicked_Repeat()

    End Sub

    Public WriteOnly Property zRow_Input(ByVal aRow As Integer) As zuResult
        Set(ByVal value As zuResult)

            If aRow < 1 Or aRow > ZDataTable1.zRowCount Then Exit Property

            With ZDataTable1
                .zCell_Text(aRow, 0) = value.z0Date_ToString
                .zCell_Text(aRow, 1) = value.z1Time_ToString
                .zCell_Text(aRow, 2) = value.z2Cards
                .zCell_Text(aRow, 3) = value.z3KeysMin
                .zCell_Text(aRow, 4) = value.z4Errors
            End With

        End Set
    End Property

    Sub New()

        InitializeComponent()

        With ZDataTable1
            .zLegend_Text(0) = "Date"
            .zLegend_Text(1) = "Stopwatch"
            .zLegend_Text(2) = "Cards"
            .zLegend_Text(3) = "keys/min"
            .zLegend_Text(4) = "Errors"

            .zRowCount = RESULTS_QUANTITY
            .zRow_IsHighlightened(1) = True
        End With

    End Sub

    Public Sub zInitLayout()


        Dim x As Integer = (Me.Width - ZDataTable1.Width) / 2
        Dim y As Integer = ((Me.Height - Label2.Height - NavigationBar1.Height - ZDataTable1.Height) / 2) + Label2.Height

        ZDataTable1.Location = New Point(x, y)

    End Sub

End Class
