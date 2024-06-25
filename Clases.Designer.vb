<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clases))
        Me.dgvClases = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodClase = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnMostrarTods = New System.Windows.Forms.Button()
        Me.btnDeshabilitar = New System.Windows.Forms.Button()
        Me.btnmostrarhabilitados = New System.Windows.Forms.Button()
        Me.btnhabilitar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.dgvClases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClases
        '
        Me.dgvClases.AllowUserToAddRows = False
        Me.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClases.Location = New System.Drawing.Point(336, 24)
        Me.dgvClases.Name = "dgvClases"
        Me.dgvClases.Size = New System.Drawing.Size(354, 265)
        Me.dgvClases.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(137, 138)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(129, 20)
        Me.txtNombre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre De la Clase"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(60, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Cod.Clase"
        '
        'txtCodClase
        '
        Me.txtCodClase.Enabled = False
        Me.txtCodClase.Location = New System.Drawing.Point(137, 71)
        Me.txtCodClase.Name = "txtCodClase"
        Me.txtCodClase.Size = New System.Drawing.Size(129, 20)
        Me.txtCodClase.TabIndex = 10
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.Proyecto_Final.My.Resources.Resources.edit_icon_icons_com_66118__1_
        Me.btnModificar.Location = New System.Drawing.Point(9, 335)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(114, 55)
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(12, 257)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(111, 63)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnMostrarTods
        '
        Me.btnMostrarTods.Image = Global.Proyecto_Final.My.Resources.Resources._3844476_eye_see_show_view_watch_110339
        Me.btnMostrarTods.Location = New System.Drawing.Point(336, 310)
        Me.btnMostrarTods.Name = "btnMostrarTods"
        Me.btnMostrarTods.Size = New System.Drawing.Size(132, 64)
        Me.btnMostrarTods.TabIndex = 26
        Me.btnMostrarTods.Text = "Motrar Todos"
        Me.btnMostrarTods.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMostrarTods.UseVisualStyleBackColor = True
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeshabilitar.Image = Global.Proyecto_Final.My.Resources.Resources.vcsconflicting_93497
        Me.btnDeshabilitar.Location = New System.Drawing.Point(137, 334)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(129, 56)
        Me.btnDeshabilitar.TabIndex = 25
        Me.btnDeshabilitar.Text = "Deshabilitar"
        Me.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnmostrarhabilitados
        '
        Me.btnmostrarhabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrarhabilitados.Image = CType(resources.GetObject("btnmostrarhabilitados.Image"), System.Drawing.Image)
        Me.btnmostrarhabilitados.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmostrarhabilitados.Location = New System.Drawing.Point(562, 309)
        Me.btnmostrarhabilitados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmostrarhabilitados.Name = "btnmostrarhabilitados"
        Me.btnmostrarhabilitados.Size = New System.Drawing.Size(128, 65)
        Me.btnmostrarhabilitados.TabIndex = 49
        Me.btnmostrarhabilitados.Text = "Mostrar Habilitados"
        Me.btnmostrarhabilitados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmostrarhabilitados.UseVisualStyleBackColor = True
        '
        'btnhabilitar
        '
        Me.btnhabilitar.BackColor = System.Drawing.SystemColors.Control
        Me.btnhabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhabilitar.Image = CType(resources.GetObject("btnhabilitar.Image"), System.Drawing.Image)
        Me.btnhabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhabilitar.Location = New System.Drawing.Point(137, 257)
        Me.btnhabilitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhabilitar.Name = "btnhabilitar"
        Me.btnhabilitar.Size = New System.Drawing.Size(129, 63)
        Me.btnhabilitar.TabIndex = 50
        Me.btnhabilitar.Text = "Habilitar"
        Me.btnhabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhabilitar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(17, 186)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 46)
        Me.btnBuscar.TabIndex = 57
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(134, 200)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(132, 20)
        Me.txtBuscar.TabIndex = 56
        '
        'Clases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(724, 412)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnhabilitar)
        Me.Controls.Add(Me.btnmostrarhabilitados)
        Me.Controls.Add(Me.btnMostrarTods)
        Me.Controls.Add(Me.btnDeshabilitar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodClase)
        Me.Controls.Add(Me.dgvClases)
        Me.Name = "Clases"
        Me.Text = "Clases"
        CType(Me.dgvClases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClases As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodClase As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnMostrarTods As Button
    Friend WithEvents btnDeshabilitar As Button
    Private WithEvents btnmostrarhabilitados As Button
    Friend WithEvents btnhabilitar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
End Class
