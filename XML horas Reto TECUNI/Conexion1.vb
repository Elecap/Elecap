Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Net.NetworkInformation.Ping
Imports nsoftware.IPWorks

Public Class Conexion1

    Public iBufferIN As String = ""
    Private ipTiempoEsperaRespuesta As Integer = 10

    Private Function Conexion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Return conectar()
    End Function

    Public Function conectar()
        Try
            If comenzarCliente("12.168.100.100", "8000") Then
                Me.pbEstado.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Connected.png")
                Me.pbEstadoTexto.Text = "Conectado"
                Return True
            Else
                Me.pbEstado.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\NotConnected.png")
                Me.pbEstadoTexto.Text = "Desconectado"
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    'Public Function encenderA()
    '    Dim comando As String = "1000002712000200010350"
    '    If enviarComando(comando) Then
    '        Return True
    '    Else
    '        Return False

    '    End If
    'End Function

    'Public Function enviarComando(ByVal c As String)
    '    Try
    '        If puertoIP.Connected Then
    '            puertoIP.DataToSend &= c & puertoIP.EOL
    '        End If
    '        Return True
    '    Catch
    '        Return False
    '    End Try
    'End Function

    Public Function comenzarCliente(ByVal ip As String, ByVal host As String)
        Try
            Dim ipAddress As IPAddress = IPAddress.Parse(ip)
            Dim remoteEP As IPEndPoint = New IPEndPoint(ipAddress, Integer.Parse(host))

            puertoIP.Connect(ip, host)
            puertoIP.EOL = vbLf
            Return True
        Catch ex As Exception
            MsgBox("Conexion fallida")
            Return False
        End Try
    End Function

    Private Sub Ipport_OnSSLStatus(sender As Object, e As IpportSSLStatusEventArgs)

    End Sub
End Class