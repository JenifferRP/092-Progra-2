Module Module1
    Public Const MANO_OBRA_SOFA = 250.99
    Public Const MANO_OBRA_INDIV = 150.99
    Public Const MANO_OBRA_DOBLE = 200.99

    Public Const PRECIO_YARDA_CUERO = 75
    Public Const PRECIO_YARDA_CUERINA = 45.99

    Public Const CANTIDAD_YARDA_SOFA = 8
    Public Const CANTIDAD_YARDA_INDIV = 3.5
    Public Const CANTIDAD_YARDA_DOBLE = 6


    Public TAMAÑO(8)
    Public MATERIAL(8)
    Public NUMERO_VENTA(8)
    Public PRECIO_COSTO(8)
    Public PRECIO_MANO_OBRA(8)
    Public PRECIO_VENTA(8)



    Public CONTADOR = 0

    Sub LIMPIAR_VECTORES()
        ReDim TAMAÑO(8)
        ReDim MATERIAL(8)
        ReDim NUMERO_VENTA(8)
        ReDim PRECIO_COSTO(8)
        ReDim PRECIO_MANO_OBRA(8)
        ReDim PRECIO_VENTA(8)
        Form1.CBTAMAÑO.SelectedIndex = -1
        Form1.RBCUERINA.Checked = False
        Form1.RBCUERO.Checked = False
    End Sub

    Sub LIMPIAR_LISTBOX()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
    End Sub


End Module

