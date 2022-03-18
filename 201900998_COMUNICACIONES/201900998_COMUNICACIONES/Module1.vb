Module Module1

    Public PRECIO_TABLET = 375
    Public PRECIO_DRONE = 560
    Public PRECIO_CELULAR = 1450
    Public PRECIO_TELE = 3250

    Public INDEX = 0
    Public COMISION(6)
    Public BONO(6)
    Public SUELDO_FINAL(6)

    Public NOMBRE(6)
    Public VALOR(6)
    Public ARTICULOS(6)

    Public Const PORCENTAJE_COMISION = 5.5 / 100
    Public Const BONO1 = 3 / 100
    Public Const BONO2 = 4 / 100
    Public Const BONO3 = 5 / 100




    Sub LIMPIAR()
        ReDim COMISION(6)
        ReDim BONO(6)
        ReDim SUELDO_FINAL(6)
        ReDim NOMBRE(6)
        ReDim VALOR(6)
        ReDim ARTICULOS(6)

    End Sub


End Module
