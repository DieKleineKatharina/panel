Public Class Form1
    Private Sub NachOben(sender As Object, e As EventArgs) Handles Button1.MouseHover
        panMove.Location = New Point(panMove.Location.X,
                                     panMove.Location.Y - 10)
    End Sub

    Private Sub NachRechts(sender As Object, e As EventArgs) Handles Button2.Click
        panMove.Location = New Point(
           panMove.Location.X + 10,
           panMove.Location.Y)
    End Sub

    Private Sub NachUnten(sender As Object, e As EventArgs) Handles Button3.Click
        panMove.Location = New Point(
            panMove.Location.X,
            panMove.Location.Y + 10)
    End Sub

    Private Sub NachLinks(sender As Object, e As EventArgs) Handles Button4.Click
        panMove.Location = New Point(panMove.Location.X - 10,
            panMove.Location.Y)
    End Sub
End Class
