<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.dgvclientes = New System.Windows.Forms.DataGridView()
        Me.txtbuscarc = New System.Windows.Forms.TextBox()
        Me.cbuniversidad = New System.Windows.Forms.ComboBox()
        Me.nudedad = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnmostrarhabilitados = New System.Windows.Forms.Button()
        Me.btnmostrartod = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btndeshabilitar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnhabilitar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 186)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 230)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Celular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 270)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Universidad:"
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Enabled = False
        Me.txtcodcliente.Location = New System.Drawing.Point(130, 37)
        Me.txtcodcliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(120, 20)
        Me.txtcodcliente.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(130, 73)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(120, 20)
        Me.txtnombre.TabIndex = 8
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(130, 108)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(120, 20)
        Me.txtapellido.TabIndex = 9
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(130, 146)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(120, 20)
        Me.txtcorreo.TabIndex = 10
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(130, 230)
        Me.txtcelular.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(120, 20)
        Me.txtcelular.TabIndex = 12
        '
        'dgvclientes
        '
        Me.dgvclientes.AllowUserToAddRows = False
        Me.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclientes.Location = New System.Drawing.Point(309, 35)
        Me.dgvclientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvclientes.Name = "dgvclientes"
        Me.dgvclientes.RowHeadersWidth = 51
        Me.dgvclientes.RowTemplate.Height = 24
        Me.dgvclientes.Size = New System.Drawing.Size(553, 314)
        Me.dgvclientes.TabIndex = 18
        '
        'txtbuscarc
        '
        Me.txtbuscarc.Location = New System.Drawing.Point(130, 329)
        Me.txtbuscarc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbuscarc.Name = "txtbuscarc"
        Me.txtbuscarc.Size = New System.Drawing.Size(132, 20)
        Me.txtbuscarc.TabIndex = 19
        '
        'cbuniversidad
        '
        Me.cbuniversidad.FormattingEnabled = True
        Me.cbuniversidad.Location = New System.Drawing.Point(130, 270)
        Me.cbuniversidad.Name = "cbuniversidad"
        Me.cbuniversidad.Size = New System.Drawing.Size(121, 21)
        Me.cbuniversidad.TabIndex = 23
        '
        'nudedad
        '
        Me.nudedad.Location = New System.Drawing.Point(130, 186)
        Me.nudedad.Name = "nudedad"
        Me.nudedad.Size = New System.Drawing.Size(120, 20)
        Me.nudedad.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Proyecto_Final.My.Resources.Resources._1486504846_clipboard_tasks_report_business_checking_verification_document_81354
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(711, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 71)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Reporte"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnmostrarhabilitados
        '
        Me.btnmostrarhabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrarhabilitados.Image = CType(resources.GetObject("btnmostrarhabilitados.Image"), System.Drawing.Image)
        Me.btnmostrarhabilitados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmostrarhabilitados.Location = New System.Drawing.Point(597, 363)
        Me.btnmostrarhabilitados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmostrarhabilitados.Name = "btnmostrarhabilitados"
        Me.btnmostrarhabilitados.Size = New System.Drawing.Size(181, 51)
        Me.btnmostrarhabilitados.TabIndex = 22
        Me.btnmostrarhabilitados.Text = "Mostrar Habilitados"
        Me.btnmostrarhabilitados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmostrarhabilitados.UseVisualStyleBackColor = True
        '
        'btnmostrartod
        '
        Me.btnmostrartod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrartod.Image = CType(resources.GetObject("btnmostrartod.Image"), System.Drawing.Image)
        Me.btnmostrartod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmostrartod.Location = New System.Drawing.Point(382, 363)
        Me.btnmostrartod.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmostrartod.Name = "btnmostrartod"
        Me.btnmostrartod.Size = New System.Drawing.Size(181, 48)
        Me.btnmostrartod.TabIndex = 21
        Me.btnmostrartod.Text = "Mostrar Todo"
        Me.btnmostrartod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmostrartod.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.Location = New System.Drawing.Point(26, 315)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(84, 46)
        Me.btnbuscar.TabIndex = 20
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btndeshabilitar
        '
        Me.btndeshabilitar.BackColor = System.Drawing.SystemColors.Control
        Me.btndeshabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeshabilitar.Image = CType(resources.GetObject("btndeshabilitar.Image"), System.Drawing.Image)
        Me.btndeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndeshabilitar.Location = New System.Drawing.Point(499, 441)
        Me.btndeshabilitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btndeshabilitar.Name = "btndeshabilitar"
        Me.btndeshabilitar.Size = New System.Drawing.Size(159, 62)
        Me.btndeshabilitar.TabIndex = 17
        Me.btndeshabilitar.Text = "Deshabilitar"
        Me.btndeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeshabilitar.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar.Location = New System.Drawing.Point(341, 441)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(135, 62)
        Me.btnmodificar.TabIndex = 16
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnhabilitar
        '
        Me.btnhabilitar.BackColor = System.Drawing.SystemColors.Control
        Me.btnhabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhabilitar.Image = CType(resources.GetObject("btnhabilitar.Image"), System.Drawing.Image)
        Me.btnhabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhabilitar.Location = New System.Drawing.Point(178, 440)
        Me.btnhabilitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhabilitar.Name = "btnhabilitar"
        Me.btnhabilitar.Size = New System.Drawing.Size(135, 63)
        Me.btnhabilitar.TabIndex = 15
        Me.btnhabilitar.Text = "Habilitar"
        Me.btnhabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhabilitar.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.SystemColors.Control
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Image = CType(resources.GetObject("btnagregar.Image"), System.Drawing.Image)
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.Location = New System.Drawing.Point(26, 440)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(135, 63)
        Me.btnagregar.TabIndex = 14
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(894, 546)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nudedad)
        Me.Controls.Add(Me.cbuniversidad)
        Me.Controls.Add(Me.btnmostrarhabilitados)
        Me.Controls.Add(Me.btnmostrartod)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbuscarc)
        Me.Controls.Add(Me.dgvclientes)
        Me.Controls.Add(Me.btndeshabilitar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnhabilitar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtcelular)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcodcliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcodcliente As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnhabilitar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btndeshabilitar As Button
    Friend WithEvents dgvclientes As DataGridView
    Friend WithEvents txtbuscarc As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnmostrartod As Button
    Private WithEvents btnmostrarhabilitados As Button
    Friend WithEvents cbuniversidad As ComboBox
    Friend WithEvents nudedad As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
