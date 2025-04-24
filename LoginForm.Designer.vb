<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        SplitContainer1 = New SplitContainer()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(TableLayoutPanel1)
        SplitContainer1.Size = New Size(1036, 356)
        SplitContainer1.SplitterDistance = 538
        SplitContainer1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(538, 356)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.62753F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 64.37247F))
        TableLayoutPanel1.Controls.Add(txtUsername, 1, 0)
        TableLayoutPanel1.Controls.Add(txtPassword, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(btnLogin, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 63.73057F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 36.26943F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 136F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(494, 356)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.Location = New Point(179, 98)
        txtUsername.Margin = New Padding(3, 3, 30, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(285, 39)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.Location = New Point(179, 150)
        txtPassword.Margin = New Padding(3, 10, 30, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(285, 39)
        txtPassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(30, 98)
        Label1.Margin = New Padding(30, 0, 3, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 32)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 150)
        Label2.Margin = New Padding(30, 10, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 32)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.SetColumnSpan(btnLogin, 2)
        btnLogin.Location = New Point(30, 222)
        btnLogin.Margin = New Padding(30, 3, 30, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(434, 52)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Masuk"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1036, 356)
        Controls.Add(SplitContainer1)
        Name = "LoginForm"
        Text = "Autentikasi"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
