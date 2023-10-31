Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As Graphics = PictureBox1.CreateGraphics()
        Dim n, h, x, y, 往右移 As Integer
        Dim s, yt, pi As Double
        pi = 3.1415926535897931
        n = (Val(TextBox1.Text))
        s = Val(TextBox2.Text)
        h = PictureBox1.Height / 2
        往右移 = 50


        p.Clear(Color.White)
        p.DrawRectangle(Pens.Black, 0 + 往右移, h + 50, 600, 1)
        p.DrawRectangle(Pens.Black, 0 + 往右移, h - 150, 1, 200)

        For i = -50 To 150 Step 10
            If i Mod 50 = 0 Then

                p.DrawRectangle(Pens.Black, 0 + 往右移 - 10, h - i, 10, 1)
                p.DrawString(Format(i / 100, "0.0"), Me.Font, Brushes.Black, 0 + 往右移 - 30, h - i - 5)
            Else
                p.DrawRectangle(Pens.Black, 0 + 往右移 - 5, h - i, 5, 1)
            End If
        Next

        For t = -3 To 3 + s Step s

            yt = 0.5
            For k = 1 To n Step 2

                yt = yt + 2 / (k * pi) * Math.Cos(k * pi * t + (((-1) ^ ((k - 1) / 2) - 1) * pi / 2))


            Next
            x = Int(t * 100)
            y = Int(yt * 100)
            p.DrawRectangle(Pens.Blue, x + 300 + 往右移, -y + h, 1, 1)


            If x Mod 10 = 0 Then
                p.DrawRectangle(Pens.Black, x + 300 + 往右移, h, 5, 1)
                p.DrawRectangle(Pens.Black, x + 300 + 往右移, 50 + h, 1, 5)
            End If
            If x Mod 50 = 0 Then
                p.DrawRectangle(Pens.Black, x + 300 + 往右移, 50 + h, 1, 10)
                p.DrawString(Format(x / 100, "0.0"), Me.Font, Brushes.Black, x + 300 + 往右移 - 10, 50 + h + 10)
            End If

        Next



    End Sub
End Class
