<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        btnMenuStudent = New Button()
        btnMenuSubject = New Button()
        btnMenuGrade = New Button()
        btnMenuReport = New Button()
        btnMenuExit = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnMenuStudent, 0, 0)
        TableLayoutPanel1.Controls.Add(btnMenuSubject, 0, 1)
        TableLayoutPanel1.Controls.Add(btnMenuGrade, 0, 2)
        TableLayoutPanel1.Controls.Add(btnMenuReport, 0, 3)
        TableLayoutPanel1.Controls.Add(btnMenuExit, 0, 4)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(40)
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(578, 700)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnMenuStudent
        ' 
        btnMenuStudent.Dock = DockStyle.Fill
        btnMenuStudent.Location = New Point(43, 43)
        btnMenuStudent.Margin = New Padding(3, 3, 3, 15)
        btnMenuStudent.Name = "btnMenuStudent"
        btnMenuStudent.Size = New Size(492, 106)
        btnMenuStudent.TabIndex = 0
        btnMenuStudent.Text = "Siswa"
        btnMenuStudent.UseVisualStyleBackColor = True
        ' 
        ' btnMenuSubject
        ' 
        btnMenuSubject.Dock = DockStyle.Fill
        btnMenuSubject.Location = New Point(43, 167)
        btnMenuSubject.Margin = New Padding(3, 3, 3, 15)
        btnMenuSubject.Name = "btnMenuSubject"
        btnMenuSubject.Size = New Size(492, 106)
        btnMenuSubject.TabIndex = 1
        btnMenuSubject.Text = "Mata Pelajaran"
        btnMenuSubject.UseVisualStyleBackColor = True
        ' 
        ' btnMenuGrade
        ' 
        btnMenuGrade.Dock = DockStyle.Fill
        btnMenuGrade.Location = New Point(43, 291)
        btnMenuGrade.Margin = New Padding(3, 3, 3, 15)
        btnMenuGrade.Name = "btnMenuGrade"
        btnMenuGrade.Size = New Size(492, 106)
        btnMenuGrade.TabIndex = 2
        btnMenuGrade.Text = "Nilai"
        btnMenuGrade.UseVisualStyleBackColor = True
        ' 
        ' btnMenuReport
        ' 
        btnMenuReport.Dock = DockStyle.Fill
        btnMenuReport.Location = New Point(43, 415)
        btnMenuReport.Margin = New Padding(3, 3, 3, 15)
        btnMenuReport.Name = "btnMenuReport"
        btnMenuReport.Size = New Size(492, 106)
        btnMenuReport.TabIndex = 3
        btnMenuReport.Text = "Laporan"
        btnMenuReport.UseVisualStyleBackColor = True
        ' 
        ' btnMenuExit
        ' 
        btnMenuExit.Dock = DockStyle.Fill
        btnMenuExit.Location = New Point(43, 539)
        btnMenuExit.Margin = New Padding(3, 3, 3, 15)
        btnMenuExit.Name = "btnMenuExit"
        btnMenuExit.Size = New Size(492, 106)
        btnMenuExit.TabIndex = 4
        btnMenuExit.Text = "Keluar"
        btnMenuExit.UseVisualStyleBackColor = True
        ' 
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(578, 700)
        Controls.Add(TableLayoutPanel1)
        Name = "MainMenuForm"
        Text = "Menu Utama"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnMenuStudent As Button
    Friend WithEvents btnMenuSubject As Button
    Friend WithEvents btnMenuGrade As Button
    Friend WithEvents btnMenuReport As Button
    Friend WithEvents btnMenuExit As Button
End Class
