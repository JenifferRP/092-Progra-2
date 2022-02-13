Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CBCOMPRA.CheckedChanged
        If CBCOMPRA.Checked = True Then
            txtC.Enabled = True
        Else
            txtC.Enabled = False
        End If
    End Sub

    Private Sub CBVENTA_CheckedChanged(sender As Object, e As EventArgs) Handles CBVENTA.CheckedChanged
        If CBVENTA.Checked = True Then
            txtV.Enabled = True
        Else
            txtV.Enabled = False
        End If
    End Sub

    Private Sub BTconfirmar_Click(sender As Object, e As EventArgs) Handles BTconfirmar.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BTlimpiar_Click(sender As Object, e As EventArgs) Handles BTlimpiar.Click
        If (MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            limpiar()
        Else
            txtC.Focus()

        End If
    End Sub

    Private Sub BTsalir_Click(sender As Object, e As EventArgs) Handles BTsalir.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Mensaje de salida") = vbYes) Then
            Me.Close()
        Else
            txtC.Focus()
        End If
    End Sub
End Class