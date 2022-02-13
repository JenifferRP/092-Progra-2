Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        MsgBox(Form1.Label2.Text)
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Form1.RbDC.Checked Then
            Label3.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.txtC.Text, tcDolar))
        Else
            If Form1.RBPC.Checked Then
                Label3.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.txtC.Text, tcPM))
            Else
                If Form1.RBEC.Checked Then
                    Label3.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.txtC.Text, tccEuro))
                Else
                    If Form1.RBCRC.Checked Then
                        Label3.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.txtC.Text, tcCCR))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Form1.RBDV.Checked Then
            Label2.Text = "La cantidad de tu venta es: " + Str(calcularVenta(Form1.txtC.Text, tcDolar))
        Else
            If Form1.RBPV.Checked Then
                Label2.Text = "La cantidad de tu venta es: " + Str(calcularVenta(Form1.txtC.Text, tcPM))
            Else
                If Form1.RBEV.Checked Then
                    Label2.Text = "La cantidad de tu venta es: " + Str(calcularVenta(Form1.txtC.Text, tccEuro))
                Else
                    If Form1.RBCRV.Checked Then
                        Label2.Text = "La cantidad de tu venta es: " + Str(calcularVenta(Form1.txtC.Text, tcCCR))
                    End If
                End If
            End If
        End If
    End Sub
End Class