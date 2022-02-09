<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.remove = New System.Windows.Forms.Button()
        Me.btn_index = New System.Windows.Forms.Button()
        Me.Sorting = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.first = New System.Windows.Forms.Button()
        Me.prev_element = New System.Windows.Forms.Button()
        Me.next_element = New System.Windows.Forms.Button()
        Me.last = New System.Windows.Forms.Button()
        Me.btn_txt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.list_years = New System.Windows.Forms.Button()
        Me.amount1 = New System.Windows.Forms.TextBox()
        Me.amount2 = New System.Windows.Forms.TextBox()
        Me.amount3 = New System.Windows.Forms.TextBox()
        Me.amount4 = New System.Windows.Forms.TextBox()
        Me.amount5 = New System.Windows.Forms.TextBox()
        Me.amount6 = New System.Windows.Forms.TextBox()
        Me.details = New System.Windows.Forms.Button()
        Me.total_interest = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.year2 = New System.Windows.Forms.Label()
        Me.year3 = New System.Windows.Forms.Label()
        Me.year4 = New System.Windows.Forms.Label()
        Me.year5 = New System.Windows.Forms.Label()
        Me.year6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.year1 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.TextBox()
        Me.annuity = New System.Windows.Forms.NumericUpDown()
        Me.interest = New System.Windows.Forms.NumericUpDown()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_interest = New System.Windows.Forms.Label()
        Me.lbl_annuity = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.NumericUpDown()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_cal_interest = New System.Windows.Forms.Button()
        Me.index_element = New System.Windows.Forms.TextBox()
        Me.txt_element = New System.Windows.Forms.TextBox()
        CType(Me.annuity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.interest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'remove
        '
        Me.remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remove.Location = New System.Drawing.Point(242, 397)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(89, 30)
        Me.remove.TabIndex = 93
        Me.remove.Text = "-"
        Me.remove.UseVisualStyleBackColor = True
        '
        'btn_index
        '
        Me.btn_index.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_index.Location = New System.Drawing.Point(242, 281)
        Me.btn_index.Name = "btn_index"
        Me.btn_index.Size = New System.Drawing.Size(89, 30)
        Me.btn_index.TabIndex = 92
        Me.btn_index.Text = "Index"
        Me.btn_index.UseVisualStyleBackColor = True
        '
        'Sorting
        '
        Me.Sorting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sorting.Location = New System.Drawing.Point(242, 310)
        Me.Sorting.Name = "Sorting"
        Me.Sorting.Size = New System.Drawing.Size(89, 30)
        Me.Sorting.TabIndex = 91
        Me.Sorting.Text = "Sort Asc"
        Me.Sorting.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(242, 339)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(89, 30)
        Me.clear.TabIndex = 90
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(242, 368)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(89, 30)
        Me.add.TabIndex = 89
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = True
        '
        'first
        '
        Me.first.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first.Location = New System.Drawing.Point(10, 426)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(45, 30)
        Me.first.TabIndex = 88
        Me.first.Text = "|<"
        Me.first.UseVisualStyleBackColor = True
        '
        'prev_element
        '
        Me.prev_element.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prev_element.Location = New System.Drawing.Point(61, 426)
        Me.prev_element.Name = "prev_element"
        Me.prev_element.Size = New System.Drawing.Size(54, 30)
        Me.prev_element.TabIndex = 87
        Me.prev_element.Text = "<"
        Me.prev_element.UseVisualStyleBackColor = True
        '
        'next_element
        '
        Me.next_element.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_element.Location = New System.Drawing.Point(131, 425)
        Me.next_element.Name = "next_element"
        Me.next_element.Size = New System.Drawing.Size(55, 30)
        Me.next_element.TabIndex = 86
        Me.next_element.Text = ">"
        Me.next_element.UseVisualStyleBackColor = True
        '
        'last
        '
        Me.last.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.Location = New System.Drawing.Point(192, 426)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(44, 30)
        Me.last.TabIndex = 85
        Me.last.Text = ">|"
        Me.last.UseVisualStyleBackColor = True
        '
        'btn_txt
        '
        Me.btn_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_txt.Location = New System.Drawing.Point(242, 252)
        Me.btn_txt.Name = "btn_txt"
        Me.btn_txt.Size = New System.Drawing.Size(89, 30)
        Me.btn_txt.TabIndex = 84
        Me.btn_txt.Text = "Text"
        Me.btn_txt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 23)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Year | Amount"
        '
        'list_years
        '
        Me.list_years.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_years.Location = New System.Drawing.Point(10, 194)
        Me.list_years.Name = "list_years"
        Me.list_years.Size = New System.Drawing.Size(222, 30)
        Me.list_years.TabIndex = 77
        Me.list_years.Text = "List of Years"
        Me.list_years.UseVisualStyleBackColor = True
        '
        'amount1
        '
        Me.amount1.Location = New System.Drawing.Point(10, 168)
        Me.amount1.Name = "amount1"
        Me.amount1.Size = New System.Drawing.Size(105, 20)
        Me.amount1.TabIndex = 76
        '
        'amount2
        '
        Me.amount2.Location = New System.Drawing.Point(136, 168)
        Me.amount2.Name = "amount2"
        Me.amount2.Size = New System.Drawing.Size(96, 20)
        Me.amount2.TabIndex = 75
        '
        'amount3
        '
        Me.amount3.Location = New System.Drawing.Point(261, 168)
        Me.amount3.Name = "amount3"
        Me.amount3.Size = New System.Drawing.Size(96, 20)
        Me.amount3.TabIndex = 74
        '
        'amount4
        '
        Me.amount4.Location = New System.Drawing.Point(393, 168)
        Me.amount4.Name = "amount4"
        Me.amount4.Size = New System.Drawing.Size(96, 20)
        Me.amount4.TabIndex = 73
        '
        'amount5
        '
        Me.amount5.Location = New System.Drawing.Point(532, 168)
        Me.amount5.Name = "amount5"
        Me.amount5.Size = New System.Drawing.Size(101, 20)
        Me.amount5.TabIndex = 72
        '
        'amount6
        '
        Me.amount6.Location = New System.Drawing.Point(662, 168)
        Me.amount6.Name = "amount6"
        Me.amount6.Size = New System.Drawing.Size(96, 20)
        Me.amount6.TabIndex = 71
        '
        'details
        '
        Me.details.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.details.Location = New System.Drawing.Point(14, 114)
        Me.details.Name = "details"
        Me.details.Size = New System.Drawing.Size(734, 29)
        Me.details.TabIndex = 70
        Me.details.Text = "Details"
        Me.details.UseVisualStyleBackColor = True
        '
        'total_interest
        '
        Me.total_interest.Location = New System.Drawing.Point(628, 9)
        Me.total_interest.Name = "total_interest"
        Me.total_interest.Size = New System.Drawing.Size(120, 20)
        Me.total_interest.TabIndex = 69
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(628, 38)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(120, 20)
        Me.total.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(560, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 23)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Total"
        '
        'year2
        '
        Me.year2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year2.Location = New System.Drawing.Point(132, 146)
        Me.year2.Name = "year2"
        Me.year2.Size = New System.Drawing.Size(100, 19)
        Me.year2.TabIndex = 66
        '
        'year3
        '
        Me.year3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year3.Location = New System.Drawing.Point(257, 146)
        Me.year3.Name = "year3"
        Me.year3.Size = New System.Drawing.Size(100, 19)
        Me.year3.TabIndex = 65
        '
        'year4
        '
        Me.year4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year4.Location = New System.Drawing.Point(389, 146)
        Me.year4.Name = "year4"
        Me.year4.Size = New System.Drawing.Size(100, 19)
        Me.year4.TabIndex = 64
        '
        'year5
        '
        Me.year5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year5.Location = New System.Drawing.Point(533, 146)
        Me.year5.Name = "year5"
        Me.year5.Size = New System.Drawing.Size(100, 19)
        Me.year5.TabIndex = 63
        '
        'year6
        '
        Me.year6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year6.Location = New System.Drawing.Point(658, 146)
        Me.year6.Name = "year6"
        Me.year6.Size = New System.Drawing.Size(100, 19)
        Me.year6.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(497, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Total Interest"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 23)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "%"
        '
        'year1
        '
        Me.year1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year1.Location = New System.Drawing.Point(15, 146)
        Me.year1.Name = "year1"
        Me.year1.Size = New System.Drawing.Size(100, 19)
        Me.year1.TabIndex = 59
        '
        'year
        '
        Me.year.Location = New System.Drawing.Point(107, 88)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(120, 20)
        Me.year.TabIndex = 58
        '
        'annuity
        '
        Me.annuity.Location = New System.Drawing.Point(107, 36)
        Me.annuity.Name = "annuity"
        Me.annuity.Size = New System.Drawing.Size(120, 20)
        Me.annuity.TabIndex = 57
        '
        'interest
        '
        Me.interest.Location = New System.Drawing.Point(107, 62)
        Me.interest.Name = "interest"
        Me.interest.Size = New System.Drawing.Size(120, 20)
        Me.interest.TabIndex = 56
        '
        'lbl_year
        '
        Me.lbl_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.Location = New System.Drawing.Point(10, 88)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(100, 23)
        Me.lbl_year.TabIndex = 55
        Me.lbl_year.Text = "Year"
        '
        'lbl_interest
        '
        Me.lbl_interest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_interest.Location = New System.Drawing.Point(10, 61)
        Me.lbl_interest.Name = "lbl_interest"
        Me.lbl_interest.Size = New System.Drawing.Size(100, 23)
        Me.lbl_interest.TabIndex = 54
        Me.lbl_interest.Text = "Interest"
        '
        'lbl_annuity
        '
        Me.lbl_annuity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_annuity.Location = New System.Drawing.Point(10, 38)
        Me.lbl_annuity.Name = "lbl_annuity"
        Me.lbl_annuity.Size = New System.Drawing.Size(100, 23)
        Me.lbl_annuity.TabIndex = 53
        Me.lbl_annuity.Text = "Annuity"
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(107, 10)
        Me.amount.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(120, 20)
        Me.amount.TabIndex = 52
        '
        'lbl_amount
        '
        Me.lbl_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount.Location = New System.Drawing.Point(10, 12)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(100, 23)
        Me.lbl_amount.TabIndex = 51
        Me.lbl_amount.Text = "Amount"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(10, 252)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(226, 164)
        Me.ListBox1.TabIndex = 50
        '
        'btn_cal_interest
        '
        Me.btn_cal_interest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cal_interest.Location = New System.Drawing.Point(505, 78)
        Me.btn_cal_interest.Name = "btn_cal_interest"
        Me.btn_cal_interest.Size = New System.Drawing.Size(243, 30)
        Me.btn_cal_interest.TabIndex = 49
        Me.btn_cal_interest.Text = "Calculate Interst Simple"
        Me.btn_cal_interest.UseVisualStyleBackColor = True
        '
        'index_element
        '
        Me.index_element.Location = New System.Drawing.Point(334, 285)
        Me.index_element.Name = "index_element"
        Me.index_element.Size = New System.Drawing.Size(96, 20)
        Me.index_element.TabIndex = 94
        '
        'txt_element
        '
        Me.txt_element.Location = New System.Drawing.Point(334, 259)
        Me.txt_element.Name = "txt_element"
        Me.txt_element.Size = New System.Drawing.Size(96, 20)
        Me.txt_element.TabIndex = 95
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 465)
        Me.Controls.Add(Me.txt_element)
        Me.Controls.Add(Me.index_element)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.btn_index)
        Me.Controls.Add(Me.Sorting)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.first)
        Me.Controls.Add(Me.prev_element)
        Me.Controls.Add(Me.next_element)
        Me.Controls.Add(Me.last)
        Me.Controls.Add(Me.btn_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.list_years)
        Me.Controls.Add(Me.amount1)
        Me.Controls.Add(Me.amount2)
        Me.Controls.Add(Me.amount3)
        Me.Controls.Add(Me.amount4)
        Me.Controls.Add(Me.amount5)
        Me.Controls.Add(Me.amount6)
        Me.Controls.Add(Me.details)
        Me.Controls.Add(Me.total_interest)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.year2)
        Me.Controls.Add(Me.year3)
        Me.Controls.Add(Me.year4)
        Me.Controls.Add(Me.year5)
        Me.Controls.Add(Me.year6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.year1)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.annuity)
        Me.Controls.Add(Me.interest)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.lbl_interest)
        Me.Controls.Add(Me.lbl_annuity)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_cal_interest)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.annuity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.interest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents remove As Button
    Friend WithEvents btn_index As Button
    Friend WithEvents Sorting As Button
    Friend WithEvents clear As Button
    Friend WithEvents add As Button
    Friend WithEvents first As Button
    Friend WithEvents prev_element As Button
    Friend WithEvents next_element As Button
    Friend WithEvents last As Button
    Friend WithEvents btn_txt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents list_years As Button
    Friend WithEvents amount1 As TextBox
    Friend WithEvents amount2 As TextBox
    Friend WithEvents amount3 As TextBox
    Friend WithEvents amount4 As TextBox
    Friend WithEvents amount5 As TextBox
    Friend WithEvents amount6 As TextBox
    Friend WithEvents details As Button
    Friend WithEvents total_interest As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents year2 As Label
    Friend WithEvents year3 As Label
    Friend WithEvents year4 As Label
    Friend WithEvents year5 As Label
    Friend WithEvents year6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents year1 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents annuity As NumericUpDown
    Friend WithEvents interest As NumericUpDown
    Friend WithEvents lbl_year As Label
    Friend WithEvents lbl_interest As Label
    Friend WithEvents lbl_annuity As Label
    Friend WithEvents amount As NumericUpDown
    Friend WithEvents lbl_amount As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_cal_interest As Button
    Friend WithEvents index_element As TextBox
    Friend WithEvents txt_element As TextBox
End Class
