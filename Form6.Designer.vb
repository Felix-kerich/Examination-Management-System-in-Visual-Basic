<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class claimsForm
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
        Me.lblid = New System.Windows.Forms.Label()
        Me.BtnclaimDescription = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtclaim = New System.Windows.Forms.TextBox()
        Me.Btnsubmit = New System.Windows.Forms.Button()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(104, 41)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(77, 16)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Enter you id"
        '
        'BtnclaimDescription
        '
        Me.BtnclaimDescription.AutoSize = True
        Me.BtnclaimDescription.Location = New System.Drawing.Point(104, 184)
        Me.BtnclaimDescription.Name = "BtnclaimDescription"
        Me.BtnclaimDescription.Size = New System.Drawing.Size(102, 16)
        Me.BtnclaimDescription.TabIndex = 1
        Me.BtnclaimDescription.Text = "Enter your claim"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(247, 41)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(225, 22)
        Me.txtid.TabIndex = 2
        '
        'txtclaim
        '
        Me.txtclaim.Location = New System.Drawing.Point(247, 178)
        Me.txtclaim.Name = "txtclaim"
        Me.txtclaim.Size = New System.Drawing.Size(225, 22)
        Me.txtclaim.TabIndex = 3
        '
        'Btnsubmit
        '
        Me.Btnsubmit.Location = New System.Drawing.Point(599, 197)
        Me.Btnsubmit.Name = "Btnsubmit"
        Me.Btnsubmit.Size = New System.Drawing.Size(109, 39)
        Me.Btnsubmit.TabIndex = 4
        Me.Btnsubmit.Text = "submit"
        Me.Btnsubmit.UseVisualStyleBackColor = True
        '
        'Btnback
        '
        Me.Btnback.Location = New System.Drawing.Point(599, 357)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(109, 48)
        Me.Btnback.TabIndex = 5
        Me.Btnback.Text = "BACK"
        Me.Btnback.UseVisualStyleBackColor = True
        '
        'claimsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.Btnsubmit)
        Me.Controls.Add(Me.txtclaim)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.BtnclaimDescription)
        Me.Controls.Add(Me.lblid)
        Me.Name = "claimsForm"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblid As Label
    Friend WithEvents BtnclaimDescription As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtclaim As TextBox
    Friend WithEvents Btnsubmit As Button
    Friend WithEvents Btnback As Button
End Class
