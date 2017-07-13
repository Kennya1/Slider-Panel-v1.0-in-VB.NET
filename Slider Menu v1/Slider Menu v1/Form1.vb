Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Show" Then
            Do Until Panel1.Location.X = 0
                Panel1.Location = New Point(Panel1.Location.X + 1, 0)
                System.Threading.Thread.Sleep(2)
                Button1.Text = "Hide"
                Me.Refresh()
            Loop
        Else
            Do Until Panel1.Location.X = -115
                Panel1.Location = New Point(Panel1.Location.X - 1, 0)
                System.Threading.Thread.Sleep(2)
                Button1.Text = "Show"
                Me.Refresh()
            Loop
        End If
    End Sub
End Class
