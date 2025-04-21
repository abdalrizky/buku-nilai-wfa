<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        dgvStudents = New DataGridView()
        btnAddStudent = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtSearch = New TextBox()
        Label1 = New Label()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(3, 250)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersWidth = 82
        dgvStudents.Size = New Size(1666, 362)
        dgvStudents.TabIndex = 0
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Location = New Point(30, 640)
        btnAddStudent.Margin = New Padding(30, 25, 0, 0)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(234, 46)
        btnAddStudent.TabIndex = 1
        btnAddStudent.Text = "Tambah Siswa"
        btnAddStudent.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnAddStudent, 0, 3)
        TableLayoutPanel1.Controls.Add(dgvStudents, 0, 2)
        TableLayoutPanel1.Controls.Add(txtSearch, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 57.48988F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 42.51012F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 368F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 96F))
        TableLayoutPanel1.Size = New Size(1672, 712)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtSearch.Location = New Point(30, 178)
        txtSearch.Margin = New Padding(30, 3, 3, 30)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari..."
        txtSearch.Size = New Size(604, 39)
        txtSearch.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1666, 142)
        Label1.TabIndex = 3
        Label1.Text = "Data Siswa"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' StudentForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1672, 712)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "StudentForm"
        Text = "Data Siswa"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
End Class
