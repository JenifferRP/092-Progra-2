Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (POSICION <= 6) Then
            NOMBRE_(POSICION) = TXTNOMBRE.Text
            NIT_(POSICION) = TXTNIT.Text
            DIAS_(POSICION) = Val(TXTDIAS.Text)
            HABITACION_(POSICION) = CBHABITACION.Text
            PAGO_(POSICION) = CBPAGO.Text

            If CBHABITACION.SelectedItem Then

                Select Case CBHABITACION.SelectedIndex
                    Case "SENCILLA"
                        TPARCIAL(POSICION) = Val(TXTDIAS.Text) * PRECIO_SENCILLA
                        TOTAL_(POSICION) = TPARCIAL(POSICION)
                    Case "DOBLE"
                        TPARCIAL(POSICION) = Val(TXTDIAS.Text) * PRECIO_DOBLE
                        TOTAL_(POSICION) = TPARCIAL(POSICION)
                    Case "CABAÑA"
                        TPARCIAL(POSICION) = Val(TXTDIAS.Text) * PRECIO_CABAÑA
                        TOTAL_(POSICION) = TPARCIAL(POSICION)
                End Select

            End If
            If CBPAGO.SelectedItem Then
                Select Case CBPAGO.SelectedIndex
                    Case "EFCTIVO"
                        DESCUENTO_(POSICION) = TPARCIAL(POSICION) * 0.15
                        TOTAL_(POSICION) = TPARCIAL(POSICION) * 0.85
                    Case "TARJETA CRÉDITO"
                        DESCUENTO_(POSICION) = TPARCIAL(POSICION) * 0.03
                        TOTAL_(POSICION) = TPARCIAL(POSICION) + DESCUENTO_(POSICION)
                    Case "TARJETA DÉBITO"
                        DESCUENTO_(POSICION) = TPARCIAL(POSICION) * 0.03
                        TOTAL_(POSICION) = TPARCIAL(POSICION) + DESCUENTO_(POSICION)

                End Select
            End If
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR()
    End Sub
End Class
