Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=Araba;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from tbl_araba  where plakano='" + TextBox1.Text + "'"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "a")
        DataGridView1.DataSource = dsv.Tables("a")
        Connection.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=Araba;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from tbl_araba"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "a")
        DataGridView1.DataSource = dsv.Tables("a")
        Connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=Araba;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "Insert Into tbl_araba values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.Text + "')"
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from tbl_araba"
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "a")
        DataGridView1.DataSource = dsv.Tables("a")
        Connection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=araba;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "DELETE FROM tbl_araba where plakano ='" + TextBox1.Text + "'"
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from tbl_araba"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "h")
        DataGridView1.DataSource = dsv.Tables("h")
        Connection.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=araba;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "update tbl_araba set marka ='" + TextBox2.Text + "',model ='" + TextBox3.Text + "',modelyil ='" + TextBox4.Text + "',yakittur ='" + ComboBox1.Text + "' where plakano ='" + TextBox1.Text + "'"
        SQLcommand.Connection = Connection
        SQLcommand.ExecuteNonQuery()
        Dim sorgu = "Select * from tbl_araba"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "h")
        DataGridView1.DataSource = dsv.Tables("h")
        Connection.Close()
    End Sub
End Class
