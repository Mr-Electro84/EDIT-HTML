Public Class ClsCSS
    Private Sub SColor_Click(sender As Object, e As EventArgs) Handles SColor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            SColorT.Text = "rgb(" + ColorDialog1.Color.R.ToString + ", " + ColorDialog1.Color.G.ToString + ", " + ColorDialog1.Color.B.ToString + ")"
        End If
    End Sub

    Private Sub SColor1_Click(sender As Object, e As EventArgs) Handles SColor1.Click
        If ColorDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            SColorT1.Text = "rgb(" + ColorDialog2.Color.R.ToString + ", " + ColorDialog2.Color.G.ToString + ", " + ColorDialog2.Color.B.ToString + ")"
        End If
    End Sub

    Private Sub Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Type.SelectedIndexChanged
        If Type.SelectedItem = "Toute la page" Then
            EC.Text = "*"
        End If
    End Sub

    Private Sub PxTB_Scroll(sender As Object, e As EventArgs) Handles PxTB.Scroll
        CountPX.Text = PxTB.Value
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        'Désolé pour la mise ne forme et l'indentation qui est pas terrible, si quelqu'un peut trouver mieux il est le bienvenue
        If Type.SelectedItem = "Balise HTML" Then
            EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + ""
        End If
        If Type.SelectedItem = "Classe" Then
            EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "."
        End If
        If Type.SelectedItem = "Elément" Then
            EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "#"
        End If
        EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + EC.Text + " {
    background-color: " + SColorT.Text + ";
    color: " + SColorT1.Text + ";
"
        EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "    font-family :  " + FFBox.Text + ";
"
        If NonTaillePL.Checked = False Then
            EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "    font-size :  " + CountPX.Text + "px;
"
        End If
        EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "    text-align :  " + TAC.Text + ";
"
        If NonLo.Checked = False Then
            EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "    height: " + CountLO.Text + "px;
"
        End If
        If NonLa.Checked = False Then
            EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "    width: " + CountLA.Text + "px;
"
        End If
        If NonImg.Checked = False Then
            EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "    background-image: " + ChImg.Text + "px;
"
        End If
        EdiCSS.RichTextBox1.Text = EdiCSS.RichTextBox1.Text + "}

"
    End Sub

    Private Sub LoTB_Scroll(sender As Object, e As EventArgs) Handles LoTB.Scroll
        CountLO.Text = LoTB.Value
    End Sub

    Private Sub LaTB_Scroll(sender As Object, e As EventArgs) Handles LaTB.Scroll
        CountLA.Text = LaTB.Value
    End Sub
End Class