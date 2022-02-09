Public Class Form1
    Dim array_years(6) As Label
    Dim array_amounts(6) As TextBox
    Private Sub btn_cal_interest_Click(sender As Object, e As EventArgs) Handles btn_cal_interest.Click
        total_interest.Text = amount.Value * annuity.Value * interest.Value * 0.01
        total.Text = total_interest.Text + amount.Value
    End Sub

    Private Sub details_Click(sender As Object, e As EventArgs) Handles details.Click
        For i = 0 To 5
            array_years(i).Text = year.Text + i
            array_amounts(i).Text = amount.Value + i * amount.Value * interest.Value * 0.01
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        array_years(0) = year1
        array_years(1) = year2
        array_years(2) = year3
        array_years(3) = year4
        array_years(4) = year5
        array_years(5) = year6

        array_amounts(0) = amount1
        array_amounts(1) = amount2
        array_amounts(2) = amount3
        array_amounts(3) = amount4
        array_amounts(4) = amount5
        array_amounts(5) = amount6
        btn_txt.Enabled = False
        btn_index.Enabled = False
        clear.Enabled = False
        remove.Enabled = False
        add.Enabled = False
        list_years.Enabled = False
        details.Enabled = False
        Sorting.Enabled = False
    End Sub

    Private Sub list_years_Click(sender As Object, e As EventArgs) Handles list_years.Click
        For i = 0 To annuity.Value
            ListBox1.Items.Add(year.Text + i & " | " & amount.Value + amount.Value * interest.Value * 0.01 * i)
        Next
        clear.Enabled = ListBox1.Items.Count > 0
        Sorting.Enabled = ListBox1.Items.Count > 1
    End Sub

    Private Sub text_element_Click(sender As Object, e As EventArgs) Handles btn_txt.Click
        txt_element.Text = ListBox1.SelectedItem
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        btn_txt.Enabled = ListBox1.SelectedIndex <> -1
        btn_index.Enabled = ListBox1.SelectedIndex <> -1
        clear.Enabled = ListBox1.SelectedIndex <> -1
        add.Enabled = ListBox1.SelectedIndex <> -1
        remove.Enabled = ListBox1.SelectedIndex <> -1
    End Sub

    Private Sub btn_index_Click(sender As Object, e As EventArgs)
        index_element.Text = ListBox1.SelectedIndex
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        ListBox1.Items.Clear()
        clear.Enabled = False
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        ListBox1.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub last_Click(sender As Object, e As EventArgs) Handles last.Click
        ListBox1.SetSelected(ListBox1.Items.Count - 1, True)
    End Sub

    Private Sub first_Click(sender As Object, e As EventArgs) Handles first.Click
        ListBox1.SetSelected(0, True)
    End Sub

    Private Sub next_element_Click(sender As Object, e As EventArgs) Handles next_element.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            ListBox1.SetSelected(ListBox1.SelectedIndex + 1, True)
        End If
    End Sub

    Private Sub prev_element_Click(sender As Object, e As EventArgs) Handles prev_element.Click
        If ListBox1.SelectedIndex > 0 Then
            ListBox1.SetSelected(ListBox1.SelectedIndex - 1, True)
        End If
    End Sub

    Private Sub year_TextChanged(sender As Object, e As EventArgs) Handles year.TextChanged
        list_years.Enabled = year.Text <> ""
        details.Enabled = year.Text <> ""
    End Sub

    Private Sub Sorting_Click(sender As Object, e As EventArgs) Handles Sorting.Click

    End Sub
End Class
