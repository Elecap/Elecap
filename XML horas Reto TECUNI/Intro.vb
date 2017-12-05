Public Class Intro

    Private Sub Intro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Dim ventana As Form4 = New Form4
        'Threading.Thread.Sleep("5000")
        'MsgBox("Hola")
        'ventana.Show()
        'Me.Hide()

    End Sub



    Private Sub Intro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Intro_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim ventana As Form4 = New Form4
        Threading.Thread.Sleep("5000")
        ventana.Show()
        Me.Hide()
    End Sub
End Class