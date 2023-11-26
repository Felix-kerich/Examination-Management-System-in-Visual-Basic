<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultsForm
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
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.BtnBackToMainmenu = New System.Windows.Forms.Button()
        Me.BtnSaveResults = New System.Windows.Forms.Button()
        Me.lblsub1 = New System.Windows.Forms.Label()
        Me.lblsub2 = New System.Windows.Forms.Label()
        Me.lblsub3 = New System.Windows.Forms.Label()
        Me.lblsub4 = New System.Windows.Forms.Label()
        Me.lblsub5 = New System.Windows.Forms.Label()
        Me.lblstudid = New System.Windows.Forms.Label()
        Me.BtnData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(377, 362)
        Me.lblSum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(68, 16)
        Me.lblSum.TabIndex = 0
        Me.lblSum.Text = "Total Sum"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(553, 362)
        Me.lblMean.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(41, 16)
        Me.lblMean.TabIndex = 1
        Me.lblMean.Text = "Mean"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(791, 362)
        Me.lblGrade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(45, 16)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Grade"
        '
        'BtnBackToMainmenu
        '
        Me.BtnBackToMainmenu.Location = New System.Drawing.Point(846, 411)
        Me.BtnBackToMainmenu.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBackToMainmenu.Name = "BtnBackToMainmenu"
        Me.BtnBackToMainmenu.Size = New System.Drawing.Size(197, 28)
        Me.BtnBackToMainmenu.TabIndex = 3
        Me.BtnBackToMainmenu.Text = "Back_To_Mainmenu"
        Me.BtnBackToMainmenu.UseVisualStyleBackColor = True
        '
        'BtnSaveResults
        '
        Me.BtnSaveResults.Location = New System.Drawing.Point(209, 411)
        Me.BtnSaveResults.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSaveResults.Name = "BtnSaveResults"
        Me.BtnSaveResults.Size = New System.Drawing.Size(141, 28)
        Me.BtnSaveResults.TabIndex = 4
        Me.BtnSaveResults.Text = "Save_Results"
        Me.BtnSaveResults.UseVisualStyleBackColor = True
        '
        'lblsub1
        '
        Me.lblsub1.AutoSize = True
        Me.lblsub1.Location = New System.Drawing.Point(365, 75)
        Me.lblsub1.Name = "lblsub1"
        Me.lblsub1.Size = New System.Drawing.Size(57, 16)
        Me.lblsub1.TabIndex = 5
        Me.lblsub1.Text = "subject1"
        '
        'lblsub2
        '
        Me.lblsub2.AutoSize = True
        Me.lblsub2.Location = New System.Drawing.Point(365, 132)
        Me.lblsub2.Name = "lblsub2"
        Me.lblsub2.Size = New System.Drawing.Size(57, 16)
        Me.lblsub2.TabIndex = 6
        Me.lblsub2.Text = "subject2"
        '
        'lblsub3
        '
        Me.lblsub3.AutoSize = True
        Me.lblsub3.Location = New System.Drawing.Point(365, 192)
        Me.lblsub3.Name = "lblsub3"
        Me.lblsub3.Size = New System.Drawing.Size(57, 16)
        Me.lblsub3.TabIndex = 7
        Me.lblsub3.Text = "subject3"
        '
        'lblsub4
        '
        Me.lblsub4.AutoSize = True
        Me.lblsub4.Location = New System.Drawing.Point(365, 240)
        Me.lblsub4.Name = "lblsub4"
        Me.lblsub4.Size = New System.Drawing.Size(57, 16)
        Me.lblsub4.TabIndex = 8
        Me.lblsub4.Text = "subject4"
        '
        'lblsub5
        '
        Me.lblsub5.AutoSize = True
        Me.lblsub5.Location = New System.Drawing.Point(365, 291)
        Me.lblsub5.Name = "lblsub5"
        Me.lblsub5.Size = New System.Drawing.Size(57, 16)
        Me.lblsub5.TabIndex = 9
        Me.lblsub5.Text = "subject5"
        '
        'lblstudid
        '
        Me.lblstudid.AutoSize = True
        Me.lblstudid.Location = New System.Drawing.Point(369, 33)
        Me.lblstudid.Name = "lblstudid"
        Me.lblstudid.Size = New System.Drawing.Size(43, 16)
        Me.lblstudid.TabIndex = 10
        Me.lblstudid.Text = "studid"
        '
        'BtnData
        '
        Me.BtnData.Location = New System.Drawing.Point(478, 411)
        Me.BtnData.Name = "BtnData"
        Me.BtnData.Size = New System.Drawing.Size(264, 28)
        Me.BtnData.TabIndex = 11
        Me.BtnData.Text = "inputDataForOther Student"
        Me.BtnData.UseVisualStyleBackColor = True
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.BtnData)
        Me.Controls.Add(Me.lblstudid)
        Me.Controls.Add(Me.lblsub5)
        Me.Controls.Add(Me.lblsub4)
        Me.Controls.Add(Me.lblsub3)
        Me.Controls.Add(Me.lblsub2)
        Me.Controls.Add(Me.lblsub1)
        Me.Controls.Add(Me.BtnSaveResults)
        Me.Controls.Add(Me.BtnBackToMainmenu)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.lblSum)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ResultsForm"
        Me.Text = "Resultsform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSum As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents BtnBackToMainmenu As Button
    Friend WithEvents BtnSaveResults As Button
    Friend WithEvents lblsub1 As Label
    Friend WithEvents lblsub2 As Label
    Friend WithEvents lblsub3 As Label
    Friend WithEvents lblsub4 As Label
    Friend WithEvents lblsub5 As Label
    Friend WithEvents lblstudid As Label
    Friend WithEvents BtnData As Button
End Class
