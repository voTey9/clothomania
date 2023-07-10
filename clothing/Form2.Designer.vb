<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label3 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        prtb = New TextBox()
        qtytb = New TextBox()
        pntb = New TextBox()
        Label7 = New Label()
        catcb = New ComboBox()
        addbtn = New Button()
        delbtn = New Button()
        ubtn = New Button()
        hombtn = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        prodgv = New DataGridView()
        Label6 = New Label()
        Size_tb = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(prodgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 37.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(461, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(479, 79)
        Label3.TabIndex = 8
        Label3.Text = "ClothoManiA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Demi", 18F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(541, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(322, 38)
        Label1.TabIndex = 9
        Label1.Text = "Product's Management"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1355, 153)
        Panel1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(107, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(184, 27)
        Label2.TabIndex = 11
        Label2.Text = "Product Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(107, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 27)
        Label4.TabIndex = 12
        Label4.Text = "Quantity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(107, 364)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 27)
        Label5.TabIndex = 13
        Label5.Text = "Price"
        ' 
        ' prtb
        ' 
        prtb.BackColor = Color.Azure
        prtb.Location = New Point(316, 366)
        prtb.Name = "prtb"
        prtb.Size = New Size(191, 27)
        prtb.TabIndex = 15
        ' 
        ' qtytb
        ' 
        qtytb.BackColor = Color.Azure
        qtytb.Location = New Point(316, 295)
        qtytb.Name = "qtytb"
        qtytb.Size = New Size(191, 27)
        qtytb.TabIndex = 16
        ' 
        ' pntb
        ' 
        pntb.BackColor = Color.Azure
        pntb.Location = New Point(316, 215)
        pntb.Name = "pntb"
        pntb.Size = New Size(191, 27)
        pntb.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(107, 432)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 27)
        Label7.TabIndex = 19
        Label7.Text = "Category"
        ' 
        ' catcb
        ' 
        catcb.BackColor = Color.Azure
        catcb.FormattingEnabled = True
        catcb.Items.AddRange(New Object() {"Tshirt", "Sweatshirt", "Pants", "Under garments", "Shirt", "Trousers", "Shoe"})
        catcb.Location = New Point(316, 431)
        catcb.Name = "catcb"
        catcb.Size = New Size(191, 28)
        catcb.TabIndex = 20
        ' 
        ' addbtn
        ' 
        addbtn.BackColor = Color.LightSlateGray
        addbtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        addbtn.Location = New Point(669, 521)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(147, 39)
        addbtn.TabIndex = 21
        addbtn.Text = "Add"
        addbtn.UseVisualStyleBackColor = False
        ' 
        ' delbtn
        ' 
        delbtn.BackColor = Color.LightSlateGray
        delbtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        delbtn.Location = New Point(1017, 521)
        delbtn.Name = "delbtn"
        delbtn.Size = New Size(147, 39)
        delbtn.TabIndex = 22
        delbtn.Text = "Delete"
        delbtn.UseVisualStyleBackColor = False
        ' 
        ' ubtn
        ' 
        ubtn.BackColor = Color.LightSlateGray
        ubtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ubtn.Location = New Point(848, 521)
        ubtn.Name = "ubtn"
        ubtn.Size = New Size(147, 39)
        ubtn.TabIndex = 23
        ubtn.Text = "Update"
        ubtn.UseVisualStyleBackColor = False
        ' 
        ' hombtn
        ' 
        hombtn.BackColor = Color.LightSlateGray
        hombtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        hombtn.Location = New Point(1186, 521)
        hombtn.Name = "hombtn"
        hombtn.Size = New Size(147, 39)
        hombtn.TabIndex = 30
        hombtn.Text = "HOME"
        hombtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(48, 278)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(48, 206)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(48, 419)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 49)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 34
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(48, 344)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(53, 49)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 35
        PictureBox5.TabStop = False
        ' 
        ' prodgv
        ' 
        prodgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        prodgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        prodgv.Location = New Point(560, 174)
        prodgv.Name = "prodgv"
        prodgv.RowHeadersWidth = 51
        prodgv.RowTemplate.Height = 29
        prodgv.Size = New Size(778, 318)
        prodgv.TabIndex = 37
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(107, 491)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 27)
        Label6.TabIndex = 38
        Label6.Text = "Size"
        ' 
        ' Size_tb
        ' 
        Size_tb.BackColor = Color.Azure
        Size_tb.Location = New Point(316, 494)
        Size_tb.Name = "Size_tb"
        Size_tb.Size = New Size(191, 27)
        Size_tb.TabIndex = 39
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1361, 581)
        Controls.Add(Size_tb)
        Controls.Add(Label6)
        Controls.Add(prodgv)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(hombtn)
        Controls.Add(ubtn)
        Controls.Add(delbtn)
        Controls.Add(addbtn)
        Controls.Add(catcb)
        Controls.Add(Label7)
        Controls.Add(pntb)
        Controls.Add(qtytb)
        Controls.Add(prtb)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(prodgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents prtb As TextBox
    Friend WithEvents qtytb As TextBox
    Friend WithEvents pntb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents catcb As ComboBox
    Friend WithEvents addbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents ubtn As Button
    Friend WithEvents hombtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents adbtn As Button
    Friend WithEvents prodgv As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Size_tb As TextBox
End Class
