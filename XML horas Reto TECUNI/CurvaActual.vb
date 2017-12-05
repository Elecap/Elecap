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

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

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
        'faseLuna = Prevision.getFaseLunar

        Select Case faseLuna
            Case "Luna Nueva"

            Case "Cuarto Creciente"

            Case "Luna Llena"

            Case "Cuarto Menguante"

            Case Else

        End Select


    End Sub

    Private Sub CurvaActual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dibujarCurva()

        Select Case Me.estadoCielo
            Case "Lluvioso"
                Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Lluvioso.png")


            Case "Despejado"
                Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Despejado.png")

            Case Else
                Me.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaDeEstaNocheFondo-Nubes.png")


        End Select
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pantallaPrincipal As New Form4
        Me.Hide()
        pantallaPrincipal.Show()
    End Sub
End Class