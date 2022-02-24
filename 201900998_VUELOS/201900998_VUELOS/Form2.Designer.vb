<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.Txtdescuento = New System.Windows.Forms.TextBox()
        Me.Txtsubtotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descuento"
        '
        'Txttotal
        '
        Me.Txttotal.Enabled = False
        Me.Txttotal.Location = New System.Drawing.Point(226, 217)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(161, 26)
        Me.Txttotal.TabIndex = 3
        '
        'Txtdescuento
        '
        Me.Txtdescuento.Enabled = False
        Me.Txtdescuento.Location = New System.Drawing.Point(226, 143)
        Me.Txtdescuento.Name = "Txtdescuento"
        Me.Txtdescuento.Size = New System.Drawing.Size(161, 26)
        Me.Txtdescuento.TabIndex = 4
        '
        'Txtsubtotal
        '
        Me.Txtsubtotal.Enabled = False
        Me.Txtsubtotal.Location = New System.Drawing.Point(226, 79)
        Me.Txtsubtotal.Name = "Txtsubtotal"
        Me.Txtsubtotal.Size = New System.Drawing.Size(161, 26)
        Me.Txtsubtotal.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900998_VUELOS.My.Resources.Resources._5f5b7e5f60758fbf6e0df674_comparador_vuelos1
        Me.ClientSize = New System.Drawing.Size(554, 450)
        Me.Controls.Add(Me.Txtsubtotal)
        Me.Controls.Add(Me.Txtdescuento)
        Me.Controls.Add(Me.Txttotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "TOTALES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txttotal As TextBox
    Friend WithEvents Txtdescuento As TextBox
    Friend WithEvents Txtsubtotal As TextBox
End Class
