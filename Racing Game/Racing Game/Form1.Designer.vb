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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Limit_Line = New System.Windows.Forms.PictureBox()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy4 = New System.Windows.Forms.PictureBox()
        Me.Panzer = New System.Windows.Forms.PictureBox()
        Me.Enemy5 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Enemy3 = New System.Windows.Forms.PictureBox()
        Me.Bomb = New System.Windows.Forms.PictureBox()
        Me.Move_Right = New System.Windows.Forms.Timer(Me.components)
        Me.Move_Left = New System.Windows.Forms.Timer(Me.components)
        Me.Bomb_Move = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy_Move = New System.Windows.Forms.Timer(Me.components)
        Me.Charging_Bombs = New System.Windows.Forms.PictureBox()
        Me.Wait_For_Charge = New System.Windows.Forms.Timer(Me.components)
        Me.Game_Over = New System.Windows.Forms.PictureBox()
        Me.Last_Bomb = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Limit_Line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panzer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bomb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Charging_Bombs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Game_Over, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Limit_Line
        '
        Me.Limit_Line.BackColor = System.Drawing.Color.DarkRed
        Me.Limit_Line.Location = New System.Drawing.Point(3, 315)
        Me.Limit_Line.Name = "Limit_Line"
        Me.Limit_Line.Size = New System.Drawing.Size(941, 2)
        Me.Limit_Line.TabIndex = 0
        Me.Limit_Line.TabStop = False
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.Color.Transparent
        Me.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Enemy1.ErrorImage = Nothing
        Me.Enemy1.Image = CType(resources.GetObject("Enemy1.Image"), System.Drawing.Image)
        Me.Enemy1.Location = New System.Drawing.Point(226, 171)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(39, 79)
        Me.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy1.TabIndex = 9
        Me.Enemy1.TabStop = False
        '
        'Enemy4
        '
        Me.Enemy4.BackColor = System.Drawing.Color.Transparent
        Me.Enemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Enemy4.ErrorImage = Nothing
        Me.Enemy4.Image = CType(resources.GetObject("Enemy4.Image"), System.Drawing.Image)
        Me.Enemy4.Location = New System.Drawing.Point(426, 12)
        Me.Enemy4.Name = "Enemy4"
        Me.Enemy4.Size = New System.Drawing.Size(39, 79)
        Me.Enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy4.TabIndex = 14
        Me.Enemy4.TabStop = False
        '
        'Panzer
        '
        Me.Panzer.BackColor = System.Drawing.Color.Transparent
        Me.Panzer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panzer.ErrorImage = Nothing
        Me.Panzer.Image = CType(resources.GetObject("Panzer.Image"), System.Drawing.Image)
        Me.Panzer.Location = New System.Drawing.Point(391, 321)
        Me.Panzer.Name = "Panzer"
        Me.Panzer.Size = New System.Drawing.Size(92, 101)
        Me.Panzer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Panzer.TabIndex = 16
        Me.Panzer.TabStop = False
        '
        'Enemy5
        '
        Me.Enemy5.BackColor = System.Drawing.Color.Transparent
        Me.Enemy5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Enemy5.ErrorImage = Nothing
        Me.Enemy5.Image = CType(resources.GetObject("Enemy5.Image"), System.Drawing.Image)
        Me.Enemy5.Location = New System.Drawing.Point(67, 90)
        Me.Enemy5.Name = "Enemy5"
        Me.Enemy5.Size = New System.Drawing.Size(39, 79)
        Me.Enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy5.TabIndex = 17
        Me.Enemy5.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.Color.Transparent
        Me.Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Enemy2.ErrorImage = Nothing
        Me.Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), System.Drawing.Image)
        Me.Enemy2.Location = New System.Drawing.Point(829, 12)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(39, 79)
        Me.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy2.TabIndex = 18
        Me.Enemy2.TabStop = False
        '
        'Enemy3
        '
        Me.Enemy3.BackColor = System.Drawing.Color.Transparent
        Me.Enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Enemy3.ErrorImage = Nothing
        Me.Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), System.Drawing.Image)
        Me.Enemy3.Location = New System.Drawing.Point(658, 119)
        Me.Enemy3.Name = "Enemy3"
        Me.Enemy3.Size = New System.Drawing.Size(39, 79)
        Me.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy3.TabIndex = 19
        Me.Enemy3.TabStop = False
        '
        'Bomb
        '
        Me.Bomb.BackColor = System.Drawing.Color.Transparent
        Me.Bomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Bomb.ErrorImage = Nothing
        Me.Bomb.Image = CType(resources.GetObject("Bomb.Image"), System.Drawing.Image)
        Me.Bomb.Location = New System.Drawing.Point(416, 286)
        Me.Bomb.Name = "Bomb"
        Me.Bomb.Size = New System.Drawing.Size(29, 35)
        Me.Bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bomb.TabIndex = 20
        Me.Bomb.TabStop = False
        Me.Bomb.Visible = False
        '
        'Move_Right
        '
        Me.Move_Right.Interval = 10
        '
        'Move_Left
        '
        Me.Move_Left.Interval = 10
        '
        'Bomb_Move
        '
        Me.Bomb_Move.Interval = 10
        '
        'Enemy_Move
        '
        '
        'Charging_Bombs
        '
        Me.Charging_Bombs.Image = CType(resources.GetObject("Charging_Bombs.Image"), System.Drawing.Image)
        Me.Charging_Bombs.Location = New System.Drawing.Point(300, 119)
        Me.Charging_Bombs.Name = "Charging_Bombs"
        Me.Charging_Bombs.Size = New System.Drawing.Size(310, 131)
        Me.Charging_Bombs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Charging_Bombs.TabIndex = 21
        Me.Charging_Bombs.TabStop = False
        Me.Charging_Bombs.Visible = False
        '
        'Wait_For_Charge
        '
        Me.Wait_For_Charge.Interval = 2000
        '
        'Game_Over
        '
        Me.Game_Over.Image = CType(resources.GetObject("Game_Over.Image"), System.Drawing.Image)
        Me.Game_Over.Location = New System.Drawing.Point(300, 119)
        Me.Game_Over.Name = "Game_Over"
        Me.Game_Over.Size = New System.Drawing.Size(310, 131)
        Me.Game_Over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Game_Over.TabIndex = 22
        Me.Game_Over.TabStop = False
        Me.Game_Over.Visible = False
        '
        'Last_Bomb
        '
        Me.Last_Bomb.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(946, 424)
        Me.Controls.Add(Me.Game_Over)
        Me.Controls.Add(Me.Charging_Bombs)
        Me.Controls.Add(Me.Bomb)
        Me.Controls.Add(Me.Enemy3)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy5)
        Me.Controls.Add(Me.Panzer)
        Me.Controls.Add(Me.Enemy4)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.Limit_Line)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.MaximizeBox = False
        Me.Name = "Form1"
        CType(Me.Limit_Line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panzer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bomb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Charging_Bombs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Game_Over, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Limit_Line As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Enemy4 As PictureBox
    Friend WithEvents Panzer As PictureBox
    Friend WithEvents Enemy5 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Bomb As PictureBox
    Friend WithEvents Move_Right As Timer
    Friend WithEvents Move_Left As Timer
    Friend WithEvents Bomb_Move As Timer
    Friend WithEvents Enemy_Move As Timer
    Friend WithEvents Charging_Bombs As PictureBox
    Friend WithEvents Wait_For_Charge As Timer
    Friend WithEvents Game_Over As PictureBox
    Friend WithEvents Last_Bomb As Timer
End Class
