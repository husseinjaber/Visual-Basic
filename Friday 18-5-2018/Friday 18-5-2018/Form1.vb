Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim open_dialog As New OpenFileDialog
        open_dialog.Filter = "Images|*.png"
        If open_dialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = open_dialog.FileName
        End If
    End Sub

    Private Sub Save_Text_Click(sender As Object, e As EventArgs) Handles Save_Text.Click
        Dim save_dialog As New SaveFileDialog()
        If save_dialog.ShowDialog() = DialogResult.OK Then
            Dim file As New System.IO.StreamWriter(save_dialog.FileName + ".txt")
            file.Write(TextBox1.Text & ControlChars.NewLine & DateTimePicker1.Value.ToString() & ControlChars.NewLine & TextBox2.Text & ControlChars.NewLine & TextBox3.Text & ControlChars.NewLine & NumericUpDown1.Value.ToString() & ControlChars.NewLine & PictureBox1.ImageLocation)
            file.Dispose()
        End If
    End Sub
End Class
