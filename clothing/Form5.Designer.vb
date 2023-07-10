<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Panel2 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1369, 151)
        Panel2.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 37.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(450, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(472, 78)
        Label3.TabIndex = 7
        Label3.Text = "ClothoManiA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Demi", 18F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(576, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 38)
        Label1.TabIndex = 10
        Label1.Text = "Product's Billing"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1369, 568)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
