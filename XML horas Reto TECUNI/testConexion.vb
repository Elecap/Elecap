Public Class testConexion
    Dim encendido1 As Boolean = False
    Dim encendido2 As Boolean = False
    Dim encendido3 As Boolean = False





    Public Sub apagarA()
        Intro.c.enviarComando("1000002712000200000351")
        pbS1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If encendido1 = True Then
            Me.apagarA()
            encendido1 = False
        Else
            If Intro.c.enviarComando("4E220000002712000200010350") Then
                pbS1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_ON3.png")
                encendido1 = True
                MsgBox("TRUE " + Intro.c.iBufferIN)
            Else
                MsgBox("ERROR " + Intro.c.iBufferIN)
                MsgBox("Error al encender la salida")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        While True
            If encendido2 = True Then
                pbS2.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
                encendido2 = False
                Exit While
            End If
            If encendido2 = False Then
                pbS2.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_ON3.png")
                encendido2 = True
                Exit While
            End If
        End While
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        While True
            If encendido3 = True Then
                pbS3.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
                encendido3 = False
                Exit While
            End If
            If encendido3 = False Then
                pbS3.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_ON3.png")
                encendido3 = True
                Exit While
            End If
        End While
    End Sub



    Private Sub testConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comprobarErrores()
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
End Class