Public Class Form1

    Dim Ax, Ay, Bx, By, Cx, Cy, 每格寬度, P_H, P_W As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim p As Graphics = PictureBox1.CreateGraphics
        P_H = PictureBox1.Height / 2
        P_W = PictureBox1.Width / 2

        每格寬度 = 20


        p.DrawLine(Pens.Black, P_W + 每格寬度 * -10, P_H, P_W + 每格寬度 * 10, P_H)
        p.DrawLine(Pens.Black, P_W, P_H + 每格寬度 * -10, P_W, P_H + 每格寬度 * 10)


        For i = -10 To 10
            p.DrawLine(Pens.Black, P_W + 每格寬度 * i, P_H - 5, P_W + 每格寬度 * i, P_H + 5)
            p.DrawLine(Pens.Black, P_W - 5, P_H + 每格寬度 * i, P_W + 5, P_H + 每格寬度 * i)
        Next





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim p As Graphics = PictureBox1.CreateGraphics

        Ax = Val(TextBox1.Text) * 每格寬度 + P_W
        Ay = -Val(TextBox2.Text) * 每格寬度 + P_H
        Bx = Val(TextBox3.Text) * 每格寬度 + P_W
        By = -Val(TextBox4.Text) * 每格寬度 + P_H
        Cx = Val(TextBox5.Text) * 每格寬度 + P_W
        Cy = -Val(TextBox6.Text) * 每格寬度 + P_H

        p.FillRectangle(Brushes.Red, Ax, Ay, 5, 5)
        p.FillRectangle(Brushes.Green, Bx, By, 5, 5)
        p.FillRectangle(Brushes.Blue, Cx, Cy, 5, 5)

        p.DrawString("A", Me.Font, Brushes.Black, Ax + 5, Ay)
        p.DrawString("B", Me.Font, Brushes.Black, Bx + 5, By)
        p.DrawString("C", Me.Font, Brushes.Black, Cx + 5, Cy)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p As Graphics = PictureBox1.CreateGraphics
        p.DrawLine(Pens.Red, Ax, Ay, Bx, By)
        p.DrawLine(Pens.Green, Bx, By, Cx, Cy)
        p.DrawLine(Pens.Blue, Cx, Cy, Ax, Ay)

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim p As Graphics = PictureBox1.CreateGraphics
        p.Clear(Color.White)
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim a, b, c, s As Double

        a = Math.Sqrt((Bx - Cx) ^ 2 + (By - Cy) ^ 2) / 每格寬度
        b = Math.Sqrt((Ax - Cx) ^ 2 + (Ay - Cy) ^ 2) / 每格寬度
        c = Math.Sqrt((Bx - Ax) ^ 2 + (By - Ay) ^ 2) / 每格寬度
        s = (a + b + c) / 2

        Label8.Text = Int(Math.Sqrt(s * (s - a) * (s - b) * (s - c))) & " 平方單位"
        Label9.Text = Int(Math.Acos((b ^ 2 + c ^ 2 - a ^ 2) / (2 * b * c)) / Math.PI * 180 + 0.5) & " 度"
        Label10.Text = Int(Math.Acos((a ^ 2 + c ^ 2 - b ^ 2) / (2 * a * c)) / Math.PI * 180 + 0.5) & " 度"
        Label11.Text = Int(Math.Acos((b ^ 2 + a ^ 2 - c ^ 2) / (2 * b * a)) / Math.PI * 180 + 0.5) & " 度"

    End Sub
End Class
