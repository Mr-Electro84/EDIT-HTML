Public Class TGRAS
    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Form1.RichTextBox1.Text = Strings.Left(Form1.RichTextBox1.Text, Form1.RichTextBox1.SelectionStart) & "<b>" + tgra.Text + "</b>" & Strings.Mid(Form1.RichTextBox1.Text, Form1.RichTextBox1.SelectionStart + 1)
        Me.Close()
    End Sub
End Class