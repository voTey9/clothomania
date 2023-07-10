Imports System.Data.Common
Imports Microsoft.Data.SqlClient
Public Class sales
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=VOTEY\SQLEXPRESS;Initial Catalog=clothing;Integrated Security=True;TrustServerCertificate=True")
        con.Open()
        Dim querytemp As String = "(select price from product where product_name='" & prod.Text & "')"
        Dim cmd, cmd1, cmd2, cmd3 As SqlCommand
        cmd = New SqlCommand(querytemp, con)
        Dim rate As Double = Convert.ToInt32(cmd.ExecuteScalar())
        Dim sda, sda1, sda2 As SqlDataAdapter
        Dim total As Double
        Dim quty As Integer = Integer.Parse(qty.Text)
        Dim price As Double = Double.Parse(prc.Text)
        total = Integer.Parse(qty.Text) * Double.Parse(prc.Text)
        Dim query As String = "insert into customer2 values('" & cust.Text & "','" & prod.Text & "'," & quty & "," & price & ",'" & catc.Text & "','" & Size.Text & "'," & total & ")"
        Dim query1 As String = "(update into product set quantity=(quantity- " & quty & ") where product_name='" & prod.Text & "')"
        ' Dim querytemp As String = "select price from product where product_name='" & prod.Text & "'"
        Dim cp = rate * quty
        Dim query2 As String = "(insert into pl values('" & prod.Text & "'," & total & "," & cp & "))"
        'query = "insert into user_details values ('" & cntb.Text & "','" & mntb.Text & "','" & adtb.Text & "')"
        'Dim query As String = "Select * from Customer2"

        cmd1 = New SqlCommand(query, con)
        sda = New SqlDataAdapter
        sda.SelectCommand = cmd1
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        cmd2 = New SqlCommand(query1, con)
        sda1 = New SqlDataAdapter
        sda1.SelectCommand = cmd2
        'sda1.Fill(dt)
        cmd3 = New SqlCommand(query2, con)
        sda2 = New SqlDataAdapter
        sda2.SelectCommand = cmd3
        ' sda2.Fill(dt)
        con.Close()
        Show_Grid()
        ' prodgv.DataSource = dt

    End Sub
    Private Sub Show_Grid()
        Dim con As SqlConnection = New SqlConnection("Data Source=VOTEY\SQLEXPRESS;Initial Catalog=clothing;Integrated Security=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand
        Dim sda As SqlDataAdapter
        Dim sqlquery As String = "select * from Customer2"
        con.Open()
        cmd = New SqlCommand(sqlquery, con)
        sda = New SqlDataAdapter
        sda.SelectCommand = cmd
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        prodgv.DataSource = dt
        con.Close()
    End Sub

    Private Sub hombtn_Click(sender As Object, e As EventArgs) Handles hombtn.Click
        Me.Hide()
        employee.Show()
    End Sub
End Class