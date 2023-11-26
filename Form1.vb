Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1
    Private ConnectionString As String = "server=localhost;user=root;database=Examination_System;"

    Private Sub BtnCreateAccount_Click(sender As Object, e As EventArgs) Handles BtnCreateAccount.Click
        Dim username As String = CreateUsernameTextBox.Text
        Dim password As String = CreatePasswordTextBox.Text
        Dim isAdmin As Boolean

        If Not AccountExists(username, isAdmin) Then
            If SaveAccountToDatabase(username, password, isAdmin) Then
                MessageBox.Show("Account created successfully. You can now log in.")
                ClearCreateAccountTextBoxes()
            Else
                MessageBox.Show("Error saving account to the database.")
            End If
        Else
            MessageBox.Show("Username already exists. Please choose a different one.")
        End If
    End Sub

    Private Function AccountExists(username As String, isAdmin As Boolean) As Boolean
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Dim tableName As String = If(isAdmin, "AdminTable", "StudentTable")
            Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE username = @username;"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)

                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Private Function SaveAccountToDatabase(username As String, password As String, isAdmin As Boolean) As Boolean
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Dim tableName As String = If(isAdmin, "AdminTable", "StudentTable")
            Dim query As String = $"INSERT INTO {tableName} (username, password) VALUES (@username, @password);"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = LoginUsernameTextBox.Text
        Dim password As String = LoginPasswordTextBox.Text

        If AccountsMatchDatabase(username, password, isAdmin:=True) Then

            Dim mainForm As New MainForm()
            Me.Hide()
            mainForm.Show()
        Else
            MessageBox.Show("Login failed. Please check your username and password.")
        End If
    End Sub

    Private Sub BtnStudentLogin_Click(sender As Object, e As EventArgs) Handles BtnStudentLogin.Click
        Dim username As String = LoginUsernameTextBox.Text
        Dim password As String = LoginPasswordTextBox.Text

        If AccountsMatchDatabase(username, password, isAdmin:=False) Then

            Dim studentForm As New StudentForm()
            Me.Hide()
            studentForm.Show()
        Else
            MessageBox.Show("Login failed. Please check your username and password.")
        End If
    End Sub

    Private Function AccountsMatchDatabase(username As String, password As String, isAdmin As Boolean) As Boolean
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Dim tableName As String = If(isAdmin, "AdminTable", "StudentTable")
            Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE username = @username AND password = @password;"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function



    Private Sub ClearCreateAccountTextBoxes()
        CreateUsernameTextBox.Clear()
        CreatePasswordTextBox.Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
End Class
