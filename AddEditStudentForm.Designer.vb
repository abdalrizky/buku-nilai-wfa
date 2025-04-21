<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEditStudentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtName = New TextBox()
        txtNIS = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnSave = New Button()
        btnDelete = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 32)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 32)
        Label2.TabIndex = 2
        Label2.Text = "NIS"
        ' 
        ' txtName
        ' 
        txtName.Dock = DockStyle.Fill
        txtName.Location = New Point(197, 43)
        txtName.Name = "txtName"
        txtName.Size = New Size(522, 39)
        txtName.TabIndex = 3
        ' 
        ' txtNIS
        ' 
        txtNIS.Dock = DockStyle.Fill
        txtNIS.Location = New Point(197, 105)
        txtNIS.Name = "txtNIS"
        txtNIS.Size = New Size(522, 39)
        txtNIS.TabIndex = 4
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.5806446F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 77.41936F))
        TableLayoutPanel1.Controls.Add(txtName, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(txtNIS, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(btnSave, 1, 2)
        TableLayoutPanel1.Controls.Add(btnDelete, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(40)
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 24.0343342F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 75.96567F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.Size = New Size(762, 402)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSave.Location = New Point(569, 313)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 46)
        btnSave.TabIndex = 5
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDelete.Location = New Point(45, 306)
        btnDelete.Margin = New Padding(5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(144, 46)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Hapus"
        btnDelete.UseVisualStyleBackColor = True
        btnDelete.Visible = False
        ' 
        ' AddEditStudentForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(762, 402)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddEditStudentForm"
        Text = "Tambah Siswa"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNIS As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button

End Class
