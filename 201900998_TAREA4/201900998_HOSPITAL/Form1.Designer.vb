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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTHONORARIOS = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RBPRIVADA = New System.Windows.Forms.RadioButton()
        Me.RBSEMI = New System.Windows.Forms.RadioButton()
        Me.RBNOPRIV = New System.Windows.Forms.RadioButton()
        Me.CBENCAMA = New System.Windows.Forms.CheckBox()
        Me.CBOPERACION = New System.Windows.Forms.CheckBox()
        Me.CBMATERNIDAD = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTDIAS = New System.Windows.Forms.TextBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.ListBox10 = New System.Windows.Forms.ListBox()
        Me.ListBox11 = New System.Windows.Forms.ListBox()
        Me.CBCREDITO = New System.Windows.Forms.CheckBox()
        Me.CBDEBITO = New System.Windows.Forms.CheckBox()
        Me.CBCHEQUE = New System.Windows.Forms.CheckBox()
        Me.CBEFECTIVO = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1171, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(113, 29)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTRADASToolStripMenuItem, Me.LISTBOXToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'ENTRADASToolStripMenuItem
        '
        Me.ENTRADASToolStripMenuItem.Name = "ENTRADASToolStripMenuItem"
        Me.ENTRADASToolStripMenuItem.Size = New System.Drawing.Size(203, 34)
        Me.ENTRADASToolStripMenuItem.Text = "ENTRADAS"
        '
        'LISTBOXToolStripMenuItem
        '
        Me.LISTBOXToolStripMenuItem.Name = "LISTBOXToolStripMenuItem"
        Me.LISTBOXToolStripMenuItem.Size = New System.Drawing.Size(271, 34)
        Me.LISTBOXToolStripMenuItem.Text = "VECTORES/LISTBOX"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOMBRE "
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(142, 59)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(100, 26)
        Me.TXTNOMBRE.TabIndex = 3
        '
        'TXTNIT
        '
        Me.TXTNIT.Location = New System.Drawing.Point(142, 113)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(100, 26)
        Me.TXTNIT.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(41, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "HONORARIOS DEL MÉDICO"
        '
        'TXTHONORARIOS
        '
        Me.TXTHONORARIOS.Location = New System.Drawing.Point(254, 162)
        Me.TXTHONORARIOS.Name = "TXTHONORARIOS"
        Me.TXTHONORARIOS.Size = New System.Drawing.Size(100, 26)
        Me.TXTHONORARIOS.TabIndex = 7
        '
        'RBPRIVADA
        '
        Me.RBPRIVADA.AutoSize = True
        Me.RBPRIVADA.BackColor = System.Drawing.Color.Transparent
        Me.RBPRIVADA.Location = New System.Drawing.Point(413, 61)
        Me.RBPRIVADA.Name = "RBPRIVADA"
        Me.RBPRIVADA.Size = New System.Drawing.Size(106, 24)
        Me.RBPRIVADA.TabIndex = 8
        Me.RBPRIVADA.TabStop = True
        Me.RBPRIVADA.Text = "PRIVADA"
        Me.RBPRIVADA.UseVisualStyleBackColor = False
        '
        'RBSEMI
        '
        Me.RBSEMI.AutoSize = True
        Me.RBSEMI.BackColor = System.Drawing.Color.Transparent
        Me.RBSEMI.Location = New System.Drawing.Point(413, 109)
        Me.RBSEMI.Name = "RBSEMI"
        Me.RBSEMI.Size = New System.Drawing.Size(146, 24)
        Me.RBSEMI.TabIndex = 9
        Me.RBSEMI.TabStop = True
        Me.RBSEMI.Text = "SEMIPRIVADA"
        Me.RBSEMI.UseVisualStyleBackColor = False
        '
        'RBNOPRIV
        '
        Me.RBNOPRIV.AutoSize = True
        Me.RBNOPRIV.BackColor = System.Drawing.Color.Transparent
        Me.RBNOPRIV.Location = New System.Drawing.Point(413, 162)
        Me.RBNOPRIV.Name = "RBNOPRIV"
        Me.RBNOPRIV.Size = New System.Drawing.Size(133, 24)
        Me.RBNOPRIV.TabIndex = 10
        Me.RBNOPRIV.TabStop = True
        Me.RBNOPRIV.Text = "NO PRIVADA"
        Me.RBNOPRIV.UseVisualStyleBackColor = False
        '
        'CBENCAMA
        '
        Me.CBENCAMA.AutoSize = True
        Me.CBENCAMA.BackColor = System.Drawing.Color.Transparent
        Me.CBENCAMA.Location = New System.Drawing.Point(609, 61)
        Me.CBENCAMA.Name = "CBENCAMA"
        Me.CBENCAMA.Size = New System.Drawing.Size(164, 24)
        Me.CBENCAMA.TabIndex = 11
        Me.CBENCAMA.Text = "ENCAMAMIENTO"
        Me.CBENCAMA.UseVisualStyleBackColor = False
        '
        'CBOPERACION
        '
        Me.CBOPERACION.AutoSize = True
        Me.CBOPERACION.BackColor = System.Drawing.Color.Transparent
        Me.CBOPERACION.Location = New System.Drawing.Point(609, 109)
        Me.CBOPERACION.Name = "CBOPERACION"
        Me.CBOPERACION.Size = New System.Drawing.Size(130, 24)
        Me.CBOPERACION.TabIndex = 12
        Me.CBOPERACION.Text = "OPERACIÓN"
        Me.CBOPERACION.UseVisualStyleBackColor = False
        '
        'CBMATERNIDAD
        '
        Me.CBMATERNIDAD.AutoSize = True
        Me.CBMATERNIDAD.BackColor = System.Drawing.Color.Transparent
        Me.CBMATERNIDAD.Location = New System.Drawing.Point(609, 162)
        Me.CBMATERNIDAD.Name = "CBMATERNIDAD"
        Me.CBMATERNIDAD.Size = New System.Drawing.Size(142, 24)
        Me.CBMATERNIDAD.TabIndex = 13
        Me.CBMATERNIDAD.Text = "MATERNIDAD"
        Me.CBMATERNIDAD.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(234, 299)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 18
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(382, 299)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 84)
        Me.ListBox2.TabIndex = 19
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(524, 299)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 84)
        Me.ListBox3.TabIndex = 20
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(665, 299)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 84)
        Me.ListBox4.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(28, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "DÍAS HOSPITALIZACIÓN"
        '
        'TXTDIAS
        '
        Me.TXTDIAS.Location = New System.Drawing.Point(254, 227)
        Me.TXTDIAS.Name = "TXTDIAS"
        Me.TXTDIAS.Size = New System.Drawing.Size(100, 26)
        Me.TXTDIAS.TabIndex = 27
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(812, 299)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 84)
        Me.ListBox5.TabIndex = 28
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 20
        Me.ListBox6.Location = New System.Drawing.Point(234, 422)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(120, 84)
        Me.ListBox6.TabIndex = 29
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 20
        Me.ListBox7.Location = New System.Drawing.Point(382, 422)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(120, 84)
        Me.ListBox7.TabIndex = 30
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 20
        Me.ListBox8.Location = New System.Drawing.Point(524, 422)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(120, 84)
        Me.ListBox8.TabIndex = 31
        '
        'ListBox9
        '
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 20
        Me.ListBox9.Location = New System.Drawing.Point(665, 422)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(120, 84)
        Me.ListBox9.TabIndex = 32
        '
        'ListBox10
        '
        Me.ListBox10.FormattingEnabled = True
        Me.ListBox10.ItemHeight = 20
        Me.ListBox10.Location = New System.Drawing.Point(812, 422)
        Me.ListBox10.Name = "ListBox10"
        Me.ListBox10.Size = New System.Drawing.Size(120, 84)
        Me.ListBox10.TabIndex = 33
        '
        'ListBox11
        '
        Me.ListBox11.FormattingEnabled = True
        Me.ListBox11.ItemHeight = 20
        Me.ListBox11.Location = New System.Drawing.Point(963, 362)
        Me.ListBox11.Name = "ListBox11"
        Me.ListBox11.Size = New System.Drawing.Size(120, 84)
        Me.ListBox11.TabIndex = 34
        '
        'CBCREDITO
        '
        Me.CBCREDITO.AutoSize = True
        Me.CBCREDITO.BackColor = System.Drawing.Color.Transparent
        Me.CBCREDITO.Location = New System.Drawing.Point(830, 181)
        Me.CBCREDITO.Name = "CBCREDITO"
        Me.CBCREDITO.Size = New System.Drawing.Size(182, 24)
        Me.CBCREDITO.TabIndex = 35
        Me.CBCREDITO.Text = "TARJETA CRÉDITO"
        Me.CBCREDITO.UseVisualStyleBackColor = False
        '
        'CBDEBITO
        '
        Me.CBDEBITO.AutoSize = True
        Me.CBDEBITO.BackColor = System.Drawing.Color.Transparent
        Me.CBDEBITO.Location = New System.Drawing.Point(830, 131)
        Me.CBDEBITO.Name = "CBDEBITO"
        Me.CBDEBITO.Size = New System.Drawing.Size(170, 24)
        Me.CBDEBITO.TabIndex = 36
        Me.CBDEBITO.Text = "TARJETA DÉBITO"
        Me.CBDEBITO.UseVisualStyleBackColor = False
        '
        'CBCHEQUE
        '
        Me.CBCHEQUE.AutoSize = True
        Me.CBCHEQUE.BackColor = System.Drawing.Color.Transparent
        Me.CBCHEQUE.Location = New System.Drawing.Point(830, 81)
        Me.CBCHEQUE.Name = "CBCHEQUE"
        Me.CBCHEQUE.Size = New System.Drawing.Size(104, 24)
        Me.CBCHEQUE.TabIndex = 37
        Me.CBCHEQUE.Text = "CHEQUE"
        Me.CBCHEQUE.UseVisualStyleBackColor = False
        '
        'CBEFECTIVO
        '
        Me.CBEFECTIVO.AutoSize = True
        Me.CBEFECTIVO.BackColor = System.Drawing.Color.Transparent
        Me.CBEFECTIVO.Location = New System.Drawing.Point(830, 36)
        Me.CBEFECTIVO.Name = "CBEFECTIVO"
        Me.CBEFECTIVO.Size = New System.Drawing.Size(115, 24)
        Me.CBEFECTIVO.TabIndex = 38
        Me.CBEFECTIVO.Text = "EFECTIVO"
        Me.CBEFECTIVO.UseMnemonic = False
        Me.CBEFECTIVO.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900998_HOSPITAL.My.Resources.Resources.infraestructura_en_salud
        Me.ClientSize = New System.Drawing.Size(1171, 646)
        Me.Controls.Add(Me.CBEFECTIVO)
        Me.Controls.Add(Me.CBCHEQUE)
        Me.Controls.Add(Me.CBDEBITO)
        Me.Controls.Add(Me.CBCREDITO)
        Me.Controls.Add(Me.ListBox11)
        Me.Controls.Add(Me.ListBox10)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.TXTDIAS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CBMATERNIDAD)
        Me.Controls.Add(Me.CBOPERACION)
        Me.Controls.Add(Me.CBENCAMA)
        Me.Controls.Add(Me.RBNOPRIV)
        Me.Controls.Add(Me.RBSEMI)
        Me.Controls.Add(Me.RBPRIVADA)
        Me.Controls.Add(Me.TXTHONORARIOS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNIT)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "HOSPITAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTBOXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTHONORARIOS As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RBPRIVADA As RadioButton
    Friend WithEvents RBSEMI As RadioButton
    Friend WithEvents RBNOPRIV As RadioButton
    Friend WithEvents CBENCAMA As CheckBox
    Friend WithEvents CBOPERACION As CheckBox
    Friend WithEvents CBMATERNIDAD As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTDIAS As TextBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents ListBox10 As ListBox
    Friend WithEvents ListBox11 As ListBox
    Friend WithEvents CBCREDITO As CheckBox
    Friend WithEvents CBDEBITO As CheckBox
    Friend WithEvents CBCHEQUE As CheckBox
    Friend WithEvents CBEFECTIVO As CheckBox
End Class
