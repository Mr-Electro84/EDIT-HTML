<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApercuFEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApercuFEN))
        Me.Refr = New System.Windows.Forms.Button()
        Me.Process1 = New System.Diagnostics.Process()
        Me.ADefaut = New System.Windows.Forms.Button()
        Me.AMobile = New System.Windows.Forms.Button()
        Me.AGrandEcran = New System.Windows.Forms.Button()
        Me.OwnNavigWeb = New System.Windows.Forms.Button()
        Me.AfficheurWeb = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Refr
        '
        Me.Refr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Refr.Location = New System.Drawing.Point(961, 3)
        Me.Refr.Name = "Refr"
        Me.Refr.Size = New System.Drawing.Size(159, 23)
        Me.Refr.TabIndex = 3
        Me.Refr.Text = "Rafraîchir"
        Me.Refr.UseVisualStyleBackColor = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.FileName = "C:\EDIT'HTML\Preview\Preview.html"
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'ADefaut
        '
        Me.ADefaut.Location = New System.Drawing.Point(12, 3)
        Me.ADefaut.Name = "ADefaut"
        Me.ADefaut.Size = New System.Drawing.Size(168, 52)
        Me.ADefaut.TabIndex = 4
        Me.ADefaut.Text = "Affichage par défaut"
        Me.ADefaut.UseVisualStyleBackColor = True
        '
        'AMobile
        '
        Me.AMobile.Location = New System.Drawing.Point(186, 3)
        Me.AMobile.Name = "AMobile"
        Me.AMobile.Size = New System.Drawing.Size(125, 23)
        Me.AMobile.TabIndex = 5
        Me.AMobile.Text = "Mobile"
        Me.AMobile.UseVisualStyleBackColor = True
        '
        'AGrandEcran
        '
        Me.AGrandEcran.Location = New System.Drawing.Point(186, 32)
        Me.AGrandEcran.Name = "AGrandEcran"
        Me.AGrandEcran.Size = New System.Drawing.Size(125, 23)
        Me.AGrandEcran.TabIndex = 6
        Me.AGrandEcran.Text = "Grand écran"
        Me.AGrandEcran.UseVisualStyleBackColor = True
        '
        'OwnNavigWeb
        '
        Me.OwnNavigWeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OwnNavigWeb.Location = New System.Drawing.Point(961, 32)
        Me.OwnNavigWeb.Name = "OwnNavigWeb"
        Me.OwnNavigWeb.Size = New System.Drawing.Size(159, 23)
        Me.OwnNavigWeb.TabIndex = 7
        Me.OwnNavigWeb.Text = "Votre navigateur web"
        Me.OwnNavigWeb.UseVisualStyleBackColor = True
        '
        'AfficheurWeb
        '
        Me.AfficheurWeb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AfficheurWeb.Location = New System.Drawing.Point(13, 62)
        Me.AfficheurWeb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.AfficheurWeb.Name = "AfficheurWeb"
        Me.AfficheurWeb.Size = New System.Drawing.Size(1107, 479)
        Me.AfficheurWeb.TabIndex = 8
        '
        'ApercuFEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 553)
        Me.Controls.Add(Me.AfficheurWeb)
        Me.Controls.Add(Me.OwnNavigWeb)
        Me.Controls.Add(Me.AGrandEcran)
        Me.Controls.Add(Me.AMobile)
        Me.Controls.Add(Me.ADefaut)
        Me.Controls.Add(Me.Refr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ApercuFEN"
        Me.Text = "Aperçu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Refr As Button
    Friend WithEvents Process1 As Process
    Friend WithEvents AGrandEcran As Button
    Friend WithEvents AMobile As Button
    Friend WithEvents ADefaut As Button
    Friend WithEvents OwnNavigWeb As Button
    Friend WithEvents AfficheurWeb As WebBrowser
End Class
