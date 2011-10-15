''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''                                                                                  ''
''              Program Name: Assignment2                                           ''
''                    Author: Jeremiah J. Isaacson                                  ''
''                      Date: 11/06/2009                                            ''
''                 Form Name: frmCreateNewUser                                      ''
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

'Imports System and Windows Forms namespaces
Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports IST.DataHash


Public Class frmCreateNewUser

    'Instantiates a new object of the classLoginScreen class
    Dim objCreateNewUserVerify As New classCreateNewUserScreen

    ' SQL MyConnection settings
    Private Shared MyConnection As String = My.Settings.MySqlConnectionString
    Private Shared connection As New MySqlConnection(MyConnection)

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear all text in the txtUsername/login textbox.
        txtLoginName.Text = ""

        ' Clear all text in the txtPassword textbox.
        txtPassword.Text = ""

        ' Clear all text in the txtConfirmPassword textbox.
        txtConfirmPassword.Text = ""

        ' Clear all text in the txtFirstName textbox.
        txtFirstName.Text = ""

        ' Clear all text in the txtLastName textbox.
        txtLastName.Text = ""

        ' Clear all text in the txtEmail textbox.
        'txtEmail.Text = ""

        ' Clear all text in the txtConfirmEmail textbox.
        'txtConfirmEmail.Text = ""
    End Sub

    Private Sub btnCreateNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNewUser.Click


        Dim strError As String = ""
        Dim intErrorCounter As Integer = 0

        If String.IsNullOrEmpty(txtLoginName.Text) Then
            'Show your message here
            strError += "You must enter a Desired Login name." & vbCrLf
            intErrorCounter += 1
            ' Set the focus to the last error that occured
            txtLoginName.Focus()
        Else
            'Show your message her
        End If


        If String.IsNullOrEmpty(txtPassword.Text) Then
            'Show your message here
            strError += "You must enter a Password." & vbCrLf
            intErrorCounter += 1
            ' Set the focus to the last error that occured
            txtPassword.Focus()
        Else
            'Show your message here
        End If

        If String.IsNullOrEmpty(txtConfirmPassword.Text) Then
            'Show your message here
            strError += "You must enter a Confirm Password." & vbCrLf
            intErrorCounter += 1
            ' Set the focus to the last error that occured
            txtConfirmPassword.Focus()
        Else
            'Show your message here
        End If

        If String.IsNullOrEmpty(txtFirstName.Text) Then
            'Show your message here
            strError += "You must enter a First Name." & vbCrLf
            intErrorCounter += 1
            ' Set the focus to the last error that occured
            txtFirstName.Focus()
        Else
            'Show your message here
        End If

        If String.IsNullOrEmpty(txtLastName.Text) Then
            'Show your message here
            strError += "You must enter a Confirm Password." & vbCrLf
            intErrorCounter += 1
            ' Set the focus to the last error that occured
            txtLastName.Focus()
        Else
            'Show your message here
        End If


        '' Need to create a check so that the passwords match before submitting the form.
        '' Defines strPassword and strConfirmPassword as Strings.
        Dim strPassword As String
        Dim strConfirmPassword As String

        '' Sets username as text entered into txtPassword textbox.
        strPassword = txtPassword.Text
        '' Sets password as text entered into txtConfirmPassword textbox.
        strConfirmPassword = txtConfirmPassword.Text

        If intErrorCounter >= 1 Then
            MessageBox.Show("You have " & intErrorCounter & " errors that must be corrected!" & vbCrLf & vbCrLf & strError & "", "Data Entry Error")

            '' Sends "password" and "confirm password" attempt.
        ElseIf objCreateNewUserVerify.functionVerifyMatchingPasswords(strPassword, strConfirmPassword) = True Then

            'Create a new encryption object
            Dim objMD5 As New MD5

            strPassword = objMD5.Encrypt(txtPassword.Text)
            'MessageBox.Show(strPassword)

            ' Convert all text in the txtUsername/login textbox.
            Dim strLoginName As String = txtLoginName.Text

            ' Convert all text in the txtFirstName textbox.
            Dim strFirstName As String = txtFirstName.Text

            ' Convert all text in the txtLastName textbox.
            Dim strLastName As String = txtLastName.Text

            'Instantiates the classes used in the code below
            Dim objCheckUserCreateUser As New classDatabaseConnector

            'Creates new user if username is not taken
            objCheckUserCreateUser.functionVerifyNewUser(strLoginName, strPassword, strFirstName, strLastName)
        Else
            MessageBox.Show("Passwords do not match. Please re-type your passwords and try again", "Password Error")
            ' Set the focus to the last error that occured
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'If back button is selected, the frmLoginScreen.vb form is re-opened 
        frmLoginScreen.Show()

        'If back button is selected, the frmCreateNewUserLoginScreen.vb form is closed
        Me.Close()
    End Sub
End Class