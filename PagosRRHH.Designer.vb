<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosRRHH
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
        Me.Dvgtutorias = New System.Windows.Forms.DataGridView()
        Me.txtcodtutor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtporcentaje = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcodtutoria = New System.Windows.Forms.TextBox()
        Me.txtTotalFac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodPago = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Btneliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.Dvgtutorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dvgtutorias
        '
        Me.Dvgtutorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dvgtutorias.Location = New System.Drawing.Point(379, 34)
        Me.Dvgtutorias.Name = "Dvgtutorias"
        Me.Dvgtutorias.Size = New System.Drawing.Size(522, 278)
        Me.Dvgtutorias.TabIndex = 0
        '
        'txtcodtutor
        '
        Me.txtcodtutor.Enabled = False
        Me.txtcodtutor.Location = New System.Drawing.Point(136, 77)
        Me.txtcodtutor.Name = "txtcodtutor"
        Me.txtcodtutor.Size = New System.Drawing.Size(154, 20)
        Me.txtcodtutor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cod. Tutor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Porcentaje tutor"
        '
        'txtporcentaje
        '
        Me.txtporcentaje.Enabled = False
        Me.txtporcentaje.Location = New System.Drawing.Point(136, 178)
        Me.txtporcentaje.Name = "txtporcentaje"
        Me.txtporcentaje.Size = New System.Drawing.Size(154, 20)
        Me.txtporcentaje.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(35, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cantidad"
        '
        'txtcantidad
        '
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Location = New System.Drawing.Point(136, 222)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(154, 20)
        Me.txtcantidad.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(376, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tutorias"
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Location = New System.Drawing.Point(379, 349)
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.Size = New System.Drawing.Size(522, 278)
        Me.dgvPagos.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(384, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Pagos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(35, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Cod. Tutoria"
        '
        'txtcodtutoria
        '
        Me.txtcodtutoria.Enabled = False
        Me.txtcodtutoria.Location = New System.Drawing.Point(136, 103)
        Me.txtcodtutoria.Name = "txtcodtutoria"
        Me.txtcodtutoria.Size = New System.Drawing.Size(154, 20)
        Me.txtcodtutoria.TabIndex = 54
        '
        'txtTotalFac
        '
        Me.txtTotalFac.Enabled = False
        Me.txtTotalFac.Location = New System.Drawing.Point(136, 145)
        Me.txtTotalFac.Name = "txtTotalFac"
        Me.txtTotalFac.Size = New System.Drawing.Size(154, 20)
        Me.txtTotalFac.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Total Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Cod. Pago"
        '
        'txtCodPago
        '
        Me.txtCodPago.Enabled = False
        Me.txtCodPago.Location = New System.Drawing.Point(136, 43)
        Me.txtCodPago.Name = "txtCodPago"
        Me.txtCodPago.Size = New System.Drawing.Size(154, 20)
        Me.txtCodPago.TabIndex = 59
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(136, 279)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 61
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Btneliminar
        '
        Me.Btneliminar.Image = Global.Proyecto_Final.My.Resources.Resources.minuscirclehd_106108
        Me.Btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btneliminar.Location = New System.Drawing.Point(120, 422)
        Me.Btneliminar.Name = "Btneliminar"
        Me.Btneliminar.Size = New System.Drawing.Size(128, 54)
        Me.Btneliminar.TabIndex = 60
        Me.Btneliminar.Text = "Eliminar"
        Me.Btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btneliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(120, 349)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(128, 56)
        Me.btnAgregar.TabIndex = 53
        Me.btnAgregar.Text = "Realizar pago"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'PagosRRHH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(929, 650)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Btneliminar)
        Me.Controls.Add(Me.txtCodPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalFac)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcodtutoria)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvPagos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtporcentaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcodtutor)
        Me.Controls.Add(Me.Dvgtutorias)
        Me.Name = "PagosRRHH"
        Me.Text = "PagosRRHH"
        CType(Me.Dvgtutorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dvgtutorias As DataGridView
    Friend WithEvents txtcodtutor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtporcentaje As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvPagos As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcodtutoria As TextBox
    Friend WithEvents txtTotalFac As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodPago As TextBox
    Friend WithEvents Btneliminar As Button
    Friend WithEvents btnCalcular As Button
End Class
