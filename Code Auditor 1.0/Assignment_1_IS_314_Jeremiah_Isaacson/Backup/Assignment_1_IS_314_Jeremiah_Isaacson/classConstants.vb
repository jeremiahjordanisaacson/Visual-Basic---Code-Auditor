

Public Class classConstants

    ' Declare variables for use in each property
    Public Shared strAuditor_ID As String
    Public Shared strLogin_Name As String
    Public Shared strPassword As String
    Public Shared strConfirmPassword As String
    Public Shared strLogin_First_Name As String
    Public Shared strLogin_Last_Name As String
    Shared strProject_ID As String

    ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' '
    ' '                            PROPERTIES
    ' '
    ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' Set Auditor_ID
    Public Shared Property propertyAuditor_ID()
        Get
            Return strAuditor_ID
        End Get
        Set(ByVal strSetAuditor_ID)
            strAuditor_ID = strSetAuditor_ID
        End Set
    End Property

    ' Set Project_ID
    Property propertyProject_ID()
        Get
            Return strProject_ID
        End Get
        Set(ByVal strSetProject_ID)
            strProject_ID = strSetProject_ID
        End Set
    End Property

    ' Set Login_Name
    Public Shared Property propertyLogin_Name()
        Get
            Return strLogin_Name
        End Get
        Set(ByVal Username)
            strLogin_Name = Username
        End Set
    End Property

    ' Set Password
    Public Shared Property propertyPassword() As String
        Get
            Return strPassword
        End Get
        Set(ByVal strSetPassword As String)
            strPassword = strSetPassword
        End Set
    End Property

    ' Set Confirm Password
    Public Shared Property propertyConfirmPassword() As String
        Get
            Return strConfirmPassword
        End Get
        Set(ByVal strSetConfirmPassword As String)
            strConfirmPassword = strSetConfirmPassword
        End Set
    End Property

    ' Set Login_First_Name
    Public Shared Property propertyLogin_First_Name() As String
        Get
            Return strLogin_First_Name
        End Get
        Set(ByVal strSetLogin_First_Name As String)
            strLogin_First_Name = strSetLogin_First_Name
        End Set
    End Property

    ' Set Login_Last_Name
    Public Shared Property propertyLogin_Last_Name() As String
        Get
            Return strLogin_Last_Name
        End Get
        Set(ByVal strSetLogin_Last_Name As String)
            strLogin_Last_Name = strSetLogin_Last_Name
        End Set
    End Property
End Class
