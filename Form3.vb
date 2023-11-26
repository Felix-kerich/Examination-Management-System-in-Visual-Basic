Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ResultsForm
    Private Sum As Double
    Private Mean As Double
    Private Grade As String
    Private studid As Double
    Private Subject1 As Double
    Private Subject2 As Double
    Private Subject3 As Double
    Private Subject4 As Double
    Private Subject5 As Double

    Public Sub New(ByVal sum As Double, ByVal mean As Double, ByVal grade As String)
        InitializeComponent()

        ' Store the results
        Me.Sum = sum
        Me.Mean = mean
        Me.Grade = grade

        ' Display the results in labels
        lblSum.Text = "Total Sum: " & sum.ToString()
        lblMean.Text = "Mean: " & mean.ToString()
        lblGrade.Text = "Grade: " & grade
    End Sub
    Public Sub New(ByVal studid As Double, ByVal sub1 As Double, ByVal sub2 As Double, ByVal sub3 As Double, ByVal sub4 As Double, ByVal sub5 As Double, ByVal sum As Double, ByVal mean As Double, ByVal grade As String)
        Me.New(sum, mean, grade)

        Me.studid = studid
        Me.Subject1 = sub1
        Me.Subject2 = sub2
        Me.Subject3 = sub3
        Me.Subject4 = sub4
        Me.Subject5 = sub5

        lblstudid.Text = "studid: " & studid.ToString()
        lblsub1.Text = "subject1: " & sub1.ToString()
        lblsub2.Text = "subject2: " & sub2.ToString()
        lblsub3.Text = "subject3: " & sub3.ToString()
        lblsub4.Text = "subject4: " & sub4.ToString()
        lblsub5.Text = "subject5: " & sub5.ToString()
    End Sub

    Private Sub BtnSaveResults_Click(sender As Object, e As EventArgs) Handles BtnSaveResults.Click
        ' Save results to MySQL database
        SaveResultsToDatabase()
    End Sub

    Private Sub SaveResultsToDatabase()
        Dim connectionString As String = "server=localhost;user=root;database=Examination_system;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO Results (studid, Subject1, Subject2, Subject3, Subject4, Subject5, Sum, Mean, Grade) VALUES (@studid, @sub1, @sub2, @sub3, @sub4, @sub5, @sum, @mean, @grade);"
            Using cmd As New MySqlCommand(query, connection)

                cmd.Parameters.AddWithValue("@studid", studid)
                cmd.Parameters.AddWithValue("@sub1", Subject1)
                cmd.Parameters.AddWithValue("@sub2", Subject2)
                cmd.Parameters.AddWithValue("@sub3", Subject3)
                cmd.Parameters.AddWithValue("@sub4", Subject4)
                cmd.Parameters.AddWithValue("@sub5", Subject5)


                cmd.Parameters.AddWithValue("@sum", Sum)
                cmd.Parameters.AddWithValue("@mean", Mean)
                cmd.Parameters.AddWithValue("@grade", Grade)

                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Results saved to the database.")
    End Sub

    Private Sub BtnBackToMainmenu_Click(sender As Object, e As EventArgs) Handles BtnBackToMainmenu.Click
        Me.Hide()
        Dim mainMenuForm As New Form1()
        mainMenuForm.Show()
    End Sub

    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles BtnData.Click
        Me.Hide()
        MainForm.Show()

    End Sub
End Class
