Imports MySql.Data.MySqlClient

Public Class Form7
    ' Replace these values with your actual database details
    Dim connectionString As String = "server=localhost;user id=root;password= ;database=examination_system"
    Dim tableName As String = "claims"

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Me.Hide()
        MainForm.ShowDialog()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form loads, display all claims
        DisplayAllClaims()
    End Sub

    Private Sub DisplayAllClaims()
        Try
            ' Create the SQL query to select all data from the database
            Dim query As String = "SELECT * FROM " & tableName

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using cmd As New MySqlCommand(query, connection)
                    ' Create a DataAdapter to fill a DataTable
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()

                    ' Fill the DataTable with the results of the query
                    adapter.Fill(dataTable)

                    ' Display the data in DataGridView1
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the database operation
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' You can add code here to handle the cell click event if needed
        ' For example, you can retrieve data from the selected row
        ' Dim selectedRowIndex As Integer = e.RowIndex
        ' Dim selectedRow As DataGridViewRow = DataGridView1.Rows(selectedRowIndex)
        ' Dim studentID As String = selectedRow.Cells("student_id").Value.ToString()
        ' Dim claimText As String = selectedRow.Cells("claim_text").Value.ToString()
        ' MessageBox.Show($"Student ID: {studentID}, Claim Text: {claimText}")
    End Sub
End Class
