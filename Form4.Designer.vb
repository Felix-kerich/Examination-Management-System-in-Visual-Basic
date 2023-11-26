<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCheckResults = New System.Windows.Forms.Button()
        Me.lblstudid = New System.Windows.Forms.Label()
        Me.TxtStudid = New System.Windows.Forms.TextBox()
        Me.Btnclaims = New System.Windows.Forms.Button()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCheckResults
        '
        Me.BtnCheckResults.Location = New System.Drawing.Point(200, 192)
        Me.BtnCheckResults.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCheckResults.Name = "BtnCheckResults"
        Me.BtnCheckResults.Size = New System.Drawing.Size(149, 28)
        Me.BtnCheckResults.TabIndex = 0
        Me.BtnCheckResults.Text = "CheckResults"
        Me.BtnCheckResults.UseVisualStyleBackColor = True
        '
        'lblstudid
        '
        Me.lblstudid.AutoSize = True
        Me.lblstudid.Location = New System.Drawing.Point(197, 90)
        Me.lblstudid.Name = "lblstudid"
        Me.lblstudid.Size = New System.Drawing.Size(98, 16)
        Me.lblstudid.TabIndex = 1
        Me.lblstudid.Text = "Enter student id"
        '
        'TxtStudid
        '
        Me.TxtStudid.Location = New System.Drawing.Point(443, 84)
        Me.TxtStudid.Name = "TxtStudid"
        Me.TxtStudid.Size = New System.Drawing.Size(100, 22)
        Me.TxtStudid.TabIndex = 2
        '
        'Btnclaims
        '
        Me.Btnclaims.Location = New System.Drawing.Point(200, 269)
        Me.Btnclaims.Name = "Btnclaims"
        Me.Btnclaims.Size = New System.Drawing.Size(149, 32)
        Me.Btnclaims.TabIndex = 3
        Me.Btnclaims.Text = "claimResults"
        Me.Btnclaims.UseVisualStyleBackColor = True
        '
        'Btnback
        '
        Me.Btnback.Location = New System.Drawing.Point(841, 434)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(113, 52)
        Me.Btnback.TabIndex = 4
        Me.Btnback.Text = "BACK"
        Me.Btnback.UseVisualStyleBackColor = True
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.Btnclaims)
        Me.Controls.Add(Me.TxtStudid)
        Me.Controls.Add(Me.lblstudid)
        Me.Controls.Add(Me.BtnCheckResults)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StudentForm"
        Me.Text = "StudentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCheckResults As Button
    Friend WithEvents lblstudid As Label
    Friend WithEvents TxtStudid As TextBox
    Friend WithEvents Btnclaims As Button
    Friend WithEvents Btnback As Button
End Class
