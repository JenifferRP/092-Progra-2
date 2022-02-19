Public Class Form1



    Private Sub BTNCALCULAR_Click(sender As Object, e As EventArgs) Handles BTNCALCULAR.Click
        If RBSMALL.Checked = False And RBMEDIUM.Checked = False And RBLARGE.Checked = False Then
            MsgBox("No ha elegido un tamaño")
            End
        End If

        If RBALGODÓN.Checked = False And RBSEDA.Checked = False And RBLONA.Checked = False Then
            MsgBox("No ha elegido material")
            End
        End If

        If TextBox1.Text = "" Then
            MsgBox("Ingrese una cantidad")
            End
        End If

        Dim tamaño As String
        Dim material As String

        If RBSMALL.Checked Then
            tamaño = "Small"
        ElseIf RBMEDIUM.Checked Then
            tamaño = "Medium"
        Else
            tamaño = "Large"
        End If

        If RBSEDA.Checked Then
            material = "Seda"
        ElseIf RBALGODÓN.Checked Then
            material = "Algodón"
        Else
            material = "Lona"
        End If

        Calcular(material, tamaño, Val(TextBox1.Text))
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
