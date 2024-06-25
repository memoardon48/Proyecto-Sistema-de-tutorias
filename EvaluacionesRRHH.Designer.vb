<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EvaluacionesRRHH
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
        Me.txtCodEvalua = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCodtuto = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.nudMetododE = New System.Windows.Forms.NumericUpDown()
        Me.nudRespetuo = New System.Windows.Forms.NumericUpDown()
        Me.nudConfianza = New System.Windows.Forms.NumericUpDown()
        Me.nudComprensiondC = New System.Windows.Forms.NumericUpDown()
        Me.nudPrepa = New System.Windows.Forms.NumericUpDown()
        Me.nudResoludD = New System.Windows.Forms.NumericUpDown()
        Me.nudTiempoeficaz = New System.Windows.Forms.NumericUpDown()
        Me.dgvRecursosHumanos = New System.Windows.Forms.DataGridView()
        Me.btnDeshabilitar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.nudMetododE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRespetuo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConfianza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudComprensiondC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrepa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudResoludD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTiempoeficaz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecursosHumanos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodEvalua
        '
        Me.txtCodEvalua.Enabled = False
        Me.txtCodEvalua.Location = New System.Drawing.Point(186, 46)
        Me.txtCodEvalua.Name = "txtCodEvalua"
        Me.txtCodEvalua.Size = New System.Drawing.Size(100, 20)
        Me.txtCodEvalua.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "codEvaluacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "codTutor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Metodo de enseñanza"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tiempo eficaz"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Resolucion de Dudas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(43, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Respetuo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(43, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Confianza"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(43, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Comprension del cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(43, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Preparacion"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(186, 92)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 11
        '
        'txtCodtuto
        '
        Me.txtCodtuto.Enabled = False
        Me.txtCodtuto.Location = New System.Drawing.Point(186, 130)
        Me.txtCodtuto.Name = "txtCodtuto"
        Me.txtCodtuto.Size = New System.Drawing.Size(100, 20)
        Me.txtCodtuto.TabIndex = 12
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(311, 128)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'nudMetododE
        '
        Me.nudMetododE.Location = New System.Drawing.Point(186, 166)
        Me.nudMetododE.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudMetododE.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMetododE.Name = "nudMetododE"
        Me.nudMetododE.Size = New System.Drawing.Size(100, 20)
        Me.nudMetododE.TabIndex = 44
        Me.nudMetododE.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudRespetuo
        '
        Me.nudRespetuo.Location = New System.Drawing.Point(186, 271)
        Me.nudRespetuo.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudRespetuo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRespetuo.Name = "nudRespetuo"
        Me.nudRespetuo.Size = New System.Drawing.Size(100, 20)
        Me.nudRespetuo.TabIndex = 45
        Me.nudRespetuo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudConfianza
        '
        Me.nudConfianza.Location = New System.Drawing.Point(186, 303)
        Me.nudConfianza.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudConfianza.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudConfianza.Name = "nudConfianza"
        Me.nudConfianza.Size = New System.Drawing.Size(100, 20)
        Me.nudConfianza.TabIndex = 46
        Me.nudConfianza.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudComprensiondC
        '
        Me.nudComprensiondC.Location = New System.Drawing.Point(186, 334)
        Me.nudComprensiondC.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudComprensiondC.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudComprensiondC.Name = "nudComprensiondC"
        Me.nudComprensiondC.Size = New System.Drawing.Size(100, 20)
        Me.nudComprensiondC.TabIndex = 47
        Me.nudComprensiondC.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPrepa
        '
        Me.nudPrepa.Location = New System.Drawing.Point(186, 364)
        Me.nudPrepa.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPrepa.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPrepa.Name = "nudPrepa"
        Me.nudPrepa.Size = New System.Drawing.Size(100, 20)
        Me.nudPrepa.TabIndex = 48
        Me.nudPrepa.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudResoludD
        '
        Me.nudResoludD.Location = New System.Drawing.Point(186, 243)
        Me.nudResoludD.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudResoludD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudResoludD.Name = "nudResoludD"
        Me.nudResoludD.Size = New System.Drawing.Size(100, 20)
        Me.nudResoludD.TabIndex = 49
        Me.nudResoludD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudTiempoeficaz
        '
        Me.nudTiempoeficaz.Location = New System.Drawing.Point(186, 206)
        Me.nudTiempoeficaz.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudTiempoeficaz.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTiempoeficaz.Name = "nudTiempoeficaz"
        Me.nudTiempoeficaz.Size = New System.Drawing.Size(100, 20)
        Me.nudTiempoeficaz.TabIndex = 50
        Me.nudTiempoeficaz.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dgvRecursosHumanos
        '
        Me.dgvRecursosHumanos.AllowUserToAddRows = False
        Me.dgvRecursosHumanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecursosHumanos.Location = New System.Drawing.Point(433, 31)
        Me.dgvRecursosHumanos.Name = "dgvRecursosHumanos"
        Me.dgvRecursosHumanos.Size = New System.Drawing.Size(558, 364)
        Me.dgvRecursosHumanos.TabIndex = 51
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.Image = Global.Proyecto_Final.My.Resources.Resources.vcsconflicting_93497
        Me.btnDeshabilitar.Location = New System.Drawing.Point(306, 419)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(120, 56)
        Me.btnDeshabilitar.TabIndex = 54
        Me.btnDeshabilitar.Text = "Eliminar"
        Me.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.Proyecto_Final.My.Resources.Resources.edit_icon_icons_com_66118__1_
        Me.btnModificar.Location = New System.Drawing.Point(172, 419)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(114, 55)
        Me.btnModificar.TabIndex = 53
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(42, 419)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(105, 55)
        Me.btnAgregar.TabIndex = 52
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'EvaluacionesRRHH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1003, 522)
        Me.Controls.Add(Me.btnDeshabilitar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvRecursosHumanos)
        Me.Controls.Add(Me.nudTiempoeficaz)
        Me.Controls.Add(Me.nudResoludD)
        Me.Controls.Add(Me.nudPrepa)
        Me.Controls.Add(Me.nudComprensiondC)
        Me.Controls.Add(Me.nudConfianza)
        Me.Controls.Add(Me.nudRespetuo)
        Me.Controls.Add(Me.nudMetododE)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodtuto)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodEvalua)
        Me.Name = "EvaluacionesRRHH"
        Me.Text = "Evaluaciones"
        CType(Me.nudMetododE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRespetuo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConfianza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudComprensiondC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrepa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudResoludD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTiempoeficaz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecursosHumanos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodEvalua As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtCodtuto As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents nudMetododE As NumericUpDown
    Friend WithEvents nudRespetuo As NumericUpDown
    Friend WithEvents nudConfianza As NumericUpDown
    Friend WithEvents nudComprensiondC As NumericUpDown
    Friend WithEvents nudPrepa As NumericUpDown
    Friend WithEvents nudResoludD As NumericUpDown
    Friend WithEvents nudTiempoeficaz As NumericUpDown
    Friend WithEvents dgvRecursosHumanos As DataGridView
    Friend WithEvents btnDeshabilitar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
End Class
