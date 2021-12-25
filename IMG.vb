Public Class IMG
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.RichTextBox1.Text = Strings.Left(Form1.RichTextBox1.Text, Form1.RichTextBox1.SelectionStart) & "<img style=""width: 200px; height: 200px;"" alt=""" & Alt.Text & """ src=""" & NmIMG.Text & """>" & Strings.Mid(Form1.RichTextBox1.Text, Form1.RichTextBox1.SelectionStart + 1)
        'Form1.RichTextBox1.Text = Form1.RichTextBox1.Text & "<img style=""width: 200px; height: 200px;"" alt=""" & Alt.Text & """ src=""" & NmPath.Text & """>"
        Me.Close()
    End Sub
End Class