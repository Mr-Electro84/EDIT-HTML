Public Class LH
    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Form1.RichTextBox1.Text = Form1.RichTextBox1.Text & "<a href=" & LienHyper.Text & ">" & tas.Text & "</a>"
        Me.Close()
    End Sub
End Class