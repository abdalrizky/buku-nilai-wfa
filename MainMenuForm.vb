Imports System.Text

Public Class MainMenuForm
    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        OpenConnection()
    End Sub
    Private Sub btnMenuStudent_Click(sender As Object, e As EventArgs) Handles btnMenuStudent.Click
        StudentForm.Show()
    End Sub

    Private Sub btnMenuSubject_Click(sender As Object, e As EventArgs) Handles btnMenuSubject.Click
        SubjectForm.Show()
    End Sub

    Private Sub btnMenuGrade_Click(sender As Object, e As EventArgs) Handles btnMenuGrade.Click
        GradeForm.Show()
    End Sub

    Private Sub btnMenuReport_Click(sender As Object, e As EventArgs) Handles btnMenuReport.Click
        MessageBox.Show("Akan segera diimplementasikan.")
    End Sub

    Private Sub btnMenuExit_Click(sender As Object, e As EventArgs) Handles btnMenuExit.Click
        End
    End Sub
End Class