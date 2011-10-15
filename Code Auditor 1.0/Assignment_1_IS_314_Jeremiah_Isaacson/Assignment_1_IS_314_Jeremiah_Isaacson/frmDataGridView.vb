''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''                                                                                  ''
''              Program Name: Assignment2                                           ''
''                    Author: Jeremiah J. Isaacson                                  ''
''                      Date: 11/06/2009                                            ''
''                 Form Name: frmDataGridView                                      ''
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

Imports System
Imports MySql.Data.MySqlClient

Public Class frmDataGridView

    'Instantiates the Database class
    Dim Database As New classDatabaseConnector

    Private Sub formDataGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Declare variable
        Dim objPopulateProjectsComboBox As New classDatabaseConnector

        'Populates the Projects combobox on form load
        objPopulateProjectsComboBox.FillDropDown(cboProjects)
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        ' Open Login form
        frmLoginScreen.Show()

        ' Close the DataGridView
        Me.Close()
    End Sub

    Private Sub btnBackToAuditorScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToAuditorScreen.Click
        ' Open Login form
        frmAuditorScreen.Show()

        ' Close the DataGridView
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim UpdateDGV As New classDatabaseConnector

        'Defines strResult as string which sends objects to the database class to receive a return
        Dim strResult As String = UpdateDGV.UpdateView(CStr(cboProjects.Text), dgvTables)

        'Case which checks whether the result from above is a success or failure.
        'If failure, shows an error message.
        Select Case strResult
            Case "Success"
            Case "Failure"
                MessageBox.Show("Unfortunately there was an error reading data from the database, please try again.")
        End Select
    End Sub
End Class