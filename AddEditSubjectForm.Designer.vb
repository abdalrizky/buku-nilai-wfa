<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditSubjectForm
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
        txtSubjectName = New TextBox()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' txtSubjectName
        ' 
        txtSubjectName.Location = New Point(45, 46)
        txtSubjectName.Name = "txtSubjectName"
        txtSubjectName.Size = New Size(538, 39)
        txtSubjectName.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(433, 110)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 46)
        btnSave.TabIndex = 1
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' AddEditSubjectForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(630, 202)
        Controls.Add(btnSave)
        Controls.Add(txtSubjectName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddEditSubjectForm"
        Text = "Tambah Mata Pelajaran"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents btnSave As Button
End Class
