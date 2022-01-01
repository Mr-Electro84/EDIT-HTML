<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClsCSS
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClsCSS))
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.EC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ZE = New System.Windows.Forms.GroupBox()
        Me.NonImg = New System.Windows.Forms.CheckBox()
        Me.NonLa = New System.Windows.Forms.CheckBox()
        Me.NonLo = New System.Windows.Forms.CheckBox()
        Me.NonTaillePL = New System.Windows.Forms.CheckBox()
        Me.CountLA = New System.Windows.Forms.Label()
        Me.CountLO = New System.Windows.Forms.Label()
        Me.ChImg = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LaTB = New System.Windows.Forms.TrackBar()
        Me.LoTB = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TAC = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CountPX = New System.Windows.Forms.Label()
        Me.PxTB = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SColorT1 = New System.Windows.Forms.TextBox()
        Me.SColor1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SColorT = New System.Windows.Forms.TextBox()
        Me.SColor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FFBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.OK = New System.Windows.Forms.Button()
        Me.HelpTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ZE.SuspendLayout()
        CType(Me.LaTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PxTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Type
        '
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"Toute la page", "Balise HTML", "Classe", "Elément"})
        Me.Type.Location = New System.Drawing.Point(12, 28)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(121, 24)
        Me.Type.TabIndex = 0
        Me.Type.Text = "Type d'élément"
        '
        'EC
        '
        Me.EC.Location = New System.Drawing.Point(139, 30)
        Me.EC.Name = "EC"
        Me.EC.Size = New System.Drawing.Size(731, 22)
        Me.EC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Element cible :"
        '
        'ZE
        '
        Me.ZE.Controls.Add(Me.NonImg)
        Me.ZE.Controls.Add(Me.NonLa)
        Me.ZE.Controls.Add(Me.NonLo)
        Me.ZE.Controls.Add(Me.NonTaillePL)
        Me.ZE.Controls.Add(Me.CountLA)
        Me.ZE.Controls.Add(Me.CountLO)
        Me.ZE.Controls.Add(Me.ChImg)
        Me.ZE.Controls.Add(Me.Label9)
        Me.ZE.Controls.Add(Me.LaTB)
        Me.ZE.Controls.Add(Me.LoTB)
        Me.ZE.Controls.Add(Me.Label8)
        Me.ZE.Controls.Add(Me.Label7)
        Me.ZE.Controls.Add(Me.TAC)
        Me.ZE.Controls.Add(Me.Label6)
        Me.ZE.Controls.Add(Me.CountPX)
        Me.ZE.Controls.Add(Me.PxTB)
        Me.ZE.Controls.Add(Me.Label5)
        Me.ZE.Controls.Add(Me.SColorT1)
        Me.ZE.Controls.Add(Me.SColor1)
        Me.ZE.Controls.Add(Me.Label4)
        Me.ZE.Controls.Add(Me.SColorT)
        Me.ZE.Controls.Add(Me.SColor)
        Me.ZE.Controls.Add(Me.Label3)
        Me.ZE.Controls.Add(Me.FFBox)
        Me.ZE.Controls.Add(Me.Label2)
        Me.ZE.Location = New System.Drawing.Point(12, 58)
        Me.ZE.Name = "ZE"
        Me.ZE.Size = New System.Drawing.Size(858, 454)
        Me.ZE.TabIndex = 3
        Me.ZE.TabStop = False
        Me.ZE.Text = "Zone d'édition"
        '
        'NonImg
        '
        Me.NonImg.AutoSize = True
        Me.NonImg.Location = New System.Drawing.Point(558, 245)
        Me.NonImg.Name = "NonImg"
        Me.NonImg.Size = New System.Drawing.Size(277, 20)
        Me.NonImg.TabIndex = 24
        Me.NonImg.Text = "Ne pas prendre en compte cette proptiété"
        Me.HelpTip.SetToolTip(Me.NonImg, "Cochez cette case si vous ne voulez pas prendre en compte cette propriété")
        Me.NonImg.UseVisualStyleBackColor = True
        '
        'NonLa
        '
        Me.NonLa.AutoSize = True
        Me.NonLa.Location = New System.Drawing.Point(558, 196)
        Me.NonLa.Name = "NonLa"
        Me.NonLa.Size = New System.Drawing.Size(277, 20)
        Me.NonLa.TabIndex = 23
        Me.NonLa.Text = "Ne pas prendre en compte cette proptiété"
        Me.HelpTip.SetToolTip(Me.NonLa, "Cochez cette case si vous ne voulez pas prendre en compte cette propriété")
        Me.NonLa.UseVisualStyleBackColor = True
        '
        'NonLo
        '
        Me.NonLo.AutoSize = True
        Me.NonLo.Location = New System.Drawing.Point(558, 140)
        Me.NonLo.Name = "NonLo"
        Me.NonLo.Size = New System.Drawing.Size(277, 20)
        Me.NonLo.TabIndex = 22
        Me.NonLo.Text = "Ne pas prendre en compte cette proptiété"
        Me.HelpTip.SetToolTip(Me.NonLo, "Cochez cette case si vous ne voulez pas prendre en compte cette propriété")
        Me.NonLo.UseVisualStyleBackColor = True
        '
        'NonTaillePL
        '
        Me.NonTaillePL.AutoSize = True
        Me.NonTaillePL.Location = New System.Drawing.Point(558, 59)
        Me.NonTaillePL.Name = "NonTaillePL"
        Me.NonTaillePL.Size = New System.Drawing.Size(277, 20)
        Me.NonTaillePL.TabIndex = 21
        Me.NonTaillePL.Text = "Ne pas prendre en compte cette proptiété"
        Me.HelpTip.SetToolTip(Me.NonTaillePL, "Cochez cette case si vous ne voulez pas prendre en compte cette propriété" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.NonTaillePL.UseVisualStyleBackColor = True
        '
        'CountLA
        '
        Me.CountLA.AutoSize = True
        Me.CountLA.Location = New System.Drawing.Point(84, 200)
        Me.CountLA.Name = "CountLA"
        Me.CountLA.Size = New System.Drawing.Size(14, 16)
        Me.CountLA.TabIndex = 20
        Me.CountLA.Text = "0"
        '
        'CountLO
        '
        Me.CountLO.AutoSize = True
        Me.CountLO.Location = New System.Drawing.Point(96, 157)
        Me.CountLO.Name = "CountLO"
        Me.CountLO.Size = New System.Drawing.Size(14, 16)
        Me.CountLO.TabIndex = 19
        Me.CountLO.Text = "0"
        '
        'ChImg
        '
        Me.ChImg.Location = New System.Drawing.Point(252, 243)
        Me.ChImg.Name = "ChImg"
        Me.ChImg.Size = New System.Drawing.Size(300, 22)
        Me.ChImg.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(218, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Image de fond (indiquer le chemin) :"
        '
        'LaTB
        '
        Me.LaTB.Location = New System.Drawing.Point(133, 183)
        Me.LaTB.Maximum = 100
        Me.LaTB.Name = "LaTB"
        Me.LaTB.Size = New System.Drawing.Size(419, 56)
        Me.LaTB.TabIndex = 16
        '
        'LoTB
        '
        Me.LoTB.Location = New System.Drawing.Point(138, 132)
        Me.LoTB.Maximum = 100
        Me.LoTB.Name = "LoTB"
        Me.LoTB.Size = New System.Drawing.Size(414, 56)
        Me.LoTB.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Largeur (en %) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Hauteur (en %) :"
        '
        'TAC
        '
        Me.TAC.FormattingEnabled = True
        Me.TAC.Items.AddRange(New Object() {"left", "center", "right"})
        Me.TAC.Location = New System.Drawing.Point(186, 102)
        Me.TAC.Name = "TAC"
        Me.TAC.Size = New System.Drawing.Size(121, 24)
        Me.TAC.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Alignement des éléments :"
        '
        'CountPX
        '
        Me.CountPX.AutoSize = True
        Me.CountPX.Location = New System.Drawing.Point(124, 63)
        Me.CountPX.Name = "CountPX"
        Me.CountPX.Size = New System.Drawing.Size(14, 16)
        Me.CountPX.TabIndex = 10
        Me.CountPX.Text = "0"
        '
        'PxTB
        '
        Me.PxTB.Location = New System.Drawing.Point(186, 49)
        Me.PxTB.Maximum = 100
        Me.PxTB.Name = "PxTB"
        Me.PxTB.Size = New System.Drawing.Size(366, 56)
        Me.PxTB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Taille du texte (en pixels) :"
        '
        'SColorT1
        '
        Me.SColorT1.Location = New System.Drawing.Point(368, 416)
        Me.SColorT1.Name = "SColorT1"
        Me.SColorT1.Size = New System.Drawing.Size(189, 22)
        Me.SColorT1.TabIndex = 7
        '
        'SColor1
        '
        Me.SColor1.Location = New System.Drawing.Point(159, 415)
        Me.SColor1.Name = "SColor1"
        Me.SColor1.Size = New System.Drawing.Size(202, 23)
        Me.SColor1.TabIndex = 6
        Me.SColor1.Text = "Selectionnez une couleur"
        Me.SColor1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Couleur de 1er plan :"
        '
        'SColorT
        '
        Me.SColorT.Location = New System.Drawing.Point(368, 386)
        Me.SColorT.Name = "SColorT"
        Me.SColorT.Size = New System.Drawing.Size(189, 22)
        Me.SColorT.TabIndex = 4
        '
        'SColor
        '
        Me.SColor.Location = New System.Drawing.Point(139, 386)
        Me.SColor.Name = "SColor"
        Me.SColor.Size = New System.Drawing.Size(222, 23)
        Me.SColor.TabIndex = 3
        Me.SColor.Text = "Selectionnez une couleur"
        Me.SColor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Couleur de fond :"
        '
        'FFBox
        '
        Me.FFBox.FormattingEnabled = True
        Me.FFBox.Items.AddRange(New Object() {"serif", "sans-serif"})
        Me.FFBox.Location = New System.Drawing.Point(134, 19)
        Me.FFBox.Name = "FFBox"
        Me.FFBox.Size = New System.Drawing.Size(121, 24)
        Me.FFBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Famille de police :"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(12, 518)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(858, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'HelpTip
        '
        Me.HelpTip.IsBalloon = True
        '
        'ClsCSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 553)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.ZE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EC)
        Me.Controls.Add(Me.Type)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClsCSS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editer une classe CSS"
        Me.ZE.ResumeLayout(False)
        Me.ZE.PerformLayout()
        CType(Me.LaTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PxTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Type As ComboBox
    Friend WithEvents EC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ZE As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FFBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SColor As Button
    Friend WithEvents SColorT As TextBox
    Friend WithEvents SColorT1 As TextBox
    Friend WithEvents SColor1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents OK As Button
    Friend WithEvents CountPX As Label
    Friend WithEvents PxTB As TrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents TAC As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LoTB As TrackBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LaTB As TrackBar
    Friend WithEvents ChImg As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NonTaillePL As CheckBox
    Friend WithEvents CountLA As Label
    Friend WithEvents CountLO As Label
    Friend WithEvents NonLa As CheckBox
    Friend WithEvents NonLo As CheckBox
    Friend WithEvents NonImg As CheckBox
    Friend WithEvents HelpTip As ToolTip
End Class
