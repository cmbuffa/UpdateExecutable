Imports System.IO
Imports System.Configuration

Public Class Form1
    Dim programName As String
    Dim updateLocation As String
    Dim domainName As String
    Dim domainUserName As String
    Dim domainUserPassword As String
    Dim archivolocal As String
    Dim archivoserver As String
    Dim actualizar As Boolean

    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function

    Private Sub CopiarArchivo(ByVal origen As String, ByVal destino As String)
        Using negociar As New Tools.Impersonator(userName:="cmbuffa", domainName:="Server2008", password:="1421570-5")
            Dim bytesRead As Integer
            Dim buffer(8192) As Byte
            Using inFile As New FileStream(origen, FileMode.Open, FileAccess.Read)
                Using outFile As New FileStream(destino, FileMode.Create, FileAccess.Write)
                    ProgressBar1.Maximum = inFile.Length
                    Do
                        bytesRead = inFile.Read(buffer, 0, buffer.Length)
                        If bytesRead > 0 Then
                            outFile.Write(buffer, 0, bytesRead)
                            ProgressBar1.Value = ProgressBar1.Value + bytesRead
                            Application.DoEvents()
                        End If
                    Loop While bytesRead > 0
                End Using
            End Using
        End Using
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        programName = ConfigurationManager.AppSettings("programName") + "*"
        updateLocation = ConfigurationManager.AppSettings("updateLocation")
        domainName = ConfigurationManager.AppSettings("domainName")
        domainUserName = ConfigurationManager.AppSettings("domainUserName")
        domainUserPassword = ConfigurationManager.AppSettings("domainUserPassword")
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Label1.Text = "Conectando..."
        Timer1.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdactualizar.Click
        Using negociar As New Tools.Impersonator(userName:=Me.domainUserName, domainName:=Me.domainName, password:=Me.domainUserPassword)
            ProgressBar1.Visible = True
            lblprogreso.Visible = True
            CopiarArchivo(archivoserver, archivolocal)
        End Using
        cmdiniciar.Enabled = True
        cmdactualizar.Enabled = False
    End Sub

    Private Sub cmdiniciar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdiniciar.Click
        Try
            Shell(archivolocal, AppWinStyle.NormalFocus)
            Me.Close()
        Catch ex As FileNotFoundException
            MsgBox("No se Encuentra el archivo " + archivolocal)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Try
            Using negociar As New Tools.Impersonator(userName:=Me.domainUserName, domainName:=Me.domainName, password:=Me.domainUserPassword)
                Dim newbuildversion As Integer, serverbuildversion As Integer, localbuildversion As Integer
                localbuildversion = 0
                archivolocal = ""
                archivoserver = ""
                newbuildversion = 0
                For Each archivo In Directory.GetFiles(Directory.GetCurrentDirectory(), Me.programName, SearchOption.AllDirectories)
                    localbuildversion = GetFileVersionInfo(archivo).Build
                    If localbuildversion > newbuildversion Then
                        newbuildversion = localbuildversion
                        archivolocal = archivo
                    End If
                Next
                newbuildversion = 0
                For Each archivo In Directory.GetFiles(Me.updateLocation, Me.programName)
                    serverbuildversion = GetFileVersionInfo(archivo).Build
                    If serverbuildversion > newbuildversion Then
                        newbuildversion = serverbuildversion
                        archivoserver = archivo
                    End If
                Next
                If GetFileVersionInfo(archivoserver).Build > GetFileVersionInfo(archivolocal).Build Then
                    Dim destino As String
                    destino = Directory.GetCurrentDirectory() + "\" + My.Computer.FileSystem.GetFileInfo(archivoserver).Name
                    Label1.Text = "Hay una nueva versión del ejecutable " + GetFileVersionInfo(archivoserver).ToString()
                    archivolocal = destino
                    cmdactualizar.Enabled = True
                    cmdiniciar.Enabled = False
                Else
                    Label1.Text = "Sistema Actualizado"
                    cmdactualizar.Enabled = False
                    cmdiniciar.Enabled = True
                End If
                ProgressBar1.Visible = False
                lblprogreso.Visible = False

            End Using
        Catch ex As Exception
            Label1.Text = "No se pudo comprobar si hay actualizaciones. Compurebe la Red!"
            cmdactualizar.Enabled = False
            cmdiniciar.Enabled = True
        End Try
    End Sub
End Class
