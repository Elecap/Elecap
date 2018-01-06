Public Class ErrorForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.ActiveControl = Me.Parent



    End Sub
End Class