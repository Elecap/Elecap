Imports System.Threading

Public Class CurvaActual

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim curvaSantutxu = 5
    Dim curvaBegona = 6
    Dim curvaBolueta = 8

    Private Sub CurvaActual_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        End If

    End Sub

    Private Sub CurvaActual_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub CurvaActual_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Dim estadoCielo As String = "Nuboso"


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pbCielo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCielo.Click

    End Sub

    Private Sub dibujarCurva()


        Me.pbCurvaBegona.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + Me.curvaBegona.ToString + ".png")
        Me.pbCurvaSantutxu.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + Me.curvaSantutxu.ToString + ".png")
        Me.pbCurvaBolueta.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + Me.curvaBolueta.ToString + ".png")

    End Sub

    Private Sub establecerIconos()
        Dim faseLuna As String
        faseLuna = Prevision.getFaseLunar
        Me.lblLuna.Text = faseLuna


        Select Case faseLuna
            Case "Luna Nueva"
                Me.pbLuna.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\LunaNueva.png")
            Case "Cuarto Creciente"
                Me.pbLuna.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CuartoCreciente.png")
            Case "Luna Llena"
                Me.pbLuna.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\LunaLlena.png")
            Case "Cuarto Menguante"
                Me.pbLuna.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CuartoMenguante.png")
            Case Else

        End Select


    End Sub

    Private Sub dibujarCurvas()
        Dim nCurva = (CurvaGenerada.getCurvaElegida + 1).ToString
        Me.curvaBegona = nCurva
        Me.curvaSantutxu = nCurva
        Me.curvaBolueta = nCurva

        Me.pbCurvaBegona.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + nCurva + "-2.png")
        Me.pbCurvaBolueta.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + nCurva + "-2.png")
        Me.pbCurvaSantutxu.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + nCurva + "-2.png")
    End Sub

    Private Sub CurvaActual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbHora.Text = Me.numHoras.Value.ToString + ":00"
        establecerFondo()
        establecerIconos()
        dibujarCurva()
        'Me.PictureBox1.Visible = False


        dibujarCurvas()

        'Select Case Me.estadoCielo
        '    Case "Lluvioso"
        '        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Lluvioso.png")


        '    Case "Despejado"
        '        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Despejado.png")

        '    Case Else
        '        Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Nubes.png")


        'End Select
    End Sub

    Private Sub establecerIconoCielo(condicion As String)
        Me.lblCondicion.Text = condicion
        If condicion.Contains("espejado") Then
            Me.pbCielo.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Cielos\despejado.png")
        End If
        If condicion.Contains("Muy nuboso") Or condicion.Contains("Cubierto") Or condicion.Contains("Intervalos nubosos") Or condicion.Contains("Poco nuboso") Then
            Me.pbCielo.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Cielos\MuyNuboso.png")
        End If
        If condicion.Contains("Nuboso con lluvia escasa") Or condicion.Contains("lluvia") Then
            Me.pbCielo.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Cielos\NubosoLluviaEscasa.png")
        End If
        If condicion.Contains("Muy nuboso con lluvia escasa") Then
            Me.pbCielo.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Cielos\MuyNubosoLluviaEscasa.png")
        End If
    End Sub

    Private Sub establecerFondo()
        Dim estadoCielo = Prevision.getCondicionesCieloActuales()
        Dim horaSeleccionada = Me.numHoras.Value
        Dim horaCielo = estadoCielo(5).Substring(0, 2)
        Dim estadoCieloHoraSeleccionada As String
        For index As Integer = 0 To 24
            If horaSeleccionada = estadoCielo(index + 10).Substring(0, 2) Then
                estadoCieloHoraSeleccionada = estadoCielo(index + 10).ToString()
                Exit For

            End If
        Next

        Dim condicionHoraSeleccionada = estadoCieloHoraSeleccionada.Substring(6, estadoCieloHoraSeleccionada.Length - 6)

        If condicionHoraSeleccionada.Contains("nuboso") Or condicionHoraSeleccionada.Contains("ubierto") Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Nubes.png")
        End If
        If condicionHoraSeleccionada.Contains("espejado") Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Despejado.png")
        End If
        If condicionHoraSeleccionada.Contains("luvia") Or condicionHoraSeleccionada.Contains("lluvioso") Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Lluvioso.png")
        End If
        If condicionHoraSeleccionada.Contains("Poco nuboso") Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-PocoNuboso.png")
        End If
        If condicionHoraSeleccionada = "Cubierto" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Nubes.png")
        End If

        establecerIconoCielo(condicionHoraSeleccionada)


    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pantallaPrincipal As New Form4
        Me.Hide()
        pantallaPrincipal.Show()
    End Sub

    Private Sub pbCurvaBegona_Click(sender As Object, e As EventArgs) Handles pbCurvaBegona.Click

    End Sub

    Private Sub numHoras_ValueChanged(sender As Object, e As EventArgs) Handles numHoras.ValueChanged
        Me.lbHora.Text = Me.numHoras.Value.ToString + ":00"
        If Me.numHoras.Value > 6 Then
            If Me.numHoras.Value < 18 Then
                MsgBox("Solo se pueden ver las previsiones de 18:00 a 06:00")
                If Me.numHoras.Value = 7 Then
                    Me.numHoras.Value = 6
                End If
                If Me.numHoras.Value = 17 Then
                    Me.numHoras.Value = 18
                End If
            End If
        End If

        If Me.numHoras.Value >= 24 Then
            Dim extra = Me.numHoras.Value - 24

            Me.numHoras.Value = 0 + extra

        End If

        If Me.numHoras.Value < 0 Then
            Me.numHoras.Value = 23
        End If

        establecerFondo()
        'Me.PictureBox1.Visible = True
        'Thread.Sleep(2000)
        'Me.PictureBox1.Visible = False



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim modalAyuda As New HelpForm
        modalAyuda.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles lbHora.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim modalZoom As New FormZoom
        modalZoom.nCurva = getCurvaSantutxu()
        modalZoom.Show()
        'Me.Close()
    End Sub

    Public Function getCurvaSantutxu()
        Return Me.curvaSantutxu
    End Function

    Public Function getCurvaBegona()
        Return Me.curvaBegona
    End Function

    Public Function getCurvaBolueta()
        Return Me.curvaBolueta
    End Function

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim modalZoom As New FormZoom
        modalZoom.nCurva = getCurvaBegona()
        modalZoom.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim modalZoom As New FormZoom
        modalZoom.nCurva = getCurvaBolueta()
        modalZoom.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim configuracion As New FormSettings
        configuracion.Show()
    End Sub
End Class