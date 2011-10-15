''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''                                                                                  ''
''              Program Name: Assignment2                                           ''
''                    Author: Jeremiah J. Isaacson                                  ''
''                      Date: 11/06/2009                                            ''
''                 Form Name: classAuditorScreen                                    ''
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

' classAuditorScreen
' - calculates total
' - contains property procedures for get/set features for assigning a color
' - contains property procedures for get/set features for selected index values from frmAuditorScreen form.
Public Class classAuditorScreen


    ' Declare variables for Selected Index properties
    Dim intSelectedIndexCodeLogic As Integer
    Dim intSelectedIndexCodeDataTypes As Integer
    Dim intSelectedIndexOverallCodeDesign As Integer = -1
    Dim intSelectedIndexSecurity As Integer
    Dim intSelectedIndexDocumentation As Integer
    Dim intSelectedIndexInterfaceDesign As Integer
    Dim intSelectedIndexProgramSize As Integer

    ' Declare variables for Selected properties
    Dim intSelectedCodeLogic As Integer
    Dim intSelectedCodeDataTypes As Integer
    Dim intSelectedOverallCodeDesign As Integer
    Dim intSelectedSecurity As Integer
    Dim intSelectedDocumentation As Integer
    Dim intSelectedInterfaceDesign As Integer
    Dim intSelectedProgramSize As Integer

    ' Declare variables for color
    Dim intCurrentRequiredColor As Integer

    ' Declare variable for combobox selected property
    Dim intUserSelectedComboBox As Integer

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''                                                                                  ''
    ''      START of Property section for propertyUserSelectedComboBox()                ''
    ''                                                                                  ''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' Purpose: Assigns a color to the respective label on frmAuditorScreen.
    ' propertyUserSelectedComboBox
    Property propertyUserSelectedComboBox() As Integer
        Get
            Return intUserSelectedComboBox
        End Get
        Set(ByVal intComboboxSelected As Integer)
            intUserSelectedComboBox = intComboboxSelected
        End Set
    End Property


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''                                                                                  ''
    ''      END of Property section for propertyUserSelectedComboBox()                  ''
    ''                                                                                  ''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''                                                                                  ''
    ''      START of Properties section for all 7 comboboxes of frmAuditorScreen        ''
    ''                                                                                  ''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' Purpose: 1st combobox on the form setting and getting properties.
    ' propertySelectedIndexCodeLogic
    Property propertySelectedIndexCodeLogic() As Integer
        Get
            Return intSelectedIndexCodeLogic
        End Get
        Set(ByVal intUserSelectedChoice As Integer)
            intSelectedIndexCodeLogic = intUserSelectedChoice
            intSelectedCodeLogic = intSelectedIndexCodeLogic + 1
            If intSelectedIndexCodeLogic < 2 Then
                intCurrentRequiredColor = 1 ' Red
            Else
                intCurrentRequiredColor = 2 ' Green
            End If
        End Set
    End Property

    ' Purpose: 2nd combobox on the form setting and getting properties.
    ' propertySelectedIndexCodeDataTypes
    Property propertySelectedIndexCodeDataTypes() As Integer
        Get
            Return intSelectedIndexCodeDataTypes
        End Get
        Set(ByVal intUserSelectedChoice As Integer)
            intSelectedIndexCodeDataTypes = intUserSelectedChoice
            intSelectedCodeDataTypes = intSelectedIndexCodeDataTypes + 1
            If intSelectedIndexCodeDataTypes < 2 Then
                intCurrentRequiredColor = 1 ' Red
            Else
                intCurrentRequiredColor = 2 ' Green
            End If
        End Set
    End Property

    ' Purpose: 3rd combobox on the form setting and getting properties.
    ' propertySelectedIndexOverallCodeDesign
    Property propertySelectedIndexOverallCodeDesign() As Integer
        Get
            Return intSelectedIndexOverallCodeDesign
        End Get
        Set(ByVal intUserSelectedChoice As Integer)
            intSelectedIndexOverallCodeDesign = intUserSelectedChoice
            intSelectedOverallCodeDesign = intSelectedIndexOverallCodeDesign + 1
            If intSelectedIndexOverallCodeDesign < 2 Then
                intCurrentRequiredColor = 1 ' Red
            Else
                intCurrentRequiredColor = 2 ' Green
            End If
        End Set
    End Property

    ' Purpose: 4th combobox on the form setting and getting properties.
    ' propertySelectedIndexSecurity
    Property propertySelectedIndexSecurity() As Integer
        Get
            Return intSelectedIndexSecurity
        End Get
        Set(ByVal intUserSelectedChoice As Integer)
            intSelectedIndexSecurity = intUserSelectedChoice
            intSelectedSecurity = intSelectedIndexSecurity + 1
            If intSelectedIndexSecurity < 5 Then
                intCurrentRequiredColor = 1 ' Red
            Else
                intCurrentRequiredColor = 2 ' Green
            End If
        End Set
    End Property

    ' Purpose: 5th combobox on the form setting and getting properties.
    ' propertySelectedIndexDocumentation
    Property propertySelectedIndexDocumentation() As Integer
        Get
            Return intSelectedIndexDocumentation
        End Get
        Set(ByVal intUserSelectedChoice As Integer)
            intSelectedIndexDocumentation = intUserSelectedChoice
            intSelectedDocumentation = intSelectedIndexDocumentation + 1
            If intSelectedIndexDocumentation < 4 Then
                intCurrentRequiredColor = 1 ' Red
            Else
                intCurrentRequiredColor = 2 ' Green
            End If
        End Set
    End Property

    ' Purpose: 6th combobox on the form setting and getting properties.
    ' propertySelectedIndexInterfaceDesign
    Property propertySelectedIndexInterfaceDesign() As Integer
        Get
            Return intSelectedIndexInterfaceDesign
        End Get
        Set(ByVal intUserSelectedChoice As Integer)
            intSelectedIndexInterfaceDesign = intUserSelectedChoice
            intSelectedInterfaceDesign = intSelectedIndexInterfaceDesign + 1
            If intSelectedIndexInterfaceDesign < 1 Then
                intCurrentRequiredColor = 1 ' Red
            Else
                intCurrentRequiredColor = 2 ' Green
            End If
        End Set
    End Property

    ' Purpose: 7th combobox on the form setting and getting properties.
    ' propertySelectedIndexProgramSize
    Property propertySelectedIndexProgramSize() As Integer
        Get
            Return intSelectedIndexProgramSize
        End Get
        Set(ByVal intUserSelectedChoice As Integer)
            intSelectedIndexProgramSize = intUserSelectedChoice
            intSelectedProgramSize = intSelectedIndexProgramSize + 1
            If intSelectedIndexProgramSize < 1 Then
                intCurrentRequiredColor = 1 ' Red
            Else
                intCurrentRequiredColor = 2 ' Green
            End If
        End Set
    End Property


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''                                                                                  ''
    ''      END of Properties section for all 7 comboboxes of frmAuditorScreen          ''
    ''                                                                                  ''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''                                                                                  ''
    ''      START of Functions                                                          ''
    ''                                                                                  ''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' Purpose: Checks to see if the overall code design is up to par.
    ' functionVerifyCodeOverallCodeDesign
    Function functionVerifyCodeOverallCodeDesign()

        If intSelectedIndexOverallCodeDesign < intSelectedIndexCodeLogic Or intSelectedIndexOverallCodeDesign < intSelectedIndexCodeDataTypes Then
            If intSelectedIndexOverallCodeDesign >= 0 Then
                Return MessageBox.Show("Please select a value greater than or equal to that of Code Logic and Data Types for Overall Code Design.", "Audit Error!")
            Else
                Return Nothing
            End If

            Return Nothing

        End If

        Return Nothing

    End Function

    ' Purpose: Checks to see if the overall code design is up to par.
    ' functionVerifyCodeOverallCodeDesign
    Function functionLastVerifyCodeOverallCodeDesign()

        If intSelectedIndexOverallCodeDesign < intSelectedIndexCodeLogic Or intSelectedIndexOverallCodeDesign < intSelectedIndexCodeDataTypes Then
            If intSelectedIndexOverallCodeDesign >= 0 Then
                Return True
            Else
                Return False
            End If

            Return Nothing

        End If

        Return Nothing

    End Function

    ' Purpose: Dynamically assigns a color to a label. 
    ' functionAssignColor
    Function functionAssignColor() As Color
        ' 1st combobox
        ' intSelectedIndexCodeLogic
        If intSelectedIndexCodeLogic < 2 Then
            If intUserSelectedComboBox = 1 Then
                Return Color.Red
            End If
        End If

        ' 2nd combobox
        ' intSelectedIndexCodeDataTypes
        If intSelectedIndexCodeDataTypes < 2 Then
            If intUserSelectedComboBox = 2 Then
                Return Color.Red
            End If
        End If

        ' 3rd combobox
        ' intSelectedIndexOverallCodeDesign
        If intSelectedIndexOverallCodeDesign < 2 Then
            If intUserSelectedComboBox = 3 Then
                Return Color.Red
            End If
        End If

        ' 4th combobox
        ' intSelectedIndexSecurity
        If intSelectedIndexSecurity < 5 Then
            If intUserSelectedComboBox = 4 Then
                Return Color.Red
            End If
        End If

        ' 5th combobox
        ' intSelectedIndexDocumentation
        If intSelectedIndexDocumentation < 4 Then
            If intUserSelectedComboBox = 5 Then
                Return Color.Red
            End If
        End If

        ' 6th combobox
        ' intSelectedIndexInterfaceDesign
        If intSelectedIndexInterfaceDesign < 1 Then
            If intUserSelectedComboBox = 6 Then
                Return Color.Red
            End If
        End If

        ' 7th combobox
        ' intSelectedIndexDocumentation
        If intSelectedIndexProgramSize < 1 Then
            If intUserSelectedComboBox = 7 Then
                Return Color.Red
            End If
        End If

        Return Color.Green
    End Function

    ' Purpose: Calculates the final total for the auditor.
    ' functionCalculateTotal
    Function functionCalculateTotal() As Integer
        ' Declare the intTotal to store the final total for the frmAuditorScreen.
        Dim intTotal As Integer

        ' Adding up the final total.
        intTotal = intSelectedCodeLogic + intSelectedCodeDataTypes + intSelectedOverallCodeDesign + intSelectedSecurity + intSelectedDocumentation + intSelectedInterfaceDesign + intSelectedProgramSize

        ' Return the final total.
        Return intTotal
    End Function

    ' Purpose: Calculates the total rating and return a String value.
    ' functionCalculateTotalRating
    Function functionCalculateTotalRating() As String
        ' Declare intTotalRating to store Total Rating
        Dim intTotalRating As Integer

        ' Add all 7 comboboxs Selected values for a intTotalRating
        intTotalRating = intSelectedCodeLogic + intSelectedCodeDataTypes + intSelectedOverallCodeDesign + intSelectedSecurity + intSelectedDocumentation + intSelectedInterfaceDesign + intSelectedProgramSize

        ' Series of if statements to determine the rating
        If intTotalRating > 42 Then
            If intSelectedCodeLogic < 3 Or intSelectedCodeDataTypes < 3 Or intSelectedOverallCodeDesign < 3 Or intSelectedSecurity < 6 Or intSelectedDocumentation < 5 Or intSelectedInterfaceDesign < 2 Or intSelectedProgramSize < 2 Then
                Return "Fail"
            Else
                Return "Complete"
            End If

        ElseIf intTotalRating <= 42 And intTotalRating >= 35 Then
            If intSelectedCodeLogic < 3 Or intSelectedCodeDataTypes < 3 Or intSelectedOverallCodeDesign < 3 Or intSelectedSecurity < 6 Or intSelectedDocumentation < 5 Or intSelectedInterfaceDesign < 2 Or intSelectedProgramSize < 2 Then
                Return "Fail"
            Else
                Return "Pass"
            End If

        ElseIf intTotalRating <= 34 And intTotalRating >= 25 Then
            If intSelectedCodeLogic < 3 Or intSelectedCodeDataTypes < 3 Or intSelectedOverallCodeDesign < 3 Or intSelectedSecurity < 6 Or intSelectedDocumentation < 5 Or intSelectedInterfaceDesign < 2 Or intSelectedProgramSize < 2 Then
                Return "Fail"
            Else
                Return "Probation"
            End If

        ElseIf intTotalRating <= 24 Then
            Return "Fail"

        End If

        Return Nothing

    End Function

    ' Purpose: Checks to see if the user has selected a choice from each combobox before submitting the form.
    ' functionCheckForCompletedForm
    Function functionCheckForCompletedForm() As Boolean
        ' Checks to see if the user has selected a choice from each combobox before submitting the form.
        If intSelectedCodeLogic > 0 And intSelectedCodeDataTypes > 0 And intSelectedOverallCodeDesign > 0 And intSelectedSecurity > 0 And intSelectedDocumentation > 0 And intSelectedInterfaceDesign > 0 And intSelectedProgramSize > 0 Then
            Return True  ' User has not completed the form.
        Else
            Return False ' User has completed the form.
        End If
    End Function

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''                                                                                  ''
    ''      END of Functions                                                            ''
    ''                                                                                  ''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
End Class
