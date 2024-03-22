<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProgressBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ShowPassword = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Username
        '
        Me.Username.BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Username.BorderRadius = 5
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.DefaultText = ""
        Me.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Username.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.Location = New System.Drawing.Point(89, 251)
        Me.Username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Username.Name = "Username"
        Me.Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Username.PlaceholderText = "Enter your username"
        Me.Username.SelectedText = ""
        Me.Username.Size = New System.Drawing.Size(336, 43)
        Me.Username.TabIndex = 0
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.Color.White
        Me.ProgressBar.FillColor = System.Drawing.Color.Transparent
        Me.ProgressBar.Location = New System.Drawing.Point(-11, 1)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar.Size = New System.Drawing.Size(1142, 13)
        Me.ProgressBar.TabIndex = 3
        Me.ProgressBar.Text = "Guna2ProgressBar1"
        Me.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'ShowPassword
        '
        Me.ShowPassword.CheckedState.BorderColor = System.Drawing.Color.DarkGray
        Me.ShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ShowPassword.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPassword.CheckedState.InnerColor = System.Drawing.Color.White
        Me.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowPassword.Location = New System.Drawing.Point(90, 415)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(45, 22)
        Me.ShowPassword.TabIndex = 5
        Me.ShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPassword.UncheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.ShowPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPassword.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'LoginBtn
        '
        Me.LoginBtn.BorderRadius = 10
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.LoginBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.LoginBtn.Location = New System.Drawing.Point(87, 490)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(336, 53)
        Me.LoginBtn.TabIndex = 6
        Me.LoginBtn.Text = "Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Location = New System.Drawing.Point(521, -16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 710)
        Me.Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vehicle Parking"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(68, 201)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(83, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sign In"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(88, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(86, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Password"
        '
        'Password
        '
        Me.Password.BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Password.BorderRadius = 5
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Password.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(90, 351)
        Me.Password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Password.PlaceholderText = "Enter your password"
        Me.Password.SelectedText = ""
        Me.Password.Size = New System.Drawing.Size(336, 43)
        Me.Password.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(142, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Show Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 677)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.ShowPassword)
        Me.Controls.Add(Me.Username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProgressBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ShowPassword As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
End Class
