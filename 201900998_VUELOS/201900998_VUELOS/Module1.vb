Module Module1
    Public Const Avioneta_costaSur = 150.0
    Public Const Avioneta_Izabal = 175.99
    Public Const Avioneta_Petén = 250.99
    Public Const Jet_costaSur = 250.99
    Public Const Jet_Izabal = 325.99
    Public Const Jet_Petén = 450.99
    Public Const Helicóptero_costaSur = 125.99
    Public Const Helicóptero_Izabal = 175.99
    Public Const Helicóptero_Petén = 275.99


    Public Const descuento_jet = 2 / 100
    Public Const descuento_avioneta = 10 / 100

    Public subtotal = 0
    Public total = 0
    Public descuento = 0

    Sub limpiar()
        Form1.TextBox1.Clear()
        Form1.RBAvioneta.Checked = False
        Form1.RBHeli.Checked = False
        Form1.RBJet.Checked = False
        Form1.CBCOSTA.Checked = False
        Form1.CBIzabal.Checked = False
        Form1.CBPetén.Checked = False

    End Sub



    Public Sub Calcular(tipo As String, destino As String, cantidad As Double)
        Select Case tipo
            Case "Avioneta"
                Select Case destino
                    Case "Costa Sur"
                        subtotal = cantidad * Avioneta_costaSur
                        total = subtotal
                    Case "Izabal"
                        subtotal = cantidad * Avioneta_Izabal
                        total = subtotal
                    Case "Petén"
                        subtotal = cantidad * Avioneta_Petén
                        total = subtotal
                End Select
            Case "Jet"
                Select Case destino
                    Case "Costa Sur"
                        subtotal = cantidad * Jet_costaSur
                        total = subtotal
                    Case "Izabal"
                        subtotal = cantidad * Jet_Izabal
                        total = subtotal
                    Case "Petén"
                        subtotal = cantidad * Jet_Petén
                        total = subtotal
                End Select
            Case "Helicóptero"
                Select Case destino
                    Case "Costa Sur"
                        subtotal = cantidad * Helicóptero_costaSur
                        total = subtotal
                    Case "Izabal"
                        subtotal = cantidad * Helicóptero_Izabal
                        total = subtotal
                    Case "Petén"
                        subtotal = cantidad * Helicóptero_Petén
                        total = subtotal
                End Select
                Math.Round(subtotal, 2)
                Math.Round(total, 2)
        End Select

        If (Form1.RBJet.Checked) Then
            If (Form1.RBJet.Checked) And (Form1.CBPetén.Checked) And (Form1.CBIzabal.Checked) Then
                descuento = descuento_jet
                total = descuento_jet * subtotal
            End If
            Math.Round(descuento, 2)
            Math.Round(total, 2)
        End If
        If (Form1.RBAvioneta.Checked) Then
            If (Form1.RBAvioneta.Checked) And (Form1.CBPetén.Checked) And (Form1.CBIzabal.Checked) And (Form1.CBCOSTA.Checked) Then
                descuento = descuento_avioneta
                total = descuento_avioneta * subtotal
            End If
            Math.Round(descuento, 2)
            Math.Round(total, 2)
        End If



    End Sub






End Module
