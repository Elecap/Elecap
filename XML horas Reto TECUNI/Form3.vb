Imports System.IO
Imports System.Net
Imports System.Xml
Imports Prevision


Public Class lvCondicionesCelestesActuales


    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        End If

    End Sub

    Private Sub Form3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub


    Dim faseLunarActual As String
    Public condicionesCelestesActuales(13) As String
    Public estado As Integer

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbTitulo.Click

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbTitulo.Text = Format(Date.Now(), "dd/MMM/yyyy")



        Try
            mostrarPerfilActual()
        Catch ex As Exception
            Me.Hide()
        End Try

        establecerPerfilAsignado()

    End Sub

    Sub establecerPerfilAsignado()

    End Sub

    Sub mostrarPerfilActual()
        Try
            calcularPerfilActual()

            'tbFaseLunarActual.Text = calcularFaseLunar()
            tbFaseLunarActual.Text = Prevision.getFaseLunar()




            For Each condicion In condicionesCelestesActuales
                Me.lbCondicionesCelestes.Items.Add(condicion)

            Next
        Catch ex As Exception
            MsgBox("Error al consultar los datos. Asegurese de tener conexión a Internet")

            Dim ventanaPrincipal As New Form1
            Me.Hide()
            estado = -1
            ventanaPrincipal.Show()
        End Try



    End Sub

    Sub calcularPerfilActual()
        Try
            'Dim webRequest As WebRequest = webRequest.Create("http://www.aemet.es/xml/municipios_h/localidad_h_48020.xml")


            'Dim webResponse As WebResponse = webRequest.GetResponse
            'Dim webStream As Stream = webResponse.GetResponseStream

            'Dim xmlDoc As New XmlDocument
            'xmlDoc.Load(webStream)

            ''Cargamos XML de fases lunares en la variable
            'Dim rutaFases As String = "D:\DAM3-2\RETO\TECUNI\XML\FasesLunares.xml"
            'Dim fasesLunaresXML = XDocument.Load(rutaFases)
            'Dim documento As XmlDocument = New XmlDocument
            'documento.Load(rutaFases)

            'Dim hoy As String = System.DateTime.Today.Month.ToString + "/" + System.DateTime.Today.Day.ToString + "/" + System.DateTime.Today.Year.ToString

            'Dim XPathFaseHoy As String = "//phase[../date='" + hoy + "']/text()"
            'Dim nodosFases = documento.SelectNodes(XPathFaseHoy)

            'For Each nodeF As XmlNode In nodosFases
            '    faseLunarActual = nodeF.InnerText
            'Next

            'Dim NodosHoras As XmlNodeList = xmlDoc.SelectNodes("//dia/estado_cielo/@periodo")
            'Dim NodosNubes As XmlNodeList = xmlDoc.SelectNodes("//dia/estado_cielo/@descripcion")
            'Dim nodeh As XmlNode
            'Dim noden As XmlNode

            'Dim datos() As String = Prevision.getCondicionesCieloActuales()

            'Dim posicion As Integer
            'For Each nodeh In NodosHoras

            '    datos(posicion) += nodeh.InnerText + ":00"
            '    posicion += 1
            'Next
            'posicion = 0
            'For Each noden In NodosNubes
            '    datos(posicion) += " " + noden.InnerText
            '    posicion += 1
            'Next
            'Console.Write(datos)

            Dim datos() = Prevision.getCondicionesCieloActuales()

            Dim var As Integer
            Dim p As Integer = 0

            For var = 11 To 24 Step +1
                condicionesCelestesActuales(p) = datos(var)
                p = p + 1
            Next
            'condicionesCelestesActuales = datos


        Catch ex As Exception

            Me.Hide()


        End Try


    End Sub

    Function calcularFaseLunar() As String
        Const PhaseBase As Date = #1/17/1980 9:18:00 PM# 'GMT/UTC. Fecha del comienzo del cálculo.
        Dim Fecha As Date = Date.UtcNow 'Fecha actual del sistema.
        Const LunarSynod As Long = 42524 'Tiempo en segundos de la rotación de la luna sobre la tierra.

        Dim LunarPhase As Long


        'Returns lunar phase for TargetDate starting from PhaseBase
        'timestamp forward, at 1/24 cycle intervals, i.e. values
        'from 0 to 23:
        '
        '    0 = New Moon
        '    6 = First Quarter
        '   12 = Full Moon
        '   18 = Last Quarter
        LunarPhase = (Fix(DateDiff("n", PhaseBase, Fecha)) Mod LunarSynod) \ (LunarSynod \ 24)

        'Console.WriteLine(LunarPhase) 'Ver el módulo del resultado por consola
        Dim fase = ""
        Select Case LunarPhase
            Case 0 To 5
                fase = "Luna Nueva"
            Case 6 To 11
                fase = "Cuarto Creciente"
            Case 12 To 17
                fase = "Luna Llena"
            Case 18 To 23
                fase = "Cuarto Menguante"
        End Select

        Return fase

    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ventanaPrincipal As New Form4
        Me.Hide()
        ventanaPrincipal.Show()
    End Sub

    Private Sub lbNombrePerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ventanaPrincipal As New Form4
        Me.Hide()
        ventanaPrincipal.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim curvaActual As New CurvaActual
        Me.Hide()
        curvaActual.Show()
    End Sub
End Class