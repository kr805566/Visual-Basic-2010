Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As Graphics = PictureBox1.CreateGraphics()
        Dim m, n, h, x, y As Integer
        m = TextBox1.Text '  m=-15
        n = TextBox2.Text '  m= 15 ==> -15~15的圖形
        h = PictureBox1.Height / 2   '取垂直中間
        p.Clear(Color.White)         '畫面清除

        For i = m To n Step 0.01

            x = i * 20    ' x座標



            If x = 0 Then
                'p.DrawRectangle(Pens.Black, x - m * 20, -100 + h, 1, 130)   ' x=0 y軸上的垂直
                p.DrawLine(Pens.Black, x - m * 20, h - 100, x - m * 20, h - 100 + 130)   ' x=0 y軸上的垂直


                For j = -20 To 100 Step 5 '畫刻度,每間隔像素5 劃一橫
                    p.DrawRectangle(Pens.Black, x - m * 20, h - j, 5, 1)     ' x=0 y軸上每一格的刻度橫線
                    If j Mod 20 = 0 And j <> 0 Then p.DrawString(j / 100, Me.Font, Brushes.Black, x - m * 20 - 25, h - j)
                    ' x=0 y軸上每一格的刻度
                Next
            Else
                If x Mod 100 = 0 Then
                    p.DrawRectangle(Pens.Black, x - m * 20, h - 5, 1, 5)  ' x軸上 每一格的刻度橫線
                    p.DrawString(x / 20, Me.Font, Brushes.Black, x - m * 20, h + 5) ' x軸上 每一格的刻度
                End If
                If x Mod 20 = 0 Then
                    p.DrawRectangle(Pens.Black, x - m * 20, h - 3, 1, 3) ' x軸上 每一格的刻度橫線
                End If

                y = Int(Math.Sin(i) / i * -100) + h     'y座標
                p.DrawRectangle(Pens.Black, x - m * 20, h, 1, 1)  '繪製水平線
                p.DrawRectangle(Pens.Blue, x - m * 20, y, 1, 1)   '繪製(x,y)

            End If
        Next


    End Sub
End Class
