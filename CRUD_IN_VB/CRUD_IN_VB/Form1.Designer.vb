<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label8 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(296, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 38)
        Label1.TabIndex = 0
        Label1.Text = "CRUD In VB"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(141, 50)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(317, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 3
        Label3.Text = "Item Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(141, 106)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(317, 27)
        TextBox3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 5
        Label4.Text = "Design"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 7
        Label5.Text = "Color"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 204)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 9
        Label6.Text = "Item Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 20)
        Label7.TabIndex = 11
        Label7.Text = "Warranty Type"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(464, 50)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(546, 275)
        DataGridView1.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Black", "White", "Blue", "Golden"})
        ComboBox1.Location = New Point(141, 154)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(317, 28)
        ComboBox1.TabIndex = 14
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(141, 199)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(317, 27)
        DateTimePicker1.TabIndex = 15
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(141, 250)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 24)
        RadioButton1.TabIndex = 16
        RadioButton1.TabStop = True
        RadioButton1.Text = "Allowed"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(296, 250)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(114, 24)
        RadioButton2.TabIndex = 17
        RadioButton2.TabStop = True
        RadioButton2.Text = "Not Allowed"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(42, 375)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 18
        Button1.Text = "Insert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(181, 375)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 19
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(326, 375)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 20
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(141, 333)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(317, 27)
        TextBox1.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 336)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 21
        Label2.Text = "Product ID"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(64, 305)
        Label8.Name = "Label8"
        Label8.Size = New Size(266, 20)
        Label8.TabIndex = 23
        Label8.Text = "*Provide Product Id When Update Only"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 416)
        Controls.Add(Label8)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
End Class
