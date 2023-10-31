Public Class Form1
    Dim a(), b(), c()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim 最長位數

        最長位數 = Len(TextBox1.Text)
        If Len(TextBox2.Text) > 最長位數 Then 最長位數 = Len(TextBox2.Text)

        ReDim a(最長位數), b(最長位數), c(最長位數 + 1)

        For i = 1 To Len(TextBox1.Text)

            a(i) = Mid(TextBox1.Text, Len(TextBox1.Text) - i + 1, 1)

        Next

        For i = 1 To Len(TextBox2.Text)

            b(i) = Mid(TextBox2.Text, Len(TextBox2.Text) - i + 1, 1)

        Next


        For i = 1 To 最長位數

            c(i) = Val(a(i)) + Val(b(i)) + Val(c(i))
            c(i + 1) = Val(c(i + 1)) + Val(c(i)) \ 10
            c(i) = Val(c(i)) Mod 10
        Next i



        TextBox3.Text = ""

        If c(最長位數 + 1) <> "0" Then 最長位數 = 最長位數 + 1

        For i = 最長位數 To 1 Step -1
            TextBox3.Text = TextBox3.Text & c(i)

        Next
    End Sub
End Class
