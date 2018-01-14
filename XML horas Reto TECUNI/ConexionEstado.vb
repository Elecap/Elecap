Public Class ConexionEstado

    Dim conexion As ConexionX


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ventanaEnviarCurva As New ConxionEnviarCurva
        ventanaEnviarCurva.Show()
        Me.Close()
    End Sub



    Private Sub ConexionEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New ConexionX
        Me.getEstado()

    End Sub

    Public Sub getEstado()

        Me.conexion.conectar()


        If conexion.estaConectado Then
            Me.LabelEstado.Text = "          Conexión con el PLC realizada con éxito!"
            Me.pbEstado.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Connected.png")
        Else
            Me.LabelEstado.Text = "          NO ESTÁ CONECTADO"
            Me.pbEstado.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\NotConnected.png")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getEstado()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim ventanaPerfiles As New GestorPerfiles
        ventanaPerfiles.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim v As New CurvaActual
        v.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        End
    End Sub
End Class