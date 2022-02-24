Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            Limpiar()
        Else
            Txtnombre.Focus()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Mensaje de salida") = vbYes) Then
            Me.Close()
        Else
            Txtnombre.Focus()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If CBVE.Checked Then
            Label1.Text = "El monto del seguro es" + Str(Sueldo - segurove)
        Else
            If CBACC.Checked Then
                Label1.Text = "El monto del seguro es" + Str(Sueldo - segurove)
            End If

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If CBN.Checked Then
            Label4.Text = "El sueldo final es" + Str(Sueldo + ViaticosN)
        Else
        End If
        If CBS.Checked Then
            Label4.Text = "El sueldo final es" + Str(Sueldo + ViaticosS)
        End If

        If CBOR.Checked Then
            Label4.Text = "El sueldo final es" + Str(Sueldo + ViaticosOR)
        End If

        If CBOCC.Checked Then
            Label4.Text = "El sueldo final es" + Str(Sueldo + ViaticosOCC)
        End If



    End Sub


End Class
