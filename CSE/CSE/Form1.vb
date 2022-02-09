Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ar(2) As String

        ar(0) = "Prof"
        ar(1) = "Student"
        ar(2) = "employee"
        ComboBox1.Items.AddRange(ar)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ComboBox1.SelectedIndex
        'TextBox1.Text = ComboBox1.SelectedText.ToString()
        'TextBox1.Text = ComboBox1.Text
    End Sub
End Class
