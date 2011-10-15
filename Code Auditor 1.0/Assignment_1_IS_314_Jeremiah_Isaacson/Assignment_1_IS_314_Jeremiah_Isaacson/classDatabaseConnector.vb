''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''                                                                                  ''
''              Program Name: Assignment2                                           ''
''                    Author: Jeremiah J. Isaacson                                  ''
''                      Date: 11/06/2009                                            ''
''                 Form Name: classDatabaseConnector                                ''
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
Imports IST.DataHash

Public Class classDatabaseConnector
    'Creates a new connection based on the connection string defined in settings
    Private Shared MyConnection As String = My.Settings.MySqlConnectionString
    Private Shared connection As New MySqlConnection(MyConnection)

    'Dim conn As New MySqlConnection
    Dim myReader As MySqlDataReader

    'Instantiates MySqlDataReader
    Dim projects As MySqlDataReader

    'Instantiates the MD5 salt/data hasher
    Dim MD5 As New MD5

    'Instantiates an instance classConstants class
    Dim objConstants As New classConstants

    ' Function to encrypt a string into an MD5 Hash
    ' Encrypt the password
    Function Encrypt(ByRef strPassword As String)

        'Create a new encryption object
        Dim objMD5 As New MD5

        'Encryp an input string
        Return objMD5.Encrypt(strPassword)

    End Function

    ' Function to verify a string and a hash match
    ' Check to see if the login password is a match for what we need
    Function Verify(ByRef strPassword As String, ByRef strHash As String)

        'Creat a new encryption object
        Dim objMD5 As New MD5

        'Verify an input string and hash match
        Return objMD5.Verify(strPassword, strHash)


    End Function

    ' COMPLETED - Function functionVerifyNewUser - Checks for current user and then will create user in database
    Function functionVerifyNewUser(ByRef strLoginName, ByRef strPassword, ByRef strFirstName, ByRef strLastName)

        Dim insert As New MySqlCommand
        'Defines connection and sql statement
        Dim exists As New MySqlCommand
        exists.CommandText = "SELECT Login_Name FROM tbl_Login;"
        exists.CommandType = CommandType.Text
        exists.Connection = connection
        With insert
            .CommandText = "CALL CreateNewUser('" & strLoginName & "','" & strPassword & "', '" & strFirstName & "', '" & strLastName & "')"
            .CommandType = CommandType.Text
            .Connection = connection
            connection.Open()
            Dim myReader As MySqlDataReader = exists.ExecuteReader()
            While myReader.Read
                'If the database value matches the value in the Login textbox we don't want to store the "new" user
                If myReader.GetValue(myReader.GetOrdinal("Login_Name")) = strLoginName Then
                    connection.Close()
                    Return MessageBox.Show("Please choose a different username as your current choice already exists.", "Login Already Exists")
                End If
            End While
            connection.Close()
        End With
        'Opens connection, executes reader, closes connection
        connection.Open()
        myReader = insert.ExecuteReader
        connection.Close()
        Return MessageBox.Show("You have Successfully created a new Code Auditor user", "Success!")
    End Function

    ' COMPLETED - Function for populating combobox
    Function GetTables(ByVal box As ComboBox)
        connection.Open()
        Dim ExistingProjects As New MySqlCommand
        'Calls the table names from database
        With ExistingProjects
            .CommandText = "CALL showTables()"
            .CommandType = CommandType.Text
            .Connection = connection
        End With
        myReader = ExistingProjects.ExecuteReader
        'Fills the combo box with table names in database
        While myReader.Read
            box.Items.Add(myReader.GetValue(myReader.GetOrdinal("Tables_in_isaacsojIS314")))
        End While
        'close the connection
        connection.Close()
        Return Nothing
    End Function

    ' COMPLETED - Function which populates the Project Combo Box
    Function functionGetProjects(ByVal box As ComboBox)

        'Defines connection prompt and sql statement
        Dim command As New MySqlCommand
        command.Connection = connection
        ' Get the projects
        command.CommandText = "CALL getProjects()"
        command.Connection = connection

        'Opens connection if it isn't already.
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'Populates a combobox while values are retrieved from database
        Dim myReader As MySqlDataReader = command.ExecuteReader()
        While myReader.Read()
            'Assigns the combobox equal to values retrieved from database
            box.Items.Add(myReader.GetValue(myReader.GetOrdinal("Project_Name")))
        End While
        myReader.Close()
        connection.Close()
        Return Nothing
    End Function

    ' COMPLETED - Populates datagrid view combobox
    Function FillDropDown(ByVal cboComboBox As ComboBox) As String

        Dim myReader As MySqlDataReader
        Dim cmd As New MySqlCommand
        With cmd
            'Calls the showTables stored procedure (in database)
            .CommandText = "Call showTables()"
            .CommandType = CommandType.Text
            .Connection = connection
        End With
        'Closes connection if it isn't already
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        'Opens connection
        connection.Open()
        myReader = cmd.ExecuteReader
        While myReader.Read
            'Populates combobox based on tables in the database
            cboComboBox.Items.Add(myReader.GetValue(myReader.GetOrdinal("Tables_in_isaacsojIS314")))
        End While
        'Closes connection
        connection.Close()
        Return "Success"
    End Function

    ' COMPLETED - Populates the datagrid view
    Function UpdateView(ByVal strDatabase As String, ByVal dgvViewer As DataGridView)
        'Creates new data adpater
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim cmd As New MySqlCommand

        Try
            With cmd
                'SQL statement that retrieves the selected database from combobox
                .CommandText = "SELECT * from " & strDatabase 'strDatabase is selected database from form combobox dropdown
                .CommandType = CommandType.Text
                .Connection = connection
            End With

            'Opens connection if it isn't already
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            'Selects the command
            myAdapter.SelectCommand = cmd

            'Runs the command
            myAdapter.Fill(myData)

            'Fills the datagrid views with database results
            dgvViewer.DataSource = myData

            'Catch statement to catch exceptions
        Catch exMySqlException As MySqlException
            Return "Failure"
        End Try


        Return Nothing

    End Function

    ' COMPLETED - Function to insert Audit values into database
    Function InsertIntoDatabase(ByRef SelectedItemCodeLogic, ByRef SelectedItemCodeDataTypes, ByRef SelectedItemOverallCodeDesign, ByRef SelectedItemSecurity, ByRef SelectedItemDocumentation, ByRef SelectedItemInterfaceDesign, ByRef SelectedItemProgramSize, ByRef CommentCodeLogic, ByRef CommentCodeDataTypes, ByRef CommentOverallCodeDesign, ByRef CommentSecurity, ByRef CommentDocumentation, ByRef CommentInterfaceDesign, ByRef CommentProgramSize, ByRef intTotalRating, ByRef strProjectStatus, ByRef strProjectName, ByRef strFirstName, ByRef strLastName)

        'Creates new SqlCommand
        Dim insert As New MySqlCommand

        'Defines projectID
        Dim strProjectID As String
        strProjectID = objConstants.propertyProject_ID

        'Connection and sql command
        With insert
            .CommandText = "CALL AddDataToAuditProjectTable('" & strProjectID & "','" & SelectedItemCodeLogic & "','" & SelectedItemCodeDataTypes & "','" & SelectedItemOverallCodeDesign & "','" & SelectedItemSecurity & "','" & SelectedItemDocumentation & "','" & SelectedItemInterfaceDesign & "','" & SelectedItemProgramSize & "','" & CommentCodeLogic & "','" & CommentCodeDataTypes & "','" & CommentOverallCodeDesign & "','" & CommentSecurity & "','" & CommentDocumentation & "','" & CommentInterfaceDesign & "','" & CommentProgramSize & "','" & intTotalRating & "','" & strProjectStatus & "','" & strProjectName & "','" & classConstants.propertyAuditor_ID & "','" & strFirstName & "','" & strLastName & "')"
            .CommandType = CommandType.Text
            .Connection = connection
        End With

        'Opens connection if it isn't already
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'Executes command
        insert.ExecuteNonQuery()
        connection.Close()
        Return Nothing

    End Function

End Class
