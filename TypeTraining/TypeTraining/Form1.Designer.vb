<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.P0_Message1 = New TypeTrainingN.p0_Message
        Me.P3_Results1 = New TypeTrainingN.p3_Results
        Me.P2_Exercise1 = New TypeTrainingN.p2_Exercise
        Me.P1_StartWindow1 = New TypeTrainingN.p1_StartWindow
        Me.SuspendLayout()
        '
        'P0_Message1
        '
        Me.P0_Message1.BackColor = System.Drawing.Color.Thistle
        Me.P0_Message1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P0_Message1.Location = New System.Drawing.Point(0, 0)
        Me.P0_Message1.Name = "P0_Message1"
        Me.P0_Message1.Size = New System.Drawing.Size(684, 461)
        Me.P0_Message1.TabIndex = 3
        '
        'P3_Results1
        '
        Me.P3_Results1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P3_Results1.Location = New System.Drawing.Point(0, 0)
        Me.P3_Results1.Name = "P3_Results1"
        Me.P3_Results1.Size = New System.Drawing.Size(684, 461)
        Me.P3_Results1.TabIndex = 2
        '
        'P2_Exercise1
        '
        Me.P2_Exercise1.BackColor = System.Drawing.Color.Silver
        Me.P2_Exercise1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P2_Exercise1.Location = New System.Drawing.Point(0, 0)
        Me.P2_Exercise1.Name = "P2_Exercise1"
        Me.P2_Exercise1.Size = New System.Drawing.Size(684, 461)
        Me.P2_Exercise1.TabIndex = 1
        '
        'P1_StartWindow1
        '
        Me.P1_StartWindow1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P1_StartWindow1.Location = New System.Drawing.Point(0, 0)
        Me.P1_StartWindow1.MinimumSize = New System.Drawing.Size(410, 335)
        Me.P1_StartWindow1.Name = "P1_StartWindow1"
        Me.P1_StartWindow1.Size = New System.Drawing.Size(684, 461)
        Me.P1_StartWindow1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.P0_Message1)
        Me.Controls.Add(Me.P3_Results1)
        Me.Controls.Add(Me.P2_Exercise1)
        Me.Controls.Add(Me.P1_StartWindow1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "Form1"
        Me.Text = "TypeTraining"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P1_StartWindow1 As TypeTrainingN.p1_StartWindow
    Friend WithEvents P2_Exercise1 As TypeTrainingN.p2_Exercise
    Friend WithEvents P3_Results1 As TypeTrainingN.p3_Results
    Friend WithEvents P0_Message1 As TypeTrainingN.p0_Message

End Class
