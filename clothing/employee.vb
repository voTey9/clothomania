Public Class employee
    Private Sub Bills_Click(sender As Object, e As EventArgs) Handles Bills.Click
        Me.Hide()
        sales.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        view_products.Show()
    End Sub
End Class