<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditorScreen
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
        Me.grpCodeAuditor = New System.Windows.Forms.GroupBox
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.btnViewTables = New System.Windows.Forms.Button
        Me.btnStartAudit = New System.Windows.Forms.Button
        Me.lblLastName = New System.Windows.Forms.Label
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblProjectName = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.cboProjects = New System.Windows.Forms.ComboBox
        Me.cboProgramSize = New System.Windows.Forms.ComboBox
        Me.cboInterfaceDesign = New System.Windows.Forms.ComboBox
        Me.cboDocumentation = New System.Windows.Forms.ComboBox
        Me.cboSecurity = New System.Windows.Forms.ComboBox
        Me.cboOverallCodeDesign = New System.Windows.Forms.ComboBox
        Me.cboCodeDataTypes = New System.Windows.Forms.ComboBox
        Me.cboCodeLogic = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblComments = New System.Windows.Forms.Label
        Me.txtProgramSize = New System.Windows.Forms.TextBox
        Me.txtInterfaceDesign = New System.Windows.Forms.TextBox
        Me.txtDocumentation = New System.Windows.Forms.TextBox
        Me.txtSecurity = New System.Windows.Forms.TextBox
        Me.txtOverallCodeDesign = New System.Windows.Forms.TextBox
        Me.txtCodeDataTypes = New System.Windows.Forms.TextBox
        Me.txtCodeLogic = New System.Windows.Forms.TextBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.lblTotalRatings = New System.Windows.Forms.Label
        Me.lblProgramSize = New System.Windows.Forms.Label
        Me.lblInterfaceDesign = New System.Windows.Forms.Label
        Me.lblDocumentation = New System.Windows.Forms.Label
        Me.lblSecurity = New System.Windows.Forms.Label
        Me.lblOverallCodeDesign = New System.Windows.Forms.Label
        Me.lblCodeDataTypes = New System.Windows.Forms.Label
        Me.lblCodeLogic = New System.Windows.Forms.Label
        Me.lblQualityRating = New System.Windows.Forms.Label
        Me.lblAuditorWelcome = New System.Windows.Forms.Label
        Me.lblAuditorInstructions = New System.Windows.Forms.Label
        Me.grpCodeAuditor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCodeAuditor
        '
        Me.grpCodeAuditor.Controls.Add(Me.btnLogOut)
        Me.grpCodeAuditor.Controls.Add(Me.btnViewTables)
        Me.grpCodeAuditor.Controls.Add(Me.btnStartAudit)
        Me.grpCodeAuditor.Controls.Add(Me.lblLastName)
        Me.grpCodeAuditor.Controls.Add(Me.lblFirstName)
        Me.grpCodeAuditor.Controls.Add(Me.lblProjectName)
        Me.grpCodeAuditor.Controls.Add(Me.txtLastName)
        Me.grpCodeAuditor.Controls.Add(Me.txtFirstName)
        Me.grpCodeAuditor.Controls.Add(Me.cboProjects)
        Me.grpCodeAuditor.Controls.Add(Me.cboProgramSize)
        Me.grpCodeAuditor.Controls.Add(Me.cboInterfaceDesign)
        Me.grpCodeAuditor.Controls.Add(Me.cboDocumentation)
        Me.grpCodeAuditor.Controls.Add(Me.cboSecurity)
        Me.grpCodeAuditor.Controls.Add(Me.cboOverallCodeDesign)
        Me.grpCodeAuditor.Controls.Add(Me.cboCodeDataTypes)
        Me.grpCodeAuditor.Controls.Add(Me.cboCodeLogic)
        Me.grpCodeAuditor.Controls.Add(Me.btnClose)
        Me.grpCodeAuditor.Controls.Add(Me.lblComments)
        Me.grpCodeAuditor.Controls.Add(Me.txtProgramSize)
        Me.grpCodeAuditor.Controls.Add(Me.txtInterfaceDesign)
        Me.grpCodeAuditor.Controls.Add(Me.txtDocumentation)
        Me.grpCodeAuditor.Controls.Add(Me.txtSecurity)
        Me.grpCodeAuditor.Controls.Add(Me.txtOverallCodeDesign)
        Me.grpCodeAuditor.Controls.Add(Me.txtCodeDataTypes)
        Me.grpCodeAuditor.Controls.Add(Me.txtCodeLogic)
        Me.grpCodeAuditor.Controls.Add(Me.btnSubmit)
        Me.grpCodeAuditor.Controls.Add(Me.txtStatus)
        Me.grpCodeAuditor.Controls.Add(Me.lblStatus)
        Me.grpCodeAuditor.Controls.Add(Me.txtTotal)
        Me.grpCodeAuditor.Controls.Add(Me.lblTotalRatings)
        Me.grpCodeAuditor.Controls.Add(Me.lblProgramSize)
        Me.grpCodeAuditor.Controls.Add(Me.lblInterfaceDesign)
        Me.grpCodeAuditor.Controls.Add(Me.lblDocumentation)
        Me.grpCodeAuditor.Controls.Add(Me.lblSecurity)
        Me.grpCodeAuditor.Controls.Add(Me.lblOverallCodeDesign)
        Me.grpCodeAuditor.Controls.Add(Me.lblCodeDataTypes)
        Me.grpCodeAuditor.Controls.Add(Me.lblCodeLogic)
        Me.grpCodeAuditor.Controls.Add(Me.lblQualityRating)
        Me.grpCodeAuditor.Location = New System.Drawing.Point(4, 44)
        Me.grpCodeAuditor.Name = "grpCodeAuditor"
        Me.grpCodeAuditor.Size = New System.Drawing.Size(464, 396)
        Me.grpCodeAuditor.TabIndex = 3
        Me.grpCodeAuditor.TabStop = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(252, 76)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 50
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnViewTables
        '
        Me.btnViewTables.Location = New System.Drawing.Point(252, 44)
        Me.btnViewTables.Name = "btnViewTables"
        Me.btnViewTables.Size = New System.Drawing.Size(75, 23)
        Me.btnViewTables.TabIndex = 49
        Me.btnViewTables.Text = "View Tables"
        Me.btnViewTables.UseVisualStyleBackColor = True
        '
        'btnStartAudit
        '
        Me.btnStartAudit.Location = New System.Drawing.Point(252, 16)
        Me.btnStartAudit.Name = "btnStartAudit"
        Me.btnStartAudit.Size = New System.Drawing.Size(75, 23)
        Me.btnStartAudit.TabIndex = 48
        Me.btnStartAudit.Text = "Start Audit"
        Me.btnStartAudit.UseVisualStyleBackColor = True
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(56, 80)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 47
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(57, 52)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 46
        Me.lblFirstName.Text = "First Name:"
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Location = New System.Drawing.Point(43, 24)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(74, 13)
        Me.lblProjectName.TabIndex = 45
        Me.lblProjectName.Text = "Project Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(120, 76)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(120, 20)
        Me.txtLastName.TabIndex = 44
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(120, 48)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstName.TabIndex = 43
        '
        'cboProjects
        '
        Me.cboProjects.FormattingEnabled = True
        Me.cboProjects.Location = New System.Drawing.Point(120, 20)
        Me.cboProjects.Name = "cboProjects"
        Me.cboProjects.Size = New System.Drawing.Size(121, 21)
        Me.cboProjects.TabIndex = 42
        '
        'cboProgramSize
        '
        Me.cboProgramSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProgramSize.FormattingEnabled = True
        Me.cboProgramSize.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboProgramSize.Location = New System.Drawing.Point(120, 280)
        Me.cboProgramSize.Name = "cboProgramSize"
        Me.cboProgramSize.Size = New System.Drawing.Size(40, 21)
        Me.cboProgramSize.TabIndex = 30
        '
        'cboInterfaceDesign
        '
        Me.cboInterfaceDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInterfaceDesign.FormattingEnabled = True
        Me.cboInterfaceDesign.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboInterfaceDesign.Location = New System.Drawing.Point(120, 255)
        Me.cboInterfaceDesign.Name = "cboInterfaceDesign"
        Me.cboInterfaceDesign.Size = New System.Drawing.Size(40, 21)
        Me.cboInterfaceDesign.TabIndex = 29
        '
        'cboDocumentation
        '
        Me.cboDocumentation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumentation.FormattingEnabled = True
        Me.cboDocumentation.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboDocumentation.Location = New System.Drawing.Point(120, 231)
        Me.cboDocumentation.Name = "cboDocumentation"
        Me.cboDocumentation.Size = New System.Drawing.Size(40, 21)
        Me.cboDocumentation.TabIndex = 28
        '
        'cboSecurity
        '
        Me.cboSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecurity.FormattingEnabled = True
        Me.cboSecurity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboSecurity.Location = New System.Drawing.Point(120, 205)
        Me.cboSecurity.Name = "cboSecurity"
        Me.cboSecurity.Size = New System.Drawing.Size(40, 21)
        Me.cboSecurity.TabIndex = 24
        '
        'cboOverallCodeDesign
        '
        Me.cboOverallCodeDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOverallCodeDesign.FormattingEnabled = True
        Me.cboOverallCodeDesign.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboOverallCodeDesign.Location = New System.Drawing.Point(120, 180)
        Me.cboOverallCodeDesign.Name = "cboOverallCodeDesign"
        Me.cboOverallCodeDesign.Size = New System.Drawing.Size(40, 21)
        Me.cboOverallCodeDesign.TabIndex = 18
        '
        'cboCodeDataTypes
        '
        Me.cboCodeDataTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodeDataTypes.FormattingEnabled = True
        Me.cboCodeDataTypes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboCodeDataTypes.Location = New System.Drawing.Point(120, 156)
        Me.cboCodeDataTypes.Name = "cboCodeDataTypes"
        Me.cboCodeDataTypes.Size = New System.Drawing.Size(40, 21)
        Me.cboCodeDataTypes.TabIndex = 17
        '
        'cboCodeLogic
        '
        Me.cboCodeLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodeLogic.FormattingEnabled = True
        Me.cboCodeLogic.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboCodeLogic.Location = New System.Drawing.Point(121, 131)
        Me.cboCodeLogic.Name = "cboCodeLogic"
        Me.cboCodeLogic.Size = New System.Drawing.Size(40, 21)
        Me.cboCodeLogic.TabIndex = 15
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(300, 364)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 41
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(200, 112)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(56, 13)
        Me.lblComments.TabIndex = 40
        Me.lblComments.Text = "Comments"
        '
        'txtProgramSize
        '
        Me.txtProgramSize.Enabled = False
        Me.txtProgramSize.Location = New System.Drawing.Point(200, 282)
        Me.txtProgramSize.Multiline = True
        Me.txtProgramSize.Name = "txtProgramSize"
        Me.txtProgramSize.Size = New System.Drawing.Size(256, 18)
        Me.txtProgramSize.TabIndex = 36
        '
        'txtInterfaceDesign
        '
        Me.txtInterfaceDesign.Enabled = False
        Me.txtInterfaceDesign.Location = New System.Drawing.Point(200, 257)
        Me.txtInterfaceDesign.Multiline = True
        Me.txtInterfaceDesign.Name = "txtInterfaceDesign"
        Me.txtInterfaceDesign.Size = New System.Drawing.Size(256, 18)
        Me.txtInterfaceDesign.TabIndex = 32
        '
        'txtDocumentation
        '
        Me.txtDocumentation.Enabled = False
        Me.txtDocumentation.Location = New System.Drawing.Point(200, 232)
        Me.txtDocumentation.Multiline = True
        Me.txtDocumentation.Name = "txtDocumentation"
        Me.txtDocumentation.Size = New System.Drawing.Size(256, 18)
        Me.txtDocumentation.TabIndex = 33
        '
        'txtSecurity
        '
        Me.txtSecurity.Enabled = False
        Me.txtSecurity.Location = New System.Drawing.Point(200, 207)
        Me.txtSecurity.Multiline = True
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.Size = New System.Drawing.Size(256, 18)
        Me.txtSecurity.TabIndex = 35
        '
        'txtOverallCodeDesign
        '
        Me.txtOverallCodeDesign.Enabled = False
        Me.txtOverallCodeDesign.Location = New System.Drawing.Point(200, 182)
        Me.txtOverallCodeDesign.Multiline = True
        Me.txtOverallCodeDesign.Name = "txtOverallCodeDesign"
        Me.txtOverallCodeDesign.Size = New System.Drawing.Size(256, 18)
        Me.txtOverallCodeDesign.TabIndex = 31
        '
        'txtCodeDataTypes
        '
        Me.txtCodeDataTypes.Enabled = False
        Me.txtCodeDataTypes.Location = New System.Drawing.Point(200, 157)
        Me.txtCodeDataTypes.Multiline = True
        Me.txtCodeDataTypes.Name = "txtCodeDataTypes"
        Me.txtCodeDataTypes.Size = New System.Drawing.Size(256, 18)
        Me.txtCodeDataTypes.TabIndex = 34
        '
        'txtCodeLogic
        '
        Me.txtCodeLogic.Enabled = False
        Me.txtCodeLogic.Location = New System.Drawing.Point(200, 132)
        Me.txtCodeLogic.Multiline = True
        Me.txtCodeLogic.Name = "txtCodeLogic"
        Me.txtCodeLogic.Size = New System.Drawing.Size(256, 18)
        Me.txtCodeLogic.TabIndex = 37
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(380, 364)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 39
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(405, 333)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(51, 20)
        Me.txtStatus.TabIndex = 14
        Me.txtStatus.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(358, 336)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 38
        Me.lblStatus.Text = "Status:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(405, 311)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(51, 20)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.TabStop = False
        '
        'lblTotalRatings
        '
        Me.lblTotalRatings.AutoSize = True
        Me.lblTotalRatings.Location = New System.Drawing.Point(330, 314)
        Me.lblTotalRatings.Name = "lblTotalRatings"
        Me.lblTotalRatings.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalRatings.TabIndex = 27
        Me.lblTotalRatings.Text = "Total Rating:"
        '
        'lblProgramSize
        '
        Me.lblProgramSize.AutoSize = True
        Me.lblProgramSize.Location = New System.Drawing.Point(45, 283)
        Me.lblProgramSize.Name = "lblProgramSize"
        Me.lblProgramSize.Size = New System.Drawing.Size(72, 13)
        Me.lblProgramSize.TabIndex = 23
        Me.lblProgramSize.Text = "Program Size:"
        '
        'lblInterfaceDesign
        '
        Me.lblInterfaceDesign.AutoSize = True
        Me.lblInterfaceDesign.Location = New System.Drawing.Point(29, 258)
        Me.lblInterfaceDesign.Name = "lblInterfaceDesign"
        Me.lblInterfaceDesign.Size = New System.Drawing.Size(88, 13)
        Me.lblInterfaceDesign.TabIndex = 21
        Me.lblInterfaceDesign.Text = "Interface Design:"
        '
        'lblDocumentation
        '
        Me.lblDocumentation.AutoSize = True
        Me.lblDocumentation.Location = New System.Drawing.Point(35, 233)
        Me.lblDocumentation.Name = "lblDocumentation"
        Me.lblDocumentation.Size = New System.Drawing.Size(82, 13)
        Me.lblDocumentation.TabIndex = 19
        Me.lblDocumentation.Text = "Documentation:"
        '
        'lblSecurity
        '
        Me.lblSecurity.AutoSize = True
        Me.lblSecurity.Location = New System.Drawing.Point(69, 208)
        Me.lblSecurity.Name = "lblSecurity"
        Me.lblSecurity.Size = New System.Drawing.Size(48, 13)
        Me.lblSecurity.TabIndex = 20
        Me.lblSecurity.Text = "Security:"
        '
        'lblOverallCodeDesign
        '
        Me.lblOverallCodeDesign.AutoSize = True
        Me.lblOverallCodeDesign.Location = New System.Drawing.Point(10, 183)
        Me.lblOverallCodeDesign.Name = "lblOverallCodeDesign"
        Me.lblOverallCodeDesign.Size = New System.Drawing.Size(107, 13)
        Me.lblOverallCodeDesign.TabIndex = 26
        Me.lblOverallCodeDesign.Text = "Overall Code Design:"
        '
        'lblCodeDataTypes
        '
        Me.lblCodeDataTypes.AutoSize = True
        Me.lblCodeDataTypes.Location = New System.Drawing.Point(24, 158)
        Me.lblCodeDataTypes.Name = "lblCodeDataTypes"
        Me.lblCodeDataTypes.Size = New System.Drawing.Size(93, 13)
        Me.lblCodeDataTypes.TabIndex = 25
        Me.lblCodeDataTypes.Text = "Code Data Types:"
        '
        'lblCodeLogic
        '
        Me.lblCodeLogic.AutoSize = True
        Me.lblCodeLogic.Location = New System.Drawing.Point(53, 134)
        Me.lblCodeLogic.Name = "lblCodeLogic"
        Me.lblCodeLogic.Size = New System.Drawing.Size(64, 13)
        Me.lblCodeLogic.TabIndex = 22
        Me.lblCodeLogic.Text = "Code Logic:"
        '
        'lblQualityRating
        '
        Me.lblQualityRating.AutoSize = True
        Me.lblQualityRating.Location = New System.Drawing.Point(118, 112)
        Me.lblQualityRating.Name = "lblQualityRating"
        Me.lblQualityRating.Size = New System.Drawing.Size(73, 13)
        Me.lblQualityRating.TabIndex = 16
        Me.lblQualityRating.Text = "Quality Rating"
        '
        'lblAuditorWelcome
        '
        Me.lblAuditorWelcome.AutoSize = True
        Me.lblAuditorWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuditorWelcome.Location = New System.Drawing.Point(8, 8)
        Me.lblAuditorWelcome.Name = "lblAuditorWelcome"
        Me.lblAuditorWelcome.Size = New System.Drawing.Size(234, 18)
        Me.lblAuditorWelcome.TabIndex = 2
        Me.lblAuditorWelcome.Text = "Welcome to the Code Auditor!"
        '
        'lblAuditorInstructions
        '
        Me.lblAuditorInstructions.AutoSize = True
        Me.lblAuditorInstructions.Location = New System.Drawing.Point(8, 28)
        Me.lblAuditorInstructions.Name = "lblAuditorInstructions"
        Me.lblAuditorInstructions.Size = New System.Drawing.Size(213, 13)
        Me.lblAuditorInstructions.TabIndex = 1
        Me.lblAuditorInstructions.Text = "Please fill out the form for a new code audit."
        '
        'frmAuditorScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 452)
        Me.Controls.Add(Me.grpCodeAuditor)
        Me.Controls.Add(Me.lblAuditorWelcome)
        Me.Controls.Add(Me.lblAuditorInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAuditorScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code Auditor"
        Me.grpCodeAuditor.ResumeLayout(False)
        Me.grpCodeAuditor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCodeAuditor As System.Windows.Forms.GroupBox
    Friend WithEvents lblAuditorWelcome As System.Windows.Forms.Label
    Friend WithEvents lblAuditorInstructions As System.Windows.Forms.Label
    Friend WithEvents cboProgramSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboInterfaceDesign As System.Windows.Forms.ComboBox
    Friend WithEvents cboDocumentation As System.Windows.Forms.ComboBox
    Friend WithEvents cboSecurity As System.Windows.Forms.ComboBox
    Friend WithEvents cboOverallCodeDesign As System.Windows.Forms.ComboBox
    Friend WithEvents cboCodeDataTypes As System.Windows.Forms.ComboBox
    Friend WithEvents cboCodeLogic As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents txtProgramSize As System.Windows.Forms.TextBox
    Friend WithEvents txtInterfaceDesign As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumentation As System.Windows.Forms.TextBox
    Friend WithEvents txtSecurity As System.Windows.Forms.TextBox
    Friend WithEvents txtOverallCodeDesign As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeDataTypes As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeLogic As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalRatings As System.Windows.Forms.Label
    Friend WithEvents lblProgramSize As System.Windows.Forms.Label
    Friend WithEvents lblInterfaceDesign As System.Windows.Forms.Label
    Friend WithEvents lblDocumentation As System.Windows.Forms.Label
    Friend WithEvents lblSecurity As System.Windows.Forms.Label
    Friend WithEvents lblOverallCodeDesign As System.Windows.Forms.Label
    Friend WithEvents lblCodeDataTypes As System.Windows.Forms.Label
    Friend WithEvents lblCodeLogic As System.Windows.Forms.Label
    Friend WithEvents lblQualityRating As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblProjectName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents cboProjects As System.Windows.Forms.ComboBox
    Friend WithEvents btnStartAudit As System.Windows.Forms.Button
    Friend WithEvents btnViewTables As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
End Class
