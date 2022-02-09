Public Class Form1
    
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Matrix.TextChanged
        If Matrix.Text = "" Then
            Delete.Enabled = False
        Else
            Delete.Enabled = True
        End If

    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        If Character.Text <> "" And Spaces.Text <> "" And MatDimension.Text <> "" Then
            Dim letter As Char = Character.Text
            Dim sp As Integer = Spaces.Text
            Dim dimension As Integer = MatDimension.Text
            Dim ch As Integer
            If ComboBox1.Text = "" Then
                ch = 0
            Else
                ch = ComboBox1.Text
            End If

            If RadioUpper.Checked = True Then
                letter = letter.ToString().ToUpper()
            ElseIf RadioLower.Checked = True Then
                letter = letter.ToString().ToLower()
            End If

            If ch = 0 Then
                For i = 1 To dimension
                    For j = 1 To dimension
                        Matrix.Text = Matrix.Text + letter
                        For s = 0 To sp
                            Matrix.Text = Matrix.Text + " "
                        Next
                    Next
                    Matrix.Text = Matrix.Text & ControlChars.NewLine
                Next
            ElseIf ch = 1 Then
                For i = dimension To 1 Step -1
                    For j = 1 To i
                        Matrix.Text = Matrix.Text + letter
                        For s = 0 To sp
                            Matrix.Text = Matrix.Text + " "
                        Next
                    Next
                    Matrix.Text = Matrix.Text & ControlChars.NewLine
                Next
            ElseIf ch = 2 Then
                For i = 1 To dimension
                    For j = 1 To i
                        Matrix.Text = Matrix.Text + letter
                        For s = 0 To sp
                            Matrix.Text = Matrix.Text + " "
                        Next
                    Next
                    Matrix.Text = Matrix.Text & ControlChars.NewLine
                Next
            End If
        End If
    End Sub

    Private Sub Character_TextChanged(sender As Object, e As EventArgs) Handles Character.TextChanged
        If Character.Text <> "" And Spaces.Text <> "" And MatDimension.Text <> "" Then
            Display.Enabled = True
        Else
            Display.Enabled = False
        End If
    End Sub

    Private Sub Spaces_TextChanged(sender As Object, e As EventArgs) Handles Spaces.TextChanged
        If Character.Text <> "" And Spaces.Text <> "" And MatDimension.Text <> "" Then
            Display.Enabled = True
        Else
            Display.Enabled = False
        End If

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Matrix.Clear()
    End Sub

    Private Sub MatDimension_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MatDimension.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub Spaces_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Spaces.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub Character_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Character.KeyPress
        If Character.Text <> "" And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub MatDimension_TextChanged(sender As Object, e As EventArgs) Handles MatDimension.TextChanged
        If Character.Text <> "" And Spaces.Text <> "" And MatDimension.Text <> "" Then
            Display.Enabled = True
        Else
            Display.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
