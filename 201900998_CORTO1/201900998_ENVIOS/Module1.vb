Module Module1
    Public Const ViaticosN = 150.0
    Public Const ViaticosS = 200.0
    Public Const ViaticosOR = 175.0
    Public Const ViaticosOCC = 225
    Public Const Sueldo = 3800.0

    Public Const segurove = 3 / 100
    Public Const seguroacc = 5 / 100


    Sub Limpiar()

        Form1.Txtnombre.Clear()
        Form1.CBS.Checked = False
        Form1.CBOR.Checked = False
        Form1.CBOCC.Checked = False
        Form1.CBVE.Checked = False
        Form1.CBACC.Checked = False

    End Sub

End Module