Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class StudentForm
    Private Sub BtnCheckResults_Click(sender As Object, e As EventArgs) Handles BtnCheckResults.Click
        Dim studid As Integer

        If Integer.TryParse(TxtStudid.Text, studid) Then
            ' Query the database to get the results for the provided studid
            Dim resultsData As ResultsData = GetResultsFromDatabase(studid)

            If resultsData IsNot Nothing Then
                ' Show the ResultsForm with the stored results
                Dim ResultsForm2 As New ResultsForm2(resultsData.studid, resultsData.Sub1, resultsData.Sub2, resultsData.Sub3, resultsData.Sub4, resultsData.Sub5, resultsData.Sum, resultsData.Mean, resultsData.Grade)
                Me.Hide()
                ResultsForm2.ShowDialog()
            Else
                MessageBox.Show("No results found for the provided studid.")
            End If
        Else
            MessageBox.Show("Invalid studid. Please enter a valid studid.")
        End If
    End Sub

    ' Function to query the database for results based on studid
    Private Function GetResultsFromDatabase(studid As Integer) As ResultsData
        Dim connectionString As String = "server=localhost;user=root;database=Examination_system;"
        Dim resultsData As ResultsData = Nothing

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM Results WHERE studid = @studid;"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@studid", studid)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        resultsData = New ResultsData(
                            studid,
                            Convert.ToDouble(reader("Subject1")),
                            Convert.ToDouble(reader("Subject2")),
                            Convert.ToDouble(reader("Subject3")),
                            Convert.ToDouble(reader("Subject4")),
                            Convert.ToDouble(reader("Subject5")),
                            Convert.ToDouble(reader("Sum")),
                            Convert.ToDouble(reader("Mean")),
                            Convert.ToString(reader("Grade"))
                        )
                    End If
                End Using
            End Using
        End Using

        Return resultsData
    End Function

    Private Sub Btnclaims_Click(sender As Object, e As EventArgs) Handles Btnclaims.Click
        Me.Hide()
        claimsForm.show()
    End Sub
    Private Sub saveClaims()

    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Hide()
        Form1.ShowDialog()
    End Sub
End Class
