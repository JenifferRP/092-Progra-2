<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RBSENCILLA = New System.Windows.Forms.RadioButton()
        Me.RBDOBLE = New System.Windows.Forms.RadioButton()
        Me.RBCOMPARTIDA = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTPERSONAS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RBSEGUNDA = New System.Windows.Forms.RadioButton()
        Me.RBPRIMERA = New System.Windows.Forms.RadioButton()
        Me.ListBoxNIT = New System.Windows.Forms.ListBox()
        Me.ListBoxNOMBRE = New System.Windows.Forms.ListBox()
        Me.ListBoxCABINA = New System.Windows.Forms.ListBox()
        Me.ListBoxCLASE = New System.Windows.Forms.ListBox()
        Me.ListBoxPERSONAS = New System.Windows.Forms.ListBox()
        Me.ListBoxPRECIOINICIAL = New System.Windows.Forms.ListBox()
        Me.ListBoxTOTAL = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARLISTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTPERSONAS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RBCOMPARTIDA)
        Me.GroupBox1.Controls.Add(Me.RBDOBLE)
        Me.GroupBox1.Controls.Add(Me.RBSENCILLA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTNIT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 241)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1555, 33)
        Me.MenuStrip1.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIT"
        '
        'TXTNIT
        '
        Me.TXTNIT.Location = New System.Drawing.Point(155, 30)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(159, 26)
        Me.TXTNIT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(155, 70)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(159, 26)
        Me.TXTNOMBRE.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TIPO DE CABINA"
        '
        'RBSENCILLA
        '
        Me.RBSENCILLA.AutoSize = True
        Me.RBSENCILLA.Location = New System.Drawing.Point(165, 116)
        Me.RBSENCILLA.Name = "RBSENCILLA"
        Me.RBSENCILLA.Size = New System.Drawing.Size(112, 24)
        Me.RBSENCILLA.TabIndex = 6
        Me.RBSENCILLA.TabStop = True
        Me.RBSENCILLA.Text = "SENCILLA"
        Me.RBSENCILLA.UseVisualStyleBackColor = True
        '
        'RBDOBLE
        '
        Me.RBDOBLE.AutoSize = True
        Me.RBDOBLE.Location = New System.Drawing.Point(165, 143)
        Me.RBDOBLE.Name = "RBDOBLE"
        Me.RBDOBLE.Size = New System.Drawing.Size(89, 24)
        Me.RBDOBLE.TabIndex = 7
        Me.RBDOBLE.TabStop = True
        Me.RBDOBLE.Text = "DOBLE"
        Me.RBDOBLE.UseVisualStyleBackColor = True
        '
        'RBCOMPARTIDA
        '
        Me.RBCOMPARTIDA.AutoSize = True
        Me.RBCOMPARTIDA.Location = New System.Drawing.Point(165, 173)
        Me.RBCOMPARTIDA.Name = "RBCOMPARTIDA"
        Me.RBCOMPARTIDA.Size = New System.Drawing.Size(140, 24)
        Me.RBCOMPARTIDA.TabIndex = 8
        Me.RBCOMPARTIDA.TabStop = True
        Me.RBCOMPARTIDA.Text = "COMPARTIDA"
        Me.RBCOMPARTIDA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NÚMERO DE PERSONAS"
        '
        'TXTPERSONAS
        '
        Me.TXTPERSONAS.Location = New System.Drawing.Point(575, 30)
        Me.TXTPERSONAS.Name = "TXTPERSONAS"
        Me.TXTPERSONAS.Size = New System.Drawing.Size(159, 26)
        Me.TXTPERSONAS.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 11
        '
        'RBSEGUNDA
        '
        Me.RBSEGUNDA.AutoSize = True
        Me.RBSEGUNDA.Location = New System.Drawing.Point(64, 70)
        Me.RBSEGUNDA.Name = "RBSEGUNDA"
        Me.RBSEGUNDA.Size = New System.Drawing.Size(119, 24)
        Me.RBSEGUNDA.TabIndex = 12
        Me.RBSEGUNDA.TabStop = True
        Me.RBSEGUNDA.Text = "SEGUNDA "
        Me.RBSEGUNDA.UseVisualStyleBackColor = True
        '
        'RBPRIMERA
        '
        Me.RBPRIMERA.AutoSize = True
        Me.RBPRIMERA.Location = New System.Drawing.Point(64, 35)
        Me.RBPRIMERA.Name = "RBPRIMERA"
        Me.RBPRIMERA.Size = New System.Drawing.Size(108, 24)
        Me.RBPRIMERA.TabIndex = 13
        Me.RBPRIMERA.TabStop = True
        Me.RBPRIMERA.Text = "PRIMERA"
        Me.RBPRIMERA.UseVisualStyleBackColor = True
        '
        'ListBoxNIT
        '
        Me.ListBoxNIT.FormattingEnabled = True
        Me.ListBoxNIT.ItemHeight = 20
        Me.ListBoxNIT.Items.AddRange(New Object() {"NIT"})
        Me.ListBoxNIT.Location = New System.Drawing.Point(4, 324)
        Me.ListBoxNIT.Name = "ListBoxNIT"
        Me.ListBoxNIT.Size = New System.Drawing.Size(205, 204)
        Me.ListBoxNIT.TabIndex = 3
        '
        'ListBoxNOMBRE
        '
        Me.ListBoxNOMBRE.FormattingEnabled = True
        Me.ListBoxNOMBRE.ItemHeight = 20
        Me.ListBoxNOMBRE.Items.AddRange(New Object() {"NOMBRE"})
        Me.ListBoxNOMBRE.Location = New System.Drawing.Point(229, 324)
        Me.ListBoxNOMBRE.Name = "ListBoxNOMBRE"
        Me.ListBoxNOMBRE.Size = New System.Drawing.Size(205, 204)
        Me.ListBoxNOMBRE.TabIndex = 4
        '
        'ListBoxCABINA
        '
        Me.ListBoxCABINA.FormattingEnabled = True
        Me.ListBoxCABINA.ItemHeight = 20
        Me.ListBoxCABINA.Items.AddRange(New Object() {"TIPO DE CABINA"})
        Me.ListBoxCABINA.Location = New System.Drawing.Point(453, 324)
        Me.ListBoxCABINA.Name = "ListBoxCABINA"
        Me.ListBoxCABINA.Size = New System.Drawing.Size(205, 204)
        Me.ListBoxCABINA.TabIndex = 5
        '
        'ListBoxCLASE
        '
        Me.ListBoxCLASE.FormattingEnabled = True
        Me.ListBoxCLASE.ItemHeight = 20
        Me.ListBoxCLASE.Items.AddRange(New Object() {"TIPO DE CLASE"})
        Me.ListBoxCLASE.Location = New System.Drawing.Point(903, 324)
        Me.ListBoxCLASE.Name = "ListBoxCLASE"
        Me.ListBoxCLASE.Size = New System.Drawing.Size(205, 204)
        Me.ListBoxCLASE.TabIndex = 6
        '
        'ListBoxPERSONAS
        '
        Me.ListBoxPERSONAS.FormattingEnabled = True
        Me.ListBoxPERSONAS.ItemHeight = 20
        Me.ListBoxPERSONAS.Items.AddRange(New Object() {"NUMERO DE PERSONAS"})
        Me.ListBoxPERSONAS.Location = New System.Drawing.Point(677, 324)
        Me.ListBoxPERSONAS.Name = "ListBoxPERSONAS"
        Me.ListBoxPERSONAS.Size = New System.Drawing.Size(205, 204)
        Me.ListBoxPERSONAS.TabIndex = 7
        '
        'ListBoxPRECIOINICIAL
        '
        Me.ListBoxPRECIOINICIAL.FormattingEnabled = True
        Me.ListBoxPRECIOINICIAL.ItemHeight = 20
        Me.ListBoxPRECIOINICIAL.Items.AddRange(New Object() {"PRECIO INICIAL "})
        Me.ListBoxPRECIOINICIAL.Location = New System.Drawing.Point(1130, 324)
        Me.ListBoxPRECIOINICIAL.Name = "ListBoxPRECIOINICIAL"
        Me.ListBoxPRECIOINICIAL.Size = New System.Drawing.Size(205, 204)
        Me.ListBoxPRECIOINICIAL.TabIndex = 8
        '
        'ListBoxTOTAL
        '
        Me.ListBoxTOTAL.FormattingEnabled = True
        Me.ListBoxTOTAL.ItemHeight = 20
        Me.ListBoxTOTAL.Items.AddRange(New Object() {"TOTAL"})
        Me.ListBoxTOTAL.Location = New System.Drawing.Point(1350, 324)
        Me.ListBoxTOTAL.Name = "ListBoxTOTAL"
        Me.ListBoxTOTAL.Size = New System.Drawing.Size(205, 204)
        Me.ListBoxTOTAL.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBPRIMERA)
        Me.GroupBox2.Controls.Add(Me.RBSEGUNDA)
        Me.GroupBox2.Location = New System.Drawing.Point(468, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE CLASE"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARLISTBOXToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS "
        '
        'LIMPIARLISTBOXToolStripMenuItem
        '
        Me.LIMPIARLISTBOXToolStripMenuItem.Name = "LIMPIARLISTBOXToolStripMenuItem"
        Me.LIMPIARLISTBOXToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.LIMPIARLISTBOXToolStripMenuItem.Text = "LIMPIAR LISTBOX"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.SALIRToolStripMenuItem.Text = "SALIR "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900998_CRUCERO.My.Resources.Resources.descarga
        Me.ClientSize = New System.Drawing.Size(1555, 651)
        Me.Controls.Add(Me.ListBoxTOTAL)
        Me.Controls.Add(Me.ListBoxPRECIOINICIAL)
        Me.Controls.Add(Me.ListBoxPERSONAS)
        Me.Controls.Add(Me.ListBoxCLASE)
        Me.Controls.Add(Me.ListBoxCABINA)
        Me.Controls.Add(Me.ListBoxNOMBRE)
        Me.Controls.Add(Me.ListBoxNIT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXTPERSONAS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RBCOMPARTIDA As RadioButton
    Friend WithEvents RBDOBLE As RadioButton
    Friend WithEvents RBSENCILLA As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RBPRIMERA As RadioButton
    Friend WithEvents RBSEGUNDA As RadioButton
    Friend WithEvents ListBoxNIT As ListBox
    Friend WithEvents ListBoxNOMBRE As ListBox
    Friend WithEvents ListBoxCABINA As ListBox
    Friend WithEvents ListBoxCLASE As ListBox
    Friend WithEvents ListBoxPERSONAS As ListBox
    Friend WithEvents ListBoxPRECIOINICIAL As ListBox
    Friend WithEvents ListBoxTOTAL As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARLISTBOXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
