﻿Public Class Form1

    Function 遞迴(ByVal n As Integer) As Integer
        If n = 1 Then 遞迴 = 0 Else 遞迴 = n * (n - 1) + 遞迴(n - 1)
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = 遞迴(Val(TextBox1.Text))
    End Sub

   
End Class
