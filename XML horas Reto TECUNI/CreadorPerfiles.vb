Imports System.Xml

Public Class CreadorPerfiles

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\FondoGestorPerfiles-Larreagaburu.png")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\FondoGestorPerfiles-Miraflores.png")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\FondoGestorPerfiles-Basilica.png")
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
        Dim ventanaCurvas As New CurvaAElegir
        ventanaCurvas.Show()
        Me.Button5.Text = "Elegir curva " + "(" + ventanaCurvas.getCurvaElegida.ToString + ")"

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
End Class