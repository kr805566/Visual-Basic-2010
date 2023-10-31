Public Class Form1

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Val(TextBox2.Text)
        TextBox1.Text = ""
        For i = 0 To n
            TextBox1.Text = TextBox1.Text & Space((n - i) * 2)
            For j = 0 To i
                TextBox1.Text = TextBox1.Text & j
            Next j

            For j = i - 1 To 0 Step -1
                TextBox1.Text = TextBox1.Text & j
            Next j
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next i


        For i = n - 1 To 0 Step -1
            TextBox1.Text = TextBox1.Text & Space((n - i) * 2)
            For j = 0 To i
                TextBox1.Text = TextBox1.Text & j
            Next j

            For j = i - 1 To 0 Step -1
                TextBox1.Text = TextBox1.Text & j
            Next j
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next i
       

    End Sub
End Class
