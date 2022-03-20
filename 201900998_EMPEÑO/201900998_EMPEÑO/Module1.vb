Module Module1
    Public CONTADOR = 0
    Public MATRIZ(6, 8)

    Public Const PRECIO_TV_CORTO = 250
    Public Const PRECIO_TELEFONO_CORTO = 550
    Public Const PRECIO_LAPTOP_CORTO = 770
    Public Const PRECIO_REFRI_CORTO = 1000
    Public Const PRECIO_TV_LARGO = 300
    Public Const PRECIO_TELEFONO_LARGO = 600
    Public Const PRECIO_LAPTOP_LARGO = 800
    Public Const PRECIO_REFRI_LARGO = 1200

    Public Const DESC1 = 15 / 100
    Public Const DESC2 = 5 / 100
    Public Const DESC3 = 10 / 100
    Public Const DESC4 = 5 / 100
    Public PAGO_PARCIAL()


    Public Sub limpiar_MATRIZ_ENTRADAS()
        ReDim MATRIZ(6, 8)

        Form1.TXTNOMBRE.Clear()
        Form1.TXTCUI.Clear()
        Form1.TXTDIRECCIÓN.Clear()
        Form1.TXTCOSTO.Clear()
        Form1.RBCORTO.Checked = False
        Form1.RBLARGO.Checked = False
        Form1.CBLAPTOP.Checked = False
        Form1.CBTELEFONO.Checked = False
        Form1.CBTV.Checked = False
        Form1.CBREFRI.Checked = False

        CONTADOR = 0
    End Sub

    Public Sub LIMPIAR_LISTBOX()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
    End Sub

End Module
