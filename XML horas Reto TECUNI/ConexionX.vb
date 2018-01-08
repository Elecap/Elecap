Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Net.NetworkInformation.Ping
Imports nsoftware.IPWorks

Public Class ConexionX

    Public iBufferIN As String = ""
    Private ipTiempoEsperaRespuesta As Integer = 10
    Public estaConectado As Boolean



    Public Function conectar()
        Try
            If comenzarCliente("12.168.100.100", "8000") Then
                'Me.pbEstado.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Connected.png")
                'Me.pbEstadoTexto.Text = "Conectado"
                estaConectado = True
                Return True
            Else
                'Me.pbEstado.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\NotConnected.png")
                'Me.pbEstadoTexto.Text = "Desconectado"
                estaConectado = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function



    Public Function enviarComando(ByVal c As String)
        Dim respuesta As String

        Try
            If puertoIP.Connected Then
                puertoIP.DataToSend &= c & puertoIP.EOL
            End If
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function comenzarCliente(ByVal ip As String, ByVal host As String)
        Try
            Dim ipAddress As IPAddress = IPAddress.Parse(ip)
            Dim remoteEP As IPEndPoint = New IPEndPoint(ipAddress, Integer.Parse(host))

            puertoIP.Connect(ip, host)
            puertoIP.EOL = vbLf
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Ipport_OnSSLStatus(sender As Object, e As IpportSSLStatusEventArgs)

    End Sub

    Private Sub ConexionX_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub puertoIP_OnSSLStatus(sender As Object, e As IpportSSLStatusEventArgs) Handles puertoIP.OnSSLStatus

    End Sub

    Private Sub puertoIP_OnDataIn(sender As Object, e As IpportDataInEventArgs) Handles puertoIP.OnDataIn
        iBufferIN += e.Text

    End Sub
End Class