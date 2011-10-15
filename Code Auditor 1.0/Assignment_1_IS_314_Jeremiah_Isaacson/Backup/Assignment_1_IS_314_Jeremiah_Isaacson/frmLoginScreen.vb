''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''                                                                                  ''
''              Program Name: Assignment1                                           ''
''                    Author: Jeremiah J. Isaacson                                  ''
''                      Date: 10/09/2009                                            ''
''                 Form Name: frmLoginScreen                                        ''
''                                                                                  ''
''                                                                                  ''
''         Program Narrative: The program is simple auditor form used by code       ''
''                            auditors. A detailed listing of this program's        ''
''                            specification may be found by navigating to the link  ''
''                            below view a web browser.                             ''
''                                                                                  ''
''    Specifications PDF URL: http://www.savant.mobi/assignment1_specifications.pdf ''
''                                                                                  ''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

' Imports
Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports IST

' frmLoginScreen class
' - handles the login events
' - uses classLoginScreen
Public Class frmLoginScreen

    'Instantiates a new object of the classLoginScreen class
    Dim objLoginVerify As New classLoginScreen

    ' Clear the textboxes click event.
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear all text in the username/login textbox.
        txtUsername.Text = ""

        ' Clear all text in the password textbox.
        txtPassword.Text = ""
    End Sub

    ' Handles the login credentials
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ' Defines username and password as Strings.
        Dim strUsername As String
        Dim strPassword As String

        ' Sets username as text entered into txtUsername textbox.
        strUsername = txtUsername.Text

        ' Sets password as text entered into txtPassword textbox.
        strPassword = txtPassword.Text

        ' Sends Login class username and password attempt.
        If objLoginVerify.functionVerifyCredentials(strUsername, strPassword) = True Then

            frmAuditorScreen.Show()

            ' Close the frmLoginScreen because of 3 failed login attempts.
            Me.Close()

        End If
    End Sub

    Private Sub btnCreateNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNewUser.Click
        'If Create New User button is selected, the frmCreateNewUserLoginScreen.vb form is opened 
        frmCreateNewUser.Show()

        'If Create New User button is selected, the frmLoginScreen.vb form is closed
        Me.Close()
    End Sub
End Class
