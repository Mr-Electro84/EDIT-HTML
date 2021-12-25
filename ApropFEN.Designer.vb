<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApropFEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApropFEN))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Titrelogiciel = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.crt = New System.Windows.Forms.Label()
        Me.ctrub = New System.Windows.Forms.Button()
        Me.CFOTO = New System.Windows.Forms.Button()
        Me.LienCS = New System.Windows.Forms.Label()
        Me.GitHubTXT = New System.Windows.Forms.LinkLabel()
        Me.RGithub = New System.Diagnostics.Process()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDIT_HTML.My.Resources.Resources.log_edithtml
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Titrelogiciel
        '
        Me.Titrelogiciel.AutoSize = True
        Me.Titrelogiciel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titrelogiciel.Location = New System.Drawing.Point(220, 13)
        Me.Titrelogiciel.Name = "Titrelogiciel"
        Me.Titrelogiciel.Size = New System.Drawing.Size(186, 38)
        Me.Titrelogiciel.TabIndex = 1
        Me.Titrelogiciel.Text = "EDIT'HTML"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Location = New System.Drawing.Point(227, 56)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(80, 17)
        Me.Version.TabIndex = 2
        Me.Version.Text = "Version 2.5"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 327)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'crt
        '
        Me.crt.AutoSize = True
        Me.crt.Location = New System.Drawing.Point(220, 409)
        Me.crt.Name = "crt"
        Me.crt.Size = New System.Drawing.Size(175, 17)
        Me.crt.TabIndex = 6
        Me.crt.Text = "2021-2022 Vapps Line std"
        '
        'ctrub
        '
        Me.ctrub.Location = New System.Drawing.Point(219, 190)
        Me.ctrub.Name = "ctrub"
        Me.ctrub.Size = New System.Drawing.Size(251, 23)
        Me.ctrub.TabIndex = 7
        Me.ctrub.Text = "Voir la liste des contributeurs"
        Me.ctrub.UseVisualStyleBackColor = True
        '
        'CFOTO
        '
        Me.CFOTO.Location = New System.Drawing.Point(219, 161)
        Me.CFOTO.Name = "CFOTO"
        Me.CFOTO.Size = New System.Drawing.Size(251, 23)
        Me.CFOTO.TabIndex = 8
        Me.CFOTO.Text = "Crédits images"
        Me.CFOTO.UseVisualStyleBackColor = True
        '
        'LienCS
        '
        Me.LienCS.AutoSize = True
        Me.LienCS.Location = New System.Drawing.Point(13, 220)
        Me.LienCS.Name = "LienCS"
        Me.LienCS.Size = New System.Drawing.Size(289, 17)
        Me.LienCS.TabIndex = 9
        Me.LienCS.Text = "Retrouvez le code source d'EDIT'HTML sur :"
        '
        'GitHubTXT
        '
        Me.GitHubTXT.AutoSize = True
        Me.GitHubTXT.Location = New System.Drawing.Point(16, 241)
        Me.GitHubTXT.Name = "GitHubTXT"
        Me.GitHubTXT.Size = New System.Drawing.Size(298, 17)
        Me.GitHubTXT.TabIndex = 10
        Me.GitHubTXT.TabStop = True
        Me.GitHubTXT.Text = "https://github.com/Vapps-Line-std/EDIT-HTML"
        '
        'RGithub
        '
        Me.RGithub.StartInfo.Domain = ""
        Me.RGithub.StartInfo.FileName = "https://github.com/Vapps-Line-std/EDIT-HTML"
        Me.RGithub.StartInfo.LoadUserProfile = False
        Me.RGithub.StartInfo.Password = Nothing
        Me.RGithub.StartInfo.StandardErrorEncoding = Nothing
        Me.RGithub.StartInfo.StandardOutputEncoding = Nothing
        Me.RGithub.StartInfo.UserName = ""
        Me.RGithub.SynchronizingObject = Me
        '
        'ApropFEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.GitHubTXT)
        Me.Controls.Add(Me.LienCS)
        Me.Controls.Add(Me.CFOTO)
        Me.Controls.Add(Me.ctrub)
        Me.Controls.Add(Me.crt)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Titrelogiciel)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ApropFEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "À propos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Titrelogiciel As Label
    Friend WithEvents Version As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents crt As Label
    Friend WithEvents ctrub As Button
    Friend WithEvents CFOTO As Button
    Friend WithEvents LienCS As Label
    Friend WithEvents GitHubTXT As LinkLabel
    Friend WithEvents RGithub As Process
End Class
