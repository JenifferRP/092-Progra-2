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
        Me.RBSMALL = New System.Windows.Forms.RadioButton()
        Me.RBMEDIUM = New System.Windows.Forms.RadioButton()
        Me.RBLARGE = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MATERIAL = New System.Windows.Forms.GroupBox()
        Me.RBALGODÓN = New System.Windows.Forms.RadioButton()
        Me.RBSEDA = New System.Windows.Forms.RadioButton()
        Me.RBLONA = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNCALCULAR = New System.Windows.Forms.Button()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MATERIAL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RBSMALL)
        Me.GroupBox1.Controls.Add(Me.RBMEDIUM)
        Me.GroupBox1.Controls.Add(Me.RBLARGE)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑOS"
        '
        'RBSMALL
        '
        Me.RBSMALL.AutoSize = True
        Me.RBSMALL.Location = New System.Drawing.Point(26, 40)
        Me.RBSMALL.Name = "RBSMALL"
        Me.RBSMALL.Size = New System.Drawing.Size(73, 24)
        Me.RBSMALL.TabIndex = 1
        Me.RBSMALL.Text = "Small"
        Me.RBSMALL.UseVisualStyleBackColor = True
        '
        'RBMEDIUM
        '
        Me.RBMEDIUM.AutoSize = True
        Me.RBMEDIUM.Location = New System.Drawing.Point(26, 84)
        Me.RBMEDIUM.Name = "RBMEDIUM"
        Me.RBMEDIUM.Size = New System.Drawing.Size(90, 24)
        Me.RBMEDIUM.TabIndex = 2
        Me.RBMEDIUM.Text = "Medium"
        Me.RBMEDIUM.UseVisualStyleBackColor = True
        '
        'RBLARGE
        '
        Me.RBLARGE.AutoSize = True
        Me.RBLARGE.Location = New System.Drawing.Point(26, 134)
        Me.RBLARGE.Name = "RBLARGE"
        Me.RBLARGE.Size = New System.Drawing.Size(75, 24)
        Me.RBLARGE.TabIndex = 3
        Me.RBLARGE.Text = "Large"
        Me.RBLARGE.UseVisualStyleBackColor = True
        '
        'MATERIAL
        '
        Me.MATERIAL.BackColor = System.Drawing.Color.Transparent
        Me.MATERIAL.Controls.Add(Me.RBALGODÓN)
        Me.MATERIAL.Controls.Add(Me.RBSEDA)
        Me.MATERIAL.Controls.Add(Me.RBLONA)
        Me.MATERIAL.Location = New System.Drawing.Point(22, 241)
        Me.MATERIAL.Name = "MATERIAL"
        Me.MATERIAL.Size = New System.Drawing.Size(216, 211)
        Me.MATERIAL.TabIndex = 4
        Me.MATERIAL.TabStop = False
        Me.MATERIAL.Text = "MATERIAL"
        '
        'RBALGODÓN
        '
        Me.RBALGODÓN.AutoSize = True
        Me.RBALGODÓN.Location = New System.Drawing.Point(26, 40)
        Me.RBALGODÓN.Name = "RBALGODÓN"
        Me.RBALGODÓN.Size = New System.Drawing.Size(93, 24)
        Me.RBALGODÓN.TabIndex = 1
        Me.RBALGODÓN.Text = "Algodón"
        Me.RBALGODÓN.UseVisualStyleBackColor = True
        '
        'RBSEDA
        '
        Me.RBSEDA.AutoSize = True
        Me.RBSEDA.Location = New System.Drawing.Point(26, 84)
        Me.RBSEDA.Name = "RBSEDA"
        Me.RBSEDA.Size = New System.Drawing.Size(72, 24)
        Me.RBSEDA.TabIndex = 2
        Me.RBSEDA.Text = "Seda"
        Me.RBSEDA.UseVisualStyleBackColor = True
        '
        'RBLONA
        '
        Me.RBLONA.AutoSize = True
        Me.RBLONA.Location = New System.Drawing.Point(26, 134)
        Me.RBLONA.Name = "RBLONA"
        Me.RBLONA.Size = New System.Drawing.Size(70, 24)
        Me.RBLONA.TabIndex = 3
        Me.RBLONA.Text = "Lona"
        Me.RBLONA.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(418, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(194, 26)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(414, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "INGRESE UNA CANTIDAD"
        '
        'BTNCALCULAR
        '
        Me.BTNCALCULAR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNCALCULAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNCALCULAR.Location = New System.Drawing.Point(435, 147)
        Me.BTNCALCULAR.Name = "BTNCALCULAR"
        Me.BTNCALCULAR.Size = New System.Drawing.Size(122, 35)
        Me.BTNCALCULAR.TabIndex = 7
        Me.BTNCALCULAR.Text = "CALCULAR"
        Me.BTNCALCULAR.UseVisualStyleBackColor = False
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNLIMPIAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(435, 223)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(122, 35)
        Me.BTNLIMPIAR.TabIndex = 8
        Me.BTNLIMPIAR.Text = "LIMPIAR"
        Me.BTNLIMPIAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNSALIR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNSALIR.Location = New System.Drawing.Point(435, 306)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(122, 34)
        Me.BTNSALIR.TabIndex = 9
        Me.BTNSALIR.Text = "SALIR"
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900998_CHUMPAS.My.Resources.Resources.RA21260_2020_M3Z_1
        Me.ClientSize = New System.Drawing.Size(729, 473)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNLIMPIAR)
        Me.Controls.Add(Me.BTNCALCULAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MATERIAL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "ÁREA DE CHUMPAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MATERIAL.ResumeLayout(False)
        Me.MATERIAL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBSMALL As RadioButton
    Friend WithEvents RBMEDIUM As RadioButton
    Friend WithEvents RBLARGE As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MATERIAL As GroupBox
    Friend WithEvents RBALGODÓN As RadioButton
    Friend WithEvents RBSEDA As RadioButton
    Friend WithEvents RBLONA As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNCALCULAR As Button
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents BTNSALIR As Button
End Class
