Public Class Form1
    Private Sub ENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADASToolStripMenuItem.Click
        If (MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            LIMPIAR_ENTRADAS()
        Else
            TXTNOMBRE.Focus()
        End If

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If RBPRIVADA.Checked = False And RBNOPRIV.Checked = False And RBSEMI.Checked = False Then
            MsgBox("No ha elegido tipo de habitación")

        End If

        If CBENCAMA.Checked = False And CBOPERACION.Checked = False And CBMATERNIDAD.Checked = False Then
            MsgBox("No ha elegido un servicio")

        End If
        If CBCHEQUE.Checked = False And CBCREDITO.Checked = False And CBDEBITO.Checked = False And CBEFECTIVO.Checked = False Then
            MsgBox("No ha elegido tipo de pago")

        End If

        If TXTNOMBRE.Text = "" Then
            MsgBox("Ingrese nombre del paciente")

        End If
        If TXTNIT.Text = "" Then
            MsgBox("Ingrese número de NIT")

        End If
        If TXTHONORARIOS.Text = "" Then
            MsgBox("Ingrese honorarios del médico")
            End
        End If
        If TXTDIAS.Text = "" Then
            MsgBox("Ingrese días de hospitalización")
            End
        End If

        Dim HABITACION As String
        Dim SERVICIO As String
        Dim PAGO As String

        If CBCHEQUE.Checked Then
            PAGO = "CHEQUE"
        ElseIf CBEFECTIVO.Checked Then
            PAGO = "EFECTIVO"
        ElseIf CBDEBITO.Checked Then
            PAGO = "TARJETA DÉBITO"
        Else
            PAGO = "TARJETA CRÉDITO"
        End If

        If RBPRIVADA.Checked Then
            HABITACION = "PRIVADA"
        ElseIf RBSEMI.Checked Then
            HABITACION = "SEMI PRIVADA"
        Else
            HABITACION = "NO PRIVADA"
        End If

        If CBENCAMA.Checked Then
            SERVICIO = "ENCAMAMIENTO"
        ElseIf CBOPERACION.Checked Then
            SERVICIO = "OPERACION"
        Else
            SERVICIO = "MATERNIDAD"
        End If

        Calcular(HABITACION, SERVICIO, Val(TXTDIAS.Text))
        ListBox8.Items.Add(SUBTOTAL(INDEX))
        ListBox9.Items.Add(DESCUENTO(INDEX))
        ListBox10.Items.Add(RECARGO(INDEX))
        ListBox11.Items.Add(TOTAL(INDEX))
        ListBox1.Items.Add(TXTNOMBRE.Text)
        ListBox2.Items.Add(TXTNIT.Text)
        ListBox3.Items.Add(TXTHONORARIOS.Text)
        ListBox4.Items.Add(TXTDIAS.Text)
        ListBox5.Items.Add(HABITACION)
        ListBox6.Items.Add(SERVICIO)
        ListBox7.Items.Add(PAGO)



        INDEX = INDEX + 1

    End Sub

    Private Sub LISTBOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTBOXToolStripMenuItem.Click
        If (MsgBox("¿Desea limpiar los vectores/listbox?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            LIMPIAR_VECTORES()
        Else
            TXTNOMBRE.Focus()
        End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Mensaje de salida") = vbYes) Then
            Me.Close()
        Else
            TXTNOMBRE.Focus()

        End If
    End Sub
End Class
