Public Class Form1
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Atab\Documents\Ex.9_VB.accdb")
    Dim adapt As New OleDb.OleDbDataAdapter()
    Dim ds As New DataSet()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd As New OleDb.OleDbCommand("Select * From Person", conn)
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader()
        While (dr.Read())
            Dim line As String = dr.GetValue(0) + "#" + dr.GetValue(1) + "#" + dr.GetValue(2) + "#" + dr.GetValue(3) + "#"
        End While


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim line As String = ListBox1.SelectedItem
        Dim ar() As String = line.Split("#")


    End Sub
End Class
