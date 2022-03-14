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
        Me.TXTCARNE = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTHORAS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBXDIAS = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPFECHA = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBEFECTIVO = New System.Windows.Forms.RadioButton()
        Me.RBCHEQUE = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNCALCULAR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RBINGLES = New System.Windows.Forms.RadioButton()
        Me.RBPORTU = New System.Windows.Forms.RadioButton()
        Me.RBFRANCES = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTCARNE)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL ESTUDIANTE"
        '
        'TXTCARNE
        '
        Me.TXTCARNE.Location = New System.Drawing.Point(27, 73)
        Me.TXTCARNE.Name = "TXTCARNE"
        Me.TXTCARNE.Size = New System.Drawing.Size(143, 26)
        Me.TXTCARNE.TabIndex = 2
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(27, 155)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(143, 26)
        Me.TXTNOMBRE.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CARNÉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOMBRE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBFRANCES)
        Me.GroupBox2.Controls.Add(Me.RBPORTU)
        Me.GroupBox2.Controls.Add(Me.RBINGLES)
        Me.GroupBox2.Controls.Add(Me.TXTHORAS)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CBXDIAS)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DTPFECHA)
        Me.GroupBox2.Location = New System.Drawing.Point(253, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 293)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CURSOS"
        '
        'TXTHORAS
        '
        Me.TXTHORAS.Location = New System.Drawing.Point(30, 251)
        Me.TXTHORAS.Name = "TXTHORAS"
        Me.TXTHORAS.Size = New System.Drawing.Size(143, 26)
        Me.TXTHORAS.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "HORAS"
        '
        'CBXDIAS
        '
        Me.CBXDIAS.FormattingEnabled = True
        Me.CBXDIAS.Items.AddRange(New Object() {"Viernes", "Sábado ", "Ambos"})
        Me.CBXDIAS.Location = New System.Drawing.Point(30, 183)
        Me.CBXDIAS.Name = "CBXDIAS"
        Me.CBXDIAS.Size = New System.Drawing.Size(210, 28)
        Me.CBXDIAS.TabIndex = 7
        Me.CBXDIAS.Text = "Seleccionar un días..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DÍAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "FECHA DE INSCRIPCIÓN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "IDIOMA"
        '
        'DTPFECHA
        '
        Me.DTPFECHA.Location = New System.Drawing.Point(30, 114)
        Me.DTPFECHA.Name = "DTPFECHA"
        Me.DTPFECHA.Size = New System.Drawing.Size(294, 26)
        Me.DTPFECHA.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RBEFECTIVO)
        Me.GroupBox3.Controls.Add(Me.RBCHEQUE)
        Me.GroupBox3.Location = New System.Drawing.Point(851, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 185)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MÉTODO DE PAGO "
        '
        'RBEFECTIVO
        '
        Me.RBEFECTIVO.AutoSize = True
        Me.RBEFECTIVO.Location = New System.Drawing.Point(43, 42)
        Me.RBEFECTIVO.Name = "RBEFECTIVO"
        Me.RBEFECTIVO.Size = New System.Drawing.Size(114, 24)
        Me.RBEFECTIVO.TabIndex = 9
        Me.RBEFECTIVO.TabStop = True
        Me.RBEFECTIVO.Text = "EFECTIVO"
        Me.RBEFECTIVO.UseVisualStyleBackColor = True
        '
        'RBCHEQUE
        '
        Me.RBCHEQUE.AutoSize = True
        Me.RBCHEQUE.Location = New System.Drawing.Point(43, 108)
        Me.RBCHEQUE.Name = "RBCHEQUE"
        Me.RBCHEQUE.Size = New System.Drawing.Size(103, 24)
        Me.RBCHEQUE.TabIndex = 10
        Me.RBCHEQUE.TabStop = True
        Me.RBCHEQUE.Text = "CHEQUE"
        Me.RBCHEQUE.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 316)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1105, 239)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "REGISTRO"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "CARNÉ"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOMBRE"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "IDIOMA"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "FECHA"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "DÍAS"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "HORAS"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "MÉTODO DE PAGO"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "PAGO PARCIAL"
        Me.Column9.MinimumWidth = 8
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 150
        '
        'Column10
        '
        Me.Column10.HeaderText = "DESCUENTO 1"
        Me.Column10.MinimumWidth = 8
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 150
        '
        'Column11
        '
        Me.Column11.HeaderText = "DESCUENTO 2 "
        Me.Column11.MinimumWidth = 8
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 150
        '
        'Column12
        '
        Me.Column12.HeaderText = "TOTAL"
        Me.Column12.MinimumWidth = 8
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 150
        '
        'BTNCALCULAR
        '
        Me.BTNCALCULAR.Location = New System.Drawing.Point(719, 579)
        Me.BTNCALCULAR.Name = "BTNCALCULAR"
        Me.BTNCALCULAR.Size = New System.Drawing.Size(107, 37)
        Me.BTNCALCULAR.TabIndex = 3
        Me.BTNCALCULAR.Text = "CALCULAR"
        Me.BTNCALCULAR.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(974, 579)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(851, 579)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RBINGLES
        '
        Me.RBINGLES.AutoSize = True
        Me.RBINGLES.Location = New System.Drawing.Point(17, 54)
        Me.RBINGLES.Name = "RBINGLES"
        Me.RBINGLES.Size = New System.Drawing.Size(94, 24)
        Me.RBINGLES.TabIndex = 9
        Me.RBINGLES.TabStop = True
        Me.RBINGLES.Text = "INGLÉS"
        Me.RBINGLES.UseVisualStyleBackColor = True
        '
        'RBPORTU
        '
        Me.RBPORTU.AutoSize = True
        Me.RBPORTU.Location = New System.Drawing.Point(170, 54)
        Me.RBPORTU.Name = "RBPORTU"
        Me.RBPORTU.Size = New System.Drawing.Size(124, 24)
        Me.RBPORTU.TabIndex = 10
        Me.RBPORTU.TabStop = True
        Me.RBPORTU.Text = "PORTUGÉS"
        Me.RBPORTU.UseVisualStyleBackColor = True
        '
        'RBFRANCES
        '
        Me.RBFRANCES.AutoSize = True
        Me.RBFRANCES.Location = New System.Drawing.Point(322, 54)
        Me.RBFRANCES.Name = "RBFRANCES"
        Me.RBFRANCES.Size = New System.Drawing.Size(111, 24)
        Me.RBFRANCES.TabIndex = 11
        Me.RBFRANCES.TabStop = True
        Me.RBFRANCES.Text = "FRANCÉS"
        Me.RBFRANCES.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 621)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNCALCULAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTCARNE As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBXDIAS As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPFECHA As DateTimePicker
    Friend WithEvents TXTHORAS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RBEFECTIVO As RadioButton
    Friend WithEvents RBCHEQUE As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTNCALCULAR As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RBFRANCES As RadioButton
    Friend WithEvents RBPORTU As RadioButton
    Friend WithEvents RBINGLES As RadioButton
End Class
