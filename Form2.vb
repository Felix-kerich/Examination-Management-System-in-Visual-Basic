Imports System.Windows.Forms

Public Class MainForm
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim studid, sub1, sub2, sub3, sub4, sub5, sum As Double

        If Double.TryParse(txtstudid.Text, studid) AndAlso
            Double.TryParse(TextBox1.Text, sub1) AndAlso
            Double.TryParse(TextBox2.Text, sub2) AndAlso
            Double.TryParse(TextBox3.Text, sub3) AndAlso
            Double.TryParse(TextBox4.Text, sub4) AndAlso
            Double.TryParse(TextBox5.Text, sub5) Then

            ' Calculate total sum
            sum = sub1 + sub2 + sub3 + sub4 + sub5

            ' Calculate mean
            Dim mean As Double = sum / 5


            Dim grade As String = CalculateGrade(mean)


            MessageBox.Show("Update Successful")
            Me.Tag = New ResultsData(studid, sub1, sub2, sub3, sub4, sub5, sum, mean, grade)
        Else
            MessageBox.Show("Invalid input. Please enter valid scores for all subjects.")
        End If
    End Sub

    Private Function CalculateGrade(mean As Double) As String
        If mean >= 90 Then
            Return "A+"
        ElseIf mean >= 80 Then
            Return "A"
        ElseIf mean >= 70 Then
            Return "B"
        ElseIf mean >= 60 Then
            Return "C"
        ElseIf mean >= 50 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles Btnview.Click
        Dim resultsData As ResultsData = TryCast(Me.Tag, ResultsData)

        If resultsData IsNot Nothing Then
            Dim resultsForm As New ResultsForm(resultsData.studid, resultsData.Sub1, resultsData.Sub2, resultsData.Sub3, resultsData.Sub4, resultsData.Sub5, resultsData.Sum, resultsData.Mean, resultsData.Grade)
            Me.Hide()
            resultsForm.ShowDialog()
        Else
            MessageBox.Show("Results not available. Please update the scores first.")
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back? Any unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()

        Else


        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtstudid.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()


    End Sub

    Private Sub Btnclaim_Click(sender As Object, e As EventArgs) Handles Btnclaim.Click
        Me.Hide()
        Form7.ShowDialog()

    End Sub
End Class

Public Class ResultsData
    Public Property studid As Double
    Public Property Sub1 As Double
    Public Property Sub2 As Double
    Public Property Sub3 As Double
    Public Property Sub4 As Double
    Public Property Sub5 As Double
    Public Property Sum As Double
    Public Property Mean As Double
    Public Property Grade As String

    Public Sub New(studid As Double, sub1 As Double, sub2 As Double, sub3 As Double, sub4 As Double, sub5 As Double, sum As Double, mean As Double, grade As String)
        Me.studid = studid
        Me.Sub1 = sub1
        Me.Sub2 = sub2
        Me.Sub3 = sub3
        Me.Sub4 = sub4
        Me.Sub5 = sub5
        Me.Sum = sum
        Me.Mean = mean
        Me.Grade = grade
    End Sub
End Class
