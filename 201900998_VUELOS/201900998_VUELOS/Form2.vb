Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtsubtotal.Text = subtotal
        Txtdescuento.Text = descuento
        Txttotal.Text = total


    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class