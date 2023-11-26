<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.LoginUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.lblUsernane = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.LoginPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCreateAccountUsername = New System.Windows.Forms.Label()
        Me.lblCreateAccountPassword = New System.Windows.Forms.Label()
        Me.CreateUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.CreatePasswordTextBox = New System.Windows.Forms.TextBox()
        Me.BtnCreateAccount = New System.Windows.Forms.Button()
        Me.BtnStudentLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoginUsernameTextBox
        '
        Me.LoginUsernameTextBox.Location = New System.Drawing.Point(300, 95)
        Me.LoginUsernameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LoginUsernameTextBox.Name = "LoginUsernameTextBox"
        Me.LoginUsernameTextBox.Size = New System.Drawing.Size(132, 22)
        Me.LoginUsernameTextBox.TabIndex = 0
        '
        'lblUsernane
        '
        Me.lblUsernane.AutoSize = True
        Me.lblUsernane.Location = New System.Drawing.Point(128, 95)
        Me.lblUsernane.Name = "lblUsernane"
        Me.lblUsernane.Size = New System.Drawing.Size(101, 16)
        Me.lblUsernane.TabIndex = 1
        Me.lblUsernane.Text = "Input Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(128, 170)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(126, 16)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Input your password"
        '
        'LoginPasswordTextBox
        '
        Me.LoginPasswordTextBox.Location = New System.Drawing.Point(300, 164)
        Me.LoginPasswordTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LoginPasswordTextBox.Name = "LoginPasswordTextBox"
        Me.LoginPasswordTextBox.Size = New System.Drawing.Size(132, 22)
        Me.LoginPasswordTextBox.TabIndex = 3
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(237, 34)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(82, 16)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Please login"
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(580, 83)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(152, 32)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "Login_As_Admin"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 253)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "don't have an account...please Create Account"
        '
        'lblCreateAccountUsername
        '
        Me.lblCreateAccountUsername.AutoSize = True
        Me.lblCreateAccountUsername.Location = New System.Drawing.Point(128, 334)
        Me.lblCreateAccountUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCreateAccountUsername.Name = "lblCreateAccountUsername"
        Me.lblCreateAccountUsername.Size = New System.Drawing.Size(101, 16)
        Me.lblCreateAccountUsername.TabIndex = 7
        Me.lblCreateAccountUsername.Text = "Enter username"
        '
        'lblCreateAccountPassword
        '
        Me.lblCreateAccountPassword.AutoSize = True
        Me.lblCreateAccountPassword.Location = New System.Drawing.Point(128, 400)
        Me.lblCreateAccountPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCreateAccountPassword.Name = "lblCreateAccountPassword"
        Me.lblCreateAccountPassword.Size = New System.Drawing.Size(100, 16)
        Me.lblCreateAccountPassword.TabIndex = 8
        Me.lblCreateAccountPassword.Text = "Enter password"
        '
        'CreateUsernameTextBox
        '
        Me.CreateUsernameTextBox.Location = New System.Drawing.Point(300, 328)
        Me.CreateUsernameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CreateUsernameTextBox.Name = "CreateUsernameTextBox"
        Me.CreateUsernameTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CreateUsernameTextBox.TabIndex = 9
        '
        'CreatePasswordTextBox
        '
        Me.CreatePasswordTextBox.Location = New System.Drawing.Point(300, 394)
        Me.CreatePasswordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CreatePasswordTextBox.Name = "CreatePasswordTextBox"
        Me.CreatePasswordTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CreatePasswordTextBox.TabIndex = 10
        '
        'BtnCreateAccount
        '
        Me.BtnCreateAccount.Location = New System.Drawing.Point(580, 355)
        Me.BtnCreateAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCreateAccount.Name = "BtnCreateAccount"
        Me.BtnCreateAccount.Size = New System.Drawing.Size(127, 28)
        Me.BtnCreateAccount.TabIndex = 11
        Me.BtnCreateAccount.Text = "Create_Account"
        Me.BtnCreateAccount.UseVisualStyleBackColor = True
        '
        'BtnStudentLogin
        '
        Me.BtnStudentLogin.Location = New System.Drawing.Point(580, 128)
        Me.BtnStudentLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStudentLogin.Name = "BtnStudentLogin"
        Me.BtnStudentLogin.Size = New System.Drawing.Size(152, 34)
        Me.BtnStudentLogin.TabIndex = 12
        Me.BtnStudentLogin.Text = "Login_As_Student"
        Me.BtnStudentLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(249, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "NB: FOR STUDENTS ONLY!!"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(727, 400)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(61, 40)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnStudentLogin)
        Me.Controls.Add(Me.BtnCreateAccount)
        Me.Controls.Add(Me.CreatePasswordTextBox)
        Me.Controls.Add(Me.CreateUsernameTextBox)
        Me.Controls.Add(Me.lblCreateAccountPassword)
        Me.Controls.Add(Me.lblCreateAccountUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.LoginPasswordTextBox)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsernane)
        Me.Controls.Add(Me.LoginUsernameTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Exanination Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginUsernameTextBox As TextBox
    Friend WithEvents lblUsernane As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents LoginPasswordTextBox As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCreateAccountUsername As Label
    Friend WithEvents lblCreateAccountPassword As Label
    Friend WithEvents CreateUsernameTextBox As TextBox
    Friend WithEvents CreatePasswordTextBox As TextBox
    Friend WithEvents BtnCreateAccount As Button
    Friend WithEvents BtnStudentLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnExit As Button
End Class
