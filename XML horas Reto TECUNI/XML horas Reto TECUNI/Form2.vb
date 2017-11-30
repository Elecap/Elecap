

Public Class Form2

   

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        End If
            
    End Sub

    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub



    Private Sub guardarPerfil()
        Try
            Const fichero As String = "C:\Temp\Perfiles.txt"

            Dim contenidoPerfil As String = ""

            'Cogemoso el nombre del perfil
            contenidoPerfil += (Me.tbNombrePerfil.Text)
            contenidoPerfil += ("€") 'Separamos campos
            'Cogemos los diferentes estados del cielo
            If Me.cbCubierto.Checked Then
                contenidoPerfil += (Me.cbCubierto.Text)
                contenidoPerfil += ("$")
            End If
            If Me.cbDespejado.Checked Then
                contenidoPerfil += (Me.cbDespejado.Text)
                contenidoPerfil += ("$")
            End If
            If Me.cbCubiertoLluviaEscasa.Checked Then
                contenidoPerfil += (Me.cbCubiertoLluviaEscasa.Text)
                contenidoPerfil += ("$")
            End If
            If Me.cbIntervalosNubosos.Checked Then
                contenidoPerfil += (Me.cbIntervalosNubosos.Text)
                contenidoPerfil += ("$")
            End If
            If Me.cbPocoNuboso.Checked Then
                contenidoPerfil += (Me.cbPocoNuboso.Text)
                contenidoPerfil += ("$")
            End If
            If Me.cbIntervalosNubososLluviaEscasa.Checked Then
                contenidoPerfil += (Me.cbIntervalosNubososLluviaEscasa.Text)
                contenidoPerfil += ("$")
            End If
            If Me.cbIntervalosNubososLluviaEscasa.Checked Then
                contenidoPerfil += (Me.cbIntervalosNubososLluviaEscasa.Text)
                contenidoPerfil += ("$")
            End If
            If Me.cbMuyNubosoLluviaEscasa.Checked Then
                contenidoPerfil += (Me.cbMuyNubosoLluviaEscasa.Text)
                contenidoPerfil += ("$")
            End If
            If Me.cbNuboso.Checked Then
                contenidoPerfil += (Me.cbNuboso.Text)

            End If
            contenidoPerfil += ("€") 'Separamos campos
            'Cogemos la fase de la luna
            If Me.rbLunaLlena.Checked Then
                contenidoPerfil += (Me.rbLunaLlena.Text)
                contenidoPerfil += ("$")
            End If
            If Me.rbCuartoCreciente.Checked Then
                contenidoPerfil += (Me.rbCuartoCreciente.Text)
                contenidoPerfil += ("$")
            End If
            If Me.rbLunaLlena.Checked Then
                contenidoPerfil += (Me.rbLunaLlena.Text)
                contenidoPerfil += ("$")
            End If
            If Me.rbLunaNueva.Checked Then
                contenidoPerfil += (Me.rbLunaNueva.Text)
                contenidoPerfil += ("$")
            End If
            contenidoPerfil += ("€") 'Separamos campos


            'Cogemos la curva asignada
            contenidoPerfil += (Me.comboCurvas.Text)
            contenidoPerfil += ("€") 'Separamos campos
            contenidoPerfil += (Me.cbTipoDia.SelectedItem.ToString)
            contenidoPerfil += ("€")
            contenidoPerfil += ("#") 'Separamos registro
            Dim arrayContenidosPerfil = contenidoPerfil.Split("€")
            Dim nombrePerfil = arrayContenidosPerfil(1)

            Dim contenidoFichero As New System.IO.StreamReader(fichero)
            Dim arrayPerfilesExistentes = contenidoFichero.ReadToEnd.Split("€")
            Dim sonIguales As Boolean = False
            For Each elemento As String In arrayPerfilesExistentes
                If (elemento = nombrePerfil) Then
                    sonIguales = True
                End If
            Next
            contenidoFichero.Close()
            Dim sw As New System.IO.StreamWriter(fichero, True)

            If (sonIguales = False) Then
                sw.Write(contenidoPerfil)
                sw.Close()
                MsgBox("Perfil guardado")

            Else
                MsgBox("El nombre del perfil ya existe")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.guardarPerfil()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ventanaPrincipal = New Form1

        Me.Hide()
        ventanaPrincipal.Show()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNombrePerfil.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboCurvas.SelectedIndexChanged
        Dim Curvas = New String() {"Curva 1", "Curva 2", "Curva 3"}
        For Each curva As String In Curvas
            Me.comboCurvas.Items.Add(curva.ToString)
        Next



    End Sub

    Private Function UnicodeStringToBytes(
    ByVal str As String) As Byte()

        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub cbTipoDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoDia.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.guardarPerfil()
        Me.tbNombrePerfil.Clear()



    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim ventanaPrincipal = New Form1

        Me.Hide()
        ventanaPrincipal.Show()
    End Sub
End Class