Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Open.Click
        Dim open_file As New OpenFileDialog()
        open_file.Filter = "*.txt"
        If open_file.ShowDialog() = DialogResult.OK Then
            Dim file As New System.IO.StreamReader(open_file.FileName)
            TextBox1.Text = file.ReadToEnd()
            file.Dispose()
        End If
    End Sub
End Class
