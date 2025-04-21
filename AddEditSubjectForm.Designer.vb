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
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.5806446F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 77.41936F))
        TableLayoutPanel1.Controls.Add(TextBox1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(TextBox2, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Button1, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(40)
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 24.0343342F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 75.96567F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(205, 43)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(552, 39)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 32)
        Label2.TabIndex = 2
        Label2.Text = "NIS"
        ' 
        ' TextBox2
        ' 
        TextBox2.Dock = DockStyle.Fill
        TextBox2.Location = New Point(205, 117)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(552, 39)
        TextBox2.TabIndex = 4
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
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Location = New Point(607, 361)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 5
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AddEditSubjectForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "AddEditSubjectForm"
        Text = "AddEditSubject"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
