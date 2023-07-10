<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(employee))
        Panel2 = New Panel()
        Label3 = New Label()
        PictureBox6 = New PictureBox()
        Button6 = New Button()
        back = New Button()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Bills = New Button()
        Panel2.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 137)
        Panel2.TabIndex = 43
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 37.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(184, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(472, 78)
        Label3.TabIndex = 7
        Label3.Text = "ClothoManiA"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(287, 229)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(69, 76)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 54
        PictureBox6.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.LightSlateGray
        Button6.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(239, 311)
        Button6.Name = "Button6"
        Button6.Size = New Size(147, 39)
        Button6.TabIndex = 53
        Button6.Text = "Report"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' back
        ' 
        back.BackColor = Color.LightSlateGray
        back.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        back.Location = New Point(678, 410)
        back.Name = "back"
        back.Size = New Size(98, 37)
        back.TabIndex = 52
        back.Text = "back"
        back.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(62, 300)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(69, 76)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 51
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(523, 300)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(69, 76)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 50
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(523, 155)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(69, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 49
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(62, 155)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightSlateGray
        Button4.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(475, 382)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 39)
        Button4.TabIndex = 47
        Button4.Text = "CUSTOMERS"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightSlateGray
        Button3.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(13, 382)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 39)
        Button3.TabIndex = 46
        Button3.Text = "CATEGORY"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSlateGray
        Button2.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(13, 237)
        Button2.Name = "Button2"
        Button2.Size = New Size(212, 39)
        Button2.TabIndex = 45
        Button2.Text = "VIEW PRODUCTS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Bills
        ' 
        Bills.BackColor = Color.LightSlateGray
        Bills.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Bills.Location = New Point(475, 237)
        Bills.Name = "Bills"
        Bills.Size = New Size(147, 39)
        Bills.TabIndex = 44
        Bills.Text = "Biling"
        Bills.UseVisualStyleBackColor = False
        ' 
        ' employee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(PictureBox6)
        Controls.Add(Button6)
        Controls.Add(back)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Bills)
        Name = "employee"
        Text = "employee"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents back As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bills As Button
End Class
