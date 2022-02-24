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
        Me.GBDATOS = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBVE = New System.Windows.Forms.CheckBox()
        Me.CBACC = New System.Windows.Forms.CheckBox()
        Me.CBOCC = New System.Windows.Forms.CheckBox()
        Me.CBOR = New System.Windows.Forms.CheckBox()
        Me.CBS = New System.Windows.Forms.CheckBox()
        Me.CBN = New System.Windows.Forms.CheckBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNOMBRE = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBDATOS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBDATOS
        '
        Me.GBDATOS.BackColor = System.Drawing.Color.Transparent
        Me.GBDATOS.Controls.Add(Me.GroupBox1)
        Me.GBDATOS.Controls.Add(Me.CBOCC)
        Me.GBDATOS.Controls.Add(Me.CBOR)
        Me.GBDATOS.Controls.Add(Me.CBS)
        Me.GBDATOS.Controls.Add(Me.CBN)
        Me.GBDATOS.Controls.Add(Me.Txtnombre)
        Me.GBDATOS.Controls.Add(Me.Label3)
        Me.GBDATOS.Controls.Add(Me.LNOMBRE)
        Me.GBDATOS.Location = New System.Drawing.Point(0, 0)
        Me.GBDATOS.Name = "GBDATOS"
        Me.GBDATOS.Size = New System.Drawing.Size(472, 313)
        Me.GBDATOS.TabIndex = 0
        Me.GBDATOS.TabStop = False
        Me.GBDATOS.Text = "DATOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBVE)
        Me.GroupBox1.Controls.Add(Me.CBACC)
        Me.GroupBox1.Location = New System.Drawing.Point(245, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 144)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEGUROS"
        '
        'CBVE
        '
        Me.CBVE.AutoSize = True
        Me.CBVE.BackColor = System.Drawing.Color.Black
        Me.CBVE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CBVE.Location = New System.Drawing.Point(26, 43)
        Me.CBVE.Name = "CBVE"
        Me.CBVE.Size = New System.Drawing.Size(118, 24)
        Me.CBVE.TabIndex = 14
        Me.CBVE.Text = "VEHICULO"
        Me.CBVE.UseVisualStyleBackColor = False
        '
        'CBACC
        '
        Me.CBACC.AutoSize = True
        Me.CBACC.BackColor = System.Drawing.Color.Black
        Me.CBACC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CBACC.Location = New System.Drawing.Point(26, 93)
        Me.CBACC.Name = "CBACC"
        Me.CBACC.Size = New System.Drawing.Size(138, 24)
        Me.CBACC.TabIndex = 15
        Me.CBACC.Text = "ACCIDENTES"
        Me.CBACC.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CBACC.UseVisualStyleBackColor = False
        '
        'CBOCC
        '
        Me.CBOCC.AutoSize = True
        Me.CBOCC.BackColor = System.Drawing.Color.Black
        Me.CBOCC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CBOCC.Location = New System.Drawing.Point(105, 262)
        Me.CBOCC.Name = "CBOCC"
        Me.CBOCC.Size = New System.Drawing.Size(128, 24)
        Me.CBOCC.TabIndex = 12
        Me.CBOCC.Text = "OCCIDENTE"
        Me.CBOCC.UseVisualStyleBackColor = False
        '
        'CBOR
        '
        Me.CBOR.AutoSize = True
        Me.CBOR.BackColor = System.Drawing.Color.Black
        Me.CBOR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CBOR.Location = New System.Drawing.Point(105, 205)
        Me.CBOR.Name = "CBOR"
        Me.CBOR.Size = New System.Drawing.Size(106, 24)
        Me.CBOR.TabIndex = 11
        Me.CBOR.Text = "ORIENTE"
        Me.CBOR.UseVisualStyleBackColor = False
        '
        'CBS
        '
        Me.CBS.AutoSize = True
        Me.CBS.BackColor = System.Drawing.Color.Black
        Me.CBS.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CBS.Location = New System.Drawing.Point(105, 160)
        Me.CBS.Name = "CBS"
        Me.CBS.Size = New System.Drawing.Size(70, 24)
        Me.CBS.TabIndex = 10
        Me.CBS.Text = "SUR"
        Me.CBS.UseVisualStyleBackColor = False
        '
        'CBN
        '
        Me.CBN.AutoSize = True
        Me.CBN.BackColor = System.Drawing.Color.Black
        Me.CBN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CBN.Location = New System.Drawing.Point(105, 121)
        Me.CBN.Name = "CBN"
        Me.CBN.Size = New System.Drawing.Size(90, 24)
        Me.CBN.TabIndex = 9
        Me.CBN.Text = "NORTE"
        Me.CBN.UseVisualStyleBackColor = False
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(228, 32)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(100, 26)
        Me.Txtnombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "REGIÓN"
        '
        'LNOMBRE
        '
        Me.LNOMBRE.AutoSize = True
        Me.LNOMBRE.BackColor = System.Drawing.Color.Black
        Me.LNOMBRE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LNOMBRE.Location = New System.Drawing.Point(12, 32)
        Me.LNOMBRE.Name = "LNOMBRE"
        Me.LNOMBRE.Size = New System.Drawing.Size(183, 20)
        Me.LNOMBRE.TabIndex = 0
        Me.LNOMBRE.Text = "NOMBRE MENSAJERO"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(519, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 214)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPCIONES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CONFIRMAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(52, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(52, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 41)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(519, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(468, 162)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULTADOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(48, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "SUELDO FINAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(48, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEGURO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900998_ENVIOS.My.Resources.Resources.item_go
        Me.ClientSize = New System.Drawing.Size(1081, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBDATOS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBDATOS.ResumeLayout(False)
        Me.GBDATOS.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBDATOS As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LNOMBRE As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBVE As CheckBox
    Friend WithEvents CBACC As CheckBox
    Friend WithEvents CBOCC As CheckBox
    Friend WithEvents CBOR As CheckBox
    Friend WithEvents CBS As CheckBox
    Friend WithEvents CBN As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
