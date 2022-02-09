

Private Sub rank()
        Dim r As Integer = 1
        ds.Clear()
        adapt.Fill(ds)
        Dim sum As Integer = ds.Tables(0).Rows(row).ItemArray(3) + ds.Tables(0).Rows(row).ItemArray(4) + ds.Tables(0).Rows(row).ItemArray(5)
        For i = 0 To ds.Tables(0).Rows().Count - 1
            If (ds.Tables(0).Rows(i).ItemArray(3) + ds.Tables(0).Rows(i).ItemArray(4) + ds.Tables(0).Rows(i).ItemArray(5)) > sum Then
                r += 1
            End If
        Next
        txtrank.Text = r
    End Sub

    Private Sub display()
        txtname.Text = ds.Tables(0).Rows(row).ItemArray(1)
        combodep.Text = ds.Tables(0).Rows(row).ItemArray(2)
        G1.Text = ds.Tables(0).Rows(row).ItemArray(3)
        G2.Text = ds.Tables(0).Rows(row).ItemArray(4)
        G3.Text = ds.Tables(0).Rows(row).ItemArray(5)
        rank()
    End Sub

    Private Sub txtname_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Grade_KeyPress(sender As TextBox, e As KeyPressEventArgs) Handles G1.KeyPress, G2.KeyPress, G3.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Checking_Grade_Range(sender As TextBox, e As EventArgs) Handles G1.TextChanged, G2.TextChanged, G3.TextChanged
        If sender.Text <> "" Then
            If sender.Text > 20 Then
                MessageBox.Show("The grade must be between 0 & 20")
                sender.Text = ""
            End If
            If G1.Text <> "" And G2.Text <> "" And G3.Text <> "" Then
                txtaverage.Text = (Convert.ToDouble(G1.Text) + Convert.ToDouble(G2.Text) + Convert.ToDouble(G3.Text)) / 3
            End If
            rank()
        End If
    End Sub


    Private Sub btnpre_Click(sender As Object, e As EventArgs) Handles btnpre.Click
        If checksavepre.Checked Then
            btnupdate_Click(sender, e)
        End If
        If row > 0 Then
            row -= 1
            display()
        End If
        rank()
    End Sub


