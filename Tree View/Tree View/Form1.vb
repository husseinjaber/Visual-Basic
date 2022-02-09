Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim drivers() As String = System.Environment.GetLogicalDrives()
        For i = 0 To drivers.Count - 1
            TreeView1.Nodes.Add(drivers(i))
        Next
        ListView1.Columns.Add("No.", 40)
        ListView1.Columns.Add("Folders", 140)
        ListView1.View = View.Details
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim driver_info As New System.IO.DriveInfo(TreeView1.SelectedNode.Text)
        If driver_info.IsReady Then
            Dim folders() As String = System.IO.Directory.GetDirectories(TreeView1.SelectedNode.Text)
            For j = 0 To folders.Count - 1
                TreeView1.SelectedNode.Nodes.Add(folders(j))
                Dim ar(1) As String
                ar(0) = j.ToString()
                ar(1) = folders(j).ToString()
                Dim n As New ListViewItem(ar)
                ListView1.Items.Add(n)

            Next
        Else
            MessageBox.Show("This Driver is Not Ready!")
        End If
        Label1.Text = "Index" + TreeView1.SelectedNode.Index.ToString() + " Full Path:" + TreeView1.SelectedNode.FullPath + " Level:" + TreeView1.SelectedNode.Level.ToString() + " To String:" + TreeView1.SelectedNode.ToString()
    End Sub
End Class
