Public Class Timervb
    Dim start_time As DateTime
    Dim rounds As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Start_Stop.Click
        If Start_Stop.Text = "Start" Then
            Start_Stop.Text = "Stop"
            start_time = DateTime.Now
            Timer1.Interval = 1000
            Timer1.Start()
        Else
            Timer1.Stop()
            ProgressBar1.Value = ProgressBar1.Minimum
            Start_Stop.Text = "Start"
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        Label1.Text = Timer1.ToString()

        Dim now = DateTime.Now
        Dim spent As TimeSpan = now - start_time
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Minimum
            rounds = rounds + 1
        End If
        Label1.Text = spent.Hours.ToString("d2") & ":" & spent.Minutes.ToString("d2") & ":" & spent.Seconds.ToString("d2")
        Label2.Text = rounds & "time(s)" & spent.Seconds & "/" & ProgressBar1.Maximum
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim d As DateTime = DateTimePicker1.Value

        TextBox1.Text = d.Hour
    End Sub
End Class