Public Class CWamp
    Private Sub CWamp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CW.Text = My.Settings.CheminWamp
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        My.Settings.CheminWamp = CW.Text
        Me.Close()
    End Sub
End Class