
Imports System.Data.OleDb

Public Class Form1

    Dim dbcon As OleDb.OleDbConnection
    Dim dbadap As OleDb.OleDbDataAdapter
    Dim dbcmd As OleDb.OleDbCommand
    Sub changeform(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        changeform(yellow)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        changeform(blue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        changeform(red)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon = New OleDbConnection

        dbcon.ConnectionString = "Provider=Microssoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DATABASE\db.accdb"

        Try
            dbcon.ConnectionString = "Provider=Microssoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DATABASE\db.accdb"
            MsgBox("Connection Successfull")
        Catch ex As Exception
            MsgBox("Connection error")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        changeform(Notification)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        changeform(Settings)
    End Sub
End Class
