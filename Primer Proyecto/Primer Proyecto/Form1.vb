Public Class Form1
    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12
    Public Clear As Integer = 0
    Dim PagosinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoconIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1A.Click
        PagosinIVA = (Val(TxtArroz.Text) * precioArroz) + (Val(TxtFrijol.Text) * precioFrijol) + (Val(TxtAzucar.Text) * precioAzucar)
        valorIVA = PagosinIVA * IVA
        pagoconIVA = PagosinIVA + valorIVA
        descuento = pagoconIVA * 0.025
        pagofinal = pagoconIVA - descuento


        LblR1.Text = PagosinIVA
        LblR2.Text = valorIVA
        LblR3.Text = pagoconIVA
        LblR4.Text = descuento
        LblR5.Text = pagofinal
    End Sub

    Private Sub Btn2L_Click(sender As Object, e As EventArgs) Handles Btn2L.Click
        TxtArroz.Clear()
        TxtFrijol.Clear()
        TxtAzucar.Clear()
        LblR1.Text = ""
        LblR2.Text = ""
        LblR3.Text = ""
        LblR4.Text = ""
        LblR5.Text = ""

    End Sub

    Private Sub Btn3S_Click(sender As Object, e As EventArgs) Handles Btn3S.Click
        Close()
    End Sub

    Private Sub TexArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArroz.KeyPress
        If Asc(e.KeyChar) <> 1 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFrijol.KeyPress
        If Asc(e.KeyChar) <> 1 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAzucar.KeyPress
        If Asc(e.KeyChar) <> 1 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class