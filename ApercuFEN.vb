Public Class ApercuFEN
    Private Sub Apercu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.RichTextBox1.Text.Contains("<?php") Then
            Process1.StartInfo.FileName = "C:\EDIT'HTML\Preview\Preview.php"
        End If
        Form1.RichTextBox1.SaveFile(Process1.StartInfo.FileName, RichTextBoxStreamType.PlainText)
        WebBrowser1.Navigate(Process1.StartInfo.FileName)
        URL.Text = WebBrowser1.DocumentTitle
    End Sub

    Private Sub Refr_Click(sender As Object, e As EventArgs) Handles Refr.Click
        WebBrowser1.Refresh()
    End Sub
End Class