Public Class Form1
    Private Sub Clock1_Ring(sender As Object, e As EventArgs) Handles Clock1.Ring
        MessageBox.Show("The alarm rang")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class