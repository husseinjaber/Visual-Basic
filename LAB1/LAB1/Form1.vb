Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = NumericUpDown1.Value + NumericUpDown2.Value
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = Math.Max(NumericUpDown1.Value, NumericUpDown2.Value)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = Math.Min(NumericUpDown1.Value, NumericUpDown2.Value)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (NumericUpDown2.Value <> 0) Then
            TextBox1.Text = NumericUpDown1.Value Mod NumericUpDown2.Value
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Integer = NumericUpDown1.Value
        Dim b As Integer = NumericUpDown2.Value
        Dim gcd As Integer = 1
        Dim min As Integer = Math.Min(a, b)
        While gcd <= min
            If (a Mod gcd = 0 And b Mod gcd = 0) Then
                TextBox1.Text = gcd
            End If
            gcd = gcd + 1
        End While
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Integer = NumericUpDown1.Value
        Dim b As Integer = NumericUpDown2.Value
        Dim lcm As Integer = Math.Max(a, b)
        If (a = 0 Or b = 0) Then
            TextBox1.Text = 1
        Else
            While 1
                If (lcm Mod a = 0 And lcm Mod b = 0) Then
                    TextBox1.Text = lcm
                    Exit While
                End If
                lcm = lcm + 1
            End While
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class
