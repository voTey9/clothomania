Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Dim con As New SqlConnection("Data Source=VOTEY\SQLEXPRESS;Initial Catalog=clothing;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If anametb.Text = "" Or apasstb.Text = "" Then
            MsgBox("Enter Username And Password")
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query = "select * from adminlogin where username='" & anametb.Text & "' and password ='" & apasstb.Text & "' "
            Dim cmd = New SqlCommand(query, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count

            If a = 0 Then
                MsgBox("wrong username and password")

            Else

                ' bills.USERNAME = anametb.Text
                Me.Hide()
                Form4.Show()
                anametb.Text = ""
                apasstb.Text = ""
            End If





            con.Close()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles apasstb.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles anametb.TextChanged

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles pasrb.CheckedChanged
        Try
            If pasrb.Checked = True Then
                apasstb.UseSystemPasswordChar = False
            Else
                apasstb.UseSystemPasswordChar = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If anametb.Text = "" Or apasstb.Text = "" Then
            MsgBox("Enter Username And Password")
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query = "select * from Employee_login where Employee_ID='" & anametb.Text & "' and Employee_Password ='" & apasstb.Text & "' "
            Dim cmd = New SqlCommand(query, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count

            If a = 0 Then
                MsgBox("wrong username and password")

            Else

                ' bills.USERNAME = anametb.Text
                Me.Hide()
                employee.Show()
                anametb.Text = ""
                apasstb.Text = ""
            End If
            con.Close()
        End If
    End Sub
End Class
