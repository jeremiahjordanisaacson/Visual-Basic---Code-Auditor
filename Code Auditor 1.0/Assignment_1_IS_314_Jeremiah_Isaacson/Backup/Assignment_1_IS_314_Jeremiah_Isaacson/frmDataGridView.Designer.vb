<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataGridView
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
        Me.dgvTables = New System.Windows.Forms.DataGridView
        Me.cboProjects = New System.Windows.Forms.ComboBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.lblWelcomeDataGridViewer = New System.Windows.Forms.Label
        Me.lblLoginInstructions = New System.Windows.Forms.Label
        Me.btnBackToAuditorScreen = New System.Windows.Forms.Button
        Me.btnLogOut = New System.Windows.Forms.Button
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTables
        '
        Me.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTables.Location = New System.Drawing.Point(8, 80)
        Me.dgvTables.Name = "dgvTables"
        Me.dgvTables.Size = New System.Drawing.Size(728, 388)
        Me.dgvTables.TabIndex = 0
        '
        'cboProjects
        '
        Me.cboProjects.FormattingEnabled = True
        Me.cboProjects.Location = New System.Drawing.Point(16, 48)
        Me.cboProjects.Name = "cboProjects"
        Me.cboProjects.Size = New System.Drawing.Size(121, 21)
        Me.cboProjects.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(144, 48)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblWelcomeDataGridViewer
        '
        Me.lblWelcomeDataGridViewer.AutoSize = True
        Me.lblWelcomeDataGridViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeDataGridViewer.Location = New System.Drawing.Point(16, 8)
        Me.lblWelcomeDataGridViewer.Name = "lblWelcomeDataGridViewer"
        Me.lblWelcomeDataGridViewer.Size = New System.Drawing.Size(263, 18)
        Me.lblWelcomeDataGridViewer.TabIndex = 4
        Me.lblWelcomeDataGridViewer.Text = "Welcome to the Data Grid Viewer!"
        '
        'lblLoginInstructions
        '
        Me.lblLoginInstructions.AutoSize = True
        Me.lblLoginInstructions.Location = New System.Drawing.Point(16, 28)
        Me.lblLoginInstructions.Name = "lblLoginInstructions"
        Me.lblLoginInstructions.Size = New System.Drawing.Size(405, 13)
        Me.lblLoginInstructions.TabIndex = 3
        Me.lblLoginInstructions.Text = "Select a table from the drop down menu and click submit to view the table content" & _
            "s. "
        '
        'btnBackToAuditorScreen
        '
        Me.btnBackToAuditorScreen.Location = New System.Drawing.Point(224, 48)
        Me.btnBackToAuditorScreen.Name = "btnBackToAuditorScreen"
        Me.btnBackToAuditorScreen.Size = New System.Drawing.Size(92, 23)
        Me.btnBackToAuditorScreen.TabIndex = 5
        Me.btnBackToAuditorScreen.Text = "Back To Auditor"
        Me.btnBackToAuditorScreen.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(320, 48)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'frmDataGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 474)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnBackToAuditorScreen)
        Me.Controls.Add(Me.lblWelcomeDataGridViewer)
        Me.Controls.Add(Me.lblLoginInstructions)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cboProjects)
        Me.Controls.Add(Me.dgvTables)
        Me.Name = "frmDataGridView"
        Me.Text = "Auditor Tables Data Grid Viewer"
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTables As System.Windows.Forms.DataGridView
    Friend WithEvents cboProjects As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblWelcomeDataGridViewer As System.Windows.Forms.Label
    Friend WithEvents lblLoginInstructions As System.Windows.Forms.Label
    Friend WithEvents btnBackToAuditorScreen As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
End Class
