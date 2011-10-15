''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''                                                                                  ''
''              Program Name: Assignment2                                           ''
''                    Author: Jeremiah J. Isaacson                                  ''
''                      Date: 11/06/2009                                            ''
''                 Form Name: classCreateNewUserScreen                                ''
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

Public Class classCreateNewUserScreen

    'Password Match Verification Function to check if the password fields match
    Function functionVerifyMatchingPasswords(ByVal strPassword, ByVal strConfirmPassword)
        'Specifies that login must be "username" and password must be "password"
        If strPassword = strConfirmPassword Then
            ' The password fields match each other. Return a success!
            Return True
        Else
            Return False
        End If
    End Function

End Class
