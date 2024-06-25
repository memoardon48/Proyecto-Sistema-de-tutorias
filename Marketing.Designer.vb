<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marketing
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
        Me.btnDeshabilitar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvmarketing = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbuniversidad = New System.Windows.Forms.ComboBox()
        Me.cbpreciocomun = New System.Windows.Forms.ComboBox()
        Me.cbredsocial = New System.Windows.Forms.ComboBox()
        Me.cbhorario = New System.Windows.Forms.ComboBox()
        Me.txtcodclase = New System.Windows.Forms.TextBox()
        Me.nupmuestra = New System.Windows.Forms.NumericUpDown()
        Me.txtcodencuesta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvmarketing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupmuestra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.Image = Global.Proyecto_Final.My.Resources.Resources.vcsconflicting_93497
        Me.btnDeshabilitar.Location = New System.Drawing.Point(312, 353)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(120, 56)
        Me.btnDeshabilitar.TabIndex = 45
        Me.btnDeshabilitar.Text = "Eliminar"
        Me.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.Proyecto_Final.My.Resources.Resources.edit_icon_icons_com_66118__1_
        Me.btnModificar.Location = New System.Drawing.Point(178, 353)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(114, 55)
        Me.btnModificar.TabIndex = 44
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(48, 353)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(105, 55)
        Me.btnAgregar.TabIndex = 43
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvmarketing
        '
        Me.dgvmarketing.AllowUserToAddRows = False
        Me.dgvmarketing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmarketing.Location = New System.Drawing.Point(375, 29)
        Me.dgvmarketing.Name = "dgvmarketing"
        Me.dgvmarketing.Size = New System.Drawing.Size(542, 306)
        Me.dgvmarketing.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(53, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 26)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aplicación"
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(134, 316)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpfecha.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(53, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Universidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(53, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "precio comun"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(53, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "red social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Horario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "codigo Clase"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Muestra"
        '
        'cbuniversidad
        '
        Me.cbuniversidad.FormattingEnabled = True
        Me.cbuniversidad.Location = New System.Drawing.Point(133, 269)
        Me.cbuniversidad.Name = "cbuniversidad"
        Me.cbuniversidad.Size = New System.Drawing.Size(121, 21)
        Me.cbuniversidad.TabIndex = 32
        '
        'cbpreciocomun
        '
        Me.cbpreciocomun.FormattingEnabled = True
        Me.cbpreciocomun.Location = New System.Drawing.Point(133, 227)
        Me.cbpreciocomun.Name = "cbpreciocomun"
        Me.cbpreciocomun.Size = New System.Drawing.Size(121, 21)
        Me.cbpreciocomun.TabIndex = 31
        '
        'cbredsocial
        '
        Me.cbredsocial.FormattingEnabled = True
        Me.cbredsocial.Location = New System.Drawing.Point(133, 181)
        Me.cbredsocial.Name = "cbredsocial"
        Me.cbredsocial.Size = New System.Drawing.Size(121, 21)
        Me.cbredsocial.TabIndex = 30
        '
        'cbhorario
        '
        Me.cbhorario.FormattingEnabled = True
        Me.cbhorario.Location = New System.Drawing.Point(133, 133)
        Me.cbhorario.Name = "cbhorario"
        Me.cbhorario.Size = New System.Drawing.Size(121, 21)
        Me.cbhorario.TabIndex = 29
        '
        'txtcodclase
        '
        Me.txtcodclase.Enabled = False
        Me.txtcodclase.Location = New System.Drawing.Point(133, 91)
        Me.txtcodclase.Name = "txtcodclase"
        Me.txtcodclase.Size = New System.Drawing.Size(120, 20)
        Me.txtcodclase.TabIndex = 28
        '
        'nupmuestra
        '
        Me.nupmuestra.Location = New System.Drawing.Point(133, 46)
        Me.nupmuestra.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nupmuestra.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nupmuestra.Name = "nupmuestra"
        Me.nupmuestra.Size = New System.Drawing.Size(120, 20)
        Me.nupmuestra.TabIndex = 27
        Me.nupmuestra.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'txtcodencuesta
        '
        Me.txtcodencuesta.Enabled = False
        Me.txtcodencuesta.Location = New System.Drawing.Point(133, 12)
        Me.txtcodencuesta.Name = "txtcodencuesta"
        Me.txtcodencuesta.Size = New System.Drawing.Size(120, 20)
        Me.txtcodencuesta.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(53, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Cod Encuesta"
        '
        'Marketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(954, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcodencuesta)
        Me.Controls.Add(Me.btnDeshabilitar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvmarketing)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbuniversidad)
        Me.Controls.Add(Me.cbpreciocomun)
        Me.Controls.Add(Me.cbredsocial)
        Me.Controls.Add(Me.cbhorario)
        Me.Controls.Add(Me.txtcodclase)
        Me.Controls.Add(Me.nupmuestra)
        Me.Name = "Marketing"
        Me.Text = "Marketing"
        CType(Me.dgvmarketing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupmuestra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeshabilitar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvmarketing As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbuniversidad As ComboBox
    Friend WithEvents cbpreciocomun As ComboBox
    Friend WithEvents cbredsocial As ComboBox
    Friend WithEvents cbhorario As ComboBox
    Friend WithEvents txtcodclase As TextBox
    Friend WithEvents nupmuestra As NumericUpDown
    Friend WithEvents txtcodencuesta As TextBox
    Friend WithEvents Label8 As Label
End Class
