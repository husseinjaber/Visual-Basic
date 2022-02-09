Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnReset.Click
        ProgressBar1.Value = 100
        btnQty.Enabled = False
        btnDelete.Enabled = False
        txtTotal.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Dim readfile As New System.IO.StreamReader("D:\\data.txt")
        Dim input As String = readfile.ReadToEnd()
        readfile.Dispose()
        Dim ar() As String = input.Split("|")
        Dim BtnsArray(6) As Button
        BtnsArray(0) = Button1
        BtnsArray(1) = Button2
        BtnsArray(2) = Button3
        BtnsArray(3) = Button4
        BtnsArray(4) = Button5
        BtnsArray(5) = Button6
        For i = 0 To ar.Count - 1
            BtnsArray(i).Enabled = True
            BtnsArray(i).Text = ar(i)
        Next
        If ar.Count < 6 Then
            For i = ar.Count To 5
                BtnsArray(i).Text = ""
            Next
        End If
    End Sub

    Private Sub GetTotal()
        Dim total As Integer = 0
        Dim ar() As String
        For i As Integer = 0 To ListBox1.Items.Count - 1
            ar = ListBox1.Items(i).Split(",")
            total = total + (ar(1) * ar(2))
        Next
        If rdbVATYes.Checked = True Then
            total = total + (total * 0.1)
        End If
        txtTotal.Enabled = True
        txtTotal.Text = total
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ListBox1.Items.Clear()
        txtTotal.Clear()
        btnQty.Enabled = False
        btnDelete.Enabled = False
        rdbVATNo.Checked = False
        rdbVATYes.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Minimum Then
            ProgressBar1.Value = ProgressBar1.Maximum
            btnReset_Click(sender, e)
        Else
            ProgressBar1.Value = ProgressBar1.Value - 1
        End If
    End Sub

    Private Sub AddItem(sender As Button, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click
        'Incrementing the quantity of choice if it is already in the invoice list:
        'Dim ar1() As String = sender.Text.Split(",")
        'For i = 0 To ListBox1.Items.Count - 1
        '    Dim ar2() As String = ListBox1.Items(i).Split(",")
        '    If ar1(0) = ar2(0) Then
        '        Dim ar() As String = ListBox1.Items(i).Split(",")
        '        ListBox1.Items.RemoveAt(i)
        '        ar(2) = ar(2) + 1
        '        Dim newstring As String = ar(0) & "," & ar(1) & "," & ar(2) 'You can use '+' instead of '&'
        '        ListBox1.Items.Insert(i, newstring)
        '        GetTotal()
        '        Exit Sub
        '    End If
        'Next
        ListBox1.Items.Add(sender.Text + ",1")
        GetTotal()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        btnQty.Enabled = ListBox1.SelectedItems.Count = 1
        btnDelete.Enabled = ListBox1.SelectedItems.Count <> 0
    End Sub

    Private Sub btnQty_Click(sender As Object, e As EventArgs) Handles btnQty.Click
        Dim index As Integer = ListBox1.SelectedIndex
        Dim ar() As String = ListBox1.SelectedItem.Split(",")
        ListBox1.Items.RemoveAt(index)
        ListBox1.Items.Insert(index, ar(0) & "," & ar(1) & "," & ar(2) + 1) 'You can use '+' instead of '&'
        GetTotal()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i = ListBox1.SelectedIndices.Count - 1 To 0 Step -1
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndices(i))
        Next
        GetTotal()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sfd As New SaveFileDialog()
        sfd.InitialDirectory = "D:\"
        sfd.Filter = "Text Files|*.txt"
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim txtfile As New System.IO.StreamWriter(sfd.FileName)
            For i = 0 To ListBox1.Items.Count - 1
                txtfile.Write(ListBox1.Items(i) & ControlChars.NewLine)
            Next
            txtfile.Dispose()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If ListBox1.Items.Count = 0 Then
            Me.Close() 'Or Close()
        End If
    End Sub

    Private Sub rdbVATYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVATYes.CheckedChanged
        GetTotal()
    End Sub

    Private Sub rdbVATNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVATNo.CheckedChanged
        GetTotal()
    End Sub

End Class