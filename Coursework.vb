Public Class Coursework
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim Marks As Integer
        'input validation for marks to ensure numeric input'
        If Not Integer.TryParse(txtEnterMarks.Text, Marks) Then
            MessageBox.Show("please enter a valid numeric value for marks.")
            Exit Sub
        End If
        'check if marks exceeds 100
        If Marks > 100 Then
            MessageBox.Show("wrong entry,please re-enter the marks")
            Exit Sub
        End If
        'using select case to determine the grade best on marks
        Select Case Marks
            Case 90 To 100
                LblGrade.Text = "Excellent"
            Case 80 To 89
                LblGrade.Text = "Very Good"
            Case 70 To 79
                LblGrade.Text = "Good"
            Case 60 To 69
                LblGrade.Text = "Medium"
            Case 50 To 59
                LblGrade.Text = "Pass"
            Case 0 To 49
                LblGrade.Text = "Fail"
            Case Else
                LblGrade.Text = "Invalid Marks"
        End Select
    End Sub

    Private Sub txtEnterMarks_TextChanged(sender As Object, e As EventArgs) Handles txtEnterMarks.TextChanged

    End Sub

    Private Sub LblGrade_Click(sender As Object, e As EventArgs) Handles LblGrade.Click
    End Sub

    Private Sub LblEnterMarks_Click(sender As Object, e As EventArgs) Handles LblEnterMarks.Click

    End Sub
End Class
