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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Character = New System.Windows.Forms.TextBox()
        Me.RadioUpper = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Display = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MatDimension = New System.Windows.Forms.TextBox()
        Me.Spaces = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioLower = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Matrix = New System.Windows.Forms.TextBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Character"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Character
        '
        Me.Character.Location = New System.Drawing.Point(221, 11)
        Me.Character.Name = "Character"
        Me.Character.Size = New System.Drawing.Size(127, 20)
        Me.Character.TabIndex = 1
        '
        'RadioUpper
        '
        Me.RadioUpper.AutoSize = True
        Me.RadioUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioUpper.Location = New System.Drawing.Point(17, 149)
        Me.RadioUpper.Name = "RadioUpper"
        Me.RadioUpper.Size = New System.Drawing.Size(98, 19)
        Me.RadioUpper.TabIndex = 2
        Me.RadioUpper.TabStop = True
        Me.RadioUpper.Text = "Upper case"
        Me.RadioUpper.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2"})
        Me.ComboBox1.Location = New System.Drawing.Point(586, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Display
        '
        Me.Display.Enabled = False
        Me.Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display.Location = New System.Drawing.Point(354, 224)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(98, 37)
        Me.Display.TabIndex = 4
        Me.Display.Text = "Display"
        Me.Display.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Matrix Dimension"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(406, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nbr-Spaces"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MatDimension
        '
        Me.MatDimension.Location = New System.Drawing.Point(221, 40)
        Me.MatDimension.Name = "MatDimension"
        Me.MatDimension.Size = New System.Drawing.Size(127, 20)
        Me.MatDimension.TabIndex = 7
        '
        'Spaces
        '
        Me.Spaces.Location = New System.Drawing.Point(544, 11)
        Me.Spaces.Name = "Spaces"
        Me.Spaces.Size = New System.Drawing.Size(127, 20)
        Me.Spaces.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Upper or Lower Case"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioLower
        '
        Me.RadioLower.AutoSize = True
        Me.RadioLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioLower.Location = New System.Drawing.Point(125, 149)
        Me.RadioLower.Name = "RadioLower"
        Me.RadioLower.Size = New System.Drawing.Size(98, 19)
        Me.RadioLower.TabIndex = 10
        Me.RadioLower.TabStop = True
        Me.RadioLower.Text = "Lower case"
        Me.RadioLower.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(406, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Display Choice:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Matrix"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Matrix
        '
        Me.Matrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matrix.Location = New System.Drawing.Point(103, 198)
        Me.Matrix.Multiline = True
        Me.Matrix.Name = "Matrix"
        Me.Matrix.ReadOnly = True
        Me.Matrix.Size = New System.Drawing.Size(245, 167)
        Me.Matrix.TabIndex = 13
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(354, 288)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(98, 37)
        Me.Delete.TabIndex = 14
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 377)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Matrix)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioLower)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Spaces)
        Me.Controls.Add(Me.MatDimension)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioUpper)
        Me.Controls.Add(Me.Character)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Character As TextBox
    Friend WithEvents RadioUpper As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Display As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MatDimension As TextBox
    Friend WithEvents Spaces As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioLower As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Matrix As TextBox
    Friend WithEvents Delete As Button
End Class
