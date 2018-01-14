Imports System.Threading

Public Class HelpForm
    Dim curvaIdeal As String() = CurvaGenerada.getCurvaIdeal
    Private Sub HelpForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Public Sub generarCurvaDelay()
        Dim curvaIdeal As String() = CurvaGenerada.getCurvaIdeal

        Me.PictureBox1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaGenerada\" + curvaIdeal(0).ToString + ".png")
        Me.PictureBox2.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaGenerada\" + curvaIdeal(1).ToString + ".png")
        Me.PictureBox3.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaGenerada\" + curvaIdeal(2).ToString + ".png")
        Me.PictureBox4.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaGenerada\" + curvaIdeal(3).ToString + ".png")
        CurvaGenerada.getCurvaIdeal()

        Dim nCurva = (CurvaGenerada.getCurvaElegida + 1).ToString

        Me.pbCurvaElegida.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + nCurva + ".png")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pantallaPrincipal As New Form4
        Me.Hide()
        pantallaPrincipal.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If True Then
            pintarCurvaGenerada1()
        End If
        Timer1.Enabled = False
        Timer2.Enabled = True
       
        
        

    End Sub

    Private Sub pintarCurvaGenerada1()
        Me.PictureBox1.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaGenerada\" + curvaIdeal(0).ToString + ".png")
    End Sub
    Private Sub pintarCurvaGenerada2()
        Me.PictureBox2.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaGenerada\" + curvaIdeal(1).ToString + ".png")
    End Sub
    Private Sub pintarCurvaGenerada3()
        Me.PictureBox3.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaGenerada\" + curvaIdeal(2).ToString + ".png")
    End Sub
    Private Sub pintarCurvaGenerada4()
        Me.PictureBox4.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\CurvaGenerada\" + curvaIdeal(3).ToString + ".png")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If True Then
            pintarCurvaGenerada2()
        End If
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If True Then
            pintarCurvaGenerada3()
        End If
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If True Then
            pintarCurvaGenerada4()
        End If
        Me.pbCurvaElegida.BackgroundImage = System.Drawing.Image.FromFile("D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Curva" + (CurvaGenerada.getCurvaElegida + 1).ToString + "-2.png")
        Timer4.Enabled = False
    End Sub

    Private Sub pbCurvaElegida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCurvaElegida.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class