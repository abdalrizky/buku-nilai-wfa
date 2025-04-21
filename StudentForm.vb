Imports MySql.Data.MySqlClient

Public Class StudentForm
    Private Sub LoadData()
        Dim query As String = "SELECT * FROM students"
        Dim cmd As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)
        dgvStudents.DataSource = table

        With dgvStudents
            .Columns("id").Visible = False
            .Columns("nis").HeaderText = "NIS"
            .Columns("name").HeaderText = "Nama"
        End With
    End Sub

    Private Sub Search(text As String)
        Dim query As String = "SELECT * FROM students WHERE name LIKE @name OR nis LIKE @nis"
        Dim cmd As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()

        cmd.Parameters.AddWithValue("@name", "%" & text & "%")
        cmd.Parameters.AddWithValue("@nis", "%" & text & "%")

        adapter.Fill(table)
        dgvStudents.DataSource = table
    End Sub
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        AddEditStudentForm.ShowDialog()
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text <> "" Then
            Search(txtSearch.Text)
        Else
            LoadData()
        End If
    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedValue As String = dgvStudents.Rows(e.RowIndex).Cells("id").Value.ToString()

            Dim editForm As New AddEditStudentForm()

            Dim student As New Student()
            student.Id = Convert.ToInt32(selectedValue)
            student.Name = dgvStudents.Rows(e.RowIndex).Cells("name").Value.ToString()
            student.NIS = dgvStudents.Rows(e.RowIndex).Cells("nis").Value.ToString()

            editForm.IsEditMode = True
            editForm.Student = student
            editForm.ShowDialog()
            LoadData()
        End If
    End Sub
End Class