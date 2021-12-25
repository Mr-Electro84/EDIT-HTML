<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TGRAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TGRAS))
        Me.desc1 = New System.Windows.Forms.Label()
        Me.tgra = New System.Windows.Forms.TextBox()
        Me.ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'desc1
        '
        Me.desc1.AutoSize = True
        Me.desc1.Location = New System.Drawing.Point(12, 9)
        Me.desc1.Name = "desc1"
        Me.desc1.Size = New System.Drawing.Size(219, 17)
        Me.desc1.TabIndex = 0
        Me.desc1.Text = "Entrez du texte à mettre en gras :"
        '
        'tgra
        '
        Me.tgra.Location = New System.Drawing.Point(12, 29)
        Me.tgra.Name = "tgra"
        Me.tgra.Size = New System.Drawing.Size(258, 22)
        Me.tgra.TabIndex = 1
        Me.tgra.Text = "Votre texte ici"
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(12, 118)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(258, 23)
        Me.ok.TabIndex = 3
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'TGRAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 153)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.tgra)
        Me.Controls.Add(Me.desc1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TGRAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents desc1 As Label
    Friend WithEvents tgra As TextBox
    Friend WithEvents ok As Button
End Class
