Public Class Form1
    Private Sub Save_File_Click(sender As Object, e As EventArgs) Handles Save_File.Click
        Dim save_dialog As New SaveFileDialog()
        save_dialog.Filter = "*.txt|"
        If save_dialog.ShowDialog() = DialogResult.OK Then
            Dim write As New System.IO.StreamWriter(save_dialog.FileName + ".txt")
            write.Write(TextBox1.Text)
            write.Dispose()
        End If
    End Sub

    Private Sub Load_File_Click(sender As Object, e As EventArgs) Handles Load_File.Click
        Dim open_dialog As New OpenFileDialog()
        open_dialog.Filter = "*.txt|"
        If open_dialog.ShowDialog() = DialogResult.OK Then
            Dim read As New System.IO.StreamReader(open_dialog.FileName)
            TextBox1.Text = read.ReadToEnd()
            read.Dispose()
        End If
    End Sub

    Private Sub Font_Change_Click(sender As Object, e As EventArgs) Handles Font_Change.Click
        Dim font As New FontDialog()
        If font.ShowDialog() = DialogResult.OK Then
            TextBox1.Font = font.Font
        End If
    End Sub

    Private Sub Color_Change_Click(sender As Object, e As EventArgs) Handles Color_Change.Click
        Dim color As New ColorDialog()
        If color.ShowDialog() = DialogResult.OK Then
            TextBox1.ForeColor = color.Color
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        TextBox1.Clear()
    End Sub
End Class
