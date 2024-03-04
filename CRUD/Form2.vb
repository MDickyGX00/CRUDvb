Public Class Form2
    Sub childForm(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False

        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        childForm(Form1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        childForm(Form2)
    End Sub
End Class