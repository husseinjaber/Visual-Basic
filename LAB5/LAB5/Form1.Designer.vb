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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Save_File = New System.Windows.Forms.Button()
        Me.Load_File = New System.Windows.Forms.Button()
        Me.Font_Change = New System.Windows.Forms.Button()
        Me.Color_Change = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(219, 170)
        Me.TextBox1.TabIndex = 0
        '
        'Save_File
        '
        Me.Save_File.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_File.Location = New System.Drawing.Point(6, 12)
        Me.Save_File.Name = "Save_File"
        Me.Save_File.Size = New System.Drawing.Size(121, 44)
        Me.Save_File.TabIndex = 1
        Me.Save_File.Text = "Save"
        Me.Save_File.UseVisualStyleBackColor = True
        '
        'Load_File
        '
        Me.Load_File.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load_File.Location = New System.Drawing.Point(6, 138)
        Me.Load_File.Name = "Load_File"
        Me.Load_File.Size = New System.Drawing.Size(121, 44)
        Me.Load_File.TabIndex = 2
        Me.Load_File.Text = "Load"
        Me.Load_File.UseVisualStyleBackColor = True
        '
        'Font_Change
        '
        Me.Font_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Font_Change.Location = New System.Drawing.Point(358, 12)
        Me.Font_Change.Name = "Font_Change"
        Me.Font_Change.Size = New System.Drawing.Size(121, 44)
        Me.Font_Change.TabIndex = 3
        Me.Font_Change.Text = "Font"
        Me.Font_Change.UseVisualStyleBackColor = True
        '
        'Color_Change
        '
        Me.Color_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color_Change.Location = New System.Drawing.Point(358, 138)
        Me.Color_Change.Name = "Color_Change"
        Me.Color_Change.Size = New System.Drawing.Size(121, 44)
        Me.Color_Change.TabIndex = 4
        Me.Color_Change.Text = "Color"
        Me.Color_Change.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(133, 188)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(219, 44)
        Me.Delete.TabIndex = 5
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 253)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Color_Change)
        Me.Controls.Add(Me.Font_Change)
        Me.Controls.Add(Me.Load_File)
        Me.Controls.Add(Me.Save_File)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Save_File As Button
    Friend WithEvents Load_File As Button
    Friend WithEvents Font_Change As Button
    Friend WithEvents Color_Change As Button
    Friend WithEvents Delete As Button
End Class
