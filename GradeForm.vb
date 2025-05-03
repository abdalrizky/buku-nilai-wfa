Imports MySql.Data.MySqlClient

Public Class GradeForm
    Private selectedGradeId As Integer = -1
    Private Sub GradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
        LoadSubjects()
        LoadGrades()
    End Sub

    Sub ClearForm()
        cmbStudent.SelectedIndex = -1
        cmbSubject.SelectedIndex = -1
        txtGrade.Clear()
        selectedGradeId = -1
    End Sub

    Sub LoadStudents()
        Dim cmd As New MySqlCommand("SELECT id, name FROM students", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        cmbStudent.DataSource = dt
        cmbStudent.DisplayMember = "name"
        cmbStudent.ValueMember = "id"
    End Sub

    Sub LoadSubjects()
        Dim cmd As New MySqlCommand("SELECT id, name FROM subjects", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        cmbSubject.DataSource = dt
        cmbSubject.DisplayMember = "name"
        cmbSubject.ValueMember = "id"
    End Sub

    Sub LoadGrades()
        Dim query As String = "SELECT 
            g.id, 
            s.name,
            g.student_id,
            g.subject_id,
            sub.name AS Subject, 
            g.score
        FROM grades g
        JOIN students s ON g.student_id = s.id
        JOIN subjects sub ON g.subject_id = sub.id"
        Dim cmd As New MySqlCommand(query, conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvGrades.DataSource = dt
        dgvGrades.Columns("id").Visible = False
        dgvGrades.Columns("subject_id").Visible = False
        dgvGrades.Columns("student_id").Visible = False
        dgvGrades.Columns("name").HeaderText = "Nama Siswa"
        dgvGrades.Columns("Subject").HeaderText = "Mata Pelajaran"
        dgvGrades.Columns("score").HeaderText = "Nilai"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmd As New MySqlCommand("INSERT INTO grades(student_id, subject_id, score) VALUES(@student_id, @subject_id, @score)", conn)
        cmd.Parameters.AddWithValue("@student_id", cmbStudent.SelectedValue)
        cmd.Parameters.AddWithValue("@subject_id", cmbSubject.SelectedValue)
        cmd.Parameters.AddWithValue("@score", txtGrade.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Nilai berhasil disimpan!")
        LoadGrades()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedGradeId = -1 Then
            MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu.")
            Return
        End If

        Dim query As String = "UPDATE grades SET student_id=@student_id, subject_id=@subject_id, score=@score WHERE id=@grade_id"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@student_id", cmbStudent.SelectedValue)
        cmd.Parameters.AddWithValue("@subject_id", cmbSubject.SelectedValue)
        cmd.Parameters.AddWithValue("@score", txtGrade.Text)
        cmd.Parameters.AddWithValue("@grade_id", selectedGradeId)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Data nilai berhasil diperbarui.")
        LoadGrades()
        ClearForm()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedGradeId = -1 Then
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim query As String = "DELETE FROM grades WHERE id=@grade_id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@grade_id", selectedGradeId)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data nilai berhasil dihapus.")
            LoadGrades()
            ClearForm()
        End If
    End Sub
    Private Sub dgvGrades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrades.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvGrades.Rows(e.RowIndex)

            selectedGradeId = Convert.ToInt32(row.Cells("id").Value)
            cmbStudent.SelectedValue = Convert.ToInt32(row.Cells("student_id").Value)
            cmbSubject.SelectedValue = Convert.ToInt32(row.Cells("subject_id").Value)
            txtGrade.Text = row.Cells("score").Value.ToString()
        End If
    End Sub
End Class