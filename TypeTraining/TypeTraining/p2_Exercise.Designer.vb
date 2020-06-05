<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p2_Exercise
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TLP1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ZCard1 = New TypeTrainingN.zCard
        Me.NavigationBar1 = New TypeTrainingN.NavigationBar
        Me.TLP1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP1
        '
        Me.TLP1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TLP1.ColumnCount = 5
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TLP1.Controls.Add(Me.Label6, 3, 0)
        Me.TLP1.Controls.Add(Me.Label5, 2, 0)
        Me.TLP1.Controls.Add(Me.Label4, 1, 0)
        Me.TLP1.Controls.Add(Me.Label3, 4, 0)
        Me.TLP1.Controls.Add(Me.Label2, 0, 0)
        Me.TLP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLP1.Location = New System.Drawing.Point(0, 0)
        Me.TLP1.Margin = New System.Windows.Forms.Padding(0)
        Me.TLP1.Name = "TLP1"
        Me.TLP1.RowCount = 1
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP1.Size = New System.Drawing.Size(550, 35)
        Me.TLP1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightYellow
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(346, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 33)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "200 keys/min"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightYellow
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(206, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 33)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Errors:  5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightYellow
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(66, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 33)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Time:  4:50"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightYellow
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(486, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "200"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightYellow
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "800"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ZCard1
        '
        Me.ZCard1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ZCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZCard1.Location = New System.Drawing.Point(196, 117)
        Me.ZCard1.Name = "ZCard1"
        Me.ZCard1.Padding = New System.Windows.Forms.Padding(1)
        Me.ZCard1.Size = New System.Drawing.Size(146, 146)
        Me.ZCard1.TabIndex = 8
        Me.ZCard1.Text = "ZCard1"
        Me.ZCard1.zText = "H"
        '
        'NavigationBar1
        '
        Me.NavigationBar1.BackColor = System.Drawing.Color.Gainsboro
        Me.NavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavigationBar1.Location = New System.Drawing.Point(0, 345)
        Me.NavigationBar1.Name = "NavigationBar1"
        Me.NavigationBar1.Size = New System.Drawing.Size(550, 55)
        Me.NavigationBar1.TabIndex = 9
        Me.NavigationBar1.zButtonL_Enabled = True
        Me.NavigationBar1.zButtonL_Text = "Exit"
        Me.NavigationBar1.zButtonL_Visible = True
        Me.NavigationBar1.zButtonR_Enabled = True
        Me.NavigationBar1.zButtonR_Text = "Go"
        Me.NavigationBar1.zButtonR_Visible = False
        '
        'p2_Exercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.NavigationBar1)
        Me.Controls.Add(Me.ZCard1)
        Me.Controls.Add(Me.TLP1)
        Me.Name = "p2_Exercise"
        Me.Size = New System.Drawing.Size(550, 400)
        Me.TLP1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLP1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ZCard1 As TypeTrainingN.zCard
    Friend WithEvents NavigationBar1 As TypeTrainingN.NavigationBar

End Class
