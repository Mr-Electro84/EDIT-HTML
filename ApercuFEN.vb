Imports CefSharp.WinForms
Imports CefSharp
Public Class ApercuFEN

    Private WithEvents browser As ChromiumWebBrowser
    Private Sub Apercu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists("C:\EDIT'HTML\Preview") Then
            System.IO.Directory.CreateDirectory("C:\EDIT'HTML\Preview")
        End If
        If Form1.RichTextBox1.Text.Contains("<?php") Then
            Process1.StartInfo.FileName = "C:\EDIT'HTML\Preview\Preview.php"
        End If
        Form1.RichTextBox1.SaveFile(Process1.StartInfo.FileName, RichTextBoxStreamType.PlainText)
        'WebBrowser1.Navigate(Process1.StartInfo.FileName)
    End Sub

    Public Sub New()
        InitializeComponent()

        If My.Settings.InitWeb = False Then
            Dim settings As New CefSettings()
            CefSharp.Cef.Initialize(settings)
            My.Settings.InitWeb = True
        End If

        browser = New ChromiumWebBrowser(Process1.StartInfo.FileName) With {
            .Dock = DockStyle.Fill
        }
        NWeb.Controls.Add(browser)

    End Sub

    Private Sub Refr_Click(sender As Object, e As EventArgs) Handles Refr.Click
        'WebBrowser1.Refresh()
        browser.Reload
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