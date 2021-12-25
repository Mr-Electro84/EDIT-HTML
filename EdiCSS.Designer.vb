<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdiCSS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EdiCSS))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OuvCSS = New System.Windows.Forms.ToolStripButton()
        Me.EnrCSS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.FermCSS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditClass = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Process1 = New System.Diagnostics.Process()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 69)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1108, 472)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvCSS, Me.EnrCSS, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1132, 31)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OuvCSS
        '
        Me.OuvCSS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OuvCSS.Image = CType(resources.GetObject("OuvCSS.Image"), System.Drawing.Image)
        Me.OuvCSS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OuvCSS.Name = "OuvCSS"
        Me.OuvCSS.Size = New System.Drawing.Size(147, 28)
        Me.OuvCSS.Text = "Ouvrir un fichier CSS"
        '
        'EnrCSS
        '
        Me.EnrCSS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EnrCSS.Image = CType(resources.GetObject("EnrCSS.Image"), System.Drawing.Image)
        Me.EnrCSS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnrCSS.Name = "EnrCSS"
        Me.EnrCSS.Size = New System.Drawing.Size(178, 28)
        Me.EnrCSS.Text = "Enregistrer un fichier CSS"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(147, 28)
        Me.ToolStripButton1.Text = "Insérer le fichier CSS"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.FermCSS, Me.ToolStripSeparator1, Me.EditClass})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 31)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1132, 31)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton3.Text = "Ouvrir une classe CSS"
        '
        'FermCSS
        '
        Me.FermCSS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FermCSS.Image = CType(resources.GetObject("FermCSS.Image"), System.Drawing.Image)
        Me.FermCSS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FermCSS.Name = "FermCSS"
        Me.FermCSS.Size = New System.Drawing.Size(29, 28)
        Me.FermCSS.Text = "Fermer une classe CSS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'EditClass
        '
        Me.EditClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditClass.Image = CType(resources.GetObject("EditClass.Image"), System.Drawing.Image)
        Me.EditClass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditClass.Name = "EditClass"
        Me.EditClass.Size = New System.Drawing.Size(29, 28)
        Me.EditClass.Text = "Editer une classe CSS"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "EDIT'HTML (Editeur CSS)"
        Me.NotifyIcon1.Visible = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.FileName = "C:\Windows\notepad.exe"
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'EdiCSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 553)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EdiCSS"
        Me.Text = "Editeur CSS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents OuvCSS As ToolStripButton
    Friend WithEvents EnrCSS As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents FermCSS As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Process1 As Process
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EditClass As ToolStripButton
End Class
