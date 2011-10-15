''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''                                                                                  ''
''              Program Name: Assignment2                                           ''
''                    Author: Jeremiah J. Isaacson                                  ''
''                      Date: 11/06/2009                                            ''
''                 Form Name: frmAuditorScreen                                      ''
''                                                                                  ''
''                                                                                  ''
''         Program Narrative: The program is complicated auditor form used by code  ''
''                            auditors. A detailed listing of this program's        ''
''                            specification may be found by navigating to the link  ''
''                            below view a web browser.                             ''
''                                                                                  ''
''    Specifications PDF URL: http://www.savant.mobi/assignment2_specifications.pdf ''
''                                                                                  ''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

' Imports
Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

' frmAuditorScreen 
' - uses classAuditorScreen for functions and methods related to this form.
Public Class frmAuditorScreen

    ' Create a new object of the classAuditorScreen
    Dim objAuditor As New classAuditorScreen
    Dim objDatabase As New classDatabaseConnector
    Dim objConstants As New classConstants
    Dim SelectedItemCodeLogic As Integer
    Dim SelectedItemCodeDataTypes As Integer
    Dim SelectedItemOverallCodeDesign As Integer
    Dim SelectedItemSecurity As Integer
    Dim SelectedItemDocumentation As Integer
    Dim SelectedItemInterfaceDesign As Integer
    Dim SelectedItemProgramSize As Integer
    Dim intTotalRating As Integer
    Dim strProjectStatus As String
    Dim strProjectName As String
    Dim strFirstName As String
    Dim strLastName As String
    Dim CommentCodeLogic As String
    Dim CommentCodeDataTypes As String
    Dim CommentOverallCodeDesign As String
    Dim CommentSecurity As String
    Dim CommentDocumentation As String
    Dim CommentInterfaceDesign As String
    Dim CommentProgramSize As String

    ' Sumbit the form
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Dim strError As String = ""
        Dim intErrorCounter As Integer = 0

        'Assigns each variable to its related combobox selected item
        SelectedItemCodeLogic = cboCodeLogic.SelectedItem
        SelectedItemCodeDataTypes = cboCodeDataTypes.SelectedItem
        SelectedItemOverallCodeDesign = cboOverallCodeDesign.SelectedItem
        SelectedItemSecurity = cboSecurity.SelectedItem
        SelectedItemDocumentation = cboDocumentation.SelectedItem
        SelectedItemInterfaceDesign = cboInterfaceDesign.SelectedItem
        SelectedItemProgramSize = cboProgramSize.SelectedItem


        'Assigns each variable to its related textbox
        CommentCodeLogic = txtCodeLogic.Text
        CommentCodeDataTypes = txtCodeDataTypes.Text
        CommentOverallCodeDesign = txtOverallCodeDesign.Text
        CommentSecurity = txtSecurity.Text
        CommentDocumentation = txtDocumentation.Text
        CommentInterfaceDesign = txtInterfaceDesign.Text
        CommentProgramSize = txtProgramSize.Text

        'Defines certain variables to this related textbox fields
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strProjectName = cboProjects.Text

        If objAuditor.functionCheckForCompletedForm() Then

            If String.IsNullOrEmpty(txtCodeLogic.Text) Then
                If txtCodeLogic.Enabled = True Then
                    'Show your message here
                    strError += "Please add a comment to the Code Logic comment field to Submit the form." & vbCrLf
                    intErrorCounter += 1

                    ' Set the focus to the last error that occured
                    txtCodeLogic.Focus()
                End If
            Else
                'Show your message her
            End If

            If String.IsNullOrEmpty(txtCodeDataTypes.Text) Then
                If txtCodeDataTypes.Enabled = True Then
                    'Show your message here
                    strError += "Please add a comment to the Code Data Types comment field to Submit the form." & vbCrLf
                    intErrorCounter += 1

                    ' Set the focus to the last error that occured
                    txtCodeDataTypes.Focus()
                End If
            Else
                'Show your message her
            End If


            If String.IsNullOrEmpty(txtOverallCodeDesign.Text) Then
                If txtOverallCodeDesign.Enabled = True Then
                    'Show your message here
                    strError += "Please add a comment to the Overall Code Design comment field to Submit the form." & vbCrLf
                    intErrorCounter += 1

                    ' Set the focus to the last error that occured
                    txtOverallCodeDesign.Focus()
                End If
            Else
                'Show your message her
            End If

            If String.IsNullOrEmpty(txtSecurity.Text) Then
                If txtSecurity.Enabled = True Then
                    'Show your message here
                    strError += "Please add a comment to the Security comment field to Submit the form." & vbCrLf
                    intErrorCounter += 1

                    ' Set the focus to the last error that occured
                    txtSecurity.Focus()
                End If
            Else
                'Show your message her
            End If

            If String.IsNullOrEmpty(txtDocumentation.Text) Then
                If txtDocumentation.Enabled = True Then
                    'Show your message here
                    strError += "Please add a comment to the Documentation comment field to Submit the form." & vbCrLf
                    intErrorCounter += 1

                    ' Set the focus to the last error that occured
                    txtDocumentation.Focus()
                End If
            Else
                'Show your message her
            End If

            If String.IsNullOrEmpty(txtInterfaceDesign.Text) Then
                If txtInterfaceDesign.Enabled = True Then
                    'Show your message here
                    strError += "Please add a comment to the Interface Design comment field to Submit the form." & vbCrLf
                    intErrorCounter += 1

                    ' Set the focus to the last error that occured
                    txtInterfaceDesign.Focus()
                End If
            Else
                'Show your message her
            End If

            If String.IsNullOrEmpty(txtProgramSize.Text) Then
                If txtProgramSize.Enabled = True Then
                    'Show your message here
                    strError += "Please add a comment to the Program Size comment field to Submit the form." & vbCrLf
                    intErrorCounter += 1

                    ' Set the focus to the last error that occured
                    txtProgramSize.Focus()
                End If
            Else
                'Show your message her
            End If


            'MessageBox.Show("Please add a comment to the Program Size comment field to Submit the form.", "Form Incomplete")

            If intErrorCounter >= 1 Then
                'MessageBox.Show("Please make a selection in each of the dropdown areas on the for to Submit the form.", "Form Incomplete")
                MessageBox.Show("You have " & intErrorCounter & " errors that must be corrected!" & vbCrLf & vbCrLf & strError & "", "Data Entry Error")

                ' Sumbit the form	

                '
                ' This needs work
                ' Note: This overall code design will not all me to have the same values but the other
                ' one does. WHY is it working like that?
            ElseIf objAuditor.functionLastVerifyCodeOverallCodeDesign() = True Then
                MessageBox.Show("Please select a value greater than or equal to that of Code Logic and Data Types for Overall Code Design.", "Audit Error!")
            Else

                MessageBox.Show("Success!", "Calculation Completed.")
                ' Display the total via a call the the calculate function.
                txtTotal.Text = objAuditor.functionCalculateTotal()

                ' Set text box equal to "Fail" or "Probation" or "Pass" or "Complete".
                txtStatus.Text = objAuditor.functionCalculateTotalRating()


                Dim strStatus As String
                Dim strTotal As String

                'Sets status equal to related textbox
                strStatus = txtStatus.Text

                strTotal = txtTotal.Text

                'Database insert statement that inserts various data into the database
                objDatabase.InsertIntoDatabase(SelectedItemCodeLogic, SelectedItemCodeDataTypes, SelectedItemOverallCodeDesign, SelectedItemSecurity, SelectedItemDocumentation, SelectedItemInterfaceDesign, SelectedItemProgramSize, CommentCodeLogic, CommentCodeDataTypes, CommentOverallCodeDesign, CommentSecurity, CommentDocumentation, CommentInterfaceDesign, CommentProgramSize, strTotal, strStatus, strProjectName, strFirstName, strLastName)

            End If
        Else
            MessageBox.Show("Please fill out the entire form before submitting for calculation", "Error")
        End If

    End Sub

    ' Exit the program by closing the frmAuditorScreen form.
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Exit the program by closing the frmAuditorScreen form.
        Me.Close()
    End Sub

    ' cboCodeLogic_SelectedIndexChanged
    Private Sub cboCodeLogic_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodeLogic.SelectedIndexChanged

        ' Send the property the value of the user selection
        objAuditor.propertySelectedIndexCodeLogic = cboCodeLogic.SelectedIndex

        ' Display the value of the index selected. Previously stored and now retrived from the class property.
        'MessageBox.Show(objAuditor.propertySelectedIndexCodeLogic())
        objAuditor.propertyUserSelectedComboBox = 1

        ' Assign the respective label the correct color.
        lblCodeLogic.ForeColor = objAuditor.functionAssignColor()

        ' Determine if the comments are open or closed and clear them if closed.
        If objAuditor.functionAssignColor() = Color.Red Then
            txtCodeLogic.Enabled = True
        Else
            txtCodeLogic.Enabled = False
            txtCodeLogic.Text = ""
        End If

        ' Purpose: Check to see if Overall Code Design is larger or equal to Code Logic and Overall Code
        ' Call functionVerifyCodeOverallCodeDesign
        objAuditor.functionVerifyCodeOverallCodeDesign()
    End Sub

    ' cboCodeDataTypes_SelectedIndexChanged
    Private Sub cboCodeDataTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodeDataTypes.SelectedIndexChanged

        ' Send the property the value of the user selection
        objAuditor.propertySelectedIndexCodeDataTypes = cboCodeDataTypes.SelectedIndex

        ' Display the value of the index selected. Previously stored and now retrived from the class property.
        objAuditor.propertyUserSelectedComboBox = 2

        ' Assign the respective label the correct color.
        lblCodeDataTypes.ForeColor = objAuditor.functionAssignColor()

        ' Determine if the comments are open or closed and clear them if closed.
        If objAuditor.functionAssignColor() = Color.Red Then
            txtCodeDataTypes.Enabled = True
        Else
            txtCodeDataTypes.Enabled = False
            txtCodeDataTypes.Text = ""
        End If

        ' Purpose: Check to see if Overall Code Design is larger or equal to Code Logic and Overall Code
        ' Call functionVerifyCodeOverallCodeDesign
        objAuditor.functionVerifyCodeOverallCodeDesign()
    End Sub

    ' cboOverallCodeDesign_SelectedIndexChanged
    Private Sub cboOverallCodeDesign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOverallCodeDesign.SelectedIndexChanged
        ' Send the property the value of the user selection
        objAuditor.propertySelectedIndexOverallCodeDesign = cboOverallCodeDesign.SelectedIndex

        ' Display the value of the index selected. Previously stored and now retrived from the class property.
        objAuditor.propertyUserSelectedComboBox = 3

        ' Assign the respective label the correct color.
        lblOverallCodeDesign.ForeColor = objAuditor.functionAssignColor()

        ' Determine if the comments are open or closed and clear them if closed.
        If objAuditor.functionAssignColor() = Color.Red Then
            txtOverallCodeDesign.Enabled = True
        Else
            txtOverallCodeDesign.Enabled = False
            txtOverallCodeDesign.Text = ""
        End If

        ' Purpose: Check to see if Overall Code Design is larger or equal to Code Logic and Overall Code
        ' Call functionVerifyCodeOverallCodeDesign
        objAuditor.functionVerifyCodeOverallCodeDesign()
    End Sub

    ' cboSecurity_SelectedIndexChanged
    Private Sub cboSecurity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSecurity.SelectedIndexChanged
        ' Send the property the value of the user selection
        objAuditor.propertySelectedIndexSecurity = cboSecurity.SelectedIndex

        ' Display the value of the index selected. Previously stored and now retrived from the class property.
        objAuditor.propertyUserSelectedComboBox = 4

        ' Assign the respective label the correct color.
        lblSecurity.ForeColor = objAuditor.functionAssignColor()

        ' Determine if the comments are open or closed and clear them if closed.
        If objAuditor.functionAssignColor() = Color.Red Then
            txtSecurity.Enabled = True
        Else
            txtSecurity.Enabled = False
            txtSecurity.Text = ""
        End If
    End Sub

    ' cboDocumentation_SelectedIndexChanged
    Private Sub cboDocumentation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocumentation.SelectedIndexChanged
        ' Send the property the value of the user selection
        objAuditor.propertySelectedIndexDocumentation = cboDocumentation.SelectedIndex

        ' Display the value of the index selected. Previously stored and now retrived from the class property.
        objAuditor.propertyUserSelectedComboBox = 5

        ' Assign the respective label the correct color.
        lblDocumentation.ForeColor = objAuditor.functionAssignColor()

        ' Determine if the comments are open or closed and clear them if closed.
        If objAuditor.functionAssignColor() = Color.Red Then
            txtDocumentation.Enabled = True
        Else
            txtDocumentation.Enabled = False
            txtDocumentation.Text = ""
        End If
    End Sub

    ' cboInterfaceDesign_SelectedIndexChanged
    Private Sub cboInterfaceDesign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInterfaceDesign.SelectedIndexChanged
        ' Send the property the value of the user selection
        objAuditor.propertySelectedIndexInterfaceDesign = cboInterfaceDesign.SelectedIndex

        ' Display the value of the index selected. Previously stored and now retrived from the class property.
        objAuditor.propertyUserSelectedComboBox = 6

        ' Assign the respective label the correct color.
        lblInterfaceDesign.ForeColor = objAuditor.functionAssignColor()

        ' Determine if the comments are open or closed and clear them if closed.
        If objAuditor.functionAssignColor() = Color.Red Then
            txtInterfaceDesign.Enabled = True
        Else
            txtInterfaceDesign.Enabled = False
            txtInterfaceDesign.Text = ""
        End If
    End Sub

    ' cboProgramSize_SelectedIndexChanged
    Private Sub cboProgramSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProgramSize.SelectedIndexChanged
        ' Send the property the value of the user selection
        objAuditor.propertySelectedIndexProgramSize = cboProgramSize.SelectedIndex

        ' Display the value of the index selected. Previously stored and now retrived from the class property.
        objAuditor.propertyUserSelectedComboBox = 7

        ' Assign the respective label the correct color.
        lblProgramSize.ForeColor = objAuditor.functionAssignColor()

        ' Determine if the comments are open or closed and clear them if closed.
        If objAuditor.functionAssignColor() = Color.Red Then
            txtProgramSize.Enabled = True
        Else
            txtProgramSize.Enabled = False
            txtProgramSize.Text = ""
        End If
    End Sub

    Private Sub frmAuditorScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Disable combo boxes onLoad of the frmAuditorScreen
        cboCodeLogic.Enabled = False
        cboCodeDataTypes.Enabled = False
        cboOverallCodeDesign.Enabled = False
        cboSecurity.Enabled = False
        cboDocumentation.Enabled = False
        cboInterfaceDesign.Enabled = False
        cboProgramSize.Enabled = False

        'Populates the Project DropDown Box
        objDatabase.functionGetProjects(cboProjects)
    End Sub

    Private Sub btnStartAudit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartAudit.Click
        'If statement that says if first and last name textboxes are not empty, and item is selected in Project combobox, rating comboboxes are enabled
        If cboProjects.SelectedItem <> "" Then
            If txtFirstName.Text <> "" And txtLastName.Text <> "" Then
                cboCodeLogic.Enabled = True
                cboCodeDataTypes.Enabled = True
                cboOverallCodeDesign.Enabled = True
                cboSecurity.Enabled = True
                cboDocumentation.Enabled = True
                cboInterfaceDesign.Enabled = True
                cboProgramSize.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnViewTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTables.Click
        ' Display the frmDataGridView
        frmDataGridView.Show()

        ' Close the Auditor form
        Me.Close()
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        ' Open Login form
        frmLoginScreen.Show()

        ' Close the DataGridView
        Me.Close()
    End Sub

    Private Sub cboProjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProjects.SelectedIndexChanged
        Dim SelectedItem As Integer
        'Adds 1 to the selected index
        SelectedItem = cboProjects.SelectedIndex + 1

        'Sets projectID based on which project is selected
        objConstants.propertyProject_ID = SelectedItem
    End Sub
End Class