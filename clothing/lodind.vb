Public Class lodind

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub lodind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
        End If

    End Sub
End Class