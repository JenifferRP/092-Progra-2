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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBVENTA = New System.Windows.Forms.CheckBox()
        Me.CBCOMPRA = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBCRC = New System.Windows.Forms.RadioButton()
        Me.RBEC = New System.Windows.Forms.RadioButton()
        Me.RBPC = New System.Windows.Forms.RadioButton()
        Me.RbDC = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RBCRV = New System.Windows.Forms.RadioButton()
        Me.RBEV = New System.Windows.Forms.RadioButton()
        Me.RBPV = New System.Windows.Forms.RadioButton()
        Me.RBDV = New System.Windows.Forms.RadioButton()
        Me.BTsalir = New System.Windows.Forms.Button()
        Me.BTlimpiar = New System.Windows.Forms.Button()
        Me.BTconfirmar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CBVENTA)
        Me.GroupBox1.Controls.Add(Me.CBCOMPRA)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSACCIONES"
        '
        'CBVENTA
        '
        Me.CBVENTA.AutoSize = True
        Me.CBVENTA.Location = New System.Drawing.Point(35, 83)
        Me.CBVENTA.Name = "CBVENTA"
        Me.CBVENTA.Size = New System.Drawing.Size(88, 24)
        Me.CBVENTA.TabIndex = 1
        Me.CBVENTA.Text = "VENTA"
        Me.CBVENTA.UseVisualStyleBackColor = True
        '
        'CBCOMPRA
        '
        Me.CBCOMPRA.AutoSize = True
        Me.CBCOMPRA.Location = New System.Drawing.Point(35, 35)
        Me.CBCOMPRA.Name = "CBCOMPRA"
        Me.CBCOMPRA.Size = New System.Drawing.Size(104, 24)
        Me.CBCOMPRA.TabIndex = 0
        Me.CBCOMPRA.Text = "COMPRA"
        Me.CBCOMPRA.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtV)
        Me.GroupBox2.Controls.Add(Me.txtC)
        Me.GroupBox2.Location = New System.Drawing.Point(290, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 145)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INGRESO CANTIDADES EN QUETZALES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "VENTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COMPRA"
        '
        'txtV
        '
        Me.txtV.Enabled = False
        Me.txtV.Location = New System.Drawing.Point(129, 83)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(100, 26)
        Me.txtV.TabIndex = 1
        '
        'txtC
        '
        Me.txtC.Enabled = False
        Me.txtC.Location = New System.Drawing.Point(129, 25)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 26)
        Me.txtC.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RBCRC)
        Me.GroupBox3.Controls.Add(Me.RBEC)
        Me.GroupBox3.Controls.Add(Me.RBPC)
        Me.GroupBox3.Controls.Add(Me.RbDC)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 248)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COMPRA"
        '
        'RBCRC
        '
        Me.RBCRC.AutoSize = True
        Me.RBCRC.BackColor = System.Drawing.Color.Gainsboro
        Me.RBCRC.Location = New System.Drawing.Point(24, 193)
        Me.RBCRC.Name = "RBCRC"
        Me.RBCRC.Size = New System.Drawing.Size(138, 24)
        Me.RBCRC.TabIndex = 7
        Me.RBCRC.TabStop = True
        Me.RBCRC.Text = "COLONES CR"
        Me.RBCRC.UseVisualStyleBackColor = False
        '
        'RBEC
        '
        Me.RBEC.AutoSize = True
        Me.RBEC.BackColor = System.Drawing.Color.Gainsboro
        Me.RBEC.Location = New System.Drawing.Point(24, 142)
        Me.RBEC.Name = "RBEC"
        Me.RBEC.Size = New System.Drawing.Size(92, 24)
        Me.RBEC.TabIndex = 6
        Me.RBEC.TabStop = True
        Me.RBEC.Text = "EUROS"
        Me.RBEC.UseVisualStyleBackColor = False
        '
        'RBPC
        '
        Me.RBPC.AutoSize = True
        Me.RBPC.BackColor = System.Drawing.Color.Gainsboro
        Me.RBPC.Location = New System.Drawing.Point(24, 89)
        Me.RBPC.Name = "RBPC"
        Me.RBPC.Size = New System.Drawing.Size(178, 24)
        Me.RBPC.TabIndex = 5
        Me.RBPC.TabStop = True
        Me.RBPC.Text = "PESO MEXICANOS"
        Me.RBPC.UseVisualStyleBackColor = False
        '
        'RbDC
        '
        Me.RbDC.AutoSize = True
        Me.RbDC.BackColor = System.Drawing.Color.Gainsboro
        Me.RbDC.Location = New System.Drawing.Point(24, 39)
        Me.RbDC.Name = "RbDC"
        Me.RbDC.Size = New System.Drawing.Size(90, 24)
        Me.RbDC.TabIndex = 4
        Me.RbDC.TabStop = True
        Me.RbDC.Text = "DOLAR"
        Me.RbDC.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.RBCRV)
        Me.GroupBox4.Controls.Add(Me.RBEV)
        Me.GroupBox4.Controls.Add(Me.RBPV)
        Me.GroupBox4.Controls.Add(Me.RBDV)
        Me.GroupBox4.Location = New System.Drawing.Point(270, 190)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(228, 248)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "VENTA"
        '
        'RBCRV
        '
        Me.RBCRV.AutoSize = True
        Me.RBCRV.BackColor = System.Drawing.Color.Gainsboro
        Me.RBCRV.Location = New System.Drawing.Point(24, 193)
        Me.RBCRV.Name = "RBCRV"
        Me.RBCRV.Size = New System.Drawing.Size(138, 24)
        Me.RBCRV.TabIndex = 7
        Me.RBCRV.TabStop = True
        Me.RBCRV.Text = "COLONES CR"
        Me.RBCRV.UseVisualStyleBackColor = False
        '
        'RBEV
        '
        Me.RBEV.AutoSize = True
        Me.RBEV.BackColor = System.Drawing.Color.Gainsboro
        Me.RBEV.Location = New System.Drawing.Point(24, 142)
        Me.RBEV.Name = "RBEV"
        Me.RBEV.Size = New System.Drawing.Size(92, 24)
        Me.RBEV.TabIndex = 6
        Me.RBEV.TabStop = True
        Me.RBEV.Text = "EUROS"
        Me.RBEV.UseVisualStyleBackColor = False
        '
        'RBPV
        '
        Me.RBPV.AutoSize = True
        Me.RBPV.BackColor = System.Drawing.Color.Gainsboro
        Me.RBPV.Location = New System.Drawing.Point(24, 89)
        Me.RBPV.Name = "RBPV"
        Me.RBPV.Size = New System.Drawing.Size(178, 24)
        Me.RBPV.TabIndex = 5
        Me.RBPV.TabStop = True
        Me.RBPV.Text = "PESO MEXICANOS"
        Me.RBPV.UseVisualStyleBackColor = False
        '
        'RBDV
        '
        Me.RBDV.AutoSize = True
        Me.RBDV.BackColor = System.Drawing.Color.Gainsboro
        Me.RBDV.Location = New System.Drawing.Point(24, 39)
        Me.RBDV.Name = "RBDV"
        Me.RBDV.Size = New System.Drawing.Size(90, 24)
        Me.RBDV.TabIndex = 4
        Me.RBDV.TabStop = True
        Me.RBDV.Text = "DOLAR"
        Me.RBDV.UseVisualStyleBackColor = False
        '
        'BTsalir
        '
        Me.BTsalir.Location = New System.Drawing.Point(609, 384)
        Me.BTsalir.Name = "BTsalir"
        Me.BTsalir.Size = New System.Drawing.Size(124, 36)
        Me.BTsalir.TabIndex = 9
        Me.BTsalir.Text = "SALIR"
        Me.BTsalir.UseVisualStyleBackColor = True
        '
        'BTlimpiar
        '
        Me.BTlimpiar.Location = New System.Drawing.Point(609, 325)
        Me.BTlimpiar.Name = "BTlimpiar"
        Me.BTlimpiar.Size = New System.Drawing.Size(124, 32)
        Me.BTlimpiar.TabIndex = 10
        Me.BTlimpiar.Text = "LIMPIAR"
        Me.BTlimpiar.UseVisualStyleBackColor = True
        '
        'BTconfirmar
        '
        Me.BTconfirmar.Location = New System.Drawing.Point(609, 270)
        Me.BTconfirmar.Name = "BTconfirmar"
        Me.BTconfirmar.Size = New System.Drawing.Size(124, 34)
        Me.BTconfirmar.TabIndex = 11
        Me.BTconfirmar.Text = "CONFIRMAR"
        Me.BTconfirmar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.T3.My.Resources.Resources._2022_02_12__2_
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTconfirmar)
        Me.Controls.Add(Me.BTlimpiar)
        Me.Controls.Add(Me.BTsalir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "CASA CAMBIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBVENTA As CheckBox
    Friend WithEvents CBCOMPRA As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtV As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RBCRC As RadioButton
    Friend WithEvents RBEC As RadioButton
    Friend WithEvents RBPC As RadioButton
    Friend WithEvents RbDC As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RBCRV As RadioButton
    Friend WithEvents RBEV As RadioButton
    Friend WithEvents RBPV As RadioButton
    Friend WithEvents RBDV As RadioButton
    Friend WithEvents BTsalir As Button
    Friend WithEvents BTlimpiar As Button
    Friend WithEvents BTconfirmar As Button
End Class
