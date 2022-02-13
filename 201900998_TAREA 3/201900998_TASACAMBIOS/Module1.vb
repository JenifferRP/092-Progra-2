Module Module1
    Public Const tcDolar = 7.69
    Public Const tcPM = 0.38
    Public Const tccEuro = 7.89
    Public Const tcCCR = 0.012

    Const comisionCompra = 2.5 / 100
    Const comisionVenta = 3 / 100

    Dim Total_parcial = 0
    Dim total



    Sub limpiar()
        Form1.txtC.Clear()
        Form1.txtV.Clear()
        Form1.CBCOMPRA.Checked = False
        Form1.CBVENTA.Checked = False

        Form2.Label2.Text = "Limpio"
        Form2.Label3.Text = "Limpio"
    End Sub

    Function calcularCompra(cantidadVenta As Double, tipoVenta As Double) As Double
        If cantidadVenta > 0 Then
            Total_parcial = cantidadVenta / tipoVenta
            total = Total_parcial * comisionVenta + Total_parcial
        End If
        Return Math.Round(total, 2)

    End Function

    Function calcularVenta(cantidadCompra As Double, tipoCompra As Double) As Double
        If cantidadCompra > 0 Then
            Total_parcial = cantidadCompra * tipoCompra
            total = Total_parcial * comisionCompra + Total_parcial
        End If
        Return Math.Round(total, 2)

    End Function
End Module
