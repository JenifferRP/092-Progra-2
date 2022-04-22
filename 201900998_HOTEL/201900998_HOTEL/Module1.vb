Module Module1

    Public Const PRECIO_SENCILLA = 250
    Public Const PRECIO_DOBLE = 400
    Public Const PRECIO_CABAÑA = 650

    Public POSICION As Byte = 0
    Public NOMBRE_(7)
    Public NIT_(7) As String
    Public DIAS_(7) As String
    Public IMPUESTO_(7) As Double
    Public HABITACION_(7)
    Public PAGO_(7)
    Public TPARCIAL(7)
    Public DESCUENTO_(7)
    Public TOTAL_(7)

    Sub MOSTRAR()
        Dim z As Byte
        For z = 0 To 6
            If TOTAL_(z) <> Nothing Then
                Form1.DataGridView1.Columns.Add(NOMBRE_(z))

            Else
                Exit For
            End If
        Next z

    End Sub
End Module
