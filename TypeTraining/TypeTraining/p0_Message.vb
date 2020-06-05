Public Class p0_Message

    Event zdClose()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button1.Click

        RaiseEvent zdClose()

    End Sub

    Public Sub zInitLayout()

        PanelMain.Location = New Point((Me.Width - PanelMain.Width) / 2, _
                                       (Me.Height - PanelMain.Height) / 2)

        Button1.Location = New Point((PanelButton.Width - Button1.Width) / 2, _
                                     (PanelButton.Height - Button1.Height) / 2)

    End Sub
    Sub New()

        InitializeComponent()
        Label1.Text = My.Resources.InitialMessage.ToString()

    End Sub

End Class
