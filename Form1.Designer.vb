<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        LOGO = New PictureBox()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Panel2 = New Panel()
        CType(LOGO, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(38, 150)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "PROFILE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Yellow
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(38, 221)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "BUDDIES"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Blue
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(38, 304)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "SEARCH"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(187, 41)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(951, 664)
        Panel1.TabIndex = 3
        ' 
        ' LOGO
        ' 
        LOGO.Location = New Point(25, 16)
        LOGO.Name = "LOGO"
        LOGO.Size = New Size(100, 90)
        LOGO.TabIndex = 4
        LOGO.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(38, 619)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 5
        Button4.Text = "LOGOUT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(38, 377)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 6
        Button5.Text = "NOTIFICATION"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(38, 458)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 7
        Button6.Text = "SETTINGS"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(LOGO)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button3)
        Panel2.Location = New Point(-2, -5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(155, 761)
        Panel2.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1150, 717)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(LOGO, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2 As Panel

End Class
