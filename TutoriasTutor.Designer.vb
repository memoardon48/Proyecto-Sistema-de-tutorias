<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutoriasTutor
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
        Me.DgvTutorias = New System.Windows.Forms.DataGridView()
        Me.btnDeshabilitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvTutores = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPagadas = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DgvTutorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTutores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvTutorias
        '
        Me.DgvTutorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTutorias.Location = New System.Drawing.Point(12, 31)
        Me.DgvTutorias.Name = "DgvTutorias"
        Me.DgvTutorias.Size = New System.Drawing.Size(535, 274)
        Me.DgvTutorias.TabIndex = 51
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.Image = Global.Proyecto_Final.My.Resources.Resources.vcsconflicting_93497
        Me.btnDeshabilitar.Location = New System.Drawing.Point(570, 323)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(209, 56)
        Me.btnDeshabilitar.TabIndex = 49
        Me.btnDeshabilitar.Text = "No hay tutores para la tutoria"
        Me.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(360, 323)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(156, 57)
        Me.btnAgregar.TabIndex = 47
        Me.btnAgregar.Text = "Asignar Tutor"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvTutores
        '
        Me.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTutores.Location = New System.Drawing.Point(561, 31)
        Me.dgvTutores.Name = "dgvTutores"
        Me.dgvTutores.Size = New System.Drawing.Size(535, 274)
        Me.dgvTutores.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Tutorias propuestas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(558, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Tutores para la tutoria"
        '
        'dgvPagadas
        '
        Me.dgvPagadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagadas.Location = New System.Drawing.Point(114, 433)
        Me.dgvPagadas.Name = "dgvPagadas"
        Me.dgvPagadas.Size = New System.Drawing.Size(874, 190)
        Me.dgvPagadas.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "TUTORIAS PAGADAS Y CONFIRMADAS"
        '
        'TutoriasTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1107, 657)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvPagadas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTutores)
        Me.Controls.Add(Me.DgvTutorias)
        Me.Controls.Add(Me.btnDeshabilitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "TutoriasTutor"
        Me.Text = "TutoriasTutor"
        CType(Me.DgvTutorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTutores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvTutorias As DataGridView
    Friend WithEvents btnDeshabilitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvTutores As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvPagadas As DataGridView
    Friend WithEvents Label3 As Label
End Class
