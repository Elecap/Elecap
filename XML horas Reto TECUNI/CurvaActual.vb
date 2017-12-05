Public Class CurvaActual

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub pbCielo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCielo.Click

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

    End Sub
End Class