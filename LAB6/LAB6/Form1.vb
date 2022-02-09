Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim folder_dialog As New FolderBrowserDialog()
        If folder_dialog.ShowDialog() = DialogResult.OK Then
            Source_Selected.Text = folder_dialog.SelectedPath
            Dim array_files() As String = System.IO.Directory.GetFiles(folder_dialog.SelectedPath)
            Dim file_extension As String
            For i = 0 To array_files.Count - 1
                file_extension = System.IO.Path.GetExtension(array_files(i))
                If file_extension = ".jpg" Or file_extension = ".jpeg" Or file_extension = ".png" Then
                    ListBox1.Items.Add(System.IO.Path.GetFileName(array_files(i)))
                End If
            Next
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim file_location As String
        file_location = System.IO.Path.Combine(Source_Selected.Text, ListBox1.SelectedItem)
        PictureBox1.ImageLocation = file_location
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim folder_dialog As New FolderBrowserDialog
        If folder_dialog.ShowDialog() = DialogResult.OK Then
            Destination_Selected.Text = folder_dialog.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        System.IO.File.Copy(System.IO.Path.Combine(Source_Selected.Text, ListBox1.SelectedItem), System.IO.Path.Combine(Destination_Selected.Text, ListBox1.SelectedItem))
    End Sub
End Class