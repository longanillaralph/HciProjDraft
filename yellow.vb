Imports System.Data.OleDb
Public Class yellow

    Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DB.accdb;"


    Sub LoadFriends()
        Dim da As New OleDbDataAdapter("SELECT FriendName, Age, Gender, IsFavorite, FriendID FROM TblFriends WHERE UserID=" & LoggedInUserID, conn)

        Dim dt As New DataTable
        da.Fill(dt)

        DgvFriends.DataSource = dt
    End Sub

End Class