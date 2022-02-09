Imports System.IO
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim vlcm As Decimal = 1

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        NumericUpDown2.Value = HScrollBar1.Value
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        HScrollBar1.Value = NumericUpDown2.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        NumericUpDown1.Value = HScrollBar2.Value
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        HScrollBar2.Value = NumericUpDown1.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = NumericUpDown1.Value + NumericUpDown2.Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim lcm As Decimal
        Dim a As Decimal = NumericUpDown1.Value
        Dim b As Decimal = NumericUpDown2.Value
        For i As Decimal = a To a * b
            If i Mod a = 0 And i Mod b = 0 Then
                lcm = i
                Exit For
            End If
        Next

        TextBox4.Text = lcm
    End Sub
    Private Function LCM(a As Integer, b As Integer)
        Dim LLcm As Decimal
        For i As Decimal = a To a * b
            If i Mod a = 0 And i Mod b = 0 Then
                LLcm = i
                Exit For
            End If
        Next
        Return LLcm
    End Function
End Class

