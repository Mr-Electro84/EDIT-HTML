Imports System.IO
Public Class ApercuFEN
    Private Sub Apercu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists("C:\EDIT'HTML\Preview") Then
            System.IO.Directory.CreateDirectory("C:\EDIT'HTML\Preview")
        End If
        If Form1.RichTextBox1.Text.Contains("<?php") Then
            Process1.StartInfo.FileName = "C:\EDIT'HTML\Preview\Preview.php"
        End If
        Using RedacteurAP As StreamWriter =
            New StreamWriter(Process1.StartInfo.FileName)
            RedacteurAP.Write(Form1.RichTextBox1.Text)
        End Using
        'Form1.RichTextBox1.SaveFile(Process1.StartInfo.FileName, RichTextBoxStreamType.PlainText)
        AfficheurWeb.Navigate(Process1.StartInfo.FileName)
    End Sub

    Private Sub Refr_Click(sender As Object, e As EventArgs) Handles Refr.Click
        AfficheurWeb.Refresh()
    End Sub

    Private Sub ADefaut_Click(sender As Object, e As EventArgs) Handles ADefaut.Click
        'Largeur 865 Hauteur 488
        ApercuFEN.ActiveForm.Width = 865
        ApercuFEN.ActiveForm.Height = 488
    End Sub

    Private Sub AMobile_Click(sender As Object, e As EventArgs) Handles AMobile.Click
        ApercuFEN.ActiveForm.Width = 425
        ApercuFEN.ActiveForm.Height = 656
    End Sub

    Private Sub AGrandEcran_Click(sender As Object, e As EventArgs) Handles AGrandEcran.Click
        ApercuFEN.ActiveForm.Width = 1440
        ApercuFEN.ActiveForm.Height = 656
    End Sub

    Private Sub OwnNavigWeb_Click(sender As Object, e As EventArgs) Handles OwnNavigWeb.Click
        Process1.Start()
    End Sub
End Class