Imports System.Windows.Forms

Public Class NavegaciónLateral

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim ventanaPrevision As New CurvaActual

        ventanaPrevision.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Dim contador As Integer = 0
        'Dim formulario As Integer = 0
        'Dim ventanasAbiertas = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0}
        'Try
        '    For Each f As Form In My.Application.OpenForms

        '        If f.Name IsNot "Form4" Then
        '            ventanasAbiertas(contador) = formulario
        '            contador = contador + 1
        '        End If
        '        formulario = formulario + 1
        '    Next
        'Catch ex As Exception
        '    Dim ventanaPrincipal As New Form4
        '    ventanaPrincipal.Show()
        'End Try
        'For Each ventana In ventanasAbiertas
        '    If ventana = 0 Then

        '    Else
        '        My.Application.OpenForms(ventana).Close()
        '    End If

        'Next
        ''''''''''''''''''''''''''''''''''''''''''
        'Dim formulario As Form
        'For Each f In My.Application.OpenForms
        '    If f.Name <> Me.Name Then
        '        formulario = f
        '    End If
        'Next
        'If formulario = vbNull Then
        'Else
        '    formulario.Close()
        'End If



    End Sub
End Class