Public Class Form1

    Function 遞迴(ByVal n As Integer)
        If n = 1 Or n = 2 Then 遞迴 = 1 Else 遞迴 = 遞迴(n - 1) + 遞迴(n - 2)

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = 遞迴(Val(TextBox1.Text))
    End Sub
End Class
