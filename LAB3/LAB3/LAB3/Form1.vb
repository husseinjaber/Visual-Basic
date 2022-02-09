Public Class Form1
    Private Sub ChronometerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChronometerToolStripMenuItem.Click
        Dim t As New Timervb()
        Timervb.Show()
        t.MdiParent = Me
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
