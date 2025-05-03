<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        cmbStudent = New ComboBox()
        cmbSubject = New ComboBox()
        txtGrade = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        dgvGrades = New DataGridView()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvGrades, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 398F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 242F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 398F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 132F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 364F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(cmbStudent, 1, 1)
        TableLayoutPanel1.Controls.Add(cmbSubject, 3, 1)
        TableLayoutPanel1.Controls.Add(txtGrade, 5, 1)
        TableLayoutPanel1.Controls.Add(Label3, 2, 1)
        TableLayoutPanel1.Controls.Add(Label4, 4, 1)
        TableLayoutPanel1.Controls.Add(dgvGrades, 0, 3)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 3, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 56.1085968F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 43.8914032F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 68F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 426F))
        TableLayoutPanel1.Size = New Size(1672, 712)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        TableLayoutPanel1.SetColumnSpan(Label1, 6)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1666, 122)
        Label1.TabIndex = 3
        Label1.Text = "Data Nilai"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 152)
        Label2.Margin = New Padding(30)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 32)
        Label2.TabIndex = 4
        Label2.Text = "Siswa"
        ' 
        ' cmbStudent
        ' 
        cmbStudent.FormattingEnabled = True
        cmbStudent.Location = New Point(168, 152)
        cmbStudent.Margin = New Padding(30)
        cmbStudent.Name = "cmbStudent"
        cmbStudent.Size = New Size(314, 40)
        cmbStudent.TabIndex = 5
        ' 
        ' cmbSubject
        ' 
        cmbSubject.FormattingEnabled = True
        cmbSubject.Location = New Point(808, 152)
        cmbSubject.Margin = New Padding(30)
        cmbSubject.Name = "cmbSubject"
        cmbSubject.Size = New Size(320, 40)
        cmbSubject.TabIndex = 6
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(1338, 152)
        txtGrade.Margin = New Padding(30)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(258, 39)
        txtGrade.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(566, 152)
        Label3.Margin = New Padding(30)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 32)
        Label3.TabIndex = 8
        Label3.Text = "Mata Pelajaran"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1206, 152)
        Label4.Margin = New Padding(30)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 32)
        Label4.TabIndex = 9
        Label4.Text = "Nilai"
        ' 
        ' dgvGrades
        ' 
        dgvGrades.AllowUserToAddRows = False
        dgvGrades.AllowUserToDeleteRows = False
        dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableLayoutPanel1.SetColumnSpan(dgvGrades, 6)
        dgvGrades.Location = New Point(3, 288)
        dgvGrades.Name = "dgvGrades"
        dgvGrades.ReadOnly = True
        dgvGrades.RowHeadersWidth = 82
        dgvGrades.Size = New Size(1666, 421)
        dgvGrades.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(FlowLayoutPanel1, 3)
        FlowLayoutPanel1.Controls.Add(btnAdd)
        FlowLayoutPanel1.Controls.Add(btnEdit)
        FlowLayoutPanel1.Controls.Add(btnDelete)
        FlowLayoutPanel1.Location = New Point(1175, 220)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(494, 62)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.Location = New Point(3, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 46)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Tambah"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.Location = New Point(159, 3)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(150, 46)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Ubah"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDelete.Location = New Point(315, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(150, 46)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Hapus"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' GradeForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1672, 712)
        Controls.Add(TableLayoutPanel1)
        Name = "GradeForm"
        Text = "Data Nilai"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvGrades, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvGrades As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbStudent As ComboBox
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
