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
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBTV = New System.Windows.Forms.CheckBox()
        Me.CBTELEFONO = New System.Windows.Forms.CheckBox()
        Me.CBLAPTOP = New System.Windows.Forms.CheckBox()
        Me.CBREFRI = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCUI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTDIRECCIÓN = New System.Windows.Forms.TextBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.LIMPIARMATRIZENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARLISTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTCOSTO = New System.Windows.Forms.TextBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.RBLARGO = New System.Windows.Forms.RadioButton()
        Me.RBCORTO = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
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
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LIMPIARMATRIZENTRADASToolStripMenuItem, Me.LIMPIARLISTBOXToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBCORTO)
        Me.GroupBox1.Controls.Add(Me.RBLARGO)
        Me.GroupBox1.Location = New System.Drawing.Point(540, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 129)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PLAZOS"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(31, 228)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(171, 228)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 84)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(312, 228)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 84)
        Me.ListBox3.TabIndex = 2
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(455, 228)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 84)
        Me.ListBox4.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBREFRI)
        Me.GroupBox2.Controls.Add(Me.CBLAPTOP)
        Me.GroupBox2.Controls.Add(Me.CBTELEFONO)
        Me.GroupBox2.Controls.Add(Me.CBTV)
        Me.GroupBox2.Location = New System.Drawing.Point(321, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 163)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "APARATOS"
        '
        'CBTV
        '
        Me.CBTV.AutoSize = True
        Me.CBTV.Location = New System.Drawing.Point(24, 27)
        Me.CBTV.Name = "CBTV"
        Me.CBTV.Size = New System.Drawing.Size(55, 24)
        Me.CBTV.TabIndex = 0
        Me.CBTV.Text = "TV"
        Me.CBTV.UseVisualStyleBackColor = True
        '
        'CBTELEFONO
        '
        Me.CBTELEFONO.AutoSize = True
        Me.CBTELEFONO.Location = New System.Drawing.Point(24, 57)
        Me.CBTELEFONO.Name = "CBTELEFONO"
        Me.CBTELEFONO.Size = New System.Drawing.Size(120, 24)
        Me.CBTELEFONO.TabIndex = 1
        Me.CBTELEFONO.Text = "TELEFONO"
        Me.CBTELEFONO.UseVisualStyleBackColor = True
        '
        'CBLAPTOP
        '
        Me.CBLAPTOP.AutoSize = True
        Me.CBLAPTOP.Location = New System.Drawing.Point(24, 87)
        Me.CBLAPTOP.Name = "CBLAPTOP"
        Me.CBLAPTOP.Size = New System.Drawing.Size(96, 24)
        Me.CBLAPTOP.TabIndex = 2
        Me.CBLAPTOP.Text = "LAPTOP"
        Me.CBLAPTOP.UseVisualStyleBackColor = True
        '
        'CBREFRI
        '
        Me.CBREFRI.AutoSize = True
        Me.CBREFRI.Location = New System.Drawing.Point(24, 117)
        Me.CBREFRI.Name = "CBREFRI"
        Me.CBREFRI.Size = New System.Drawing.Size(167, 24)
        Me.CBREFRI.TabIndex = 3
        Me.CBREFRI.Text = "REFRIGERADOA"
        Me.CBREFRI.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXTCOSTO)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TXTDIRECCIÓN)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TXTCUI)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 166)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NOMBRE"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(104, 25)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(156, 26)
        Me.TXTNOMBRE.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CUI"
        '
        'TXTCUI
        '
        Me.TXTCUI.Location = New System.Drawing.Point(104, 60)
        Me.TXTCUI.Name = "TXTCUI"
        Me.TXTCUI.Size = New System.Drawing.Size(156, 26)
        Me.TXTCUI.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-1, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DIRECCIÓN"
        '
        'TXTDIRECCIÓN
        '
        Me.TXTDIRECCIÓN.Location = New System.Drawing.Point(104, 94)
        Me.TXTDIRECCIÓN.Name = "TXTDIRECCIÓN"
        Me.TXTDIRECCIÓN.Size = New System.Drawing.Size(156, 26)
        Me.TXTDIRECCIÓN.TabIndex = 11
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(600, 228)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(145, 84)
        Me.ListBox5.TabIndex = 5
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 20
        Me.ListBox6.Location = New System.Drawing.Point(31, 332)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(120, 84)
        Me.ListBox6.TabIndex = 6
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 20
        Me.ListBox7.Location = New System.Drawing.Point(171, 332)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(120, 84)
        Me.ListBox7.TabIndex = 7
        '
        'LIMPIARMATRIZENTRADASToolStripMenuItem
        '
        Me.LIMPIARMATRIZENTRADASToolStripMenuItem.Name = "LIMPIARMATRIZENTRADASToolStripMenuItem"
        Me.LIMPIARMATRIZENTRADASToolStripMenuItem.Size = New System.Drawing.Size(344, 34)
        Me.LIMPIARMATRIZENTRADASToolStripMenuItem.Text = "LIMPIAR MATRIZ/ENTRADAS"
        '
        'LIMPIARLISTBOXToolStripMenuItem
        '
        Me.LIMPIARLISTBOXToolStripMenuItem.Name = "LIMPIARLISTBOXToolStripMenuItem"
        Me.LIMPIARLISTBOXToolStripMenuItem.Size = New System.Drawing.Size(344, 34)
        Me.LIMPIARLISTBOXToolStripMenuItem.Text = "LIMPIAR LISTBOX"
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 20
        Me.ListBox8.Location = New System.Drawing.Point(312, 332)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(120, 84)
        Me.ListBox8.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "COSTO"
        '
        'TXTCOSTO
        '
        Me.TXTCOSTO.Location = New System.Drawing.Point(104, 134)
        Me.TXTCOSTO.Name = "TXTCOSTO"
        Me.TXTCOSTO.Size = New System.Drawing.Size(156, 26)
        Me.TXTCOSTO.TabIndex = 13
        '
        'ListBox9
        '
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 20
        Me.ListBox9.Location = New System.Drawing.Point(455, 332)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(120, 84)
        Me.ListBox9.TabIndex = 9
        '
        'RBLARGO
        '
        Me.RBLARGO.AutoSize = True
        Me.RBLARGO.Location = New System.Drawing.Point(15, 25)
        Me.RBLARGO.Name = "RBLARGO"
        Me.RBLARGO.Size = New System.Drawing.Size(91, 24)
        Me.RBLARGO.TabIndex = 0
        Me.RBLARGO.TabStop = True
        Me.RBLARGO.Text = "LARGO"
        Me.RBLARGO.UseVisualStyleBackColor = True
        '
        'RBCORTO
        '
        Me.RBCORTO.AutoSize = True
        Me.RBCORTO.Location = New System.Drawing.Point(15, 74)
        Me.RBCORTO.Name = "RBCORTO"
        Me.RBCORTO.Size = New System.Drawing.Size(90, 24)
        Me.RBCORTO.TabIndex = 1
        Me.RBCORTO.TabStop = True
        Me.RBCORTO.Text = "CORTO"
        Me.RBCORTO.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBREFRI As CheckBox
    Friend WithEvents CBLAPTOP As CheckBox
    Friend WithEvents CBTELEFONO As CheckBox
    Friend WithEvents CBTV As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LIMPIARMATRIZENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARLISTBOXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXTDIRECCIÓN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTCUI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents TXTCOSTO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents RBCORTO As RadioButton
    Friend WithEvents RBLARGO As RadioButton
End Class
