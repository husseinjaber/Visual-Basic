Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_ADD.Enabled = False
        L1toL2.Enabled = False
        L2toL1.Enabled = False
        ClearL1.Enabled = False
        ClearL2.Enabled = False
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        ListBox2.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button_ADD.Enabled = TextBox1.Text <> ""
        Addbefore.Enabled = TextBox1.Text <> "" And ListBox1.SelectedIndices.Count = 1
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        L1toL2.Enabled = ListBox1.SelectedIndices.Count <> 0
        ClearL1.Enabled = ListBox1.Items.Count > 0
        Delselection1.Enabled = ListBox1.SelectedIndices.Count > 0
        CancelSelecion1.Enabled = ListBox1.SelectedIndices.Count > 0
        Addbefore.Enabled = ListBox1.SelectedIndices.Count = 1 And TextBox1.Text <> ""
        Selectall.Enabled = ListBox1.Items.Count > 0
    End Sub

    Private Sub L1toL2_Click(sender As Object, e As EventArgs) Handles L1toL2.Click
        'For i = 0 To ListBox1.SelectedIndices.Count - 1
        '    ListBox2.Items.Add(ListBox1.Items(ListBox1.SelectedIndices(i)))
        'Next
        'For i = ListBox1.SelectedIndices.Count - 1 To 0 Step -1
        '    ListBox1.Items.RemoveAt(ListBox1.SelectedIndices(i))
        'Next
        'Selectall.Enabled = ListBox1.Items.Count > 0
        'selectall2.Enabled = ListBox2.Items.Count > 0

        'ClearL2.Enabled = ListBox2.Items.Count > 0
        'ClearL1.Enabled = ListBox1.Items.Count > 0
        transfer(ListBox1, ListBox2)
    End Sub

    Private Sub Button_ADD_Click(sender As Object, e As EventArgs) Handles Button_ADD.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
        ClearL1.Enabled = ListBox1.Items.Count > 0
        Selectall.Enabled = ListBox1.Items.Count > 0

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        L2toL1.Enabled = ListBox2.SelectedIndices.Count <> 0
        ClearL2.Enabled = ListBox2.Items.Count <> 0
        Deleteselection2.Enabled = ListBox2.SelectedIndices.Count > 0
        Clearselection2.Enabled = ListBox2.SelectedIndices.Count > 0
        selectall2.Enabled = ListBox2.Items.Count <> 0
    End Sub

    Private Sub ClearL2_Click(sender As Object, e As EventArgs) Handles ClearL2.Click
        ListBox2.Items.Clear()
        ClearL2.Enabled = False
        selectall2.Enabled = False
    End Sub

    Private Sub L2toL1_Click(sender As Object, e As EventArgs) Handles L2toL1.Click
        'For i = 0 To ListBox2.SelectedIndices.Count - 1
        '    ListBox1.Items.Add(ListBox2.Items(ListBox2.SelectedIndices(i)))
        'Next
        'For i = ListBox2.SelectedIndices.Count - 1 To 0 Step -1
        '    ListBox2.Items.RemoveAt(ListBox2.SelectedIndices(i))
        'Next

        'Selectall.Enabled = ListBox1.Items.Count > 0
        'selectall2.Enabled = ListBox1.Items.Count > 0
        'ClearL1.Enabled = ListBox1.Items.Count > 0
        'ClearL2.Enabled = ListBox2.Items.Count > 0
        transfer(ListBox2, ListBox1)

    End Sub

    Private Sub ClearL1_Click(sender As Object, e As EventArgs) Handles ClearL1.Click
        ListBox1.Items.Clear()
        ClearL1.Enabled = False
        Selectall.Enabled = False
        Delselection1.Enabled = False
        CancelSelecion1.Enabled=False 
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Selectall.Click
        For i = 0 To ListBox1.Items.Count - 1
            ListBox1.SetSelected(i, True)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Clearselection2.Click
        ListBox2.ClearSelected()
    End Sub

    Private Sub Delselection1_Click(sender As Object, e As EventArgs) Handles Delselection1.Click
        For i = ListBox1.SelectedIndices.Count - 1 To 0 Step -1
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndices(i))
        Next
    End Sub

    Private Sub CancelSelecion1_Click(sender As Object, e As EventArgs) Handles CancelSelecion1.Click
        ListBox1.ClearSelected()
    End Sub

    Private Sub selectall2_Click(sender As Object, e As EventArgs) Handles selectall2.Click
        For i = 0 To ListBox2.Items.Count - 1
            ListBox2.SetSelected(i, True)
        Next
    End Sub

    Private Sub Deleteselection2_Click(sender As Object, e As EventArgs) Handles Deleteselection2.Click
        For i = ListBox2.SelectedIndices.Count - 1 To 0 Step -1
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndices(i))
        Next
    End Sub

    Private Sub Addbefore_Click(sender As Object, e As EventArgs) Handles Addbefore.Click
        Dim selectedind As Integer = ListBox1.SelectedIndex
        Dim current As String
        Dim temp As String = ListBox1.Items(ListBox1.SelectedIndex)
        For i = selectedind + 1 To ListBox1.Items.Count - 1
            current = ListBox1.Items(i)
            ListBox1.Items(i) = temp
            temp = current
        Next
        ListBox1.Items.Add(temp)
        ListBox1.Items(ListBox1.SelectedIndex) = TextBox1.Text
    End Sub

    Private Sub Leave_Click(sender As Object, e As EventArgs) Handles Leave.Click
        Me.Close()
    End Sub

    Private Sub transfer(from As ListBox, dest As ListBox)
        For i = 0 To from.SelectedIndices.Count - 1
            dest.Items.Add(from.Items(from.SelectedIndices(i)))
        Next
        For i = from.SelectedIndices.Count - 1 To 0 Step -1
            from.Items.RemoveAt(from.SelectedIndices(i))
        Next
        ClearL1.Enabled = ListBox1.Items.Count > 0
        ClearL2.Enabled = ListBox2.Items.Count > 0
        Selectall.Enabled = ListBox1.Items.Count > 0
        selectall2.Enabled = ListBox2.Items.Count > 0
    End Sub

End Class