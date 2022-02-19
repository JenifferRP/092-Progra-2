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
        Me.TxtprecioC = New System.Windows.Forms.TextBox()
        Me.TxtprecioV = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(187, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRECIO DE COSTO (Q)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(189, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PRECIO DE VENTA (Q)"
        '
        'TxtprecioC
        '
        Me.TxtprecioC.Enabled = False
        Me.TxtprecioC.Location = New System.Drawing.Point(415, 136)
        Me.TxtprecioC.Name = "TxtprecioC"
        Me.TxtprecioC.Size = New System.Drawing.Size(170, 26)
        Me.TxtprecioC.TabIndex = 2
        '
        'TxtprecioV
        '
        Me.TxtprecioV.Enabled = False
        Me.TxtprecioV.Location = New System.Drawing.Point(415, 255)
        Me.TxtprecioV.Name = "TxtprecioV"
        Me.TxtprecioV.Size = New System.Drawing.Size(170, 26)
        Me.TxtprecioV.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900998_CHUMPAS.My.Resources.Resources.expositores_de_tienda
        Me.ClientSize = New System.Drawing.Size(690, 452)
        Me.Controls.Add(Me.TxtprecioV)
        Me.Controls.Add(Me.TxtprecioC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "PRECIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtprecioC As TextBox
    Friend WithEvents TxtprecioV As TextBox
End Class
