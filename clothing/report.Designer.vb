<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(report))
        Label6 = New Label()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        hombtn = New Button()
        pntb = New TextBox()
        qtytb = New TextBox()
        prtb = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(-170, 436)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 27)
        Label6.TabIndex = 58
        Label6.Text = "Size"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(-229, 289)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(53, 49)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 56
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(-229, 364)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 49)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 55
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-229, 151)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 54
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-229, 223)
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
        hombtn.Location = New Point(1110, 487)
        hombtn.Name = "hombtn"
        hombtn.Size = New Size(147, 39)
        hombtn.TabIndex = 52
        hombtn.Text = "HOME"
        hombtn.UseVisualStyleBackColor = False
        ' 
        ' pntb
        ' 
        pntb.BackColor = Color.Azure
        pntb.Location = New Point(771, 269)
        pntb.Name = "pntb"
        pntb.Size = New Size(191, 27)
        pntb.TabIndex = 46
        pntb.Text = "."
        ' 
        ' qtytb
        ' 
        qtytb.BackColor = Color.Azure
        qtytb.Location = New Point(771, 338)
        qtytb.Name = "qtytb"
        qtytb.Size = New Size(191, 27)
        qtytb.TabIndex = 45
        ' 
        ' prtb
        ' 
        prtb.BackColor = Color.Azure
        prtb.Location = New Point(771, 411)
        prtb.Name = "prtb"
        prtb.Size = New Size(191, 27)
        prtb.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(-170, 309)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 27)
        Label5.TabIndex = 43
        Label5.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(474, 338)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 27)
        Label4.TabIndex = 42
        Label4.Text = "Quantity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(377, 269)
        Label2.Name = "Label2"
        Label2.Size = New Size(326, 27)
        Label2.TabIndex = 41
        Label2.Text = "Total Inventory Valuation"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-277, -55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1690, 212)
        Panel1.TabIndex = 40
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 37.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(800, 64)
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
        Label1.Location = New Point(975, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 38)
        Label1.TabIndex = 9
        Label1.Text = "Report"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(465, 411)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 27)
        Label7.TabIndex = 47
        Label7.Text = "Profit/Loss"
        ' 
        ' report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1413, 582)
        Controls.Add(Label6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(hombtn)
        Controls.Add(pntb)
        Controls.Add(qtytb)
        Controls.Add(prtb)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.None
        Name = "report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "report"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents hombtn As Button
    Friend WithEvents pntb As TextBox
    Friend WithEvents qtytb As TextBox
    Friend WithEvents prtb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
