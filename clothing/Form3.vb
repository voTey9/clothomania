Imports System.Text.RegularExpressions

Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Identity.Client.Cache
Public Class Form3
    Dim con As New SqlConnection("Data Source=VOTEY\SQLEXPRESS;Initial Catalog=clothing;Integrated Security=True")
    Private Sub populate()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim query = "select * from customer"
        Dim adopter As SqlDataAdapter
        adopter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adopter)
        Dim ds As DataSet
        ds = New DataSet
        adopter.Fill(ds)
        cdgv.DataSource = ds.Tables(0)
        con.Close()

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If cntb.Text = " " Or mntb.Text = " " Or adtb.Text = "" Then
            MsgBox("missing informations")
        Else
            con.Open()
            Dim query As String
            query = "insert into customer  values ('" & cntb.Text & "','" & mntb.Text & "','" & adtb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("customer saved succesfully")
            populate()
            'Reset()
            con.Close()
        End If
    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        Try
            If key = 0 Then
                MsgBox("select the customer to be deleted")
            Else
                con.Open()
                Dim query As String
                query = "delete from customer  where customer_id=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" customer deleted succesfully")
                con.Close()
                populate()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim key = 0
    Private Sub cdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles cdgv.CellMouseClick
        Try
            Dim row As DataGridViewRow = cdgv.Rows(e.RowIndex)

            cntb.Text = row.Cells(1).Value.ToString
            mntb.Text = row.Cells(2).Value.ToString
            adtb.Text = row.Cells(3).Value.ToString
            ' qtytb.Text = row.Cells(2).Value.ToString
            ' catcb.SelectedItem = row.Cells(4).Value.ToString
            '  qtytb.Text = row.Cells(4).Value.ToString
            '  B_pricetb.Text = row.Cells(5).Value.ToString
            ' S_pricetb.Text = row.Cells(6).Value.ToString

            If cntb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mntb_TextChanged(sender As Object, e As EventArgs) Handles mntb.TextChanged

    End Sub
End Class