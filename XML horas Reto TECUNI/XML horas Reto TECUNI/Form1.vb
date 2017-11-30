Public Class Form1

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        End If

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ventana = New Form2
        Me.Hide()
        ventana.Show()
    End Sub

    Private Sub cbPerfiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPerfiles.SelectedIndexChanged
        Me.cargarPerfil()
        'Const fichero As String = "C:\Temp\Perfiles.txt"
        'Dim contenidoFichero As New System.IO.StreamReader(fichero)
        'Dim arrayPerfiles = contenidoFichero.ReadLine.Split("#")
        'For Each campo In arrayPerfiles
        'Dim 
        'Next
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim otraVentana = New lvCondicionesCelestesActuales
        otraVentana.Show()
        If (otraVentana.estado = -1) Then
            otraVentana.Hide()

        End If
        Me.Hide()



    End Sub

    Private Sub cargarPerfil()
        Me.lvCielo.Items.Clear()
        Me.lvOtrasCondiciones.Items.Clear()
        Try
            Const fichero As String = "C:\Temp\Perfiles.txt"
            Dim contenidoFichero As New System.IO.StreamReader(fichero)
            Dim arrayRegistrosExistentes = contenidoFichero.ReadToEnd.Split("#")
            For Each registro As String In arrayRegistrosExistentes
                Dim arrayCamposExistentes = registro.Split("€")
                If arrayCamposExistentes(0) = Me.cbPerfiles.SelectedItem.ToString() Then
                    Dim arrayCondicionesExistentes = arrayCamposExistentes(1).Split("$")
                    For Each condicion As String In arrayCondicionesExistentes
                        Me.lvCielo.Items.Add(condicion.ToString) 'Cargamos condiciones del cielo
                    Next

                    Me.tbCurva.Text = (arrayCamposExistentes(3).ToString) 'Cargamos curva
                    Dim arrayFasesExistentes = arrayCamposExistentes(2).Split("$")
                    For Each fase In arrayFasesExistentes
                        If fase.ToString = "Luna Llena" Then
                            Me.cbLL.Checked = True
                        End If
                        If fase.ToString = "Luna Nueva" Then
                            Me.cbLN.Checked = True
                        End If
                        If fase.ToString = "Cuarto Creciente" Then
                            Me.cbCC.Checked = True
                        End If
                        If fase.ToString = "Cuarto Menguante" Then
                            Me.cbCM.Checked = True
                        End If
                    Next

                    Me.lvOtrasCondiciones.Items.Add(arrayCamposExistentes(4).ToString)


                End If
            Next


            contenidoFichero.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarPerfiles()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ventanaMenu As New Form4
        Me.Hide()
        ventanaMenu.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim v As Form2 = New Form2
        v.Show()
        Me.Hide()
    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub lvOtrasCondiciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ventanaPrincipal = New Form4

        Me.Hide()
        ventanaPrincipal.Show()
    End Sub

    Private Sub PanelArriba_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class