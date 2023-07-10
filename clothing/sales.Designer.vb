<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(sales))
        Size = New TextBox()
        Label6 = New Label()
        prodgv = New DataGridView()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        hombtn = New Button()
        addbtn = New Button()
        catc = New ComboBox()
        prod = New TextBox()
        qty = New TextBox()
        prc = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        cust = New TextBox()
        delbtn = New Button()
        CType(prodgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Size
        ' 
        Size.BackColor = Color.Azure
        Size.Location = New Point(327, 491)
        Size.Name = "Size"
        Size.Size = New Size(191, 27)
        Size.TabIndex = 59
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(101, 488)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 27)
        Label6.TabIndex = 58
        Label6.Text = "Size"
        ' 
        ' prodgv
        ' 
        prodgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        prodgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        prodgv.Location = New Point(554, 161)
        prodgv.Name = "prodgv"
        prodgv.RowHeadersWidth = 51
        prodgv.RowTemplate.Height = 29
        prodgv.Size = New Size(778, 318)
        prodgv.TabIndex = 57
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(42, 348)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(53, 49)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 56
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(42, 416)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 49)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 55
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(42, 211)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 54
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(42, 281)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 53
        PictureBox1.TabStop = False
        ' 
        ' hombtn
        ' 
        hombtn.BackColor = Color.LightSlateGray
        hombtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        hombtn.Location = New Point(1064, 489)
        hombtn.Name = "hombtn"
        hombtn.Size = New Size(147, 39)
        hombtn.TabIndex = 52
        hombtn.Text = "HOME"
        hombtn.UseVisualStyleBackColor = False
        ' 
        ' addbtn
        ' 
        addbtn.BackColor = Color.LightSlateGray
        addbtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        addbtn.Location = New Point(575, 490)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(147, 39)
        addbtn.TabIndex = 49
        addbtn.Text = "Add"
        addbtn.UseVisualStyleBackColor = False
        ' 
        ' catc
        ' 
        catc.BackColor = Color.Azure
        catc.FormattingEnabled = True
        catc.Items.AddRange(New Object() {"Tshirt", "Sweatshirt", "Pants", "Under garments", "Shirt", "Trousers", "Shoe"})
        catc.Location = New Point(327, 428)
        catc.Name = "catc"
        catc.Size = New Size(191, 28)
        catc.TabIndex = 48
        ' 
        ' prod
        ' 
        prod.BackColor = Color.Azure
        prod.Location = New Point(327, 221)
        prod.Name = "prod"
        prod.Size = New Size(191, 27)
        prod.TabIndex = 46
        ' 
        ' qty
        ' 
        qty.BackColor = Color.Azure
        qty.Location = New Point(327, 292)
        qty.Name = "qty"
        qty.Size = New Size(191, 27)
        qty.TabIndex = 45
        ' 
        ' prc
        ' 
        prc.BackColor = Color.Azure
        prc.Location = New Point(327, 363)
        prc.Name = "prc"
        prc.Size = New Size(191, 27)
        prc.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(101, 361)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 27)
        Label5.TabIndex = 43
        Label5.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(101, 292)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 27)
        Label4.TabIndex = 42
        Label4.Text = "Quantity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(101, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(184, 27)
        Label2.TabIndex = 41
        Label2.Text = "Product Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-6, -13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1355, 153)
        Panel1.TabIndex = 40
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
        Label1.Location = New Point(626, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 38)
        Label1.TabIndex = 9
        Label1.Text = "Billing"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(101, 429)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 27)
        Label7.TabIndex = 47
        Label7.Text = "Category"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(101, 161)
        Label8.Name = "Label8"
        Label8.Size = New Size(204, 27)
        Label8.TabIndex = 60
        Label8.Text = "Customer Name"
        ' 
        ' cust
        ' 
        cust.BackColor = Color.Azure
        cust.Location = New Point(329, 161)
        cust.Name = "cust"
        cust.Size = New Size(191, 27)
        cust.TabIndex = 61
        ' 
        ' delbtn
        ' 
        delbtn.BackColor = Color.LightSlateGray
        delbtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        delbtn.Location = New Point(820, 488)
        delbtn.Name = "delbtn"
        delbtn.Size = New Size(147, 39)
        delbtn.TabIndex = 50
        delbtn.Text = "Delete"
        delbtn.UseVisualStyleBackColor = False
        ' 
        ' sales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1343, 534)
        Controls.Add(cust)
        Controls.Add(Label8)
        Controls.Add(Size)
        Controls.Add(Label6)
        Controls.Add(prodgv)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(hombtn)
        Controls.Add(delbtn)
        Controls.Add(addbtn)
        Controls.Add(catc)
        Controls.Add(prod)
        Controls.Add(qty)
        Controls.Add(prc)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.None
        Name = "sales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "sales"
        CType(prodgv, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Size As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents prodgv As DataGridView
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents hombtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents catc As ComboBox
    Friend WithEvents prod As TextBox
    Friend WithEvents qty As TextBox
    Friend WithEvents prc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cust As TextBox
    Friend WithEvents delbtn As Button
End Class
