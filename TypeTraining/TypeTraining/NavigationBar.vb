Public Class NavigationBar

    Event zdButtonL_Clicked()
    Event zdButtonR_Clicked()

    Private Sub hButtonL_Clicked() Handles Button1.Click
        RaiseEvent zdButtonL_Clicked()
    End Sub
    Private Sub hButtonR_Clicked() Handles Button2.Click
        RaiseEvent zdButtonR_Clicked()
    End Sub

    Public Property zButtonL_Text() As String
        Get
            Return Button1.Text
        End Get
        Set(ByVal value As String)
            Button1.Text = value
        End Set
    End Property
    Public Property zButtonL_Visible() As Boolean
        Get
            Return Button1.Visible
        End Get
        Set(ByVal value As Boolean)
            Button1.Visible = value
        End Set
    End Property
    Public Property zButtonL_Enabled() As Boolean
        Get
            Return Button1.Enabled
        End Get
        Set(ByVal value As Boolean)
            Button1.Enabled = value
        End Set
    End Property

    Public Property zButtonR_Text() As String
        Get
            Return Button2.Text
        End Get
        Set(ByVal value As String)
            Button2.Text = value
        End Set
    End Property
    Public Property zButtonR_Visible() As Boolean
        Get
            Return Button2.Visible
        End Get
        Set(ByVal value As Boolean)
            Button2.Visible = value
        End Set
    End Property
    Public Property zButtonR_Enabled() As Boolean
        Get
            Return Button2.Enabled
        End Get
        Set(ByVal value As Boolean)
            Button2.Enabled = value
        End Set
    End Property

    Public Sub zInitLayout()

        Dim v As Integer = Button1.Margin.Bottom

        Button1.Location = New Point(v, Me.Height - v - Button1.Height)
        Button2.Location = New Point(Me.Width - Button2.Width - v, Me.Height - v - Button2.Height)

    End Sub

End Class
