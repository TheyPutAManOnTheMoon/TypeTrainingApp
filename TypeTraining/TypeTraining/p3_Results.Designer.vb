<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p3_Results
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.ZDataTable1 = New TypeTrainingN.zDataTable
        Me.NavigationBar1 = New TypeTrainingN.NavigationBar
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGreen
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(555, 35)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "5 Last Results (on this PC)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ZDataTable1
        '
        Me.ZDataTable1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ZDataTable1.Location = New System.Drawing.Point(66, 90)
        Me.ZDataTable1.Name = "ZDataTable1"
        Me.ZDataTable1.Size = New System.Drawing.Size(421, 213)
        Me.ZDataTable1.TabIndex = 8
        Me.ZDataTable1.zCells_ColorHighlight = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ZDataTable1.zCells_ColorNormal = System.Drawing.Color.Gainsboro
        Me.ZDataTable1.zColumnCount = 4
        Me.ZDataTable1.zLegend_ColorHighlight = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ZDataTable1.zLegend_ColorNormal = System.Drawing.Color.LightGray
        Me.ZDataTable1.zRowCount = 5
        '
        'NavigationBar1
        '
        Me.NavigationBar1.BackColor = System.Drawing.Color.Gainsboro
        Me.NavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavigationBar1.Location = New System.Drawing.Point(0, 350)
        Me.NavigationBar1.Name = "NavigationBar1"
        Me.NavigationBar1.Size = New System.Drawing.Size(555, 55)
        Me.NavigationBar1.TabIndex = 9
        Me.NavigationBar1.zButtonL_Enabled = True
        Me.NavigationBar1.zButtonL_Text = "Exit"
        Me.NavigationBar1.zButtonL_Visible = True
        Me.NavigationBar1.zButtonR_Enabled = True
        Me.NavigationBar1.zButtonR_Text = "Repeat"
        Me.NavigationBar1.zButtonR_Visible = True
        '
        'p3_Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.NavigationBar1)
        Me.Controls.Add(Me.ZDataTable1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "p3_Results"
        Me.Size = New System.Drawing.Size(555, 405)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ZDataTable1 As TypeTrainingN.zDataTable
    Friend WithEvents NavigationBar1 As TypeTrainingN.NavigationBar

End Class
