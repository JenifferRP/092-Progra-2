<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.VUELOS = New System.Windows.Forms.GroupBox()
        Me.RBHeli = New System.Windows.Forms.RadioButton()
        Me.RBJet = New System.Windows.Forms.RadioButton()
        Me.RBAvioneta = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBPetén = New System.Windows.Forms.CheckBox()
        Me.CBIzabal = New System.Windows.Forms.CheckBox()
        Me.CBCOSTA = New System.Windows.Forms.CheckBox()
        Me.LCANTIDAD = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTNCALCULAR = New System.Windows.Forms.Button()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.VUELOS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VUELOS
        '
        Me.VUELOS.BackColor = System.Drawing.Color.Transparent
        Me.VUELOS.Controls.Add(Me.RBHeli)
        Me.VUELOS.Controls.Add(Me.RBJet)
        Me.VUELOS.Controls.Add(Me.RBAvioneta)
        Me.VUELOS.Location = New System.Drawing.Point(75, 28)
        Me.VUELOS.Name = "VUELOS"
        Me.VUELOS.Size = New System.Drawing.Size(185, 164)
        Me.VUELOS.TabIndex = 0
        Me.VUELOS.TabStop = False
        Me.VUELOS.Text = "TIPO"
        '
        'RBHeli
        '
        Me.RBHeli.AutoSize = True
        Me.RBHeli.Location = New System.Drawing.Point(12, 112)
        Me.RBHeli.Name = "RBHeli"
        Me.RBHeli.Size = New System.Drawing.Size(115, 24)
        Me.RBHeli.TabIndex = 2
        Me.RBHeli.TabStop = True
        Me.RBHeli.Text = "Helicóptero"
        Me.RBHeli.UseVisualStyleBackColor = True
        '
        'RBJet
        '
        Me.RBJet.AutoSize = True
        Me.RBJet.Location = New System.Drawing.Point(12, 67)
        Me.RBJet.Name = "RBJet"
        Me.RBJet.Size = New System.Drawing.Size(56, 24)
        Me.RBJet.TabIndex = 1
        Me.RBJet.TabStop = True
        Me.RBJet.Text = "Jet"
        Me.RBJet.UseVisualStyleBackColor = True
        '
        'RBAvioneta
        '
        Me.RBAvioneta.AutoSize = True
        Me.RBAvioneta.Location = New System.Drawing.Point(12, 25)
        Me.RBAvioneta.Name = "RBAvioneta"
        Me.RBAvioneta.Size = New System.Drawing.Size(96, 24)
        Me.RBAvioneta.TabIndex = 0
        Me.RBAvioneta.TabStop = True
        Me.RBAvioneta.Text = "Avioneta"
        Me.RBAvioneta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CBPetén)
        Me.GroupBox1.Controls.Add(Me.CBIzabal)
        Me.GroupBox1.Controls.Add(Me.CBCOSTA)
        Me.GroupBox1.Location = New System.Drawing.Point(75, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 164)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DESTINOS"
        '
        'CBPetén
        '
        Me.CBPetén.AutoSize = True
        Me.CBPetén.Location = New System.Drawing.Point(11, 120)
        Me.CBPetén.Name = "CBPetén"
        Me.CBPetén.Size = New System.Drawing.Size(77, 24)
        Me.CBPetén.TabIndex = 2
        Me.CBPetén.Text = "Petén"
        Me.CBPetén.UseVisualStyleBackColor = True
        '
        'CBIzabal
        '
        Me.CBIzabal.AutoSize = True
        Me.CBIzabal.Location = New System.Drawing.Point(11, 72)
        Me.CBIzabal.Name = "CBIzabal"
        Me.CBIzabal.Size = New System.Drawing.Size(78, 24)
        Me.CBIzabal.TabIndex = 1
        Me.CBIzabal.Text = "Izabal"
        Me.CBIzabal.UseVisualStyleBackColor = True
        '
        'CBCOSTA
        '
        Me.CBCOSTA.AutoSize = True
        Me.CBCOSTA.Location = New System.Drawing.Point(10, 25)
        Me.CBCOSTA.Name = "CBCOSTA"
        Me.CBCOSTA.Size = New System.Drawing.Size(106, 24)
        Me.CBCOSTA.TabIndex = 0
        Me.CBCOSTA.Text = "Costa Sur"
        Me.CBCOSTA.UseVisualStyleBackColor = True
        '
        'LCANTIDAD
        '
        Me.LCANTIDAD.AutoSize = True
        Me.LCANTIDAD.BackColor = System.Drawing.Color.Transparent
        Me.LCANTIDAD.Location = New System.Drawing.Point(285, 28)
        Me.LCANTIDAD.Name = "LCANTIDAD"
        Me.LCANTIDAD.Size = New System.Drawing.Size(219, 20)
        Me.LCANTIDAD.TabIndex = 4
        Me.LCANTIDAD.Text = "CANTIDAD DE PASAJEROS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(289, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 26)
        Me.TextBox1.TabIndex = 5
        '
        'BTNCALCULAR
        '
        Me.BTNCALCULAR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNCALCULAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNCALCULAR.Location = New System.Drawing.Point(345, 125)
        Me.BTNCALCULAR.Name = "BTNCALCULAR"
        Me.BTNCALCULAR.Size = New System.Drawing.Size(112, 39)
        Me.BTNCALCULAR.TabIndex = 6
        Me.BTNCALCULAR.Text = "CALCULAR"
        Me.BTNCALCULAR.UseVisualStyleBackColor = False
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNLIMPIAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(345, 192)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(112, 34)
        Me.BTNLIMPIAR.TabIndex = 7
        Me.BTNLIMPIAR.Text = "LIMPIAR"
        Me.BTNLIMPIAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNSALIR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNSALIR.Location = New System.Drawing.Point(345, 251)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(110, 38)
        Me.BTNSALIR.TabIndex = 8
        Me.BTNSALIR.Text = "SALIR"
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900998_VUELOS.My.Resources.Resources._5f5b7e5f60758fbf6e0df674_comparador_vuelos
        Me.ClientSize = New System.Drawing.Size(590, 450)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNLIMPIAR)
        Me.Controls.Add(Me.BTNCALCULAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LCANTIDAD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VUELOS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.VUELOS.ResumeLayout(False)
        Me.VUELOS.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VUELOS As GroupBox
    Friend WithEvents RBHeli As RadioButton
    Friend WithEvents RBJet As RadioButton
    Friend WithEvents RBAvioneta As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBPetén As CheckBox
    Friend WithEvents CBIzabal As CheckBox
    Friend WithEvents CBCOSTA As CheckBox
    Friend WithEvents LCANTIDAD As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTNCALCULAR As Button
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents BTNSALIR As Button
End Class
