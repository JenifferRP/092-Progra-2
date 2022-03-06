Module Module1

    Public INDEX = 0
    Public TOTAL(5)
    Public DESCUENTO(5)
    Public RECARGO(5)

    Public NOMBRE(5)
    Public NIT(5)
    Public DIAS(5)
    Public HONORARIOS(5)
    Public HABITACION(5)
    Public SERVICIO(5)
    Public SUBTOTAL(5)

    Public ENCAMAMIENTO_PRIVADA = 350.0
    Public ENCAMAMIENTO_SEMIPRIVADA = 250.0
    Public ENCAMAMIENTO_NOPRIVADA = 150.0
    Public OPERACION_PRIVADA = 550.0
    Public OPERACION_SEMIPRIVADA = 400.0
    Public OPERACION_NOPRIVADA = 300.0
    Public MATERNIDAD_PRIVADA = 450.0
    Public MATERNIDAD_SEMIPRIVADA = 350.0
    Public MATERNIDAD_NOPRIVADA = 250.0

    Public Const DESCUENTO_EFECTIVO = 15 / 100
    Public Const DESCUENTO_CHEQUE = 15 / 100
    Public Const DESCUENTO_DEBITO = 8 / 100
    Public Const RECARGO_CRÉDITO = 5 / 100




    Sub LIMPIAR_VECTORES()
        ReDim SUBTOTAL(5)
        ReDim TOTAL(5)
        ReDim DESCUENTO(5)
        ReDim RECARGO(5)
        ReDim NOMBRE(5)
        ReDim NIT(5)
        ReDim DIAS(5)
        ReDim HONORARIOS(5)
        ReDim HABITACION(5)
        ReDim SERVICIO(5)
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
        Form1.ListBox10.Items.Clear()
        Form1.ListBox11.Items.Clear()

    End Sub

    Sub LIMPIAR_ENTRADAS()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTNIT.Clear()
        Form1.TXTHONORARIOS.Clear()
        Form1.TXTDIAS.Clear()
        Form1.RBPRIVADA.Checked = False
        Form1.RBSEMI.Checked = False
        Form1.RBNOPRIV.Checked = False
        Form1.CBEFECTIVO.Checked = False
        Form1.CBCHEQUE.Checked = False
        Form1.CBDEBITO.Checked = False
        Form1.CBCREDITO.Checked = False
        Form1.CBENCAMA.Checked = False
        Form1.CBMATERNIDAD.Checked = False
        Form1.CBOPERACION.Checked = False



    End Sub


    Public Sub Calcular(HABITACION As String, SERVICIO As String, CANTIDAD As Double)
        Select Case HABITACION
            Case "PRIVADA"
                Select Case SERVICIO
                    Case "ENCAMAMIENTO"
                        SUBTOTAL(INDEX) = CANTIDAD * ENCAMAMIENTO_PRIVADA

                    Case "OPERACION"
                        SUBTOTAL(INDEX) = CANTIDAD * OPERACION_PRIVADA

                    Case "MATERNIDAD"
                        SUBTOTAL(INDEX) = CANTIDAD * MATERNIDAD_PRIVADA

                End Select
            Case "SEMI PRIVADA"
                Select Case SERVICIO
                    Case "ENCAMAMIENTO"
                        SUBTOTAL(INDEX) = CANTIDAD * ENCAMAMIENTO_SEMIPRIVADA
                    Case "OPERACION"
                        SUBTOTAL(INDEX) = CANTIDAD * OPERACION_SEMIPRIVADA
                    Case "MATERNIDAD"
                        SUBTOTAL(INDEX) = CANTIDAD * MATERNIDAD_SEMIPRIVADA
                End Select
            Case "NO PRIVADA"
                Select Case SERVICIO
                    Case "ENCAMAMIENTO"
                        SUBTOTAL(INDEX) = CANTIDAD * ENCAMAMIENTO_NOPRIVADA
                    Case "OPERACION"
                        SUBTOTAL(INDEX) = CANTIDAD * OPERACION_NOPRIVADA
                    Case "MATERNIDAD"
                        SUBTOTAL(INDEX) = CANTIDAD * MATERNIDAD_NOPRIVADA
                End Select
                Math.Round(SUBTOTAL(INDEX), 2)

        End Select

        If (Form1.CBEFECTIVO.Checked) Then
            DESCUENTO(INDEX) = SUBTOTAL(INDEX) * DESCUENTO_EFECTIVO
            TOTAL(INDEX) = SUBTOTAL(INDEX) * 0.85
            RECARGO(INDEX) = 0


        End If

        If (Form1.CBCHEQUE.Checked) Then
            DESCUENTO(INDEX) = SUBTOTAL(INDEX) * DESCUENTO_CHEQUE
            TOTAL(INDEX) = SUBTOTAL(INDEX) * 0.85
            RECARGO(INDEX) = 0

        End If

        If (Form1.CBDEBITO.Checked) Then
            DESCUENTO(INDEX) = SUBTOTAL(INDEX) * DESCUENTO_DEBITO
            TOTAL(INDEX) = SUBTOTAL(INDEX) * 0.9
            RECARGO(INDEX) = 0


        End If

        If (Form1.CBCREDITO.Checked) Then
            RECARGO(INDEX) = SUBTOTAL(INDEX) * RECARGO_CRÉDITO
            TOTAL(INDEX) = SUBTOTAL(INDEX) + (SUBTOTAL(INDEX) * RECARGO_CRÉDITO)
            DESCUENTO(INDEX) = 0
        End If


    End Sub
End Module
