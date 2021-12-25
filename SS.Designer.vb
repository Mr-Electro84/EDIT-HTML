<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SS))
        Me.PROD = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Version = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Loading = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PROD
        '
        Me.PROD.AutoSize = True
        Me.PROD.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROD.Location = New System.Drawing.Point(190, 13)
        Me.PROD.Name = "PROD"
        Me.PROD.Size = New System.Drawing.Size(186, 38)
        Me.PROD.TabIndex = 1
        Me.PROD.Text = "EDIT'HTML"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDIT_HTML.My.Resources.Resources.log_edithtml
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(530, 165)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(158, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Location = New System.Drawing.Point(608, 13)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(80, 17)
        Me.Version.TabIndex = 3
        Me.Version.Text = "Version 2.5"
        '
        'Timer1
        '
        '
        'Loading
        '
        Me.Loading.Image = CType(resources.GetObject("Loading.Image"), System.Drawing.Image)
        Me.Loading.Location = New System.Drawing.Point(197, 68)
        Me.Loading.Name = "Loading"
        Me.Loading.Size = New System.Drawing.Size(120, 120)
        Me.Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Loading.TabIndex = 5
        Me.Loading.TabStop = False
        '
        'SS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 200)
        Me.Controls.Add(Me.Loading)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PROD)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chargement..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PROD As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Version As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Loading As PictureBox
End Class
