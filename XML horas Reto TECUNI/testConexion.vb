Public Class testConexion
    Dim encendido1 As Boolean = False
    Dim encendido2 As Boolean = False
    Dim encendido3 As Boolean = False
    Dim encendido4 As Boolean = False

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        While True
            If encendido1 = True Then
                pbS1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
                encendido1 = False
                Exit While
            End If
            If encendido1 = False Then
                pbS1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_ON3.png")
                encendido1 = True
                Exit While
            End If
        End While

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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        While True
            If encendido4 = True Then
                pbS4.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_OFF2.png")
                encendido4 = False
                Exit While
            End If
            If encendido4 = False Then
                pbS4.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\luz_ON3.png")
                encendido4 = True
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