Public Class Form1

    Private Sub BTNCALCULAR_Click(sender As Object, e As EventArgs) Handles BTNCALCULAR.Click

        If TXTCARNE.Text = "" Then
            MsgBox("Error Campo Carné")
            Exit Sub
        End If

        If TXTNOMBRE.Text = "" Then
            MsgBox("Error Campo Nombre")
            Exit Sub
        End If

        If CBXDIAS.SelectedIndex = 0 Then
            MsgBox("Error Campo Días")
            Exit Sub
        End If

        If TXTHORAS.Text = "" Then
            MsgBox("Error Campo Horas")
            Exit Sub
        End If

        If RBCHEQUE.Checked = False And RBEFECTIVO.Checked = False Then
            MsgBox("Error Campo Método de Pago")
            Exit Sub
        End If

        If RBFRANCES.Checked = False And RBINGLES.Checked = False And RBPORTU.Checked = False Then
            MsgBox("Error Campo Idioma")
            Exit Sub
        End If

        If INDICE < 8 Then
            MATRIZ(0, INDICE) = TXTCARNE.Text
            MATRIZ(1, INDICE) = TXTNOMBRE.Text
            MATRIZ(3, INDICE) = DTPFECHA.Value
            MATRIZ(4, INDICE) = CBXDIAS.SelectedItem
            MATRIZ(5, INDICE) = TXTHORAS.Text
            PAGO_PARCIAL()
            MATRIZ(8, INDICE) = DESCUENTO1()

            If RBFRANCES.Checked = False Then
                MATRIZ(2, INDICE) = "FRANCÉS"
            ElseIf RBINGLES.Checked Then
                MATRIZ(2, INDICE) = "INGLÉS"
            ElseIf RBPORTU.Checked Then
                MATRIZ(2, INDICE) = "PORTUGUÉS"

            End If


            If RBCHEQUE.Checked Then
                MATRIZ(6, INDICE) = RBCHEQUE.Text
            ElseIf RBEFECTIVO.Checked Then
                MATRIZ(6, INDICE) = RBEFECTIVO.Text
            End If

            DataGridView1.Rows.Add(INDICE + 1, MATRIZ(0, INDICE), MATRIZ(1, INDICE), MATRIZ(2, INDICE), MATRIZ(3, INDICE), MATRIZ(4, INDICE), MATRIZ(5, INDICE), MATRIZ(6, INDICE), MATRIZ(7, INDICE), MATRIZ(8, INDICE), MATRIZ(9, INDICE), MATRIZ(10, INDICE))
            INDICE = INDICE + 1


            Else
                MessageBox.Show("Ya se llegó al límite")

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Mensaje de salida") = vbYes) Then
            Me.Close()
        Else
            TXTCARNE.Focus()

        End If
    End Sub
End Class
