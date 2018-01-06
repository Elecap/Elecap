Imports System.Drawing.Drawing2D
Imports System.Drawing

Public Class Form4

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ventanaGestion As New GestorPerfiles


        Me.Hide()
        ventanaGestion.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ventanaPrevision As New CurvaActual

        Me.Hide()
        ventanaPrevision.Show()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim cargaDatos As New lvCondicionesCelestesActuales



    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim rutasImagenes() As String = New String() {"c:\temp\imagen1.jpg", "c:\temp\imagen2.jpg"}
        'Dim posicion = 0
        'While (True)
        '    Me.BackgroundImage = System.Drawing.Image.FromFile(rutasImagenes(posicion))
        '    'Threading.Thread.Sleep(1000)
        '    If (posicion = rutasImagenes.Length - 1) Then
        '        posicion = 0
        '    Else
        '        posicion = posicion + 1
        '    End If

        'End While

        Dim linGrBrush As New LinearGradientBrush( _
   New Point(0, 10), _
   New Point(200, 10), _
   Color.FromArgb(255, 255, 0, 0), _
   Color.FromArgb(255, 0, 0, 255))
        Dim pen As New Pen(linGrBrush)



    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim ventanaPrevision As New CurvaActual

        Me.Hide()
        ventanaPrevision.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim test As New testConexion

        Me.Hide()
        test.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim configuracion As New FormSettings
        configuracion.Show()
    End Sub
End Class