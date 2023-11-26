<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultsForm2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblstudid = New System.Windows.Forms.Label()
        Me.lblsub1 = New System.Windows.Forms.Label()
        Me.lblsub2 = New System.Windows.Forms.Label()
        Me.lblsub3 = New System.Windows.Forms.Label()
        Me.lblsub4 = New System.Windows.Forms.Label()
        Me.lblsub5 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.BackToMainmenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblstudid
        '
        Me.lblstudid.AutoSize = True
        Me.lblstudid.Location = New System.Drawing.Point(197, 20)
        Me.lblstudid.Name = "lblstudid"
        Me.lblstudid.Size = New System.Drawing.Size(43, 16)
        Me.lblstudid.TabIndex = 0
        Me.lblstudid.Text = "studid"
        '
        'lblsub1
        '
        Me.lblsub1.AutoSize = True
        Me.lblsub1.Location = New System.Drawing.Point(197, 67)
        Me.lblsub1.Name = "lblsub1"
        Me.lblsub1.Size = New System.Drawing.Size(60, 16)
        Me.lblsub1.TabIndex = 1
        Me.lblsub1.Text = "subject 1"
        '
        'lblsub2
        '
        Me.lblsub2.AutoSize = True
        Me.lblsub2.Location = New System.Drawing.Point(197, 112)
        Me.lblsub2.Name = "lblsub2"
        Me.lblsub2.Size = New System.Drawing.Size(60, 16)
        Me.lblsub2.TabIndex = 2
        Me.lblsub2.Text = "subject 2"
        '
        'lblsub3
        '
        Me.lblsub3.AutoSize = True
        Me.lblsub3.Location = New System.Drawing.Point(197, 154)
        Me.lblsub3.Name = "lblsub3"
        Me.lblsub3.Size = New System.Drawing.Size(60, 16)
        Me.lblsub3.TabIndex = 3
        Me.lblsub3.Text = "subject 3"
        '
        'lblsub4
        '
        Me.lblsub4.AutoSize = True
        Me.lblsub4.Location = New System.Drawing.Point(197, 208)
        Me.lblsub4.Name = "lblsub4"
        Me.lblsub4.Size = New System.Drawing.Size(60, 16)
        Me.lblsub4.TabIndex = 4
        Me.lblsub4.Text = "subject 4"
        '
        'lblsub5
        '
        Me.lblsub5.AutoSize = True
        Me.lblsub5.Location = New System.Drawing.Point(197, 258)
        Me.lblsub5.Name = "lblsub5"
        Me.lblsub5.Size = New System.Drawing.Size(60, 16)
        Me.lblsub5.TabIndex = 5
        Me.lblsub5.Text = "subject 5"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(160, 343)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(32, 16)
        Me.lblSum.TabIndex = 6
        Me.lblSum.Text = "sum"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(375, 343)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(41, 16)
        Me.lblMean.TabIndex = 7
        Me.lblMean.Text = "mean"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(586, 343)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(45, 16)
        Me.lblGrade.TabIndex = 8
        Me.lblGrade.Text = "Grade"
        '
        'BackToMainmenu
        '
        Me.BackToMainmenu.Location = New System.Drawing.Point(289, 404)
        Me.BackToMainmenu.Name = "BackToMainmenu"
        Me.BackToMainmenu.Size = New System.Drawing.Size(203, 23)
        Me.BackToMainmenu.TabIndex = 9
        Me.BackToMainmenu.Text = "BackToMainmenu"
        Me.BackToMainmenu.UseVisualStyleBackColor = True
        '
        'ResultsForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackToMainmenu)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.lblsub5)
        Me.Controls.Add(Me.lblsub4)
        Me.Controls.Add(Me.lblsub3)
        Me.Controls.Add(Me.lblsub2)
        Me.Controls.Add(Me.lblsub1)
        Me.Controls.Add(Me.lblstudid)
        Me.Name = "ResultsForm2"
        Me.Text = "ResultsForm2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblstudid As Label
    Friend WithEvents lblsub1 As Label
    Friend WithEvents lblsub2 As Label
    Friend WithEvents lblsub3 As Label
    Friend WithEvents lblsub4 As Label
    Friend WithEvents lblsub5 As Label
    Friend WithEvents lblSum As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents BackToMainmenu As Button
End Class
