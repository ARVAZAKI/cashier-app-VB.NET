Imports System.Reflection.Metadata

Public Class Form1
    Dim hitung As Integer
    Dim cashback As Integer

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Const hargaftea As Integer = 3000
        Const hargafloridina As Integer = 3000
        Const hargamilktea As Integer = 4000
        Const hargaesteh As Integer = 3000
        Const hargaesjeruk As Integer = 5000
        Const hargaindomie As Integer = 5000
        Const hargabakso As Integer = 5000
        Const hargamieayam As Integer = 4000
        Const hargachickenwings As Integer = 10000




        If boxfruittea.Checked = True Then
            hitung = txtfruittea.Text * hargaftea
        End If
        If boxfloridina.Checked = True Then
            hitung = txtfloridina.Text * hargafloridina
        End If
        If boxmilktea.Checked = True Then
            hitung = txtmilktea.Text * hargamilktea
        End If
        If boxesteh.Checked = True Then
            hitung = txtesteh.Text * hargaesteh
        End If
        If boxesjeruk.Checked = True Then
            hitung = txtesjeruk.Text * hargaesjeruk
        End If
        If boxindomie.Checked = True Then
            hitung = txtindomie.Text * hargaindomie
        End If
        If boxbakso.Checked = True Then
            hitung = txtbakso.Text * hargabakso
        End If
        If boxmieayam.Checked = True Then
            hitung = txtmieayam.Text * hargamieayam
        End If
        If boxchickenwings.Checked = True Then
            hitung = txtchickenwings.Text * hargachickenwings

        End If


        txttotal.Text = hitung.ToString("c")

    End Sub


    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnbayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        If txtjumlahuang.Text = "" Then
            MsgBox("Mohon isi jumlah uang pembeli")
        Else
            cashback = Double.Parse(txtjumlahuang.Text) - Double.Parse(hitung)
            txtkembalian.Text = cashback.ToString("c")
        End If

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtfruittea.Text = ""
        txtfloridina.Text = ""
        txtmilktea.Text = ""
        txtesteh.Text = ""
        txtesjeruk.Text = ""
        txtbakso.Text = ""
        txtindomie.Text = ""
        txtmieayam.Text = ""
        txtchickenwings.Text = ""
        txttotal.Text = ""
        txtjumlahuang.Text = ""
        txtkembalian.Text = ""
        boxfruittea.Checked = False
        boxfloridina.Checked = False
        boxmilktea.Checked = False
        boxesteh.Checked = False
        boxesjeruk.Checked = False
        boxindomie.Checked = False
        boxmieayam.Checked = False
        boxbakso.Checked = False
        boxchickenwings.Checked = False

    End Sub
End Class
