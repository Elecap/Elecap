﻿Public Class Intro

    Public c As New ConexionX


    Private Sub Intro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Dim ventana As Form4 = New Form4
        'Threading.Thread.Sleep("5000")
        'MsgBox("Hola")
        'ventana.Show()
        'Me.Hide()

    End Sub



    Private Sub Intro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c.conectar()
        Timer1.Enabled = True

    End Sub



    Private Sub Intro_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Me.Show()
        'Dim ventana As Form4 = New Form4
        'Threading.Thread.Sleep("5000")
        'MsgBox("Hola")
        'ventana.Show()
        'Me.Hide()
    End Sub

    Private Sub Timer1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Disposed

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ventana As Form4 = New Form4
        ventana.Show()
        Me.Hide()
        Timer1.Enabled = False

    End Sub
End Class