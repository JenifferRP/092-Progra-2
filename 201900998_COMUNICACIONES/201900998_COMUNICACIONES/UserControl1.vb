Public Class UserControl1

    Private Sub BTNCALCULAR_Click(sender As Object, e As EventArgs) Handles BTNCALCULAR.Click

        Dim ARTICULO As String
        If RTABLET.Checked Then

            COMISION(INDEX) = PRECIO_TABLET * PORCENTAJE_COMISION
            SUELDO_FINAL(INDEX) = COMISION(INDEX) + Val(TXTVALOR.Text)
        End If

        If RBDRONE.Checked Then

            COMISION(INDEX) = PRECIO_DRONE * PORCENTAJE_COMISION
            SUELDO_FINAL(INDEX) = COMISION(INDEX) + Val(TXTVALOR.Text)
        End If

        If RBCELULAR.Checked Then

            COMISION(INDEX) = PRECIO_CELULAR * PORCENTAJE_COMISION
            SUELDO_FINAL(INDEX) = COMISION(INDEX) + Val(TXTVALOR.Text)
        End If



        If RBTELE.Checked Then

            COMISION(INDEX) = PRECIO_TELE * PORCENTAJE_COMISION
            SUELDO_FINAL(INDEX) = COMISION(INDEX) + Val(TXTVALOR.Text)
        End If

        If RBCELULAR.Checked Then
            ARTICULO = "CELULAR"
        ElseIf RBDRONE.Checked Then
            ARTICULO = "DRONE"
        ElseIf RTABLET.Checked Then
            ARTICULO = "TABLET"
        Else
            ARTICULO = "TELEVISOR"
        End If

        ListBox1.Items.Add(TXTNOMBRE.Text)
        ListBox2.Items.Add(TXTVALOR.Text)
        ListBox3.Items.Add(RBCELULAR.Text)
        ListBox3.Items.Add(RBDRONE.Text)
        ListBox3.Items.Add(RTABLET.Text)
        ListBox3.Items.Add(RBTELE.Text)
        ListBox4.Items.Add(COMISION(INDEX))

        ListBox6.Items.Add(SUELDO_FINAL(INDEX))
    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        LIMPIAR()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Mensaje de salida") = vbYes) Then

        Else
            TXTNOMBRE.Focus()

        End If
    End Sub
End Class
