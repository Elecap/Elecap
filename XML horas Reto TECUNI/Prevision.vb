Imports System.IO
Imports System.Net
Imports System.Xml

Public Class Prevision
    Shared faseLunar As String
    Shared arrayCondicionesCielo(47) As String

    Public Shared Function getFaseLunar() As String
        calcularFaseLunar()
        Return faseLunar

    End Function

    Public Shared Function getCondicionesCieloActuales() As String()
        calcularPerfilActual()
        Return arrayCondicionesCielo

    End Function


    Public Shared Sub calcularPerfilActual()
        Try
            Dim webRequest As WebRequest = WebRequest.Create("http://www.aemet.es/xml/municipios_h/localidad_h_48020.xml")


            Dim webResponse As WebResponse = webRequest.GetResponse
            Dim webStream As Stream = webResponse.GetResponseStream

            Dim xmlDoc As New XmlDocument
            xmlDoc.Load(webStream)

            'Cargamos XML de fases lunares en la variable
            Dim rutaFases As String = "D:\DAM3-2\RETO\TECUNI\XML\FasesLunares.xml"
            Dim fasesLunaresXML = XDocument.Load(rutaFases)
            Dim documento As XmlDocument = New XmlDocument
            documento.Load(rutaFases)

            Dim hoy As String = System.DateTime.Today.Month.ToString + "/" + System.DateTime.Today.Day.ToString + "/" + System.DateTime.Today.Year.ToString



            Dim NodosHoras As XmlNodeList = xmlDoc.SelectNodes("//dia/estado_cielo/@periodo")
            Dim NodosNubes As XmlNodeList = xmlDoc.SelectNodes("//dia/estado_cielo/@descripcion")
            Dim nodeh As XmlNode
            Dim noden As XmlNode

            Dim datos(47) As String
            Dim posicion As Integer
            For Each nodeh In NodosHoras

                datos(posicion) += nodeh.InnerText + ":00"
                posicion += 1
            Next
            posicion = 0
            For Each noden In NodosNubes
                datos(posicion) += " " + noden.InnerText
                posicion += 1
            Next
            Console.Write(datos)
            arrayCondicionesCielo = datos


            'Dim var As Integer
            'Dim p As Integer = 0

            'For var = 11 To 24 Step +1
            '    arrayCondicionesCielo(p) = datos(var)
            '    p = p + 1
            'Next
            ''condicionesCelestesActuales = datos


        Catch ex As Exception



        End Try
    End Sub


    Public Shared Sub calcularFaseLunar()
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

        faseLunar = fase


    End Sub



End Class
