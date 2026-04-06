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
        FlpFriends = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' FlpFriends
        ' 
        FlpFriends.AutoScroll = True
        FlpFriends.Dock = DockStyle.Fill
        FlpFriends.Location = New Point(0, 0)
        FlpFriends.Name = "FlpFriends"
        FlpFriends.Size = New Size(951, 664)
        FlpFriends.TabIndex = 2
        ' 
        ' yellow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(951, 664)
        Controls.Add(FlpFriends)
        FormBorderStyle = FormBorderStyle.None
        Name = "yellow"
        Text = "HISTORY"
        ResumeLayout(False)
    End Sub
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents FlpFriends As FlowLayoutPanel
End Class
