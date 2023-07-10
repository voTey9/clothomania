Imports System.Data.Common
Imports Microsoft.Data.SqlClient
Public Class view_products
    Private Sub view_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As SqlConnection = New SqlConnection("Data Source=VOTEY\SQLEXPRESS;Initial Catalog=clothing;Integrated Security=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand
        Dim sda As SqlDataAdapter
        Dim query As String = "Select * from product"
        con.Open()
        cmd = New SqlCommand(query, con)
        sda = New SqlDataAdapter
        sda.SelectCommand = cmd
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub HM_Click(sender As Object, e As EventArgs) Handles HM.Click
        Me.Hide()
        employee.Show()
    End Sub
End Class