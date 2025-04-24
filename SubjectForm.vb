Imports MySql.Data.MySqlClient

Public Class SubjectForm
    Private Sub LoadData()
        lbSubjects.Items.Clear()

        Dim query As String = "SELECT * FROM subjects"
        Dim cmd As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim subject As New Subject()
            subject.Id = reader("id")
            subject.Name = reader("name").ToString()
            lbSubjects.Items.Add(subject)
        End While

        reader.Close()
    End Sub

    Private Sub DeleteSubject(id As Integer)
        Dim query As String = "DELETE FROM subjects WHERE id = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", id)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Mata pelajaran berhasil dihapus.", "Hapus Mata Pelajaran", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch e As Exception
            MessageBox.Show("Terjadi kesalahan: " & e.Message)
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addEditSubjectForm As New AddEditSubjectForm
        addEditSubjectForm.ShowDialog()
        LoadData()
    End Sub

    Private Sub SubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub lbSubjects_DoubleClick(sender As Object, e As EventArgs) Handles lbSubjects.DoubleClick
        If lbSubjects.SelectedIndex <> -1 Then
            Dim addEditSubjectForm As New AddEditSubjectForm()
            addEditSubjectForm.Subject = New Subject()
            addEditSubjectForm.Subject.Id = CType(lbSubjects.SelectedItem, Subject).Id
            addEditSubjectForm.Subject.Name = lbSubjects.SelectedItem.ToString()
            addEditSubjectForm.IsEditMode = True
            addEditSubjectForm.ShowDialog()
            LoadData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lbSubjects.SelectedIndex <> -1 Then
            Dim subjectId As Integer = CType(lbSubjects.SelectedItem, Subject).Id
            Dim result As DialogResult = MessageBox.Show("Yakin ingin menghapus mata pelajaran ini? Semua nilai siswa yang terkait dengan mata pelajaran ini akan dihapus. Harap lakukan dengan hati-hati.", "Hapus Mata Pelajaran", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                DeleteSubject(subjectId)
                LoadData()
            End If
        End If
    End Sub
End Class