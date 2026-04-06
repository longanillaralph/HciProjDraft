<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class yellow
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
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        Label1 = New Label()
        DgvFriends = New DataGridView()
        CType(DgvFriends, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(416, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 0
        Label1.Text = "FRIENDS LIST"
        ' 
        ' DgvFriends
        ' 
        DgvFriends.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvFriends.Location = New Point(12, 98)
        DgvFriends.Name = "DgvFriends"
        DgvFriends.Size = New Size(910, 529)
        DgvFriends.TabIndex = 7
        ' 
        ' yellow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(951, 664)
        Controls.Add(DgvFriends)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "yellow"
        Text = "HISTORY"
        CType(DgvFriends, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvFriends As DataGridView
End Class
