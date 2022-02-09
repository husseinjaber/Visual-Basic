Public Class Bomb
    Inherits PictureBox
    Public Sub New()
        With Me
            .Size = New Size(29, 35)
            .Location = New Point(Form1.Panzer.Location.X + 24, Form1.Panzer.Location.Y - 35)
            .BackgroundImageLayout = ImageLayout.Stretch
            .Image = Form1.Bomb.Image
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
    End Sub
End Class
