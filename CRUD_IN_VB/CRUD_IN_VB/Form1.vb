Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form1

    Dim con As New SqlConnection("Data Source=DESKTOP-IJ1NB7I\SQLEXPRESS;Initial Catalog=ProgrammingDB;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iname As String = TextBox2.Text
        Dim design As String = TextBox3.Text
        Dim color As String = ComboBox1.Text
        Dim insertdate As DateTime = DateTimePicker1.Text
        Dim wType As String = ""
        If RadioButton1.Checked = True Then
            wType = "Allowed"
        Else
            wType = "Not Allowed"
        End If

        con.Open()
        Dim command As New SqlCommand("Insert into Product_Setup_Tab values( '" & iname & "', '" & design & "', '" & color & "', '" & insertdate & "', '" & wType & "')", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted")
        LoadDataInGrid()

        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        ComboBox1.SelectedItem = Nothing
        DateTimePicker1.Value = DateTime.Now
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("select * from Product_Setup_Tab", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pid As Integer = TextBox1.Text
        Dim iname As String = TextBox2.Text
        Dim design As String = TextBox3.Text
        Dim color As String = ComboBox1.Text
        Dim insertdate As DateTime = DateTimePicker1.Text
        Dim wType As String = ""
        If RadioButton1.Checked = True Then
            wType = "Allowed"
        Else
            wType = "Not Allowed"
        End If

        con.Open()
        Dim command As New SqlCommand("Update Product_Setup_Tab set Item_Name = '" & iname & "', Design = '" & design & "', Color = '" & color & "', ItemDate = '" & insertdate & "', WarrantyType = '" & wType & "' where Product_Id = '" & pid & "' ", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Updated")
        LoadDataInGrid()

        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        ComboBox1.SelectedItem = Nothing
        DateTimePicker1.Value = DateTime.Now
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pid As Integer = TextBox1.Text
        con.Open()
        Dim command As New SqlCommand("delete Product_Setup_Tab where Product_Id = '" & pid & "' ", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Deleted")
        LoadDataInGrid()

        TextBox1.Text = String.Empty
    End Sub

End Class
