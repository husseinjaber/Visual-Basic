Public Class Form1
    Dim flagM As Boolean = False
    Dim flagD As Boolean = False
    Dim flagA As Boolean = False
    Dim flagS As Boolean = False
    Dim flaginput As Boolean = False
    Dim flagresult As Boolean = False
    Dim input As Decimal = 0

    Private Sub clear()
        flaginput = False
        flagresult = False
        flagA = False
        flagM = False
        flagD = False
        flagS = False
    End Sub
    Private Sub block()
        For Each btn As Button In MyBase.Controls.OfType(Of Button)
            If btn.Text <> "C" Then
                btn.Enabled = False
            End If
        Next
    End Sub
    Private Sub unblock()
        For Each btn As Button In MyBase.Controls.OfType(Of Button)
            btn.Enabled = True
        Next
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        clear()
        unblock()
        TextBox1.Text = 0
        input = 0
    End Sub

    Private Sub number(sender As Button, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        If TextBox1.Text = "0" Or flagresult = True And Not TextBox1.Text.Contains(".") Then
            TextBox1.Clear()
        End If
        TextBox1.Text += sender.Text
    End Sub

    Private Sub divide_by_0_error()
        TextBox1.Text = "MATH ERROR!"
        clear()
        block()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If flaginput = False And TextBox1.Text <> "" Then
            flagM = True
            flaginput = True
            input = TextBox1.Text
            TextBox1.Clear()
            Exit Sub
        End If
        If flagresult = False And TextBox1.Text <> "" Then
            If flagM = True Then
                input = input * TextBox1.Text
                TextBox1.Clear()
            ElseIf flagS = True Then
                input = input - TextBox1.Text
                flagS = False
                TextBox1.Clear()
            ElseIf flagD = True Then
                If TextBox1.Text = "0" Then
                    divide_by_0_error()
                Else
                    input = input / TextBox1.Text
                    TextBox1.Clear()
                End If
                flagD = False
            ElseIf flagA = True Then
                input = input + TextBox1.Text
                flagA = False
                TextBox1.Clear()

            Else
                clear()
            End If
        End If

            flagM = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If flagM = True Then
            input = input * TextBox1.Text
            TextBox1.Text = input

        ElseIf flagD = True Then
            If TextBox1.Text = "0" Then
                divide_by_0_error()
            Else
                input = input / TextBox1.Text
                TextBox1.Text = input
            End If
        ElseIf flagA = True Then
            input = input + TextBox1.Text
            TextBox1.Text = input
        ElseIf flagS = True Then
            input = input - TextBox1.Text
            TextBox1.Text = input
        End If
        clear()
        flagresult = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If flaginput = False And TextBox1.Text <> "" Then
            flagD = True
            flaginput = True
            input = TextBox1.Text
            TextBox1.Clear()
            Exit Sub
        End If
        If flagresult = False And TextBox1.Text <> "" Then
            If flagM = True Then
                input = input * TextBox1.Text
                TextBox1.Clear()
                flagM = False
            ElseIf flagS = True Then
                input = input - TextBox1.Text
                flagS = False
                TextBox1.Clear()
            ElseIf flagD = True Then
                If TextBox1.Text = "0" Then
                    divide_by_0_error()
                Else
                    input = input / TextBox1.Text
                    TextBox1.Text = input
                End If

            ElseIf flagA = True Then
                input = input + TextBox1.Text
                flagA = False
                TextBox1.Clear()
            End If
        Else
            clear()
        End If

        flagD = True

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If flaginput = False And TextBox1.Text <> "" Then
            flagA = True
            flaginput = True
            input = TextBox1.Text
            TextBox1.Clear()
            Exit Sub
        End If
        If flagresult = False And TextBox1.Text <> "" Then
            If flagM = True Then
                input = input * TextBox1.Text
                flagM = False
                TextBox1.Clear()
            ElseIf flagS = True Then
                input = input - TextBox1.Text
                flagS = False
                TextBox1.Clear()
            ElseIf flagD = True Then
                If TextBox1.Text = "0" Then
                    divide_by_0_error()
                Else
                    input = input / TextBox1.Text
                    TextBox1.Text = input
                End If
                flagD = False
            ElseIf flagA = True Then
                input = input + TextBox1.Text
                TextBox1.Clear()
            End If
        Else
            clear()
        End If
        flagA = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If flaginput = False And TextBox1.Text <> "" Then
            flagS = True
            flaginput = True
            input = TextBox1.Text
            TextBox1.Clear()
            Exit Sub
        End If
        If flagresult = False And TextBox1.Text <> "" Then
            If flagM = True Then
                input = input * TextBox1.Text
                flagM = False
                TextBox1.Clear()

            ElseIf flagS = True Then
                input = input - TextBox1.Text
            ElseIf flagD = True Then
                If TextBox1.Text = "0" Then
                    divide_by_0_error()
                Else
                    input = input / TextBox1.Text
                    TextBox1.Text = input
                End If
                flagD = False
            ElseIf flagA = True Then
                input = input + TextBox1.Text
                TextBox1.Clear()
                flagA = False
            End If
        Else
            clear()
        End If
        flagS = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim st As String = TextBox1.Text
        For i = 0 To st.Length - 1
            If st(i) = "." Then
                Exit Sub
            End If
        Next
        If TextBox1.Text <> "" Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub
End Class