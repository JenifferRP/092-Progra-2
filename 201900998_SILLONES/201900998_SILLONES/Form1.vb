Public Class Form1
    Private Sub CALCULAEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULAEToolStripMenuItem.Click

        If CBTAMAÑO.SelectedIndex = -1 Then
            MsgBox("Seleccione tipo de tamaño")
            Exit Sub
        End If

        If RBCUERO.Checked = False And RBCUERINA.Checked = False Then
            MsgBox("Seleccione tipo de material")
            Exit Sub
        End If


        If RBCUERO.Checked Then
            MATERIAL(CONTADOR) = RBCUERO.Text


        End If

        If RBCUERINA.Checked Then
            MATERIAL(CONTADOR) = RBCUERINA.Text

        End If
        If CONTADOR < 8 Then
            NUMERO_VENTA(CONTADOR) = CONTADOR + 1
            TAMAÑO(CONTADOR) = CBTAMAÑO.SelectedItem


            Dim PRECIO, YARDAS As Decimal

            Select Case TAMAÑO(CONTADOR)
                Case "SOFÁ"
                    Select Case MATERIAL(CONTADOR)
                        Case "CUERO"
                            PRECIO_MANO_OBRA(CONTADOR) = MANO_OBRA_SOFA
                            PRECIO_COSTO(CONTADOR) = CANTIDAD_YARDA_SOFA * PRECIO_YARDA_CUERO + PRECIO_MANO_OBRA(CONTADOR)
                        Case "CUERINA"
                            PRECIO_MANO_OBRA(CONTADOR) = MANO_OBRA_SOFA
                            PRECIO_COSTO(CONTADOR) = CANTIDAD_YARDA_SOFA * PRECIO_YARDA_CUERINA + PRECIO_MANO_OBRA(CONTADOR)
                    End Select
                    Math.Round(PRECIO_COSTO(CONTADOR), 2)
                    Math.Round(PRECIO_MANO_OBRA(CONTADOR), 2)

                Case "INDIVIDUAL"
                    Select Case MATERIAL(CONTADOR)
                        Case "CUERO"
                            PRECIO_MANO_OBRA(CONTADOR) = MANO_OBRA_SOFA
                            PRECIO_COSTO(CONTADOR) = CANTIDAD_YARDA_INDIV * PRECIO_YARDA_CUERO + PRECIO_MANO_OBRA(CONTADOR)
                        Case "CUERINA"
                            PRECIO_MANO_OBRA(CONTADOR) = MANO_OBRA_INDIV
                            PRECIO_COSTO(CONTADOR) = CANTIDAD_YARDA_INDIV * PRECIO_YARDA_CUERINA + PRECIO_MANO_OBRA(CONTADOR)
                    End Select
                    Math.Round(PRECIO_COSTO(CONTADOR), 2)
                    Math.Round(PRECIO_MANO_OBRA(CONTADOR), 2)

                Case "DOBLE"
                    Select Case MATERIAL(CONTADOR)
                        Case "CUERO"
                            PRECIO_MANO_OBRA(CONTADOR) = MANO_OBRA_DOBLE
                            PRECIO_COSTO(CONTADOR) = CANTIDAD_YARDA_DOBLE * PRECIO_YARDA_CUERO + PRECIO_MANO_OBRA(CONTADOR)
                        Case "CUERINA"
                            PRECIO_MANO_OBRA(CONTADOR) = MANO_OBRA_DOBLE
                            PRECIO_COSTO(CONTADOR) = CANTIDAD_YARDA_DOBLE * PRECIO_YARDA_CUERINA + PRECIO_MANO_OBRA(CONTADOR)
                    End Select
                    Math.Round(PRECIO_COSTO(CONTADOR), 2)
                    Math.Round(PRECIO_MANO_OBRA(CONTADOR), 2)
            End Select

            PRECIO_VENTA(CONTADOR) = PRECIO_COSTO(CONTADOR) * 1.65
            Math.Round(PRECIO_VENTA(CONTADOR), 2)


            ListBox1.Items.Add(NUMERO_VENTA(CONTADOR))
            ListBox2.Items.Add(TAMAÑO(CONTADOR))
            ListBox3.Items.Add(MATERIAL(CONTADOR))
            ListBox4.Items.Add(PRECIO_MANO_OBRA(CONTADOR))
            ListBox5.Items.Add(PRECIO_COSTO(CONTADOR))
            ListBox6.Items.Add(PRECIO_VENTA(CONTADOR))
            CONTADOR = CONTADOR + 1

        Else
            MsgBox("Se ha llegado al límite de registros")
        End If
    End Sub

    Private Sub LIMPIARVECTORESENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESENTRADASToolStripMenuItem.Click

        If (MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            LIMPIAR_VECTORES()
        Else
            CBTAMAÑO.Focus()
        End If

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Mensaje de salida") = vbYes) Then
            Me.Close()
        Else
            CBTAMAÑO.Focus()

        End If
    End Sub

    Private Sub LIMPIARGRIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARGRIDToolStripMenuItem.Click
        If (MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            LIMPIAR_LISTBOX()
        Else
            CBTAMAÑO.Focus()
        End If

    End Sub
End Class
