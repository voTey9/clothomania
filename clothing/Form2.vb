
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Identity.Client.Cache

Public Class Form2
    Dim con As New SqlConnection("Data Source=VOTEY\SQLEXPRESS;Initial Catalog=clothing;Integrated Security=True")


    Private Sub populate()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim query = "select * from product"
        Dim adopter As SqlDataAdapter
        adopter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adopter)
        Dim ds As DataSet
        ds = New DataSet
        adopter.Fill(ds)
        prodgv.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    Private Sub reset()
        pntb.Text = " "
        qtytb.Text = " "
        prtb.Text = " "
        catcb.SelectedIndex = -1
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    '  Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    '  End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If pntb.Text = " " Or qtytb.Text = " " Or prtb.Text = " " Or catcb.SelectedIndex = -1 Then
            MsgBox("missing informations")
        Else
            con.Open()
            Dim query As String
            query = "insert into  product values ('" & pntb.Text & "','" & qtytb.Text & "','" & prtb.Text & "','" & catcb.SelectedItem.ToString() & "','" & Size_tb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("product saved succesfully")
            populate()
            reset()
            con.Close()
        End If
    End Sub
    Dim key = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ubtn.Click
        Try

            If pntb.Text = " " Or qtytb.Text = " " Or prtb.Text = " " Or catcb.SelectedIndex = -1 Then
                MsgBox("missing informations")
            Else


                con.Open()
                Dim query As String
                query = "update  product set product_name  = '" & pntb.Text & "', quantity ='" & qtytb.Text & "', price ='" & prtb.Text & "', category='" & catcb.SelectedItem & "',size = '" & Size_tb.Text & "'  where  product_id=" & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" product Updated Succesfully")
                con.Close()
                populate()
                reset()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    '  Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    '  End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles hombtn.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub qtytb_TextChanged(sender As Object, e As EventArgs) Handles qtytb.TextChanged

    End Sub



    Private Sub prodgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles prodgv.CellContentClick

    End Sub

    Private Sub prodgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles prodgv.CellMouseClick
        Try
            Dim row As DataGridViewRow = prodgv.Rows(e.RowIndex)

            pntb.Text = row.Cells(1).Value.ToString
            qtytb.Text = row.Cells(2).Value.ToString
            prtb.Text = row.Cells(3).Value.ToString
            ' qtytb.Text = row.Cells(2).Value.ToString
            catcb.SelectedItem = row.Cells(4).Value.ToString
            '  qtytb.Text = row.Cells(4).Value.ToString
            '  B_pricetb.Text = row.Cells(5).Value.ToString
            ' S_pricetb.Text = row.Cells(6).Value.ToString

            If pntb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        Try
            If key = 0 Then
                MsgBox("select the product to be deleted")
            Else
                con.Open()
                Dim query As String
                query = "delete from product  where product_id=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" deleted succesfully")
                con.Close()
                populate()

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class