Public Class COMM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.RichTextBox1.Text = Form1.RichTextBox1.Text & "<!-- " & com.Text & " -->"
        Me.Close()
    End Sub
End Class