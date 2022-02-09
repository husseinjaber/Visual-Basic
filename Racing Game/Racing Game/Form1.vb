Partial Class Form1
    Dim enemies(5), bombs(4) As PictureBox
    Dim count, number_of_presses, tick, number_of_destroyed_enemies As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enemies(0) = Enemy1
        enemies(1) = Enemy2
        enemies(2) = Enemy3
        enemies(3) = Enemy4
        enemies(4) = Enemy5
        Dim random_position As New Random()
        enemies(0).Location = New Point(random_position.Next(3, 20), random_position.Next(-Enemy1.Height, 10))
        enemies(1).Location = New Point(random_position.Next(23, 40), random_position.Next(60, 100))
        enemies(2).Location = New Point(random_position.Next(42, 60), random_position.Next(14, 25))
        enemies(3).Location = New Point(random_position.Next(63, 80), random_position.Next(30, 40))
        enemies(4).Location = New Point(random_position.Next(82, 90), random_position.Next(42, 58))
        Limit_Line.Location = New Point(3, 315)
        Enemy_Move.Start()
        Game_Over.Visible = False
        Charging_Bombs.Visible = False
        tick = 0
        count = 0
        number_of_destroyed_enemies = 0
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Charging_Bombs.Visible Or Game_Over.Visible Then
            Exit Sub
        End If
        If e.KeyCode = Keys.Right And Panzer.Left < Me.Width - Panzer.Width - 14 Then
            Move_Left.Stop()
            Move_Right.Start()
            Panzer.Left += 10
        ElseIf e.KeyCode = Keys.Left And Panzer.Left > 0 Then
            Move_Right.Stop()
            Move_Left.Start()
            Panzer.Left -= 10
        ElseIf number_of_presses = 0 And e.KeyCode = Keys.Space And count < 5 Then
            ReDim Preserve bombs(count)
            bombs(count) = New Bomb
            Controls.Add(bombs(count))
            bombs(count).Location = New Point(Panzer.Location.X + 24, Panzer.Location.Y - 35)
            Bomb_Move.Start()
            My.Computer.Audio.Play("C:\Users\Atab\Desktop\Panzer Bomb.wav", AudioPlayMode.Background)
            count += 1
            number_of_presses = 1
        End If
        If count = 5 And Charging_Bombs.Visible Then
            Wait_For_Charge.Start()
            count = 0
            For i = 0 To 4
                bombs(i).Dispose()
            Next
            Exit Sub
        End If

        If e.KeyCode = Keys.ControlKey Then
            Move_Left.Stop()
            Move_Right.Stop()
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Right Then
            Move_Left.Stop()
            Move_Right.Start()
        ElseIf e.KeyCode = Keys.Left Then
            Move_Right.Stop()
            Move_Left.Start()
        End If
        number_of_presses = 0
    End Sub

    Private Sub Move_Right_Tick(sender As Object, e As EventArgs) Handles Move_Right.Tick
        If Panzer.Left >= Me.Width - Panzer.Width - 14 Then
            Move_Right.Stop()
            Move_Left.Start()
        Else
            Panzer.Left += 2
        End If
    End Sub

    Private Sub Move_Left_Tick(sender As Object, e As EventArgs) Handles Move_Left.Tick
        If Panzer.Left <= 0 Then
            Move_Left.Stop()
            Move_Right.Start()
        Else
            Panzer.Left -= 2
        End If
    End Sub

    Private Sub Game_Over_Click(sender As Object, e As EventArgs) Handles Game_Over.Click
        Form1_Load(sender, e)

    End Sub

    Private Sub Last_Bomb_Tick(sender As Object, e As EventArgs) Handles Last_Bomb.Tick
        If bombs(4).Top >= -Bomb.Height - 30 Then
            bombs(4).Top -= 3
        Else
            count = 0
            Last_Bomb.Stop()
            Charging_Bombs.Visible = False
        End If
    End Sub

    Private Sub Bomb_Move_Tick(sender As Object, e As EventArgs) Handles Bomb_Move.Tick
        For i = 0 To count - 1
            For j = 0 To 4
                If bombs(i).Bounds.IntersectsWith(enemies(j).Bounds) Then
                    My.Computer.Audio.Play("C:\Users\Atab\Desktop\Enemy Explosion.wav", AudioPlayMode.Background)
                    bombs(i).Dispose()
                    number_of_destroyed_enemies += 1
                    Dim random_position As New Random()
                    enemies(j).Location = New Point(random_position.Next(0, 900), -Enemy1.Height * 1.5)
                Else
                    bombs(i).Top -= 3
                End If
            Next
            If count = 5 Then
                Charging_Bombs.Visible = True
                Last_Bomb.Start()
            End If
        Next

    End Sub

    Private Sub Wait_For_Charge_Tick(sender As Object, e As EventArgs) Handles Wait_For_Charge.Tick
        If tick = 1 Then
            Charging_Bombs.Visible = False
            tick = 0
            Wait_For_Charge.Stop()
            Exit Sub
        Else
            tick += 1
        End If
    End Sub

    Private Sub Enemy_Move_Tick(sender As Object, e As EventArgs) Handles Enemy_Move.Tick
        For i = 0 To 4
            If enemies(i).Bounds.IntersectsWith(Limit_Line.Bounds) Then
                Game_Over.Visible = True
                Enemy_Move.Stop()

            Else
                For j = 0 To 4
                    If enemies(i).Bounds.IntersectsWith(enemies(j).Bounds) And i <> j Then
                        Dim random_position As New Random()
                        enemies(j).Location = New Point(random_position.Next(0, 900), -Enemy1.Height * 1.5)
                    End If
                Next
            End If
            enemies(i).Top += 2
        Next
        If number_of_destroyed_enemies >= 5 Then
            Limit_Line.Top -= 10
            number_of_destroyed_enemies = 0
        End If
    End Sub
End Class