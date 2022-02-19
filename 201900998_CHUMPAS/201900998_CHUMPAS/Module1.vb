Module Module1
    Public Const mano_obra_small = 65.5
    Public Const mano_obra_medium = 85.99
    Public Const mano_obra_large = 99.99

    Public Const precio_yarda_algodon = 15.0
    Public Const precio_yarda_seda = 23.99
    Public Const precio_yarda_lona = 30.99

    Public Const cantidad_yarda_small = 2
    Public Const cantidad_yarda_medium = 2.5
    Public Const cantidad_yarda_large = 3

    Public precio_costo = 0
    Public precio_Venta = 0

    Sub limpiar()
        Form1.TextBox1.Clear()
        Form1.RBSMALL.Checked = False
        Form1.RBMEDIUM.Checked = False
        Form1.RBLARGE.Checked = False
        Form1.RBALGODÓN.Checked = False
        Form1.RBSEDA.Checked = False
        Form1.RBLONA.Checked = False

    End Sub

    Public Sub Calcular(material As String, tamaño As String, cantidad As Double)
        Select Case tamaño
            Case "Small"
                Select Case material
                    Case "Algodón"
                        precio_costo = cantidad * mano_obra_small + cantidad * precio_yarda_algodon * cantidad_yarda_small
                    Case "Seda"
                        precio_costo = cantidad * mano_obra_small + cantidad * precio_yarda_seda * cantidad_yarda_small
                    Case "Lona"
                        precio_costo = cantidad * mano_obra_small + cantidad * precio_yarda_lona * cantidad_yarda_small

                End Select
            Case "Medium"
                Select Case material
                    Case "Algodón"
                        precio_costo = cantidad * mano_obra_medium + cantidad * precio_yarda_algodon * cantidad_yarda_medium
                    Case "Seda"
                        precio_costo = cantidad * mano_obra_medium + cantidad * precio_yarda_seda * cantidad_yarda_medium
                    Case "Lona"
                        precio_costo = cantidad * mano_obra_medium + cantidad * precio_yarda_lona * cantidad_yarda_medium


                End Select
            Case "Large"
                Select Case material
                    Case "Algodón"
                        precio_costo = cantidad * mano_obra_large + cantidad * precio_yarda_algodon * cantidad_yarda_large
                    Case "Seda"
                        precio_costo = cantidad * mano_obra_large + cantidad * precio_yarda_seda * cantidad_yarda_large
                    Case "Lona"
                        precio_costo = cantidad * mano_obra_large + cantidad * precio_yarda_lona * cantidad_yarda_large
                End Select

        End Select
        Math.Round(precio_costo, 2)

        precio_Venta = precio_costo + 0.65 * precio_costo

        Math.Round(precio_Venta, 2)
    End Sub


End Module
