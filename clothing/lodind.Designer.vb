<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lodind
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
        components = New ComponentModel.Container()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = SystemColors.Desktop
        ProgressBar1.Location = New Point(137, 117)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(529, 155)
        ProgressBar1.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 39F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(150, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(501, 80)
        Label3.TabIndex = 7
        Label3.Text = "ClothoManiA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(343, 291)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 27)
        Label4.TabIndex = 13
        Label4.Text = "Loading...."
        ' 
        ' lodind
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "lodind"
        StartPosition = FormStartPosition.CenterScreen
        Text = "lodind"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
