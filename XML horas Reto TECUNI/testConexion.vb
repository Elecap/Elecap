Public Class testConexion
    Dim encendido1 As Boolean = False
    Dim encendido2 As Boolean = False
    Dim encendido3 As Boolean = False
    Dim conexionTest As New ConexionX

    Public Sub apagarA()

        pbS1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If encendido1 = True Then

            conexionTest.enviarComando(":00001000002712000200000351")
            If conexionTest.puertoIP.Connected Then
                pbS1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
                encendido1 = False
                Me.pbWarning1.Visible = False
            Else
                Me.pbWarning1.Visible = True
            End If

        Else
            If conexionTest.enviarComando(":00001000002712000200010350") Then
                If conexionTest.puertoIP.Connected Then
                    pbS1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_ON3.png")
                    encendido1 = True
                    Me.pbWarning1.Visible = False
                Else
                    Me.pbWarning1.Visible = True
                End If

            Else
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If encendido2 = True Then
            conexionTest.enviarComando(":00001000002712000200000251")
            If conexionTest.puertoIP.Connected Then
                pbS2.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
                encendido2 = False
                Me.pbWarning2.Visible = False
            Else
                Me.pbWarning2.Visible = True
            End If
        Else
            If conexionTest.enviarComando(":00001000002712000200010250") Then
                If conexionTest.puertoIP.Connected Then
                    pbS2.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_ON3.png")
                    encendido2 = True
                    Me.pbWarning2.Visible = False
                Else
                    Me.pbWarning2.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If encendido3 = True Then
            conexionTest.enviarComando(":0000100000271200020000010033")
            If conexionTest.puertoIP.Connected Then
                pbS3.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
                encendido3 = False
                Me.pbWarning3.Visible = False
            Else
                Me.pbWarning3.Visible = True
            End If
        Else
            If conexionTest.enviarComando(":00001000002712000200010150") Then
                If conexionTest.puertoIP.Connected Then
                    pbS3.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_ON3.png")
                    encendido3 = True
                    Me.pbWarning3.Visible = False
                Else
                    Me.pbWarning3.Visible = True
                End If
            Else
            End If
        End If
    End Sub

    Private Sub testConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comprobarErrores()
        Intro.c.desconectar()
        conexionTest.conectar()
        conexionTest.enviarComando(":0000100000271000010001D3")
    End Sub

    Private Sub comprobarErrores()
        Dim s1 As Boolean
        Dim s2 As Boolean
        Dim s3 As Boolean
        Dim s4 As Boolean

        'If comprobarError(1) Then
        '    pbWarning1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
        'End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pantallaPrincipal As New Form4
        Me.Hide()
        pantallaPrincipal.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ventanaEnviarCurva As New ConxionEnviarCurva
        ventanaEnviarCurva.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim ventanaEstado As New ConexionEstado
        ventanaEstado.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim ventanaPrincipal As New Form4
        ventanaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim ventanaPerfiles As New GestorPerfiles
        ventanaPerfiles.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        End
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim v As New CurvaActual
        v.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub
End Class