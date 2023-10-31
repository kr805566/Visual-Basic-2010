Public Class Form1

    Function 遞迴(ByVal m As Integer, ByVal n As Integer) As Integer
        If m = 0 Then
            遞迴 = n + 1
        ElseIf n = 0 Then
            遞迴 = 遞迴(m - 1, 1)
        Else
            遞迴 = 遞迴(m - 1, 遞迴(m, n - 1))
        End If
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = 遞迴(Val(TextBox1.Text), Val(TextBox2.Text))
    End Sub

 
End Class
