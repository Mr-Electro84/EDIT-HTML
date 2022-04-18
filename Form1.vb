'EDIT'HTML Version 2.5 2022 Vapps Line std, le projet est sous licence MIT
'Modules complémentaires importés
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Reflection
Public Class Form1

    Private Sub Vérifier_Click(sender As Object, e As EventArgs) Handles Vérifier.Click
        'Script permettant de vérifier les erreurs
        ListBox1.Items.Clear()

        If Not RichTextBox1.Text.Contains("<!DOCTYPE html>") Then
            ListBox1.Items.Add("Votre source doit contenir obligatoirement <!DOCTYPE html>")
        End If
        If Not RichTextBox1.Text.Contains("<html>") Then
            ListBox1.Items.Add("Votre source doit contenir obligatoirement <html>")
        End If
        If Not RichTextBox1.Text.Contains("<head>") Then
            ListBox1.Items.Add("Votre source doit contenir obligatoirement <head>")
        End If
        If Not RichTextBox1.Text.Contains("<body>") Then
            ListBox1.Items.Add("Votre source doit contenir obligatoirement <body>")
        End If
        If RichTextBox1.Text.Contains("<body>") And Not RichTextBox1.Text.Contains("</body>") Then
            ListBox1.Items.Add("La classe <body> doit être terminé par </body>")
        End If
        If RichTextBox1.Text.Contains("<html>") And Not RichTextBox1.Text.Contains("</html>") Then
            ListBox1.Items.Add("La classe <html> doit être terminé par </html>")
        End If
        If RichTextBox1.Text.Contains("<head>") And Not RichTextBox1.Text.Contains("</head>") Then
            ListBox1.Items.Add("La classe <head> doit être terminé par </head>")
        End If
        If Not RichTextBox1.Text.Contains("<meta charset=") Then
            ListBox1.Items.Add("AVERISSEMENT : Les accents riquent de ne pas être pris en compte sans charset")
        End If
        If RichTextBox1.Text.Contains("</body>") And RichTextBox1.Text.Contains("<body>") And RichTextBox1.Text.Contains("<html>") And RichTextBox1.Text.Contains("<!DOCTYPE html>") And RichTextBox1.Text.Contains("</html>") And RichTextBox1.Text.Contains("<head>") And RichTextBox1.Text.Contains("</head>") And RichTextBox1.Text.Contains("<meta charset=") Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Aucune erreur détecté")
        End If
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        'Ouverture d'un fichier
        OpenFileDialog1.Filter = "EDIT'HTML File(*.ehf)|*.ehf|Hyper Text Markup Langage(*.html)|*.html|Rich Text Format(*.rtf)|*.rtf"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.FileName.Contains(".htm") Then
                Dim fileReader As String
                fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.UTF8)
                RichTextBox1.Text = fileReader
                'RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            Else My.Settings.CodeHTML = True
                RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            End If
        End If
    End Sub
    Private Sub Apercu_Click(sender As Object, e As EventArgs) Handles Apercu.Click
        'Apercu
        ApercuFEN.Visible = True
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        'Enregistrement d'un nouvrau fichier
        SaveFileDialog1.Filter = "EDIT'HTML File(*.ehf)|*.ehf|Hyper Text Markup Langage(*.html)|*.html|Rich Text Format(*.rtf)|*.rtf"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If SaveFileDialog1.FileName.Contains(".html") Then
                'Process1.Start()
                'RichTextBox1.SelectAll()
                'RichTextBox1.Copy()
                'NotifyIcon1.BalloonTipTitle = "Procédure à suivre"
                'NotifyIcon1.BalloonTipText = "À présent collez le code dans bloc-notes et sauvegardez le fichier en tant que HTML"
                'NotifyIcon1.ShowBalloonTip(10)
                'RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                Using Redacteur As StreamWriter =
                    New StreamWriter(SaveFileDialog1.FileName)
                    Redacteur.Write(RichTextBox1.Text)
                End Using
            Else RichTextBox1.SaveFile(SaveFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        'Enregistrement d'un fichier existant
        RichTextBox1.SaveFile(OpenFileDialog1.FileName)
    End Sub
    'SECTION TEXTE
    Private Sub P_Click(sender As Object, e As EventArgs) Handles P.Click
        'Code obsolète
        'RichTextBox1.Text = RichTextBox1.Text & "<p></p>"
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<p></p>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub H1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H1ToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & "<h1></h1>"
    End Sub

    Private Sub H2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H2ToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & "<h2></h2>"
    End Sub

    Private Sub H3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H3ToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & "<h3></h3>"
    End Sub

    Private Sub H4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H4ToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & "<h4></h4>"
    End Sub

    Private Sub H5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H5ToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & "<h5></h5>"
    End Sub

    Private Sub H6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H6ToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & "<h6></h6>"
    End Sub
    'FIN DE LA SECTION TEXTE

    Private Sub InsLI_Click(sender As Object, e As EventArgs) Handles InsLI.Click
        'Lien hypertexte
        LH.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Commandes à faires lors de l'initialisation
        NotifyIcon1.Text = "EDIT'HTML"
        NotifyIcon1.Visible = True
        RichTextBox1.WordWrap = False
        RichTextBox1.ForeColor = My.Settings.ThemeTxt
        RichTextBox1.BackColor = My.Settings.ThemeClrs
        My.Settings.CodeHTML = False
    End Sub

    Private Sub Balvide_Click(sender As Object, e As EventArgs) Handles balvide.Click
        'Insertion d'une balise vide
        'RichTextBox1.Text = RichTextBox1.Text & "<></>"
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<></>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub ÀProposDeCeLogicielToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposDeCeLogicielToolStripMenuItem.Click
        'Affichage de la fenêtre "A propos"
        ApropFEN.Visible = True
    End Sub

    Private Sub X2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X2ToolStripMenuItem.Click
        'Insertion d'un tableau (à améliorer si possible)
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) &
"<table style=""width: 100%"" border=""1"">
    <tbody>
    <tr>
        <td>A1</td>
        <td>B1</td>
    </tr>
    <tr>
        <td>A2</td>
        <td>B2</td>
    </tr>
    </tbody>
</table>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub AperçuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperçuToolStripMenuItem.Click
        'Affichage de la fenêtre "Aperçu"
        ApercuFEN.Visible = True
    End Sub

    Private Sub Insimg_Click(sender As Object, e As EventArgs) Handles Insimg.Click
        'Inserion d'une image
        IMG.Visible = True
    End Sub

    Private Sub VérifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VérifierToolStripMenuItem.Click
        Vérifier.PerformClick()
    End Sub

    Private Sub TitreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitreToolStripMenuItem.Click
        Titre.ShowDropDown()
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        Insimg.PerformClick()
    End Sub

    Private Sub TableauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableauToolStripMenuItem.Click
        instab.ShowDropDown()
    End Sub

    Private Sub ScriptVideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptVideToolStripMenuItem.Click
        balvide.PerformClick()
    End Sub

    Private Sub LienHypertexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LienHypertexteToolStripMenuItem.Click
        InsLI.PerformClick()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Affichage de l'éditeur CSS
        EdiCSS.Visible = True
    End Sub

    Private Sub Ajoutcomm_Click(sender As Object, e As EventArgs) Handles Ajoutcomm.Click
        'Affichege Pop-Up commentaire
        COMM.Visible = True
    End Sub

    Private Sub EncdUTF8_Click(sender As Object, e As EventArgs) Handles EncdUTF8.Click
        'Insertion de la balise ISO-8859-1
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<meta charset=""ISO-8859-1"">" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub UTF8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UTF8ToolStripMenuItem.Click
        'Insertion de la balise UTF-8 (voir EncdUTF8)
        EncdUTF8.PerformClick()
    End Sub
    'PARAMÈTRES
    Private Sub DuTexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuTexteToolStripMenuItem.Click
        'Couleur de texte
        ColorDialog1.Color = My.Settings.ThemeTxt
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color
        My.Settings.ThemeTxt = ColorDialog1.Color
    End Sub

    Private Sub DeFondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeFondToolStripMenuItem.Click
        'Couleur de fond
        ColorDialog2.Color = My.Settings.ThemeClrs
        ColorDialog2.ShowDialog()
        RichTextBox1.BackColor = ColorDialog2.Color
        My.Settings.ThemeClrs = ColorDialog2.Color
    End Sub
    'FIN DE LA SECTION PARAMÈTRES

    Private Sub Ann_Click(sender As Object, e As EventArgs) Handles ann.Click
        'Annuler
        RichTextBox1.Undo()
    End Sub

    Private Sub Ret_Click(sender As Object, e As EventArgs) Handles ret.Click
        'Rétablir
        RichTextBox1.Redo()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'Actualisation du nombres de caractères
        CountNum.Text = RichTextBox1.TextLength
        'Actualisation du nombre de lignes
        CountLin.Text = RichTextBox1.Lines.Length
        'Obtetnion de la ligne actuelle
        Actlin.Text = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
        'Complétion de la source
        If RichTextBox1.TextLength = 0 Then
            My.Settings.CodeHTML = False
        End If
        If Not RichTextBox1.Text.Contains("<html>") Then
            My.Settings.CodeHTML = False
        End If
        'Raccourcis texte
        If RichTextBox1.Text.Contains(":p:") Then
            RichTextBox1.Find(":p:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<p></p>"
        End If
        If RichTextBox1.Text.Contains(":p='") And RichTextBox1.Text.Contains("':") Then
            RichTextBox1.Find(":p='", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<p>"
            RichTextBox1.Find("':", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "</p>"
        End If
        If RichTextBox1.Text.Contains(":h1:") Then
            RichTextBox1.Find(":h1:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<h1></h1>"
        End If
        If RichTextBox1.Text.Contains(":h2:") Then
            RichTextBox1.Find(":h2:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<h2></h2>"
        End If
        If RichTextBox1.Text.Contains(":h3:") Then
            RichTextBox1.Find(":h3:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<h3></h3>"
        End If
        If RichTextBox1.Text.Contains(":h4:") Then
            RichTextBox1.Find(":h4:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<h4></h4>"
        End If
        If RichTextBox1.Text.Contains(":h5:") Then
            RichTextBox1.Find(":h5:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<h5></h5>"
        End If
        If RichTextBox1.Text.Contains(":script:") Then
            RichTextBox1.Find(":script:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<script></script>"
        End If
        If RichTextBox1.Text.Contains(":style:") Then
            RichTextBox1.Find(":style:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<style></style>"
        End If
        If RichTextBox1.Text.Contains(":widget:") Then
            RichTextBox1.Find(":widget:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<html>"
        End If
        If RichTextBox1.Text.Contains(":frame:") Then
            RichTextBox1.Find(":widget:", 0, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectedText = "<iframe>"
        End If
        If RichTextBox1.Text.Contains("<html>") And My.Settings.CodeHTML = False Then
            RichTextBox1.Text = RichTextBox1.Text &
"
<head>
<!-- Cette page web à été réalisée avec le logiciel EDIT'HTML, plus d'informations : https://vapps-line-std.github.io/eh/ -->
<meta name=""generator"" content=""EDIT'HTML (version 2.5)"">
<title>Votre titre de page ici</title>
</head>
<body>
<!-- Ecrivez votre code ici -->
</body>
</html>"
            My.Settings.CodeHTML = True
        End If
    End Sub
    Private Sub Tab_Click_RTB1(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.Tab And e.KeyCode = Keys.Control Then
            RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "    " & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
        End If
    End Sub

    Private Sub Cpy_Click(sender As Object, e As EventArgs) Handles cpy.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub Cper_Click(sender As Object, e As EventArgs) Handles cper.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub Cler_Click(sender As Object, e As EventArgs) Handles cler.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub X1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X1ToolStripMenuItem.Click
        'Insertion d'un tableau (à améliorer si possible)
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) &
"<table style=""width: 100%"" border=""1"">
    <tbody>
    <tr>
        <td>A1</td>
    </tr>
    <tr>
        <td>A2</td>
    </tr>
    </tbody>
</table>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub Txtgras_Click(sender As Object, e As EventArgs) Handles txtgras.Click
        'Insertion Pop-Up texte à mettre en gras
        TGRAS.Visible = True
    End Sub

    Private Sub ToutIgnorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToutIgnorerToolStripMenuItem.Click
        'Notification
        ListBox1.Items.Clear()
        NotifyIcon1.BalloonTipTitle = "INFORMATION"
        NotifyIcon1.BalloonTipText = "Toutes les erreurs ont été ignorées"
        NotifyIcon1.ShowBalloonTip(5)
    End Sub
    'OPTIONS COPIER/COUPER-COLLER
    Private Sub CopierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CouperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouperToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub ToutSélectionnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToutSélectionnerToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub Tselect_Click(sender As Object, e As EventArgs) Handles tselect.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub VérifierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VérifierToolStripMenuItem1.Click
        Vérifier.PerformClick()
    End Sub

    Private Sub BALFAN_Click(sender As Object, e As EventArgs) Handles BALFAN.Click
        'Insertion d'une balise meta
        'RichTextBox1.Text = RichTextBox1.Text + "<meta propriété=""Valeur définie"">"
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<meta propriété=""Valeur définie"">" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub AperçuAvecWampServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperçuAvecWampServerToolStripMenuItem.Click
        Dim RepW
        RepW = MsgBox("Votre chemin du répertoire WampServer est-il correct : " + My.Settings.CheminWamp, 3 + 32)
        If RepW = vbYes Then
            If Not System.IO.Directory.Exists(My.Settings.CheminWamp) Then
                MsgBox("Le chemin d'accès est introuvable", 16, "Erreur")
            Else
                If RichTextBox1.Text.Contains("<?php") Then
                    Process2.StartInfo.FileName = My.Settings.CheminWamp + "Preview.html"
                Else Process2.StartInfo.FileName = My.Settings.CheminWamp + "Preview.php"
                End If
                Process2.Start()
            End If
        ElseIf RepW = vbNo Then
            CWamp.Visible = True
        End If
    End Sub

    Private Sub RapBPHP_Click(sender As Object, e As EventArgs) Handles RapBPHP.Click
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<?php echo ""Bonjour le monde""; ?>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub
    'PANNEAU LATERAL
    Private Sub RapBCSS_Click(sender As Object, e As EventArgs) Handles RapBCSS.Click
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<style></style>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub RapBJS_Click(sender As Object, e As EventArgs) Handles RapBJS.Click
        RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<script></script>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
    End Sub

    Private Sub RapBV_Click(sender As Object, e As EventArgs) Handles RapBV.Click
        If Not DescBaliseE.Text = "html" Then
            RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<" + DescBaliseE.Text + ">" + "</" + DescBaliseE.Text + ">" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
            DescBaliseE.Clear()
        Else
            RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<html>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
            DescBaliseE.Clear()
        End If
    End Sub

    Private Sub DescBaliseE_KeyDown(sender As Object, e As KeyEventArgs) Handles DescBaliseE.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not DescBaliseE.Text = "html" Then
                RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<" + DescBaliseE.Text + ">" + "</" + DescBaliseE.Text + ">" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
                DescBaliseE.Clear()
            Else
                RichTextBox1.Text = Strings.Left(RichTextBox1.Text, RichTextBox1.SelectionStart) & "<html>" & Strings.Mid(RichTextBox1.Text, RichTextBox1.SelectionStart + 1)
                DescBaliseE.Clear()
            End If
        End If
    End Sub

    Private Sub SupprErr_Click(sender As Object, e As EventArgs) Handles SupprErr.Click
        ToutIgnorerToolStripMenuItem.PerformClick()
    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        End
    End Sub

    Private Sub FermerEtRevenirÀLécranDaccueilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerEtRevenirÀLécranDaccueilToolStripMenuItem.Click
        Accueil.Visible = True
        Me.Close()
    End Sub
End Class