Imports MySql.Data.MySqlClient

Public Class AddEditSubjectForm
    Public Property IsEditMode As Boolean
    Public Property Subject As Subject
    Public Sub InsertSubject(subject As Subject)
        Dim query As String = "INSERT INTO subjects (name) VALUES (@name)"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", subject.Name)

        Try
            cmd.ExecuteNonQuery()
            Close()
        Catch e As Exception
            MessageBox.Show("Terjadi kesalahan: " & e.Message)
        End Try
    End Sub

    Private Sub UpdateStudent(subject As Subject)
        Dim query As String = "UPDATE subjects SET name = @name WHERE id = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", subject.Name)
        cmd.Parameters.AddWithValue("@id", subject.Id)
        Try
            cmd.ExecuteNonQuery()
            Close()
        Catch e As Exception
            MessageBox.Show("Terjadi kesalahan: " & e.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not IsEditMode Then
            Dim subject As New Subject()
            subject.Name = txtSubjectName.Text
            InsertSubject(subject)
        Else
            Dim newSubject As New Subject()
            newSubject.Id = Subject.Id
            newSubject.Name = txtSubjectName.Text
            UpdateStudent(newSubject)
        End If
    End Sub

    Private Sub AddEditSubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsEditMode Then
            txtSubjectName.Text = Subject.Name
        End If
    End Sub
End Class