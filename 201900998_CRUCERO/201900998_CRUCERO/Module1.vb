Module Module1
    Public PRECIO_SENCILLA_PRIMERA = 400
    Public PRECIO_SENCILLA_SEGUNDA = 375
    Public PRECIO_DOBLE_PRIMERA = 700
    Public PRECIO_DOBLE_SEGUNDA = 600
    Public PRECIO_COMPARTIDA_PRIMERA = 350
    Public PRECIO_COMPARTIDA_SEGUNDA = 300

    Public NIT(6)
    Public NOMBRE(6)
    Public CABINA(6)
    Public PERSONAS(6)
    Public CLASE(6)
    Public PRECIO_INDIVIDUAL(6)
    Public TOTAL(6)
    Public INDEX = 0


    Sub MOSTRAR()
        Form1.ListBoxNIT.Items.Add(Form1.TXTNIT.Text)
        Form1.ListBoxNOMBRE.Items.Add(Form1.TXTNOMBRE.Text)
        Form1.ListBoxCABINA.Items.Add(CABINA(INDEX))
        Form1.ListBoxPERSONAS.Items.Add(Form1.TXTPERSONAS.Text)
        Form1.ListBoxCLASE.Items.Add(Form1.RBPRIMERA.Text)

        Form1.ListBoxPRECIOINICIAL.Items.Add(Val(PRECIO_INDIVIDUAL(INDEX)))
        Form1.ListBoxTOTAL.Items.Add(Val(TOTAL(INDEX)))
    End Sub

    Sub LIMPIAR_ENTRADAS()
        Form1.TXTNIT.Clear()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTPERSONAS.Clear()
        Form1.RBSENCILLA.Checked = 0
        Form1.RBDOBLE.Checked = 0
        Form1.RBCOMPARTIDA.Checked = 0
        Form1.RBPRIMERA.Checked = 0
        Form1.RBSEGUNDA.Checked = 0

    End Sub

    Sub LIMPIAR_LISTBOX()
        Form1.ListBoxNIT.Items.Clear()
        Form1.ListBoxNOMBRE.Items.Clear()
        Form1.ListBoxCABINA.Items.Clear()
        Form1.ListBoxPERSONAS.Items.Clear()
        Form1.ListBoxPRECIOINICIAL.Items.Clear()
        Form1.ListBoxTOTAL.Items.Clear()
        Form1.ListBoxCLASE.Items.Clear()


    End Sub

    Sub LIMPIAR_VECTORES()

    End Sub
End Module
