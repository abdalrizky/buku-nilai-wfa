Imports MySql.Data.MySqlClient

Public Class AddEditStudentForm
    Public Property IsEditMode As Boolean
    Public Property Student As Student

    Private Sub InsertStudent(student As Student)
        Dim query As String = "INSERT INTO students (name, nis) VALUES (@name, @nis)"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", student.Name)
        cmd.Parameters.AddWithValue("@nis", student.NIS)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Siswa berhasil ditambahkan.")
            Close()
        Catch e As Exception
            MessageBox.Show("Terjadi kesalahan: " & e.Message)
        End Try

    End Sub

    Private Sub UpdateStudent(student As Student)
        Dim query As String = "UPDATE students SET nis = @nis, name = @name WHERE id = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nis", student.NIS)
        cmd.Parameters.AddWithValue("@name", student.Name)
        cmd.Parameters.AddWithValue("@id", student.Id)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Siswa berhasil diperbarui.")
            Close()
        Catch e As Exception
            MessageBox.Show("Terjadi kesalahan: " & e.Message)
        End Try
    End Sub

    Private Sub DeleteStudent(student As Student)
        Dim query As String = "DELETE FROM students WHERE id = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", student.Id)
        Try
            cmd.ExecuteNonQuery()
            Dim result As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus siswa ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                Close()
            End If
            Close()
        Catch e As Exception
            MessageBox.Show("Terjadi kesalahan: " & e.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not IsEditMode Then
            Dim student As New Student()
            student.Name = txtName.Text
            student.NIS = txtNIS.Text
            InsertStudent(student)
        Else
            Dim newStudent As New Student()
            newStudent.Id = Student.Id
            newStudent.Name = txtName.Text
            newStudent.NIS = txtNIS.Text
            UpdateStudent(newStudent)
        End If
    End Sub

    Private Sub AddEditStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsEditMode Then
            txtName.Text = Student.Name
            txtNIS.Text = Student.NIS
            btnDelete.Visible = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteStudent(Student)
    End Sub
End Class
