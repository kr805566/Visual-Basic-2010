Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call 遞迴(Val(TextBox1.Text), Val(TextBox2.Text))
    End Sub


    Function 遞迴(ByVal m As Integer, ByVal n As Integer)
        If n = 0 Then TextBox3.Text = m Else Call 遞迴(n, m Mod n)


    End Function
End Class
