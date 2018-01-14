Imports System.Xml

Public Class CreadorPerfiles
    Dim ventanaCurvas As New CurvaAElegir

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\FondoGestorPerfiles-LarreagaburuG.png")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\FondoGestorPerfiles-MirafloresG.png")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\FondoGestorPerfiles-BasilicaG.png")
    End Sub

    Private Sub cbIntervalosNubososLluviaEscasa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbMuyNubosoLluviaEscasa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbNubosoLluviaEscasa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbCubiertoLluviaEscasa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbCubierto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbPocoNuboso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbIntervalosNubosos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbNuboso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbDespejado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        ventanaCurvas.Show()
        'Me.Button5.Text = "Elegir curva " + "(" + ventanaCurvas.curvaElegida.ToString + ")"

    End Sub

    Private Sub ventanaCurvas_evento(i As Integer)
        Me.Button5.Text = "Elegir curva " + "(" + i.ToString + ")"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.tbDescripcion.Text = "" Then 'Añadir las demás comprobaciones
            Dim formError As New ErrorForm
            formError.lbTexto.Text = "No se han introducido todos los datos. Por favor asegúrese de que ha rellenado todos los campos."
            formError.Show()
        Else
            crearPerfil()
            Dim formSuccess As New SuccessForm
            formSuccess.lbMensaje.Text = "Perfil creado correctamente."
            formSuccess.Show()
        End If
    End Sub

    Private Sub crearPerfil()
        Dim ruta As String = "C:\Temp\perfiles.xml"
        Try
            Dim writer As XmlTextWriter = New XmlTextWriter(ruta, System.Text.Encoding.UTF8)
            writer.Formatting = Formatting.Indented
            writer.WriteStartDocument()
            writer.WriteStartDocument("perfiles")
            'escribirCondiciones()
            'escribirDescripcion()
            'escribirFasesLunares()
            'escribirCurva()
            'escribirFechas()


            writer.WriteEndDocument()
            writer.Close()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Dim gestorDePerfiles As New GestorPerfiles
        gestorDePerfiles.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ventanaPrincipal As New Form4
        ventanaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim ventanaPrevision As New CurvaActual
        ventanaPrevision.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ventanaConexion As New testConexion
        ventanaConexion.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub CreadorPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler ventanaCurvas.evento, AddressOf ventanaCurvas_evento
    End Sub
End Class