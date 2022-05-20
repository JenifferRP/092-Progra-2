Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTPERSONAS.TextChanged

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click

        If (RBSENCILLA.Checked) Then
            CABINA(INDEX) = RBSENCILLA.Text
        ElseIf RBDOBLE.Checked Then
            CABINA(INDEX) = RBDOBLE.Text
        ElseIf RBCOMPARTIDA.Checked Then
            CABINA(INDEX) = RBCOMPARTIDA.Text
        End If


        If (RBSENCILLA.Checked) And (RBPRIMERA.Checked) Then
            PRECIO_INDIVIDUAL(INDEX) = PRECIO_SENCILLA_PRIMERA
            TOTAL(INDEX) = Val(TXTPERSONAS.Text) * PRECIO_INDIVIDUAL(INDEX)

        End If
        If (RBSENCILLA.Checked) And (RBSEGUNDA.Checked) Then
            PRECIO_INDIVIDUAL(INDEX) = PRECIO_SENCILLA_SEGUNDA
            TOTAL(INDEX) = Val(TXTPERSONAS.Text) * PRECIO_INDIVIDUAL(INDEX)

        End If
        If (RBDOBLE.Checked) And (RBPRIMERA.Checked) Then
            PRECIO_INDIVIDUAL(INDEX) = PRECIO_DOBLE_PRIMERA
            TOTAL(INDEX) = Val(TXTPERSONAS.Text) * PRECIO_INDIVIDUAL(INDEX)

        End If
        If (RBDOBLE.Checked) And (RBSEGUNDA.Checked) Then
            PRECIO_INDIVIDUAL(INDEX) = PRECIO_DOBLE_SEGUNDA
            TOTAL(INDEX) = Val(TXTPERSONAS.Text) * PRECIO_INDIVIDUAL(INDEX)

        End If
        If (RBCOMPARTIDA.Checked) And (RBPRIMERA.Checked) Then
            PRECIO_INDIVIDUAL(INDEX) = PRECIO_COMPARTIDA_PRIMERA
            TOTAL(INDEX) = Val(TXTPERSONAS.Text) * PRECIO_INDIVIDUAL(INDEX)

        End If
        If (RBCOMPARTIDA.Checked) And (RBSEGUNDA.Checked) Then
            PRECIO_INDIVIDUAL(INDEX) = PRECIO_COMPARTIDA_SEGUNDA
            TOTAL(INDEX) = Val(TXTPERSONAS.Text) * PRECIO_INDIVIDUAL(INDEX)

        End If


    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub LIMPIARLISTBOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARLISTBOXToolStripMenuItem.Click
        LIMPIAR_LISTBOX()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class
