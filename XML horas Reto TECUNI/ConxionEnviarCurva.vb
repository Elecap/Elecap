Public Class ConxionEnviarCurva

    Dim curva1 As String = 1
    Dim curva2 As String = 1
    Dim curva3 As String = 1
    Dim c As ConexionX
    Dim ventanaCurvas As New CurvaAElegir


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ventanaEncendido As New testConexion
        ventanaEncendido.Show()
        Me.Close()
    End Sub

    Private Sub pbCurva3_Click(sender As Object, e As EventArgs) Handles pbCurva3.Click
        ventanaCurvas.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim ventanaEstado As New ConexionEstado
        ventanaEstado.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        enviarCurvas()
    End Sub
    Public Sub enviarCurvas()

        c.enviarComando(":00031000002B08000200030" + curva1 + "5D")
        c.enviarComando(":00031000002B08000200020" + curva2 + "5D")
        c.enviarComando(":00031000002B08000200010" + curva3 + "5D")

    End Sub

    Private Sub ventanaCurvas_evento(i As Integer)
        pintarCurvas()
    End Sub

    Public Sub pintarCurvas()
        Me.pbCurva1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + curva1 + "-2.png")
        Me.pbCurva2.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + curva2 + "-2.png")
        Me.pbCurva3.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + curva3 + "-2.png")
    End Sub

    Private Sub ConxionEnviarCurva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c = New ConexionX
        AddHandler ventanaCurvas.evento, AddressOf ventanaCurvas_evento
    End Sub

    Private Sub pbCurva8_Click(sender As Object, e As EventArgs) Handles pbCurva2.Click
        ventanaCurvas.Show()
    End Sub

    Private Sub pbCurva10_Click(sender As Object, e As EventArgs) Handles pbCurva1.Click
        ventanaCurvas.Show()

    End Sub
End Class