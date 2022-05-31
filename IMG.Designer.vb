<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IMG
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMG))
        Me.InsIMG = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NmIMG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Alt = New System.Windows.Forms.RichTextBox()
        Me.ButtonAlt = New System.Windows.Forms.Button()
        Me.HelpPopup = New System.Windows.Forms.ToolTip(Me.components)
        Me.NmPath = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'InsIMG
        '
        Me.InsIMG.FileName = "Image"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Image à insérer :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(408, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom de l'image (avec extenion de l'image) :"
        '
        'NmIMG
        '
        Me.NmIMG.Location = New System.Drawing.Point(12, 29)
        Me.NmIMG.Name = "NmIMG"
        Me.NmIMG.Size = New System.Drawing.Size(282, 22)
        Me.NmIMG.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Texte alterantive :"
        '
        'Alt
        '
        Me.Alt.Location = New System.Drawing.Point(12, 86)
        Me.Alt.Name = "Alt"
        Me.Alt.Size = New System.Drawing.Size(359, 96)
        Me.Alt.TabIndex = 5
        Me.Alt.Text = "image"
        '
        'ButtonAlt
        '
        Me.ButtonAlt.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAlt.ForeColor = System.Drawing.Color.White
        Me.ButtonAlt.Location = New System.Drawing.Point(377, 86)
        Me.ButtonAlt.Name = "ButtonAlt"
        Me.ButtonAlt.Size = New System.Drawing.Size(43, 96)
        Me.ButtonAlt.TabIndex = 6
        Me.ButtonAlt.Text = "?"
        Me.HelpPopup.SetToolTip(Me.ButtonAlt, "Un texte alternative est une texe remplaçant l'image si le chemin ne foncionne pa" &
        "s, il sert aussi à améliorer l'acessibilité du site.")
        Me.ButtonAlt.UseVisualStyleBackColor = False
        '
        'HelpPopup
        '
        Me.HelpPopup.IsBalloon = True
        '
        'NmPath
        '
        Me.NmPath.Location = New System.Drawing.Point(300, 28)
        Me.NmPath.Name = "NmPath"
        Me.NmPath.Size = New System.Drawing.Size(120, 23)
        Me.NmPath.TabIndex = 7
        Me.NmPath.Text = "Ne pas remplir cette zone de texte"
        Me.NmPath.WordWrap = False
        '
        'IMG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 253)
        Me.Controls.Add(Me.NmPath)
        Me.Controls.Add(Me.ButtonAlt)
        Me.Controls.Add(Me.Alt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NmIMG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IMG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InsIMG As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents NmIMG As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Alt As RichTextBox
    Friend WithEvents ButtonAlt As Button
    Friend WithEvents HelpPopup As ToolTip
    Friend WithEvents NmPath As RichTextBox
End Class
