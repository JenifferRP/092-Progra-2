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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.TXTDIAS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTIMPUESTO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBHABITACION = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBPAGO = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPUESTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HABITACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCUENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FINAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.ELIMINARToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1559, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(113, 29)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(111, 29)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(126, 29)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(183, 29)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBPAGO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBHABITACION)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTIMPUESTO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTDIAS)
        Me.GroupBox1.Controls.Add(Me.TXTNIT)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 214)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DIAS DE HOSPEDAJE"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(129, 32)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(169, 26)
        Me.TXTNOMBRE.TabIndex = 4
        '
        'TXTNIT
        '
        Me.TXTNIT.Location = New System.Drawing.Point(167, 68)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(131, 26)
        Me.TXTNIT.TabIndex = 5
        '
        'TXTDIAS
        '
        Me.TXTDIAS.Location = New System.Drawing.Point(198, 110)
        Me.TXTDIAS.Name = "TXTDIAS"
        Me.TXTDIAS.Size = New System.Drawing.Size(100, 26)
        Me.TXTDIAS.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "IMPUESTO"
        '
        'TXTIMPUESTO
        '
        Me.TXTIMPUESTO.Location = New System.Drawing.Point(198, 156)
        Me.TXTIMPUESTO.Name = "TXTIMPUESTO"
        Me.TXTIMPUESTO.Size = New System.Drawing.Size(100, 26)
        Me.TXTIMPUESTO.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "HABITACIÓN"
        '
        'CBHABITACION
        '
        Me.CBHABITACION.FormattingEnabled = True
        Me.CBHABITACION.Items.AddRange(New Object() {"SENCILLA", "DOBLE", "CABAÑA"})
        Me.CBHABITACION.Location = New System.Drawing.Point(337, 61)
        Me.CBHABITACION.Name = "CBHABITACION"
        Me.CBHABITACION.Size = New System.Drawing.Size(230, 28)
        Me.CBHABITACION.TabIndex = 10
        Me.CBHABITACION.Text = "SELECCIONE UN TIPO "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(333, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TIPO DE PAGO"
        '
        'CBPAGO
        '
        Me.CBPAGO.FormattingEnabled = True
        Me.CBPAGO.Items.AddRange(New Object() {"EFECTIVO", "TARJETA CRÉDITO", "TARJETA DÉBITO ", "TRANSFERENCIA", "DÉPOSTIVO"})
        Me.CBPAGO.Location = New System.Drawing.Point(337, 133)
        Me.CBPAGO.Name = "CBPAGO"
        Me.CBPAGO.Size = New System.Drawing.Size(230, 28)
        Me.CBPAGO.TabIndex = 12
        Me.CBPAGO.Text = "SELECCIONE UN TIPO "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBRE, Me.NIT, Me.DIAS, Me.IMPUESTO, Me.HABITACION, Me.PAGO, Me.TOTAL, Me.DESCUENTO, Me.FINAL})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1424, 298)
        Me.DataGridView1.TabIndex = 13
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.MinimumWidth = 8
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Width = 150
        '
        'NIT
        '
        Me.NIT.HeaderText = "NIT"
        Me.NIT.MinimumWidth = 8
        Me.NIT.Name = "NIT"
        Me.NIT.Width = 150
        '
        'DIAS
        '
        Me.DIAS.HeaderText = "DIAS HOSPEDAJE"
        Me.DIAS.MinimumWidth = 8
        Me.DIAS.Name = "DIAS"
        Me.DIAS.Width = 150
        '
        'IMPUESTO
        '
        Me.IMPUESTO.HeaderText = "IMPUESTO"
        Me.IMPUESTO.MinimumWidth = 8
        Me.IMPUESTO.Name = "IMPUESTO"
        Me.IMPUESTO.Width = 150
        '
        'HABITACION
        '
        Me.HABITACION.HeaderText = "TIPO HABITACIÓN"
        Me.HABITACION.MinimumWidth = 8
        Me.HABITACION.Name = "HABITACION"
        Me.HABITACION.Width = 150
        '
        'PAGO
        '
        Me.PAGO.HeaderText = "TIPO PAGO"
        Me.PAGO.MinimumWidth = 8
        Me.PAGO.Name = "PAGO"
        Me.PAGO.Width = 150
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL PARCIAL"
        Me.TOTAL.MinimumWidth = 8
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Width = 150
        '
        'DESCUENTO
        '
        Me.DESCUENTO.HeaderText = "DESCUENTO/RECARGO"
        Me.DESCUENTO.MinimumWidth = 8
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.Width = 150
        '
        'FINAL
        '
        Me.FINAL.HeaderText = "TOTAL"
        Me.FINAL.MinimumWidth = 8
        Me.FINAL.Name = "FINAL"
        Me.FINAL.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1559, 618)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBPAGO As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBHABITACION As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTIMPUESTO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTDIAS As TextBox
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents NIT As DataGridViewTextBoxColumn
    Friend WithEvents DIAS As DataGridViewTextBoxColumn
    Friend WithEvents IMPUESTO As DataGridViewTextBoxColumn
    Friend WithEvents HABITACION As DataGridViewTextBoxColumn
    Friend WithEvents PAGO As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents DESCUENTO As DataGridViewTextBoxColumn
    Friend WithEvents FINAL As DataGridViewTextBoxColumn
End Class
