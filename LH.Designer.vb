<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LH))
        Me.deschy = New System.Windows.Forms.Label()
        Me.LienHyper = New System.Windows.Forms.TextBox()
        Me.ok = New System.Windows.Forms.Button()
        Me.desc2hy = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'deschy
        '
        Me.deschy.AutoSize = True
        Me.deschy.Location = New System.Drawing.Point(12, 9)
        Me.deschy.Name = "deschy"
        Me.deschy.Size = New System.Drawing.Size(173, 17)
        Me.deschy.TabIndex = 0
        Me.deschy.Text = "Entrez un lien hypertexte :"
        Me.deschy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LienHyper
        '
        Me.LienHyper.Location = New System.Drawing.Point(12, 29)
        Me.LienHyper.Name = "LienHyper"
        Me.LienHyper.Size = New System.Drawing.Size(258, 22)
        Me.LienHyper.TabIndex = 1
        Me.LienHyper.Text = """https://site.web"""
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(15, 118)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(255, 23)
        Me.ok.TabIndex = 2
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'desc2hy
        '
        Me.desc2hy.AutoSize = True
        Me.desc2hy.Location = New System.Drawing.Point(12, 54)
        Me.desc2hy.Name = "desc2hy"
        Me.desc2hy.Size = New System.Drawing.Size(219, 17)
        Me.desc2hy.TabIndex = 3
        Me.desc2hy.Text = "Merci d'écrire entre les guillemets"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pour une adresse mail, insérer mailto:"
        '
        'tas
        '
        Me.tas.Location = New System.Drawing.Point(110, 90)
        Me.tas.Name = "tas"
        Me.tas.Size = New System.Drawing.Size(160, 22)
        Me.tas.TabIndex = 5
        Me.tas.Text = "Votre texte ici"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Texte associé"
        '
        'LH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 153)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.desc2hy)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.LienHyper)
        Me.Controls.Add(Me.deschy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deschy As Label
    Friend WithEvents LienHyper As TextBox
    Friend WithEvents ok As Button
    Friend WithEvents desc2hy As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tas As TextBox
    Friend WithEvents Label2 As Label
End Class
