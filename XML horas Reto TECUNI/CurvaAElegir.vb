﻿Public Class CurvaAElegir
    Public Shared curvaElegida As Integer = 1

    Public Shared Function getCurvaElegida()
        Return curvaElegida
    End Function
    Private Function pbCurvaSantutxu_Click(sender As Object, e As EventArgs) As Integer Handles pbCurva1.Click
        Me.curvaElegida = 1
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida

    End Function



    Public Event evento(ByVal i As Integer)




    Private Function pbCurva2_Click(sender As Object, e As EventArgs) Handles pbCurva2.Click
        Me.curvaElegida = 2
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida
    End Function

    Private Function pbCurva3_Click(sender As Object, e As EventArgs) Handles pbCurva3.Click
        Me.curvaElegida = 3
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida
    End Function
    Private Function pbCurva4_Click(sender As Object, e As EventArgs) Handles pbCurva4.Click
        Me.curvaElegida = 4
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida
    End Function

    Private Function pbCurva5_Click(sender As Object, e As EventArgs) Handles pbCurva5.Click
        Me.curvaElegida = 5
        Me.Hide()
        RaiseEvent evento(curvaElegida)

        Return curvaElegida
    End Function
    Private Function pbCurva6_Click(sender As Object, e As EventArgs) Handles pbCurva6.Click
        Me.curvaElegida = 6
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida
    End Function

    Private Function pbCurva7_Click(sender As Object, e As EventArgs) Handles pbCurva7.Click
        Me.curvaElegida = 7
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida
    End Function
    Private Function pbCurva8_Click(sender As Object, e As EventArgs) Handles pbCurva8.Click
        Me.curvaElegida = 8
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida
    End Function

    Private Function pbCurva9_Click(sender As Object, e As EventArgs) Handles pbCurva9.Click
        Me.curvaElegida = 9
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida
    End Function
    Private Function pbCurva10_Click(sender As Object, e As EventArgs) Handles pbCurva10.Click
        Me.curvaElegida = 10
        Me.Hide()
        RaiseEvent evento(curvaElegida)
        Return curvaElegida
    End Function

    Private Sub CurvaAElegir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class