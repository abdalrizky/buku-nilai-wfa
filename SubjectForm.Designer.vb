<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectForm
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
        lbSubjects = New ListBox()
        btnAdd = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' lbSubjects
        ' 
        lbSubjects.FormattingEnabled = True
        lbSubjects.Location = New Point(35, 38)
        lbSubjects.Name = "lbSubjects"
        lbSubjects.Size = New Size(462, 676)
        lbSubjects.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(525, 52)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(180, 46)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Tambah"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(525, 120)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(180, 46)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Hapus"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' SubjectForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(742, 756)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(lbSubjects)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "SubjectForm"
        Text = "Mata Pelajaran"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbSubjects As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
End Class
