<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutoriasCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutoriasCliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTemas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodClase = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.dgvEsperayRecha = New System.Windows.Forms.DataGridView()
        Me.txtBuscarConf = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnBuscarClase = New System.Windows.Forms.Button()
        Me.cboConocimiento = New System.Windows.Forms.ComboBox()
        Me.dtpFechaTuto = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudHoras = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodTutoria2 = New System.Windows.Forms.TextBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodFactura = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNombreClase = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nudPersonas = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgvConf = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCodTutoria = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBuscarEspera = New System.Windows.Forms.TextBox()
        Me.btnBuscarEspera = New System.Windows.Forms.Button()
        Me.btnBuscarConf = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnMostrarTod = New System.Windows.Forms.Button()
        Me.btnMostrarTodo2 = New System.Windows.Forms.Button()
        CType(Me.dgvEsperayRecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod.Cliente "
        '
        'txtTemas
        '
        Me.txtTemas.Location = New System.Drawing.Point(145, 166)
        Me.txtTemas.Multiline = True
        Me.txtTemas.Name = "txtTemas"
        Me.txtTemas.Size = New System.Drawing.Size(200, 83)
        Me.txtTemas.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cod.Clase"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(37, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Temas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(37, 401)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 26)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nivel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Conocimiento"
        '
        'txtCodClase
        '
        Me.txtCodClase.Enabled = False
        Me.txtCodClase.Location = New System.Drawing.Point(145, 107)
        Me.txtCodClase.Name = "txtCodClase"
        Me.txtCodClase.Size = New System.Drawing.Size(100, 20)
        Me.txtCodClase.TabIndex = 15
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Enabled = False
        Me.txtCodCliente.Location = New System.Drawing.Point(145, 55)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCliente.TabIndex = 16
        '
        'dgvEsperayRecha
        '
        Me.dgvEsperayRecha.AllowUserToAddRows = False
        Me.dgvEsperayRecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEsperayRecha.Location = New System.Drawing.Point(373, 31)
        Me.dgvEsperayRecha.Name = "dgvEsperayRecha"
        Me.dgvEsperayRecha.Size = New System.Drawing.Size(782, 134)
        Me.dgvEsperayRecha.TabIndex = 24
        '
        'txtBuscarConf
        '
        Me.txtBuscarConf.Location = New System.Drawing.Point(1055, 422)
        Me.txtBuscarConf.Name = "txtBuscarConf"
        Me.txtBuscarConf.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarConf.TabIndex = 27
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(259, 53)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(38, 23)
        Me.btnBuscarCliente.TabIndex = 29
        Me.btnBuscarCliente.Text = "..."
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarClase
        '
        Me.btnBuscarClase.Location = New System.Drawing.Point(259, 105)
        Me.btnBuscarClase.Name = "btnBuscarClase"
        Me.btnBuscarClase.Size = New System.Drawing.Size(38, 23)
        Me.btnBuscarClase.TabIndex = 30
        Me.btnBuscarClase.Text = "..."
        Me.btnBuscarClase.UseVisualStyleBackColor = True
        '
        'cboConocimiento
        '
        Me.cboConocimiento.FormattingEnabled = True
        Me.cboConocimiento.Items.AddRange(New Object() {"No le entiendo", "Le entiendo un poco", "Entiendo gran parte"})
        Me.cboConocimiento.Location = New System.Drawing.Point(145, 401)
        Me.cboConocimiento.Name = "cboConocimiento"
        Me.cboConocimiento.Size = New System.Drawing.Size(200, 21)
        Me.cboConocimiento.TabIndex = 31
        '
        'dtpFechaTuto
        '
        Me.dtpFechaTuto.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.dtpFechaTuto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaTuto.Location = New System.Drawing.Point(145, 265)
        Me.dtpFechaTuto.Name = "dtpFechaTuto"
        Me.dtpFechaTuto.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaTuto.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(40, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tipo"
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Individual", "Grupal"})
        Me.cboTipo.Location = New System.Drawing.Point(145, 309)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(200, 21)
        Me.cboTipo.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(37, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Horas"
        '
        'nudHoras
        '
        Me.nudHoras.Location = New System.Drawing.Point(145, 336)
        Me.nudHoras.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudHoras.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudHoras.Name = "nudHoras"
        Me.nudHoras.Size = New System.Drawing.Size(120, 20)
        Me.nudHoras.TabIndex = 39
        Me.nudHoras.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCodTutoria2)
        Me.GroupBox1.Controls.Add(Me.btnPagar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCodFactura)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(31, 477)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1111, 205)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAGOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Final.My.Resources.Resources._6
        Me.PictureBox1.Location = New System.Drawing.Point(750, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 24)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Cod. Tutoria"
        '
        'txtCodTutoria2
        '
        Me.txtCodTutoria2.Enabled = False
        Me.txtCodTutoria2.Location = New System.Drawing.Point(183, 81)
        Me.txtCodTutoria2.Name = "txtCodTutoria2"
        Me.txtCodTutoria2.Size = New System.Drawing.Size(203, 29)
        Me.txtCodTutoria2.TabIndex = 52
        '
        'btnPagar
        '
        Me.btnPagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPagar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnPagar.Location = New System.Drawing.Point(500, 63)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(171, 57)
        Me.btnPagar.TabIndex = 51
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 24)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(183, 145)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(203, 29)
        Me.txtTotal.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 24)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Cod. Factura"
        '
        'txtCodFactura
        '
        Me.txtCodFactura.Enabled = False
        Me.txtCodFactura.Location = New System.Drawing.Point(183, 28)
        Me.txtCodFactura.Name = "txtCodFactura"
        Me.txtCodFactura.Size = New System.Drawing.Size(203, 29)
        Me.txtCodFactura.TabIndex = 0
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Enabled = False
        Me.txtNombreCliente.Location = New System.Drawing.Point(145, 81)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreCliente.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(37, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Nombre Cliente"
        '
        'txtNombreClase
        '
        Me.txtNombreClase.Enabled = False
        Me.txtNombreClase.Location = New System.Drawing.Point(145, 133)
        Me.txtNombreClase.Name = "txtNombreClase"
        Me.txtNombreClase.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreClase.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(37, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Nombre clase"
        '
        'nudPersonas
        '
        Me.nudPersonas.Location = New System.Drawing.Point(145, 363)
        Me.nudPersonas.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudPersonas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPersonas.Name = "nudPersonas"
        Me.nudPersonas.Size = New System.Drawing.Size(120, 20)
        Me.nudPersonas.TabIndex = 52
        Me.nudPersonas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(37, 371)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Personas"
        '
        'dgvConf
        '
        Me.dgvConf.AllowUserToAddRows = False
        Me.dgvConf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConf.Location = New System.Drawing.Point(373, 272)
        Me.dgvConf.Name = "dgvConf"
        Me.dgvConf.Size = New System.Drawing.Size(782, 134)
        Me.dgvConf.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "En espera y rechazadas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(370, 247)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Confirmadas"
        '
        'txtCodTutoria
        '
        Me.txtCodTutoria.Enabled = False
        Me.txtCodTutoria.Location = New System.Drawing.Point(145, 29)
        Me.txtCodTutoria.Name = "txtCodTutoria"
        Me.txtCodTutoria.Size = New System.Drawing.Size(100, 20)
        Me.txtCodTutoria.TabIndex = 57
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(40, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Cod Tutoria"
        '
        'txtBuscarEspera
        '
        Me.txtBuscarEspera.Location = New System.Drawing.Point(1055, 190)
        Me.txtBuscarEspera.Name = "txtBuscarEspera"
        Me.txtBuscarEspera.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarEspera.TabIndex = 58
        '
        'btnBuscarEspera
        '
        Me.btnBuscarEspera.Image = Global.Proyecto_Final.My.Resources.Resources.search_locate_find_icon_icons_com_67287__1_
        Me.btnBuscarEspera.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarEspera.Location = New System.Drawing.Point(961, 179)
        Me.btnBuscarEspera.Name = "btnBuscarEspera"
        Me.btnBuscarEspera.Size = New System.Drawing.Size(88, 41)
        Me.btnBuscarEspera.TabIndex = 59
        Me.btnBuscarEspera.Text = "Buscar"
        Me.btnBuscarEspera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarEspera.UseVisualStyleBackColor = True
        '
        'btnBuscarConf
        '
        Me.btnBuscarConf.Image = Global.Proyecto_Final.My.Resources.Resources.search_locate_find_icon_icons_com_67287__1_
        Me.btnBuscarConf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarConf.Location = New System.Drawing.Point(961, 411)
        Me.btnBuscarConf.Name = "btnBuscarConf"
        Me.btnBuscarConf.Size = New System.Drawing.Size(88, 41)
        Me.btnBuscarConf.TabIndex = 28
        Me.btnBuscarConf.Text = "Buscar"
        Me.btnBuscarConf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarConf.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.Proyecto_Final.My.Resources.Resources.edit_icon_icons_com_66118__1_
        Me.btnModificar.Location = New System.Drawing.Point(502, 172)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 56)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(373, 171)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(110, 57)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Proyecto_Final.My.Resources.Resources._1486504846_clipboard_tasks_report_business_checking_verification_document_81354
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(618, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 71)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Reporte"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnMostrarTod
        '
        Me.btnMostrarTod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarTod.Image = CType(resources.GetObject("btnMostrarTod.Image"), System.Drawing.Image)
        Me.btnMostrarTod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrarTod.Location = New System.Drawing.Point(812, 175)
        Me.btnMostrarTod.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrarTod.Name = "btnMostrarTod"
        Me.btnMostrarTod.Size = New System.Drawing.Size(134, 48)
        Me.btnMostrarTod.TabIndex = 67
        Me.btnMostrarTod.Text = "Mostrar Todo"
        Me.btnMostrarTod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrarTod.UseVisualStyleBackColor = True
        '
        'btnMostrarTodo2
        '
        Me.btnMostrarTodo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarTodo2.Image = CType(resources.GetObject("btnMostrarTodo2.Image"), System.Drawing.Image)
        Me.btnMostrarTodo2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrarTodo2.Location = New System.Drawing.Point(812, 411)
        Me.btnMostrarTodo2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrarTodo2.Name = "btnMostrarTodo2"
        Me.btnMostrarTodo2.Size = New System.Drawing.Size(134, 48)
        Me.btnMostrarTodo2.TabIndex = 68
        Me.btnMostrarTodo2.Text = "Mostrar Todo"
        Me.btnMostrarTodo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrarTodo2.UseVisualStyleBackColor = True
        '
        'TutoriasCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1183, 695)
        Me.Controls.Add(Me.btnMostrarTodo2)
        Me.Controls.Add(Me.btnMostrarTod)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBuscarEspera)
        Me.Controls.Add(Me.txtBuscarEspera)
        Me.Controls.Add(Me.txtCodTutoria)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvConf)
        Me.Controls.Add(Me.nudPersonas)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtNombreClase)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nudHoras)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpFechaTuto)
        Me.Controls.Add(Me.cboConocimiento)
        Me.Controls.Add(Me.btnBuscarClase)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.btnBuscarConf)
        Me.Controls.Add(Me.txtBuscarConf)
        Me.Controls.Add(Me.dgvEsperayRecha)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.txtCodClase)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTemas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "TutoriasCliente"
        Me.Text = "TutoriasCliente"
        CType(Me.dgvEsperayRecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTemas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCodClase As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents dgvEsperayRecha As DataGridView
    Friend WithEvents txtBuscarConf As TextBox
    Friend WithEvents btnBuscarConf As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnBuscarClase As Button
    Friend WithEvents cboConocimiento As ComboBox
    Friend WithEvents dtpFechaTuto As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nudHoras As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPagar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCodFactura As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNombreClase As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents nudPersonas As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents dgvConf As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCodTutoria As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnBuscarEspera As Button
    Friend WithEvents txtBuscarEspera As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodTutoria2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnMostrarTod As Button
    Friend WithEvents btnMostrarTodo2 As Button
End Class
