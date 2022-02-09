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
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.checksavenext = New System.Windows.Forms.CheckBox()
        Me.radioconsult = New System.Windows.Forms.RadioButton()
        Me.combodep = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.G3 = New System.Windows.Forms.TextBox()
        Me.G2 = New System.Windows.Forms.TextBox()
        Me.G1 = New System.Windows.Forms.TextBox()
        Me.txtaverage = New System.Windows.Forms.TextBox()
        Me.txtrank = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radiomodify = New System.Windows.Forms.RadioButton()
        Me.btnmax = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnpre = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.checksavepre = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(143, 10)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(121, 20)
        Me.txtname.TabIndex = 1
        '
        'checksavenext
        '
        Me.checksavenext.AutoSize = True
        Me.checksavenext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checksavenext.Location = New System.Drawing.Point(12, 225)
        Me.checksavenext.Name = "checksavenext"
        Me.checksavenext.Size = New System.Drawing.Size(68, 24)
        Me.checksavenext.TabIndex = 2
        Me.checksavenext.Text = "Save"
        Me.checksavenext.UseVisualStyleBackColor = True
        '
        'radioconsult
        '
        Me.radioconsult.AutoSize = True
        Me.radioconsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioconsult.Location = New System.Drawing.Point(609, 14)
        Me.radioconsult.Name = "radioconsult"
        Me.radioconsult.Size = New System.Drawing.Size(116, 21)
        Me.radioconsult.TabIndex = 3
        Me.radioconsult.TabStop = True
        Me.radioconsult.Text = "Consultation"
        Me.radioconsult.UseVisualStyleBackColor = True
        '
        'combodep
        '
        Me.combodep.FormattingEnabled = True
        Me.combodep.Location = New System.Drawing.Point(143, 43)
        Me.combodep.Name = "combodep"
        Me.combodep.Size = New System.Drawing.Size(121, 21)
        Me.combodep.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(423, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Average"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Department"
        '
        'G3
        '
        Me.G3.Location = New System.Drawing.Point(266, 134)
        Me.G3.Name = "G3"
        Me.G3.Size = New System.Drawing.Size(121, 20)
        Me.G3.TabIndex = 8
        '
        'G2
        '
        Me.G2.Location = New System.Drawing.Point(139, 134)
        Me.G2.Name = "G2"
        Me.G2.Size = New System.Drawing.Size(121, 20)
        Me.G2.TabIndex = 9
        '
        'G1
        '
        Me.G1.Location = New System.Drawing.Point(12, 134)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(121, 20)
        Me.G1.TabIndex = 10
        '
        'txtaverage
        '
        Me.txtaverage.Location = New System.Drawing.Point(426, 134)
        Me.txtaverage.Name = "txtaverage"
        Me.txtaverage.ReadOnly = True
        Me.txtaverage.Size = New System.Drawing.Size(121, 20)
        Me.txtaverage.TabIndex = 11
        '
        'txtrank
        '
        Me.txtrank.Location = New System.Drawing.Point(601, 134)
        Me.txtrank.Name = "txtrank"
        Me.txtrank.ReadOnly = True
        Me.txtrank.Size = New System.Drawing.Size(121, 20)
        Me.txtrank.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(598, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Rank"
        '
        'radiomodify
        '
        Me.radiomodify.AutoSize = True
        Me.radiomodify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiomodify.Location = New System.Drawing.Point(609, 48)
        Me.radiomodify.Name = "radiomodify"
        Me.radiomodify.Size = New System.Drawing.Size(113, 21)
        Me.radiomodify.TabIndex = 14
        Me.radiomodify.TabStop = True
        Me.radiomodify.Text = "Modification"
        Me.radiomodify.UseVisualStyleBackColor = True
        '
        'btnmax
        '
        Me.btnmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmax.Location = New System.Drawing.Point(281, 186)
        Me.btnmax.Name = "btnmax"
        Me.btnmax.Size = New System.Drawing.Size(121, 33)
        Me.btnmax.TabIndex = 21
        Me.btnmax.Text = "Maximum"
        Me.btnmax.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(547, 225)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(121, 33)
        Me.btnupdate.TabIndex = 22
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(674, 186)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(121, 33)
        Me.btndel.TabIndex = 23
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(547, 186)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(121, 33)
        Me.btninsert.TabIndex = 24
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnpre
        '
        Me.btnpre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpre.Location = New System.Drawing.Point(139, 186)
        Me.btnpre.Name = "btnpre"
        Me.btnpre.Size = New System.Drawing.Size(121, 33)
        Me.btnpre.TabIndex = 25
        Me.btnpre.Text = "Previous"
        Me.btnpre.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(12, 186)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(121, 33)
        Me.btnnext.TabIndex = 26
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnmin
        '
        Me.btnmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmin.Location = New System.Drawing.Point(408, 186)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(121, 33)
        Me.btnmin.TabIndex = 27
        Me.btnmin.Text = "Minimum"
        Me.btnmin.UseVisualStyleBackColor = True
        '
        'checksavepre
        '
        Me.checksavepre.AutoSize = True
        Me.checksavepre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checksavepre.Location = New System.Drawing.Point(139, 225)
        Me.checksavepre.Name = "checksavepre"
        Me.checksavepre.Size = New System.Drawing.Size(68, 24)
        Me.checksavepre.TabIndex = 28
        Me.checksavepre.Text = "Save"
        Me.checksavepre.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 294)
        Me.Controls.Add(Me.checksavepre)
        Me.Controls.Add(Me.btnmin)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnpre)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnmax)
        Me.Controls.Add(Me.radiomodify)
        Me.Controls.Add(Me.txtrank)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtaverage)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.G2)
        Me.Controls.Add(Me.G3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.combodep)
        Me.Controls.Add(Me.radioconsult)
        Me.Controls.Add(Me.checksavenext)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents checksavenext As CheckBox
    Friend WithEvents radioconsult As RadioButton
    Friend WithEvents combodep As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents G3 As TextBox
    Friend WithEvents G2 As TextBox
    Friend WithEvents G1 As TextBox
    Friend WithEvents txtaverage As TextBox
    Friend WithEvents txtrank As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents radiomodify As RadioButton
    Friend WithEvents btnmax As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btninsert As Button
    Friend WithEvents btnpre As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnmin As Button
    Friend WithEvents checksavepre As CheckBox
End Class
