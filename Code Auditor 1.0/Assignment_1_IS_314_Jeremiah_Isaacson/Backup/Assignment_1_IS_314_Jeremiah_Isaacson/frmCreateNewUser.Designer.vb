<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateNewUser
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
        Me.btnCreateNewUser = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.grpLogin = New System.Windows.Forms.GroupBox
        Me.btnBack = New System.Windows.Forms.Button
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.lblLastName = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.lblConfirmPassword = New System.Windows.Forms.Label
        Me.txtLoginName = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblLogin = New System.Windows.Forms.Label
        Me.lblWelcome = New System.Windows.Forms.Label
        Me.lblLoginInstructions = New System.Windows.Forms.Label
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateNewUser
        '
        Me.btnCreateNewUser.Location = New System.Drawing.Point(173, 152)
        Me.btnCreateNewUser.Name = "btnCreateNewUser"
        Me.btnCreateNewUser.Size = New System.Drawing.Size(99, 23)
        Me.btnCreateNewUser.TabIndex = 8
        Me.btnCreateNewUser.Text = "Create New User"
        Me.btnCreateNewUser.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(116, 44)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtPassword.TabIndex = 2
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.btnBack)
        Me.grpLogin.Controls.Add(Me.txtLastName)
        Me.grpLogin.Controls.Add(Me.lblLastName)
        Me.grpLogin.Controls.Add(Me.txtFirstName)
        Me.grpLogin.Controls.Add(Me.lblFirstName)
        Me.grpLogin.Controls.Add(Me.txtConfirmPassword)
        Me.grpLogin.Controls.Add(Me.lblConfirmPassword)
        Me.grpLogin.Controls.Add(Me.btnCreateNewUser)
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.Controls.Add(Me.txtLoginName)
        Me.grpLogin.Controls.Add(Me.btnClear)
        Me.grpLogin.Controls.Add(Me.lblPassword)
        Me.grpLogin.Controls.Add(Me.lblLogin)
        Me.grpLogin.Location = New System.Drawing.Point(4, 44)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(280, 184)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Create New User"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 152)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(116, 128)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(156, 20)
        Me.txtLastName.TabIndex = 5
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(45, 132)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(116, 100)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(156, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(46, 104)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(116, 72)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(12, 76)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(94, 13)
        Me.lblConfirmPassword.TabIndex = 0
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'txtLoginName
        '
        Me.txtLoginName.Location = New System.Drawing.Point(116, 16)
        Me.txtLoginName.Name = "txtLoginName"
        Me.txtLoginName.Size = New System.Drawing.Size(156, 20)
        Me.txtLoginName.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(92, 152)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(50, 48)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(31, 20)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(75, 13)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Desired Login:"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(8, 8)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(137, 18)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Create New User"
        '
        'lblLoginInstructions
        '
        Me.lblLoginInstructions.AutoSize = True
        Me.lblLoginInstructions.Location = New System.Drawing.Point(8, 28)
        Me.lblLoginInstructions.Name = "lblLoginInstructions"
        Me.lblLoginInstructions.Size = New System.Drawing.Size(285, 13)
        Me.lblLoginInstructions.TabIndex = 0
        Me.lblLoginInstructions.Text = "Please complete the fields to add a new Code Auditor user."
        '
        'frmCreateNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(289, 229)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblLoginInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCreateNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code Auditor - Create New User"
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateNewUser As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents grpLogin As System.Windows.Forms.GroupBox
    Friend WithEvents txtLoginName As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblLoginInstructions As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
