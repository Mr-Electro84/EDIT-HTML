<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApercuFEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApercuFEN))
        Me.URL = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Refr = New System.Windows.Forms.Button()
        Me.Process1 = New System.Diagnostics.Process()
        Me.SuspendLayout()
        '
        'URL
        '
        Me.URL.Location = New System.Drawing.Point(12, 3)
        Me.URL.Name = "URL"
        Me.URL.Size = New System.Drawing.Size(943, 22)
        Me.URL.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 31)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1108, 510)
        Me.WebBrowser1.TabIndex = 2
        '
        'Refr
        '
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
        'ApercuFEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 553)
        Me.Controls.Add(Me.Refr)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.URL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ApercuFEN"
        Me.Text = "Aperçu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents URL As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Refr As Button
    Friend WithEvents Process1 As Process
End Class
