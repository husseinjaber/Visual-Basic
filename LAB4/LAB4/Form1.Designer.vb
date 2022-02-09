<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button_ADD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.L2toL1 = New System.Windows.Forms.Button()
        Me.L1toL2 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Leave = New System.Windows.Forms.Button()
        Me.ClearL2 = New System.Windows.Forms.Button()
        Me.ClearL1 = New System.Windows.Forms.Button()
        Me.CancelSelecion1 = New System.Windows.Forms.Button()
        Me.Selectall = New System.Windows.Forms.Button()
        Me.Delselection1 = New System.Windows.Forms.Button()
        Me.Clearselection2 = New System.Windows.Forms.Button()
        Me.Deleteselection2 = New System.Windows.Forms.Button()
        Me.selectall2 = New System.Windows.Forms.Button()
        Me.Addbefore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Location = New System.Drawing.Point(17, 33)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 30)
        Me.TextBox1.TabIndex = 0
        '
        'Button_ADD
        '
        Me.Button_ADD.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ADD.Location = New System.Drawing.Point(271, 33)
        Me.Button_ADD.Name = "Button_ADD"
        Me.Button_ADD.Size = New System.Drawing.Size(75, 30)
        Me.Button_ADD.TabIndex = 1
        Me.Button_ADD.Text = "ADD"
        Me.Button_ADD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Write and Add to the List"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(17, 78)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 147)
        Me.ListBox1.TabIndex = 3
        '
        'L2toL1
        '
        Me.L2toL1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2toL1.Location = New System.Drawing.Point(271, 143)
        Me.L2toL1.Name = "L2toL1"
        Me.L2toL1.Size = New System.Drawing.Size(75, 30)
        Me.L2toL1.TabIndex = 4
        Me.L2toL1.Text = "<<"
        Me.L2toL1.UseVisualStyleBackColor = True
        '
        'L1toL2
        '
        Me.L1toL2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1toL2.Location = New System.Drawing.Point(271, 107)
        Me.L1toL2.Name = "L1toL2"
        Me.L1toL2.Size = New System.Drawing.Size(75, 30)
        Me.L1toL2.TabIndex = 5
        Me.L1toL2.Text = ">>"
        Me.L1toL2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(352, 78)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(248, 147)
        Me.ListBox2.TabIndex = 6
        '
        'Leave
        '
        Me.Leave.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Leave.Location = New System.Drawing.Point(271, 279)
        Me.Leave.Name = "Leave"
        Me.Leave.Size = New System.Drawing.Size(75, 30)
        Me.Leave.TabIndex = 7
        Me.Leave.Text = "Leave"
        Me.Leave.UseVisualStyleBackColor = True
        '
        'ClearL2
        '
        Me.ClearL2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearL2.Location = New System.Drawing.Point(352, 231)
        Me.ClearL2.Name = "ClearL2"
        Me.ClearL2.Size = New System.Drawing.Size(120, 30)
        Me.ClearL2.TabIndex = 8
        Me.ClearL2.Text = "Clear List2"
        Me.ClearL2.UseVisualStyleBackColor = True
        '
        'ClearL1
        '
        Me.ClearL1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearL1.Location = New System.Drawing.Point(17, 231)
        Me.ClearL1.Name = "ClearL1"
        Me.ClearL1.Size = New System.Drawing.Size(120, 30)
        Me.ClearL1.TabIndex = 10
        Me.ClearL1.Text = "Clear List1"
        Me.ClearL1.UseVisualStyleBackColor = True
        '
        'CancelSelecion1
        '
        Me.CancelSelecion1.Enabled = False
        Me.CancelSelecion1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelSelecion1.Location = New System.Drawing.Point(17, 303)
        Me.CancelSelecion1.Name = "CancelSelecion1"
        Me.CancelSelecion1.Size = New System.Drawing.Size(246, 30)
        Me.CancelSelecion1.TabIndex = 11
        Me.CancelSelecion1.Text = "Cancel Selection1"
        Me.CancelSelecion1.UseVisualStyleBackColor = True
        '
        'Selectall
        '
        Me.Selectall.Enabled = False
        Me.Selectall.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Selectall.Location = New System.Drawing.Point(145, 231)
        Me.Selectall.Name = "Selectall"
        Me.Selectall.Size = New System.Drawing.Size(120, 30)
        Me.Selectall.TabIndex = 12
        Me.Selectall.Text = "Select All"
        Me.Selectall.UseVisualStyleBackColor = True
        '
        'Delselection1
        '
        Me.Delselection1.Enabled = False
        Me.Delselection1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delselection1.Location = New System.Drawing.Point(19, 267)
        Me.Delselection1.Name = "Delselection1"
        Me.Delselection1.Size = New System.Drawing.Size(246, 30)
        Me.Delselection1.TabIndex = 13
        Me.Delselection1.Text = "Delete Selection1"
        Me.Delselection1.UseVisualStyleBackColor = True
        '
        'Clearselection2
        '
        Me.Clearselection2.Enabled = False
        Me.Clearselection2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearselection2.Location = New System.Drawing.Point(352, 303)
        Me.Clearselection2.Name = "Clearselection2"
        Me.Clearselection2.Size = New System.Drawing.Size(248, 30)
        Me.Clearselection2.TabIndex = 14
        Me.Clearselection2.Text = "Clear Selection2"
        Me.Clearselection2.UseVisualStyleBackColor = True
        '
        'Deleteselection2
        '
        Me.Deleteselection2.Enabled = False
        Me.Deleteselection2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deleteselection2.Location = New System.Drawing.Point(352, 267)
        Me.Deleteselection2.Name = "Deleteselection2"
        Me.Deleteselection2.Size = New System.Drawing.Size(248, 30)
        Me.Deleteselection2.TabIndex = 15
        Me.Deleteselection2.Text = "Delete Selection2"
        Me.Deleteselection2.UseVisualStyleBackColor = True
        '
        'selectall2
        '
        Me.selectall2.Enabled = False
        Me.selectall2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectall2.Location = New System.Drawing.Point(480, 231)
        Me.selectall2.Name = "selectall2"
        Me.selectall2.Size = New System.Drawing.Size(120, 30)
        Me.selectall2.TabIndex = 16
        Me.selectall2.Text = "Select All"
        Me.selectall2.UseVisualStyleBackColor = True
        '
        'Addbefore
        '
        Me.Addbefore.Enabled = False
        Me.Addbefore.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbefore.Location = New System.Drawing.Point(352, 33)
        Me.Addbefore.Name = "Addbefore"
        Me.Addbefore.Size = New System.Drawing.Size(136, 30)
        Me.Addbefore.TabIndex = 17
        Me.Addbefore.Text = "ADD Before"
        Me.Addbefore.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 349)
        Me.Controls.Add(Me.Addbefore)
        Me.Controls.Add(Me.selectall2)
        Me.Controls.Add(Me.Deleteselection2)
        Me.Controls.Add(Me.Clearselection2)
        Me.Controls.Add(Me.Delselection1)
        Me.Controls.Add(Me.Selectall)
        Me.Controls.Add(Me.CancelSelecion1)
        Me.Controls.Add(Me.ClearL1)
        Me.Controls.Add(Me.ClearL2)
        Me.Controls.Add(Me.Leave)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.L1toL2)
        Me.Controls.Add(Me.L2toL1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_ADD)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button_ADD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents L2toL1 As Button
    Friend WithEvents L1toL2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Leave As Button
    Friend WithEvents ClearL2 As Button
    Friend WithEvents ClearL1 As Button
    Friend WithEvents CancelSelecion1 As Button
    Friend WithEvents Selectall As Button
    Friend WithEvents Delselection1 As Button
    Friend WithEvents Clearselection2 As Button
    Friend WithEvents Deleteselection2 As Button
    Friend WithEvents selectall2 As Button
    Friend WithEvents Addbefore As Button
End Class
