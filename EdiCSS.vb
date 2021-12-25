Public Class EdiCSS
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'RichTextBox1.Text = RichTextBox1.Text + "classe {"
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "classe {" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub FermCSS_Click(sender As Object, e As EventArgs) Handles FermCSS.Click
        'RichTextBox1.Text = RichTextBox1.Text + "}"
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "}" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub OuvCSS_Click(sender As Object, e As EventArgs) Handles OuvCSS.Click
        OpenFileDialog1.Filter = "Cascading Style Sheet(*.css)|*.css"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Form1.RichTextBox1.Text = Form1.RichTextBox1.Text + "<link rel=""stylesheet"" type=""text/css"" href=""nom du fichier.css"">"
    End Sub

    Private Sub EnrCSS_Click(sender As Object, e As EventArgs) Handles EnrCSS.Click
        SaveFileDialog1.Filter = "Cascading Style Sheet(*.css)|*.css"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Process1.Start()
            'RichTextBox1.SelectAll()
            'RichTextBox1.Copy()
            'NotifyIcon1.BalloonTipTitle = "Procédure à suivre"
            'NotifyIcon1.BalloonTipText = "À présent collez le code dans bloc-notes et sauvegardez le fichier en tant que CSS"
            'NotifyIcon1.ShowBalloonTip(10)
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub EditClass_Click(sender As Object, e As EventArgs) Handles EditClass.Click
        ClsCSS.Visible = True
    End Sub
End Class