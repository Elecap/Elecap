Public Class CurvaGenerada

    Public Shared curvaIdeal(3) As String
    Public Shared curvaElegida



    Public Shared Function getCurvaIdeal() As String()
        generarCurvaIdeal()
        Return curvaIdeal

    End Function

    Public Shared Sub generarCurvaIdeal()


        Dim condicionesActuales = Prevision.getCondicionesCieloActuales
        Dim condicionesCadaTresHoras(3)

        Dim p As Integer = 0
        For var = 17 To 26 Step +3
            condicionesCadaTresHoras(p) = condicionesActuales(var)
            If var = 29 Then
                Exit For
            End If
            p = p + 1
        Next

        Dim arrayFases = condicionesCadaTresHoras

        'Dim posicion As Integer = 4
        'For var = 0 To 3 Step +1
        '    arrayFases(var) = condicionesCadaTresHoras(posicion)
        '    posicion = posicion + 1
        'Next

        ' Cogemos los valores del array 4,5,6 y 7


        Dim ficheroCielo As String = "D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Documentos\ValoresCielo.txt"
        Dim contenidoFichero As New System.IO.StreamReader(ficheroCielo)
        Dim arrayCondicionesExistentes = contenidoFichero.ReadToEnd.Split("$")

        Dim posicion As Integer = 0
        For Each fase As String In arrayFases

            For Each condicion As String In arrayCondicionesExistentes
                Dim datos = condicion.ToString.Split("#")
                Dim nombreCondicion = datos(0)
                Dim valorCondicion = datos(1)

                If arrayFases(posicion).ToString.Contains(nombreCondicion) Then
                    Dim valorReal = Integer.Parse(valorCondicion)

                    Dim lunaActual = Prevision.getFaseLunar()
                    If nombreCondicion = "Despejado" Or nombreCondicion = "Poco nuboso" Then
                        Select Case lunaActual
                            Case "Luna Llena"
                                valorReal = valorReal - 20
                            Case "Luna Nueva"
                                valorReal = valorReal - 0
                            Case Else
                                valorReal = valorReal - 10
                        End Select
                    End If

                    curvaIdeal(posicion) = valorReal

                    'posicion = posicion + 1
                    If posicion = 4 Then
                        Exit For

                    End If
                End If
            Next
            posicion = posicion + 1
        Next
    End Sub
    Public Shared Function getCurvaElegida() As Integer
        elegirCurva("")
        Return curvaElegida

    End Function

    Public Shared Function getCurvaElegida(ByVal zona As String) As Integer
        elegirCurva(zona)
        Return curvaElegida

    End Function

    Public Shared Sub elegirCurva(ByVal zona As String)
        getCurvaIdeal()
        If zona = "Santutxu" Then
            curvaIdeal(0) += 10
            curvaIdeal(1) += 10
            curvaIdeal(2) += 10
            curvaIdeal(3) += 10
        End If
        If zona = "Bolueta" Then
            curvaIdeal(0) += 20
            curvaIdeal(1) += 20
            curvaIdeal(2) += 20
            curvaIdeal(3) += 20
        End If
        If zona = "Begoña" Then
            curvaIdeal(0) += -5
            curvaIdeal(1) += -5
            curvaIdeal(2) += -5
            curvaIdeal(3) += -5
        End If

        Dim fichero As String = "D:\DAM3-2\RETO\TECUNI\XML horas Reto TECUNI\XML horas Reto TECUNI\Assets\Documentos\Curvas.txt"
        Dim contenidoFichero As New System.IO.StreamReader(fichero)
        Dim arrayCurvasExistentes = contenidoFichero.ReadToEnd.Split("$")
        Dim datosCurvas(9, 3) As String

        For x As Integer = 0 To 9
            For y As Integer = 0 To 3
                Dim datosCurvaActual = arrayCurvasExistentes(x).Split("#")
                datosCurvas(x, y) = datosCurvaActual(y + 1)
            Next
        Next

        Dim compatibilidad(9, 3) As Integer

        For x As Integer = 0 To 9
            For y As Integer = 0 To 3
                If curvaIdeal(y) = datosCurvas(x, y) Then
                    compatibilidad(x, y) = 100
                ElseIf Integer.Parse(curvaIdeal(y)) > Integer.Parse(datosCurvas(x, y)) Then
                    compatibilidad(x, y) = 100 - (Integer.Parse(curvaIdeal(y)) - Integer.Parse(datosCurvas(x, y)))
                ElseIf Integer.Parse(curvaIdeal(y)) < Integer.Parse(datosCurvas(x, y)) Then 'Añadir +10 si queremos prioridad
                    compatibilidad(x, y) = 100 - (Integer.Parse(datosCurvas(x, y)) - Integer.Parse(curvaIdeal(y))) + 10
                End If

            Next
        Next

        Dim compatibilidadCurvas(9) As Integer

        For x As Integer = 0 To 9
            Dim suma As Integer
            For y As Integer = 0 To 3
                suma = suma + compatibilidad(x, y)
            Next
            compatibilidadCurvas(x) = suma / 4
            suma = 0
        Next

        Dim max = 0
        Dim curvaGuay(3) As String
        Dim nCurvaElegida As Integer

        For x As Integer = 0 To 9
            If compatibilidadCurvas(x) > max Then
                max = compatibilidadCurvas(x)
                For y As Integer = 0 To 3
                    curvaGuay(y) = datosCurvas(x, y).ToString
                    nCurvaElegida = x
                Next
            End If
        Next

        curvaElegida = nCurvaElegida








        'Dim faseAComparar = 0
        'For Each curva As String In arrayCurvasExistentes
        '    Dim fasesCurvaReal = curva.ToString.Split("#")
        '    Dim precision()
        '    Dim posicion = 0

        '    For Each fase In curvaIdeal
        '        If fase = c Then
        '    Next
        'Next




    End Sub

End Class
