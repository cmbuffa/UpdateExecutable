Public Class Dlink
    Private cStringSql As String
    Private cServerName As String
    Private cDataBaseName As String
    Private cIntegrado As Integer
    Private cUserID As String
    Private cPwd As String
    Private cConnectionString As String
    Private cAppname As String

    Public Sub New()
        Setvariables()
    End Sub

    Public Sub New(ByVal userid As String, ByVal passwd As String, ByVal database As String)
        Setvariables(userid, passwd, database)
    End Sub

    Public Sub New(ByVal userid As String, ByVal passwd As String, ByVal database As String, ByVal server As String)
        Setvariables(userid, passwd, database, server)
    End Sub

    Public Sub CrearConexion(Optional ByVal sIntegrada As Integer = 0)

    End Sub

    Private Overloads Sub Setvariables()
        cStringSql = ""
        cServerName = ""
        cDataBaseName = ""
        cIntegrado = 0
        cUserID = ""
        cPwd = ""
        cConnectionString = ""
        cAppname = ""
    End Sub

    Private Overloads Sub Setvariables(ByVal userid As String, ByVal passwd As String, ByVal database As String)
        cStringSql = ""
        cServerName = ""
        cDataBaseName = database
        cIntegrado = 0
        cUserID = userid
        cPwd = passwd
        cConnectionString = ""
        cAppname = ""
    End Sub

    Private Overloads Sub Setvariables(ByVal userid As String, ByVal passwd As String, ByVal database As String, ByVal server As String)
        cStringSql = ""
        cServerName = server
        cDataBaseName = database
        cIntegrado = 0
        cUserID = userid
        cPwd = passwd
        cConnectionString = ""
        cAppname = ""
    End Sub


    Public Property AppName
        Get
            Return cAppname
        End Get
        Set(ByVal value)
            cAppname = value
        End Set
    End Property
End Class
