Module Module1
    Public MATRIZ(7, 10)

    Public INDICE = 0
    Public Const PRECIO_INGLES = 150
    Public Const PRECIO_PORTUGUES = 80
    Public Const PRECIO_FRANCES = 125

    Public Const DESCUENTO1_EFECTIVO = 2 / 100
    Public Const DESCUENTO1_CHEQUE = 1.5 / 100
    Public Const DESCUENTO2_DIAS = 5 / 100






    Sub LIMPIAR()
        ReDim MATRIZ(7, 10)
        Form1.TXTCARNE.Clear()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTHORAS.Clear()
        Form1.RBEFECTIVO.Checked = False
        Form1.RBCHEQUE.Checked = False

    End Sub

    Public Sub PAGO_PARCIAL()

        Select Case (Form1.RBFRANCES.Checked And Form1.RBINGLES.Checked And Form1.RBPORTU.Checked)
            Case 0
                MATRIZ(7, INDICE) = Str(PRECIO_INGLES * MATRIZ(5, INDICE))

            Case 1
                MATRIZ(7, INDICE) = Str(PRECIO_FRANCES * MATRIZ(5, INDICE))

            Case 2
                MATRIZ(7, INDICE) = Str(PRECIO_PORTUGUES * MATRIZ(5, INDICE))


        End Select

    End Sub

    Function DESCUENTO1()

        If (Form1.RBCHEQUE.Checked) Then
            DESCUENTO1 = Str(MATRIZ(7, INDICE) * DESCUENTO1_CHEQUE)

        ElseIf (Form1.RBEFECTIVO.Checked) Then
            DESCUENTO1 = Str(MATRIZ(7, INDICE) * DESCUENTO1_EFECTIVO)
        End If
        Return DESCUENTO1
    End Function

    Sub PAGO_FINAL()
        MATRIZ(10, INDICE) = Str(Val(MATRIZ(7, INDICE)) - (Val(MATRIZ(8, INDICE))))
    End Sub


End Module
