Public Class FormSettings

    Private Sub FormSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setValores()
    End Sub

    Private Sub setValores()
        Const fichero As String = "D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Documentos\ValoresCielo.txt"
        Dim contenidoFichero As New System.IO.StreamReader(fichero)
        Dim arrayFichero = contenidoFichero.ReadToEnd.Split("$")
        Dim arrayCielos(20) As String
        Dim arrayValores(20) As String
        Dim posicion As Integer
        posicion = 0
        For Each valor As String In arrayFichero
            arrayFichero = valor.Split("#")
            arrayCielos(posicion) = arrayFichero(0)
            arrayValores(posicion) = arrayFichero(1)
            posicion = posicion + 1
        Next

        contenidoFichero.Close()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Settings3.png")
        Me.PictureBox1.Hide()
        Me.Label20.Hide()
        Me.Label1.Hide()
        Me.Label2.Hide()
        Me.Label3.Hide()
        Me.Label4.Hide()
        Me.Label5.Hide()
        Me.Label6.Hide()
        Me.Label7.Hide()
        Me.Label8.Hide()
        Me.Label9.Hide()
        Me.Label10.Hide()
        Me.Label11.Hide()
        Me.Label12.Hide()
        Me.NumericUpDown1.Hide()
        Me.NumericUpDown2.Hide()
        Me.InterNub.Hide()
        Me.Cubier.Hide()
        Me.PocoNub.Hide()
        Me.Cubiertolluvesc.Hide()
        Me.NubAlt.Hide()
        Me.MuyNub.Hide()
        Me.MuyNubLluv.Hide()
        Me.IntNubLLuvEsc.Hide()
        Me.NumericUpDown11.Hide()
        Me.NumericUpDown12.Hide()

        Me.Label15.Show()
        Me.Label16.Show()
        Me.Label17.Show()
        Me.Label18.Show()

        Me.NumericUpDown13.Show()
        Me.NumericUpDown14.Show()
        Me.NumericUpDown15.Show()
        Me.NumericUpDown16.Show()

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Settings2.png")

        Me.PictureBox1.Hide()
        Me.Label20.Hide()

        Me.Label15.Hide()
        Me.Label16.Hide()
        Me.Label17.Hide()
        Me.Label18.Hide()

        Me.NumericUpDown13.Hide()
        Me.NumericUpDown14.Hide()
        Me.NumericUpDown15.Hide()
        Me.NumericUpDown16.Hide()

        Me.Label1.Show()
        Me.Label2.Show()
        Me.Label3.Show()
        Me.Label4.Show()
        Me.Label5.Show()
        Me.Label6.Show()
        Me.Label7.Show()
        Me.Label8.Show()
        Me.Label9.Show()
        Me.Label10.Show()
        Me.Label11.Show()
        Me.Label12.Show()
        Me.NumericUpDown1.Show()
        Me.NumericUpDown2.Show()
        Me.InterNub.Show()
        Me.Cubier.Show()
        Me.PocoNub.Show()
        Me.Cubiertolluvesc.Show()
        Me.NubAlt.Show()
        Me.MuyNub.Show()
        Me.MuyNubLluv.Show()
        Me.IntNubLLuvEsc.Show()
        Me.NumericUpDown11.Show()
        Me.NumericUpDown12.Show()

        Me.Label15.Hide()
        Me.Label16.Hide()
        Me.Label17.Hide()
        Me.Label18.Hide()

        Me.NumericUpDown13.Hide()
        Me.NumericUpDown14.Hide()
        Me.NumericUpDown15.Hide()
        Me.NumericUpDown16.Hide()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Settings1.png")
        Me.Label15.Hide()
        Me.Label16.Hide()
        Me.Label17.Hide()
        Me.Label18.Hide()

        Me.NumericUpDown13.Hide()
        Me.NumericUpDown14.Hide()
        Me.NumericUpDown15.Hide()
        Me.NumericUpDown16.Hide()

        Me.Label1.Hide()
        Me.Label2.Hide()
        Me.Label3.Hide()
        Me.Label4.Hide()
        Me.Label5.Hide()
        Me.Label6.Hide()
        Me.Label7.Hide()
        Me.Label8.Hide()
        Me.Label9.Hide()
        Me.Label10.Hide()
        Me.Label11.Hide()
        Me.Label12.Hide()
        Me.NumericUpDown1.Hide()
        Me.NumericUpDown2.Hide()
        Me.InterNub.Hide()
        Me.Cubier.Hide()
        Me.PocoNub.Hide()
        Me.Cubiertolluvesc.Hide()
        Me.NubAlt.Hide()
        Me.MuyNub.Hide()
        Me.MuyNubLluv.Hide()
        Me.IntNubLLuvEsc.Hide()
        Me.NumericUpDown11.Hide()
        Me.NumericUpDown12.Hide()

        Me.PictureBox1.Show()
        Me.Label20.Show()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub
End Class