Imports System.Data.Common
Imports Microsoft.Data.SqlClient
Public Class report
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As SqlConnection = New SqlConnection("Data Source=VOTEY\SQLEXPRESS;Initial Catalog=clothing;Integrated Security=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand
        Dim query1 As String = "Select sum(price) from product"
        Dim query2 As String = "Select sum(quantity) from product"
        Dim query3 As String = "Select sum(price) from product"
        Dim query4 As String = "Select sum(price) from customer2"
    End Sub
End Class