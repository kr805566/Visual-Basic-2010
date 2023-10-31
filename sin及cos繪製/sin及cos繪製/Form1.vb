Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As Graphics = PictureBox1.CreateGraphics()
        Dim x, y, h As Integer
        Dim i As Double

        h = PictureBox1.Height / 2                 '垂直中心
        p.DrawLine(Pens.Black, 0, 0, 0, h * 2)     '垂直線
        p.DrawLine(Pens.Black, 0, h, 800, h)       '水平線


        For i = 0 To 3.1415926535897931 * 2 Step 0.01    ' 0 到 2*pi
            x = Int(i * 100)                             ' x座標
            y = Int(Math.Sin(i) * -100) + h              ' y座標

            p.DrawRectangle(Pens.Blue, x, y, 1, 1)       '繪製(x,y)
        Next i

        MsgBox(Math.Acos(Math.Cos(Math.PI)) / Math.PI * 180)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim p As Graphics = PictureBox1.CreateGraphics()
        Dim x, y, h As Integer
        Dim i As Double

        h = PictureBox1.Height / 2
        p.DrawLine(Pens.Black, 0, 0, 0, h * 2)
        p.DrawLine(Pens.Black, 0, h, 800, h)


        For i = 0 To 3.1415926535897931 * 2 Step 0.01
            x = Int(i * 100)
            y = Int(Math.Cos(i) * -100) + h

            p.DrawRectangle(Pens.Red, x, y, 1, 1)
        Next i
    End Sub

    
 
End Class
