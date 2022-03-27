Public Class SS
    Private Sub SS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Accueil.Visible = True
            'Form1.Visible = True
            Timer1.Enabled = False
            Me.Close()
        Else ProgressBar1.Value = ProgressBar1.Value + 5
        End If

    End Sub
End Class