Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ResultsForm2
    Private Sum As Double
    Private Mean As Double
    Private Grade As String
    Private studid As Double
    Private Subject1 As Double
    Private Subject2 As Double
    Private Subject3 As Double
    Private Subject4 As Double
    Private Subject5 As Double

    ' Constructor to include subject-related data
    Public Sub New(ByVal studid As Double, ByVal sub1 As Double, ByVal sub2 As Double, ByVal sub3 As Double, ByVal sub4 As Double, ByVal sub5 As Double, ByVal sum As Double, ByVal mean As Double, ByVal grade As String)
        InitializeComponent()

        ' Store subject-related data
        Me.studid = studid
        Me.Subject1 = sub1
        Me.Subject2 = sub2
        Me.Subject3 = sub3
        Me.Subject4 = sub4
        Me.Subject5 = sub5

        ' Display the results in labels
        lblstudid.Text = "StudID: " & studid.ToString()
        lblsub1.Text = "Subject1: " & sub1.ToString()
        lblsub2.Text = "Subject2: " & sub2.ToString()
        lblsub3.Text = "Subject3: " & sub3.ToString()
        lblsub4.Text = "Subject4: " & sub4.ToString()
        lblsub5.Text = "Subject5: " & sub5.ToString()
        lblSum.Text = "Total Sum: " & sum.ToString()
        lblMean.Text = "Mean: " & mean.ToString()
        lblGrade.Text = "Grade: " & grade
    End Sub

    Private Sub BackToMainmenu_Click(sender As Object, e As EventArgs) Handles BackToMainmenu.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
