Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n, s, xxxx, y
        n = 8
        TextBox1.Text = ""
        s = f(n, "")
        TextBox1.Text = Mid(TextBox1.Text, 4, Len(TextBox1.Text) - 3) & "=" & s


        xxxx = "ABCD"
        y = Strings.Mid(xxxx, 2, 2)
        MsgBox(y)
    End Sub


    Function f(ByVal x As Integer, ByVal s As String)



        If x >= 10 Then
            TextBox1.Text = TextBox1.Text & "= " & s & "+" & "f(" & x & ")" & vbCrLf
            f = 1
        ElseIf x < 5 Then

            TextBox1.Text = TextBox1.Text & "= " & s & "+" & "f(" & x & ")" & vbCrLf
            f = 7 * x + f(x + 2, CStr(Val(s) + 7 * x))
        Else

            TextBox1.Text = TextBox1.Text & "= " & s & "+" & "f(" & x & ")" & vbCrLf
            f = 30 * x + f(x + 3, CStr(Val(s) + 30 * x))
        End If

    End Function

 
End Class
