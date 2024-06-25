<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasesTutor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClasesTutor))
        Me.dgvClasesTuto = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodClase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoT = New System.Windows.Forms.TextBox()
        Me.btnBuscarClase = New System.Windows.Forms.Button()
        Me.btnBuscarTutor = New System.Windows.Forms.Button()
        Me.btnmostrarhabilitados = New System.Windows.Forms.Button()
        Me.btnhabilitar = New System.Windows.Forms.Button()
        Me.btnDeshabilitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnMostrarTods = New System.Windows.Forms.Button()
        CType(Me.dgvClasesTuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClasesTuto
        '
        Me.dgvClasesTuto.AllowUserToAddRows = False
        Me.dgvClasesTuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClasesTuto.Location = New System.Drawing.Point(273, 32)
        Me.dgvClasesTuto.Name = "dgvClasesTuto"
        Me.dgvClasesTuto.Size = New System.Drawing.Size(297, 277)
        Me.dgvClasesTuto.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cod.Clase"
        '
        'txtCodClase
        '
        Me.txtCodClase.Enabled = False
        Me.txtCodClase.Location = New System.Drawing.Point(94, 126)
        Me.txtCodClase.Name = "txtCodClase"
        Me.txtCodClase.Size = New System.Drawing.Size(100, 20)
        Me.txtCodClase.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cod.Tutor"
        '
        'txtCodigoT
        '
        Me.txtCodigoT.Enabled = False
        Me.txtCodigoT.Location = New System.Drawing.Point(94, 69)
        Me.txtCodigoT.Name = "txtCodigoT"
        Me.txtCodigoT.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoT.TabIndex = 9
        '
        'btnBuscarClase
        '
        Me.btnBuscarClase.Location = New System.Drawing.Point(201, 126)
        Me.btnBuscarClase.Name = "btnBuscarClase"
        Me.btnBuscarClase.Size = New System.Drawing.Size(45, 23)
        Me.btnBuscarClase.TabIndex = 55
        Me.btnBuscarClase.Text = "..."
        Me.btnBuscarClase.UseVisualStyleBackColor = True
        '
        'btnBuscarTutor
        '
        Me.btnBuscarTutor.Location = New System.Drawing.Point(201, 67)
        Me.btnBuscarTutor.Name = "btnBuscarTutor"
        Me.btnBuscarTutor.Size = New System.Drawing.Size(45, 23)
        Me.btnBuscarTutor.TabIndex = 56
        Me.btnBuscarTutor.Text = "..."
        Me.btnBuscarTutor.UseVisualStyleBackColor = True
        '
        'btnmostrarhabilitados
        '
        Me.btnmostrarhabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrarhabilitados.Image = CType(resources.GetObject("btnmostrarhabilitados.Image"), System.Drawing.Image)
        Me.btnmostrarhabilitados.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmostrarhabilitados.Location = New System.Drawing.Point(407, 337)
        Me.btnmostrarhabilitados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmostrarhabilitados.Name = "btnmostrarhabilitados"
        Me.btnmostrarhabilitados.Size = New System.Drawing.Size(128, 65)
        Me.btnmostrarhabilitados.TabIndex = 57
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
        Me.btnhabilitar.Location = New System.Drawing.Point(139, 224)
        Me.btnhabilitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhabilitar.Name = "btnhabilitar"
        Me.btnhabilitar.Size = New System.Drawing.Size(129, 63)
        Me.btnhabilitar.TabIndex = 54
        Me.btnhabilitar.Text = "Habilitar"
        Me.btnhabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhabilitar.UseVisualStyleBackColor = False
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeshabilitar.Image = Global.Proyecto_Final.My.Resources.Resources.vcsconflicting_93497
        Me.btnDeshabilitar.Location = New System.Drawing.Point(65, 307)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(129, 56)
        Me.btnDeshabilitar.TabIndex = 53
        Me.btnDeshabilitar.Text = "Deshabilitar"
        Me.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(14, 224)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(111, 63)
        Me.btnAgregar.TabIndex = 51
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnMostrarTods
        '
        Me.btnMostrarTods.Image = Global.Proyecto_Final.My.Resources.Resources._3844476_eye_see_show_view_watch_110339
        Me.btnMostrarTods.Location = New System.Drawing.Point(297, 338)
        Me.btnMostrarTods.Name = "btnMostrarTods"
        Me.btnMostrarTods.Size = New System.Drawing.Size(105, 64)
        Me.btnMostrarTods.TabIndex = 26
        Me.btnMostrarTods.Text = "Motrar Todos"
        Me.btnMostrarTods.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMostrarTods.UseVisualStyleBackColor = True
        '
        'ClasesTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(601, 438)
        Me.Controls.Add(Me.btnmostrarhabilitados)
        Me.Controls.Add(Me.btnBuscarTutor)
        Me.Controls.Add(Me.btnBuscarClase)
        Me.Controls.Add(Me.btnhabilitar)
        Me.Controls.Add(Me.btnDeshabilitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnMostrarTods)
        Me.Controls.Add(Me.txtCodigoT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodClase)
        Me.Controls.Add(Me.dgvClasesTuto)
        Me.Name = "ClasesTutor"
        Me.Text = "ClasesTutor"
        CType(Me.dgvClasesTuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClasesTuto As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodClase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoT As TextBox
    Friend WithEvents btnMostrarTods As Button
    Friend WithEvents btnhabilitar As Button
    Friend WithEvents btnDeshabilitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBuscarClase As Button
    Friend WithEvents btnBuscarTutor As Button
    Private WithEvents btnmostrarhabilitados As Button
End Class
