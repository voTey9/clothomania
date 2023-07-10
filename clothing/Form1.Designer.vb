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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Panel1 = New Panel()
        anametb = New TextBox()
        apasstb = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        pasrb = New RadioButton()
        Button2 = New Button()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSlateGray
        Button1.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(304, 357)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 39)
        Button1.TabIndex = 0
        Button1.Text = "LogIn"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(197, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 27)
        Label1.TabIndex = 1
        Label1.Text = "   ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(197, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 27)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 137)
        Panel2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 37.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(184, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(472, 78)
        Label3.TabIndex = 7
        Label3.Text = "ClothoManiA"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.InactiveCaption
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 429)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 21)
        Panel1.TabIndex = 6
        ' 
        ' anametb
        ' 
        anametb.BackColor = Color.Azure
        anametb.Location = New Point(359, 192)
        anametb.Name = "anametb"
        anametb.Size = New Size(191, 27)
        anametb.TabIndex = 8
        ' 
        ' apasstb
        ' 
        apasstb.BackColor = Color.Azure
        apasstb.Location = New Point(359, 266)
        apasstb.Name = "apasstb"
        apasstb.Size = New Size(191, 27)
        apasstb.TabIndex = 9
        apasstb.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(138, 181)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(138, 254)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' pasrb
        ' 
        pasrb.AutoSize = True
        pasrb.Location = New Point(560, 268)
        pasrb.Name = "pasrb"
        pasrb.Size = New Size(131, 24)
        pasrb.TabIndex = 12
        pasrb.TabStop = True
        pasrb.Text = "show password"
        pasrb.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSlateGray
        Button2.Font = New Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(499, 357)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 39)
        Button2.TabIndex = 13
        Button2.Text = "LogIn as Employee"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(pasrb)
        Controls.Add(PictureBox2)
        Controls.Add(apasstb)
        Controls.Add(anametb)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents anametb As TextBox
    Friend WithEvents apasstb As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pasrb As RadioButton
    Friend WithEvents Button2 As Button
End Class
