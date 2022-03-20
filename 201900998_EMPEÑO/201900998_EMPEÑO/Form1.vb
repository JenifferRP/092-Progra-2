Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Mensaje de salida") = vbYes) Then
            Me.Close()
        Else
            TXTNOMBRE.Focus()

        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If CONTADOR < 6 Then
            MATRIZ(CONTADOR, 0) = TXTNOMBRE.Text
            MATRIZ(CONTADOR, 1) = TXTCUI.Text
            MATRIZ(CONTADOR, 2) = TXTDIRECCIÓN.Text
            MATRIZ(CONTADOR, 3) = Val(TXTCOSTO.Text)


            If RBLARGO.Checked Then
                MATRIZ(CONTADOR, 5) = RBLARGO.Text
            End If

            If RBCORTO.Checked Then
                MATRIZ(CONTADOR, 5) = RBCORTO.Text

            End If

            If CBLAPTOP.Checked Then
                MATRIZ(CONTADOR, 4) = CBLAPTOP.Text

            End If

            If CBTELEFONO.Checked Then
                MATRIZ(CONTADOR, 4) = CBTELEFONO.Text

            End If
            If CBTV.Checked Then
                MATRIZ(CONTADOR, 4) = CBTV.Text

            End If
            If CBREFRI.Checked Then
                MATRIZ(CONTADOR, 4) = CBREFRI.Text

            End If

            If CBTV.Checked And RBCORTO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_TV_CORTO
                MATRIZ(CONTADOR, 7) = 0
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            If CBTV.Checked And RBLARGO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_TV_LARGO
                MATRIZ(CONTADOR, 7) = 0
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            If CBTELEFONO.Checked And RBCORTO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_TELEFONO_CORTO
                MATRIZ(CONTADOR, 7) = 0
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            If CBTELEFONO.Checked And RBLARGO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_TELEFONO_LARGO

                MATRIZ(CONTADOR, 7) = 0
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            If CBLAPTOP.Checked And RBCORTO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_LAPTOP_CORTO
                MATRIZ(CONTADOR, 7) = 0
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            If CBLAPTOP.Checked And RBLARGO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_LAPTOP_LARGO
                MATRIZ(CONTADOR, 7) = 0
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)

            End If

            If CBREFRI.Checked And RBCORTO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_REFRI_CORTO
                MATRIZ(CONTADOR, 7) = 0
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            If CBREFRI.Checked And RBLARGO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_REFRI_LARGO
                MATRIZ(CONTADOR, 7) = 0
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)

            End If

            If CBTV.Checked And CBREFRI.Checked And RBCORTO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_TV_CORTO + PRECIO_REFRI_CORTO
                MATRIZ(CONTADOR, 7) = MATRIZ(CONTADOR, 6) * DESC1
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            If CBTV.Checked And CBREFRI.Checked And RBLARGO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_TV_LARGO + PRECIO_REFRI_LARGO
                MATRIZ(CONTADOR, 7) = MATRIZ(CONTADOR, 6) * DESC2
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If


            If CBTELEFONO.Checked And CBLAPTOP.Checked And RBLARGO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_TELEFONO_LARGO + PRECIO_LAPTOP_LARGO
                MATRIZ(CONTADOR, 7) = MATRIZ(CONTADOR, 6) * DESC3
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            If CBTELEFONO.Checked And CBLAPTOP.Checked And RBCORTO.Checked Then
                MATRIZ(CONTADOR, 6) = PRECIO_TELEFONO_CORTO + PRECIO_LAPTOP_CORTO
                MATRIZ(CONTADOR, 7) = MATRIZ(CONTADOR, 6) * DESC4
                MATRIZ(CONTADOR, 8) = MATRIZ(CONTADOR, 6) - MATRIZ(CONTADOR, 7)
            End If

            ListBox1.Items.Add(MATRIZ(CONTADOR, 0))
                ListBox2.Items.Add(MATRIZ(CONTADOR, 1))
                ListBox3.Items.Add(MATRIZ(CONTADOR, 2))
                ListBox4.Items.Add(MATRIZ(CONTADOR, 3))
                ListBox5.Items.Add(MATRIZ(CONTADOR, 4))
                ListBox6.Items.Add(MATRIZ(CONTADOR, 5))
            ListBox7.Items.Add(MATRIZ(CONTADOR, 6))
            ListBox8.Items.Add(MATRIZ(CONTADOR, 7))
            ListBox9.Items.Add(MATRIZ(CONTADOR, 8))
        End If


    End Sub

    Private Sub LIMPIARMATRIZENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZENTRADASToolStripMenuItem.Click
        If (MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            limpiar_MATRIZ_ENTRADAS()
        Else
            TXTNOMBRE.Focus()
        End If

    End Sub

    Private Sub LIMPIARLISTBOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARLISTBOXToolStripMenuItem.Click
        If (MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "Mensaje para limpiar") = vbYes) Then
            LIMPIAR_LISTBOX()
        Else
            TXTNOMBRE.Focus()
        End If

    End Sub
End Class
