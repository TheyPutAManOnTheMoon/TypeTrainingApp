<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p1_StartWindow
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.LabelInd1 = New System.Windows.Forms.Label
        Me.LabelDescr1 = New System.Windows.Forms.Label
        Me.LabelDescr2 = New System.Windows.Forms.Label
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.SubPanel1 = New System.Windows.Forms.Panel
        Me.NavigationBar1 = New TypeTrainingN.NavigationBar
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SubPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 10)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(388, 98)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Beige
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(55, 5)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(5)
        Me.TrackBar1.Maximum = 20
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(348, 45)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar1.Value = 7
        '
        'LabelInd1
        '
        Me.LabelInd1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelInd1.Location = New System.Drawing.Point(3, 0)
        Me.LabelInd1.Name = "LabelInd1"
        Me.LabelInd1.Size = New System.Drawing.Size(44, 55)
        Me.LabelInd1.TabIndex = 3
        Me.LabelInd1.Text = "700"
        Me.LabelInd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDescr1
        '
        Me.LabelDescr1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelDescr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescr1.Location = New System.Drawing.Point(0, 0)
        Me.LabelDescr1.Name = "LabelDescr1"
        Me.LabelDescr1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LabelDescr1.Size = New System.Drawing.Size(408, 30)
        Me.LabelDescr1.TabIndex = 4
        Me.LabelDescr1.Text = "1. Enter the keys that will be shown for training"
        Me.LabelDescr1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDescr2
        '
        Me.LabelDescr2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelDescr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescr2.Location = New System.Drawing.Point(0, 163)
        Me.LabelDescr2.Name = "LabelDescr2"
        Me.LabelDescr2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LabelDescr2.Size = New System.Drawing.Size(408, 30)
        Me.LabelDescr2.TabIndex = 5
        Me.LabelDescr2.Text = "2. Enter the quantity of cards for this training session"
        Me.LabelDescr2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMain.BackColor = System.Drawing.Color.Beige
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelMain.Controls.Add(Me.LabelDescr2)
        Me.PanelMain.Controls.Add(Me.Label1)
        Me.PanelMain.Controls.Add(Me.SubPanel1)
        Me.PanelMain.Controls.Add(Me.LabelDescr1)
        Me.PanelMain.Location = New System.Drawing.Point(0, 15)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(15)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(410, 283)
        Me.PanelMain.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Beige
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TrackBar1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelInd1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 193)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(408, 55)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Label1.Size = New System.Drawing.Size(408, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "0 chars identified"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SubPanel1
        '
        Me.SubPanel1.Controls.Add(Me.RichTextBox1)
        Me.SubPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SubPanel1.Name = "SubPanel1"
        Me.SubPanel1.Padding = New System.Windows.Forms.Padding(10, 10, 10, 5)
        Me.SubPanel1.Size = New System.Drawing.Size(408, 113)
        Me.SubPanel1.TabIndex = 6
        '
        'NavigationBar1
        '
        Me.NavigationBar1.BackColor = System.Drawing.Color.Gainsboro
        Me.NavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavigationBar1.Location = New System.Drawing.Point(0, 324)
        Me.NavigationBar1.Name = "NavigationBar1"
        Me.NavigationBar1.Size = New System.Drawing.Size(410, 55)
        Me.NavigationBar1.TabIndex = 7
        Me.NavigationBar1.zButtonL_Enabled = True
        Me.NavigationBar1.zButtonL_Text = "Exit"
        Me.NavigationBar1.zButtonL_Visible = False
        Me.NavigationBar1.zButtonR_Enabled = True
        Me.NavigationBar1.zButtonR_Text = "Start"
        Me.NavigationBar1.zButtonR_Visible = True
        '
        'p1_StartWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.NavigationBar1)
        Me.Controls.Add(Me.PanelMain)
        Me.MinimumSize = New System.Drawing.Size(410, 335)
        Me.Name = "p1_StartWindow"
        Me.Size = New System.Drawing.Size(410, 379)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.SubPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents LabelInd1 As System.Windows.Forms.Label
    Friend WithEvents LabelDescr1 As System.Windows.Forms.Label
    Friend WithEvents LabelDescr2 As System.Windows.Forms.Label
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents SubPanel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NavigationBar1 As TypeTrainingN.NavigationBar

End Class
