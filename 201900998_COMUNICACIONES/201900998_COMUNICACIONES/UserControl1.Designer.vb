<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNCALCULAR = New System.Windows.Forms.Button()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBTELE = New System.Windows.Forms.RadioButton()
        Me.RBCELULAR = New System.Windows.Forms.RadioButton()
        Me.RBDRONE = New System.Windows.Forms.RadioButton()
        Me.RTABLET = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTVALOR = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(717, 509)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTNCALCULAR
        '
        Me.BTNCALCULAR.Location = New System.Drawing.Point(444, 509)
        Me.BTNCALCULAR.Name = "BTNCALCULAR"
        Me.BTNCALCULAR.Size = New System.Drawing.Size(107, 34)
        Me.BTNCALCULAR.TabIndex = 1
        Me.BTNCALCULAR.Text = "CALCULAR"
        Me.BTNCALCULAR.UseVisualStyleBackColor = True
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(580, 509)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(107, 34)
        Me.BTNLIMPIAR.TabIndex = 2
        Me.BTNLIMPIAR.Text = "LIMPIAR"
        Me.BTNLIMPIAR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBTELE)
        Me.GroupBox1.Controls.Add(Me.RBCELULAR)
        Me.GroupBox1.Controls.Add(Me.RBDRONE)
        Me.GroupBox1.Controls.Add(Me.RTABLET)
        Me.GroupBox1.Location = New System.Drawing.Point(445, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 208)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ARTÍCULOS"
        '
        'RBTELE
        '
        Me.RBTELE.AutoSize = True
        Me.RBTELE.Location = New System.Drawing.Point(12, 164)
        Me.RBTELE.Name = "RBTELE"
        Me.RBTELE.Size = New System.Drawing.Size(125, 24)
        Me.RBTELE.TabIndex = 3
        Me.RBTELE.TabStop = True
        Me.RBTELE.Text = "TELEVISOR"
        Me.RBTELE.UseVisualStyleBackColor = True
        '
        'RBCELULAR
        '
        Me.RBCELULAR.AutoSize = True
        Me.RBCELULAR.Location = New System.Drawing.Point(12, 113)
        Me.RBCELULAR.Name = "RBCELULAR"
        Me.RBCELULAR.Size = New System.Drawing.Size(109, 24)
        Me.RBCELULAR.TabIndex = 2
        Me.RBCELULAR.TabStop = True
        Me.RBCELULAR.Text = "CELULAR"
        Me.RBCELULAR.UseVisualStyleBackColor = True
        '
        'RBDRONE
        '
        Me.RBDRONE.AutoSize = True
        Me.RBDRONE.Location = New System.Drawing.Point(12, 72)
        Me.RBDRONE.Name = "RBDRONE"
        Me.RBDRONE.Size = New System.Drawing.Size(92, 24)
        Me.RBDRONE.TabIndex = 1
        Me.RBDRONE.TabStop = True
        Me.RBDRONE.Text = "DRONE"
        Me.RBDRONE.UseVisualStyleBackColor = True
        '
        'RTABLET
        '
        Me.RTABLET.AutoSize = True
        Me.RTABLET.Location = New System.Drawing.Point(12, 25)
        Me.RTABLET.Name = "RTABLET"
        Me.RTABLET.Size = New System.Drawing.Size(94, 24)
        Me.RTABLET.TabIndex = 0
        Me.RTABLET.TabStop = True
        Me.RTABLET.Text = "TABLET"
        Me.RTABLET.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXTVALOR)
        Me.GroupBox2.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 127)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TXTVALOR
        '
        Me.TXTVALOR.Location = New System.Drawing.Point(134, 87)
        Me.TXTVALOR.Name = "TXTVALOR"
        Me.TXTVALOR.Size = New System.Drawing.Size(159, 26)
        Me.TXTVALOR.TabIndex = 3
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(134, 42)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(159, 26)
        Me.TXTNOMBRE.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SUELDO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE "
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(20, 254)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 204)
        Me.ListBox1.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(158, 254)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 204)
        Me.ListBox2.TabIndex = 5
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(299, 254)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 204)
        Me.ListBox3.TabIndex = 6
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(431, 254)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 204)
        Me.ListBox4.TabIndex = 7
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(567, 254)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 204)
        Me.ListBox5.TabIndex = 8
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 20
        Me.ListBox6.Location = New System.Drawing.Point(704, 254)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(120, 204)
        Me.ListBox6.TabIndex = 9
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNLIMPIAR)
        Me.Controls.Add(Me.BTNCALCULAR)
        Me.Controls.Add(Me.Button1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(909, 564)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BTNCALCULAR As Button
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBTELE As RadioButton
    Friend WithEvents RBCELULAR As RadioButton
    Friend WithEvents RBDRONE As RadioButton
    Friend WithEvents RTABLET As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXTVALOR As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
End Class
