Public Class Form1
    Private Sub BTNCALCULAR_Click(sender As Object, e As EventArgs) Handles BTNCALCULAR.Click
        If RBAvioneta.Checked = False And RBHeli.Checked = False And RBJet.Checked = False Then
            MsgBox("No ha elegido tipo de areonave")
            End
        End If

        If CBCOSTA.Checked = False And CBIzabal.Checked = False And CBPetén.Checked = False Then
            MsgBox("No ha elegido destino")
            End
        End If

        If TextBox1.Text = "" Then
            MsgBox("Ingrese cantidad de pasajeros")
            End
        End If

        Dim tipo As String
        Dim destino As String

        If RBAvioneta.Checked Then
            tipo = "Avioneta"
        ElseIf RBJet.Checked Then
            tipo = "Jet"
        Else
            tipo = "Helicóptero"
        End If

        If CBCOSTA.Checked Then
            destino = "Costa Sur"
        ElseIf CBIzabal.Checked Then
            destino = "Izabal"
        Else
            destino = "Petén"
        End If

        Calcular(tipo, destino, Val(TextBox1.Text))
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        If (MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            limpiar()
        Else
            TextBox1.Focus()

        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Mensaje de salida") = vbYes) Then
            Me.Close()
        Else
            TextBox1.Focus()
        End If
    End Sub


End Class
