﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(user))
        Label3 = New Label()
        Label1 = New Label()
        cdgv = New DataGridView()
        delbtn = New Button()
        addbtn = New Button()
        PictureBox4 = New PictureBox()
        Button1 = New Button()
        cntb = New TextBox()
        mntb = New TextBox()
        adtb = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(cdgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 37.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(464, 18)
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
        Label1.Location = New Point(564, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 38)
        Label1.TabIndex = 9
        Label1.Text = "User's Details"
        ' 
        ' cdgv
        ' 
        cdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        cdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        cdgv.Location = New Point(564, 158)
        cdgv.Name = "cdgv"
        cdgv.RowHeadersWidth = 51
        cdgv.RowTemplate.Height = 29
        cdgv.Size = New Size(791, 331)
        cdgv.TabIndex = 50
        ' 
        ' delbtn
        ' 
        delbtn.BackColor = Color.LightSlateGray
        delbtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        delbtn.Location = New Point(1011, 495)
        delbtn.Name = "delbtn"
        delbtn.Size = New Size(147, 39)
        delbtn.TabIndex = 49
        delbtn.Text = "Delete"
        delbtn.UseVisualStyleBackColor = False
        ' 
        ' addbtn
        ' 
        addbtn.BackColor = Color.LightSlateGray
        addbtn.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        addbtn.Location = New Point(812, 495)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(147, 39)
        addbtn.TabIndex = 48
        addbtn.Text = "add"
        addbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(40, 280)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(66, 42)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 47
        PictureBox4.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSlateGray
        Button1.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1208, 495)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 39)
        Button1.TabIndex = 44
        Button1.Text = "HOME"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' cntb
        ' 
        cntb.BackColor = Color.Azure
        cntb.Location = New Point(341, 220)
        cntb.Name = "cntb"
        cntb.Size = New Size(191, 27)
        cntb.TabIndex = 43
        ' 
        ' mntb
        ' 
        mntb.BackColor = Color.Azure
        mntb.Location = New Point(341, 295)
        mntb.Name = "mntb"
        mntb.Size = New Size(191, 27)
        mntb.TabIndex = 42
        ' 
        ' adtb
        ' 
        adtb.BackColor = Color.Azure
        adtb.Location = New Point(341, 374)
        adtb.Name = "adtb"
        adtb.Size = New Size(191, 27)
        adtb.TabIndex = 41
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(107, 371)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 27)
        Label5.TabIndex = 40
        Label5.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(107, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 27)
        Label4.TabIndex = 39
        Label4.Text = "Mobile No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(99, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 27)
        Label2.TabIndex = 38
        Label2.Text = "User Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1395, 153)
        Panel1.TabIndex = 37
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(40, 206)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(69, 41)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 45
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(40, 356)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(66, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 46
        PictureBox3.TabStop = False
        ' 
        ' user
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1395, 535)
        Controls.Add(cdgv)
        Controls.Add(delbtn)
        Controls.Add(addbtn)
        Controls.Add(PictureBox4)
        Controls.Add(Button1)
        Controls.Add(cntb)
        Controls.Add(mntb)
        Controls.Add(adtb)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Name = "user"
        StartPosition = FormStartPosition.CenterScreen
        Text = "user"
        CType(cdgv, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cdgv As DataGridView
    Friend WithEvents delbtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cntb As TextBox
    Friend WithEvents mntb As TextBox
    Friend WithEvents adtb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
