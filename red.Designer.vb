<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class red
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(41, 56)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(269, 259)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(346, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 46)
        Label1.TabIndex = 1
        Label1.Text = "NAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.Location = New Point(357, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 46)
        Label2.TabIndex = 2
        Label2.Text = "AGE:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(948, 753)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 95)
        Button1.TabIndex = 3
        Button1.Text = "CHANGE NAME BUTTON"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.Location = New Point(59, 349)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 46)
        Label3.TabIndex = 4
        Label3.Text = "LOCATION:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F)
        Label5.Location = New Point(59, 579)
        Label5.Name = "Label5"
        Label5.Size = New Size(305, 46)
        Label5.TabIndex = 6
        Label5.Text = "CONTACT DETAILS:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F)
        Label6.Location = New Point(59, 496)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 46)
        Label6.TabIndex = 7
        Label6.Text = "COURSE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20F)
        Label7.Location = New Point(59, 421)
        Label7.Name = "Label7"
        Label7.Size = New Size(201, 46)
        Label7.TabIndex = 8
        Label7.Text = "YEAR LEVEL:"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(697, 349)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(337, 292)
        Panel1.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(236, 20)
        Label4.TabIndex = 0
        Label4.Text = "ABOUT YOURSELF (DESCRIPTION):"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 20F)
        Label8.Location = New Point(80, 665)
        Label8.Name = "Label8"
        Label8.Size = New Size(279, 46)
        Label8.TabIndex = 10
        Label8.Text = "PREFFERED TIME:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20F)
        Label9.Location = New Point(346, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(147, 46)
        Label9.TabIndex = 11
        Label9.Text = "USER ID:"
        ' 
        ' red
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(1087, 885)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "red"
        Text = "PROFILE TAB"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
