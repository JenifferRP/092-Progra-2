Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub GUARDASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDASToolStripMenuItem.Click
        If (INDEX <= 11) Then
            NACIONALIDAD(INDEX) = CBNACIONALIDAD.Text
            EQUIPO(INDEX) = CBEQUIPO.Text
            ETAPA(INDEX) = Val(TXTETAPA.Text)
            KM(INDEX) = Val(TXTKM.Text)
            TIEMPO(INDEX) = Val(TXTTIEMPO.Text)
            PENALIZACIONRECOMPENSA()

            INDEX = INDEX + 1

        End If
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        NACIONALIDAD(INDEX) = CBNACIONALIDAD.Text
        EQUIPO(INDEX) = CBEQUIPO.Text
        KM(INDEX) = Val(TXTKM.Text)
        TIEMPO(INDEX) = Val(TXTTIEMPO.Text)

        PENALIZACIONRECOMPENSA()
        INDEX = I


    End Sub
End Class
