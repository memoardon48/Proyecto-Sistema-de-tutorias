<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tutor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tutor))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvtutor = New System.Windows.Forms.DataGridView()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodtutor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbUniversidad = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscartu = New System.Windows.Forms.Button()
        Me.btnmostrarhabilitados = New System.Windows.Forms.Button()
        Me.btnmostrartod = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btndeshabilitar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnhabilitar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.nudEdad = New System.Windows.Forms.NumericUpDown()
        Me.cboCarrera = New System.Windows.Forms.ComboBox()
        CType(Me.dgvtutor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(128, 405)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(132, 20)
        Me.txtBuscar.TabIndex = 42
        '
        'dgvtutor
        '
        Me.dgvtutor.AllowUserToAddRows = False
        Me.dgvtutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtutor.Location = New System.Drawing.Point(311, 17)
        Me.dgvtutor.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvtutor.Name = "dgvtutor"
        Me.dgvtutor.RowHeadersWidth = 51
        Me.dgvtutor.RowTemplate.Height = 24
        Me.dgvtutor.Size = New System.Drawing.Size(614, 335)
        Me.dgvtutor.TabIndex = 41
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(128, 219)
        Me.txtcelular.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(120, 20)
        Me.txtcelular.TabIndex = 35
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(128, 136)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(156, 20)
        Me.txtcorreo.TabIndex = 33
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(128, 100)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(120, 20)
        Me.txtapellido.TabIndex = 32
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(128, 63)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(120, 20)
        Me.txtnombre.TabIndex = 31
        '
        'txtcodtutor
        '
        Me.txtcodtutor.Enabled = False
        Me.txtcodtutor.Location = New System.Drawing.Point(128, 30)
        Me.txtcodtutor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodtutor.Name = "txtcodtutor"
        Me.txtcodtutor.Size = New System.Drawing.Size(120, 20)
        Me.txtcodtutor.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-73, 231)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Universidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-73, 191)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Celular:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-73, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Edad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-73, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-73, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-73, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-73, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Codigo Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 259)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Universidad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 222)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Celular:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 178)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Edad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 138)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "E-mail:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 102)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 17)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Apellido:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 63)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 17)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 30)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 17)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Codigo Tutor:"
        '
        'cmbUniversidad
        '
        Me.cmbUniversidad.FormattingEnabled = True
        Me.cmbUniversidad.Items.AddRange(New Object() {"UNICAH", "UNAH", "UNITEC", "CEUTEC"})
        Me.cmbUniversidad.Location = New System.Drawing.Point(128, 259)
        Me.cmbUniversidad.Name = "cmbUniversidad"
        Me.cmbUniversidad.Size = New System.Drawing.Size(156, 21)
        Me.cmbUniversidad.TabIndex = 56
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(30, 316)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Cuenta:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(128, 313)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(156, 20)
        Me.txtCuenta.TabIndex = 57
        '
        'cmbBanco
        '
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Items.AddRange(New Object() {"ATLÁNTIDA", "FICOHSA", "BAC"})
        Me.cmbBanco.Location = New System.Drawing.Point(128, 349)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(156, 21)
        Me.cmbBanco.TabIndex = 60
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(30, 349)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Banco:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(27, 288)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 17)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Carrera:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Proyecto_Final.My.Resources.Resources._1486504846_clipboard_tasks_report_business_checking_verification_document_81354
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(786, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 71)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Reporte"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBuscartu
        '
        Me.btnBuscartu.Image = CType(resources.GetObject("btnBuscartu.Image"), System.Drawing.Image)
        Me.btnBuscartu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscartu.Location = New System.Drawing.Point(28, 391)
        Me.btnBuscartu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscartu.Name = "btnBuscartu"
        Me.btnBuscartu.Size = New System.Drawing.Size(89, 46)
        Me.btnBuscartu.TabIndex = 55
        Me.btnBuscartu.Text = "Buscar"
        Me.btnBuscartu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscartu.UseVisualStyleBackColor = True
        '
        'btnmostrarhabilitados
        '
        Me.btnmostrarhabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrarhabilitados.Image = CType(resources.GetObject("btnmostrarhabilitados.Image"), System.Drawing.Image)
        Me.btnmostrarhabilitados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmostrarhabilitados.Location = New System.Drawing.Point(648, 377)
        Me.btnmostrarhabilitados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmostrarhabilitados.Name = "btnmostrarhabilitados"
        Me.btnmostrarhabilitados.Size = New System.Drawing.Size(176, 48)
        Me.btnmostrarhabilitados.TabIndex = 45
        Me.btnmostrarhabilitados.Text = "Mostrar Habilitados"
        Me.btnmostrarhabilitados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmostrarhabilitados.UseVisualStyleBackColor = True
        '
        'btnmostrartod
        '
        Me.btnmostrartod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrartod.Image = CType(resources.GetObject("btnmostrartod.Image"), System.Drawing.Image)
        Me.btnmostrartod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmostrartod.Location = New System.Drawing.Point(455, 377)
        Me.btnmostrartod.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmostrartod.Name = "btnmostrartod"
        Me.btnmostrartod.Size = New System.Drawing.Size(157, 48)
        Me.btnmostrartod.TabIndex = 44
        Me.btnmostrartod.Text = "Mostrar Todo"
        Me.btnmostrartod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmostrartod.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.Location = New System.Drawing.Point(-84, 277)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(70, 46)
        Me.btnbuscar.TabIndex = 43
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btndeshabilitar
        '
        Me.btndeshabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeshabilitar.Image = CType(resources.GetObject("btndeshabilitar.Image"), System.Drawing.Image)
        Me.btndeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndeshabilitar.Location = New System.Drawing.Point(567, 459)
        Me.btndeshabilitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btndeshabilitar.Name = "btndeshabilitar"
        Me.btndeshabilitar.Size = New System.Drawing.Size(167, 59)
        Me.btndeshabilitar.TabIndex = 40
        Me.btndeshabilitar.Text = "Deshabilitar"
        Me.btndeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeshabilitar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar.Location = New System.Drawing.Point(405, 459)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(135, 59)
        Me.btnmodificar.TabIndex = 39
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnhabilitar
        '
        Me.btnhabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhabilitar.Image = CType(resources.GetObject("btnhabilitar.Image"), System.Drawing.Image)
        Me.btnhabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhabilitar.Location = New System.Drawing.Point(240, 459)
        Me.btnhabilitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhabilitar.Name = "btnhabilitar"
        Me.btnhabilitar.Size = New System.Drawing.Size(135, 59)
        Me.btnhabilitar.TabIndex = 38
        Me.btnhabilitar.Text = "Habilitar"
        Me.btnhabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhabilitar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Image = CType(resources.GetObject("btnagregar.Image"), System.Drawing.Image)
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.Location = New System.Drawing.Point(68, 459)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(135, 59)
        Me.btnagregar.TabIndex = 37
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'nudEdad
        '
        Me.nudEdad.Location = New System.Drawing.Point(128, 178)
        Me.nudEdad.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nudEdad.Name = "nudEdad"
        Me.nudEdad.Size = New System.Drawing.Size(120, 20)
        Me.nudEdad.TabIndex = 66
        Me.nudEdad.Value = New Decimal(New Integer() {17, 0, 0, 0})
        '
        'cboCarrera
        '
        Me.cboCarrera.FormattingEnabled = True
        Me.cboCarrera.Items.AddRange(New Object() {"Ing. Civil", "Ing. Sistemas", "Arquitectura", "Medicina", "Finanzas", "Economía", "Ing. Industrial", "Ing. eléctrica", "Matemáticas", "Física", "Odontología"})
        Me.cboCarrera.Location = New System.Drawing.Point(128, 286)
        Me.cboCarrera.Name = "cboCarrera"
        Me.cboCarrera.Size = New System.Drawing.Size(156, 21)
        Me.cboCarrera.TabIndex = 67
        '
        'tutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.cboCarrera)
        Me.Controls.Add(Me.nudEdad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbBanco)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.cmbUniversidad)
        Me.Controls.Add(Me.btnBuscartu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnmostrarhabilitados)
        Me.Controls.Add(Me.btnmostrartod)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgvtutor)
        Me.Controls.Add(Me.btndeshabilitar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnhabilitar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtcelular)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcodtutor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "tutor"
        Me.Text = "tutor"
        CType(Me.dgvtutor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnmostrarhabilitados As Button
    Friend WithEvents btnmostrartod As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvtutor As DataGridView
    Friend WithEvents btndeshabilitar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnhabilitar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcodtutor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnBuscartu As Button
    Friend WithEvents cmbUniversidad As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents cmbBanco As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents nudEdad As NumericUpDown
    Friend WithEvents cboCarrera As ComboBox
End Class
