Imports System.IO
Imports System.Net
Imports System.Xml

Module Module1

    Sub Main()
        Dim wc As New WebClient
        Dim xmlText As String = wc.DownloadString("http://www.aemet.es/xml/municipios_h/localidad_h_48020.xml")
        File.WriteAllText("new file path.xml", xmlText)

        Dim webRequest As WebRequest = webRequest.Create("http://www.aemet.es/xml/municipios_h/localidad_h_48020.xml")
        Dim webResponse As WebResponse = webRequest.GetResponse
        Dim webStream As Stream = webResponse.GetResponseStream

        Dim xmlDoc As New XmlDocument
        xmlDoc.Load(webStream)

        Dim rutaFases As String = "D:\DAM3-2\RETO\TECUNI\XML\FasesLunares.xml"
        Dim fasesLunaresXML = XDocument.Load(rutaFases)
        Dim documento As XmlDocument = New XmlDocument
        documento.Load(rutaFases)

        Dim hoy As String = System.DateTime.Today.Month.ToString + "/" + System.DateTime.Today.Day.ToString + "/" + System.DateTime.Today.Year.ToString

        Dim XPathFaseHoy As String = "//phase[../date='" + hoy + "']/text()"
        Dim nodosFases = documento.SelectNodes(XPathFaseHoy)




        For Each nodeF As XmlNode In nodosFases
            Console.WriteLine("Fase lunar actual: " + nodeF.InnerText)
            Console.ReadKey()
        Next

        Dim NodosHoras As XmlNodeList = xmlDoc.SelectNodes("//dia/estado_cielo/@periodo")
        Dim NodosNubes As XmlNodeList = xmlDoc.SelectNodes("//dia/estado_cielo/@descripcion")
        Dim nodeh As XmlNode
        Dim noden As XmlNode

        Dim datos(200) As String
        Dim posicion As Integer
        For Each nodeh In NodosHoras

            datos(posicion) += nodeh.InnerText
            posicion += 1
        Next
        posicion = 0
        For Each noden In NodosNubes
            datos(posicion) += " " + noden.InnerText
            posicion += 1
        Next

        For Each dato In datos
            Console.WriteLine(dato)
        Next



        Console.ReadKey()


    End Sub

End Module
