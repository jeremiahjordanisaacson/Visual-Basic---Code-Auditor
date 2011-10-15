''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''                                                                                  ''
''              Program Name: Assignment2                                           ''
''                    Author: Jeremiah J. Isaacson                                  ''
''                      Date: 11/06/2009                                            ''
''                 Form Name: classLoginScreen                                      ''
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
Imports MySql
Imports IST.DataHash


' classLoginScreen 
' - used to verify the username and password
' - used to check the number of login attempts
' - used to open the frmAuditorScreen
' - used to close the frmLoginScreen on successful login attempt
Public Class classLoginScreen

    ' Variable declaration
    Public intLoginAttempts As Integer

    'Login Function to check validity of login credentials
    Function functionVerifyCredentials(ByVal strLogin, ByVal strPassword)

        Dim CConstants As New classCreateNewUserScreen
        Dim MD5 As New MD5

        Dim connection As New MySqlConnection
        connection.ConnectionString = My.Settings.MySqlConnectionString

        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = "SELECT * FROM tbl_Login WHERE Login_Name = '" & strLogin & "';"
        command.Connection = connection
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim myReader As MySqlDataReader = command.ExecuteReader()
        While myReader.Read()
            ' Dim dataReader As MySqlDataReader = command.ExecuteReader()
            'Dim myReader1 As MySqlDataReader = command.ExecuteReader()
            'Set the variables for the User's data
            If MD5.Verify(strPassword, myReader.GetValue(myReader.GetOrdinal("Login_Password"))) = True Then
                classConstants.propertyAuditor_ID = myReader.GetValue(myReader.GetOrdinal("Login_ID"))
                classConstants.propertyLogin_Name = myReader.GetValue(myReader.GetOrdinal("Login_Name"))
                classConstants.propertyLogin_First_Name = myReader.GetValue(myReader.GetOrdinal("Login_First_Name"))
                classConstants.propertyLogin_Last_Name = myReader.GetValue(myReader.GetOrdinal("Login_Last_Name"))
                myReader.Close()
                connection.Close()
                Return True
                'MessageBox.Show("Success") '"Success"
            Else
                myReader.Close()
                connection.Close()
                Return Nothing
            End If
            myReader.Close()
            connection.Close()
        End While
        myReader.Close()
        connection.Close()
        Return Nothing
    End Function
End Class
