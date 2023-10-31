Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c
        Dim m, n As Integer
        n = Len(TextBox1.Text)  '數字A長度
        m = Len(TextBox2.Text)  '數字B長度
        ReDim a(n), b(m), c(n + m) '重新宣告陣列大小

        For i = 1 To n
            a(i) = Mid(TextBox1.Text, n - i + 1, 1) ' 將A數字 每一位數 放入陣列a()           
        Next i

        For i = 1 To m
            b(i) = Mid(TextBox2.Text, m - i + 1, 1) ' 將B數字 每一位數 放入陣列b()
        Next i

        For i = 1 To m
            For j = 1 To n

                c(j + i - 1) = c(j + i - 1) + a(j) * b(i) '將 a() b() 放入陣列的數 互相乘

            Next j
        Next i

        For i = 1 To m + n - 1
            c(i + 1) = c(i + 1) + c(i) \ 10   ' 判斷 c() 是否大於9
            c(i) = c(i) Mod 10                ' 並且作修正
        Next i

        TextBox3.Text = ""

        For i = 1 To m + n
            If i = m + n And c(m + n) = 0 Then Exit For ' 判斷第一位不為零
            TextBox3.Text = c(i) & TextBox3.Text

        Next i

    End Sub
End Class
