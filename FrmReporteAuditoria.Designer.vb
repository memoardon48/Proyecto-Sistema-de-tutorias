<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteAuditoria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnBuscarUser = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.DataSis = New Proyecto_Final.DataSis()
        Me.Select_AuditoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_AuditoriaTableAdapter = New Proyecto_Final.DataSisTableAdapters.Select_AuditoriaTableAdapter()
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select_AuditoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Select_AuditoriaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.ReportAuditoria.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(70, 100)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(631, 323)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(563, 37)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnBuscarUser
        '
        Me.btnBuscarUser.Location = New System.Drawing.Point(149, 37)
        Me.btnBuscarUser.Name = "btnBuscarUser"
        Me.btnBuscarUser.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarUser.TabIndex = 2
        Me.btnBuscarUser.Text = "Buscar Usuario"
        Me.btnBuscarUser.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(320, 37)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(164, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'DataSis
        '
        Me.DataSis.DataSetName = "DataSis"
        Me.DataSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_AuditoriaBindingSource
        '
        Me.Select_AuditoriaBindingSource.DataMember = "Select_Auditoria"
        Me.Select_AuditoriaBindingSource.DataSource = Me.DataSis
        '
        'Select_AuditoriaTableAdapter
        '
        Me.Select_AuditoriaTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnBuscarUser)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteAuditoria"
        Me.Text = "FrmReporteAuditoria"
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select_AuditoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnBuscarUser As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Select_AuditoriaBindingSource As BindingSource
    Friend WithEvents DataSis As DataSis
    Friend WithEvents Select_AuditoriaTableAdapter As DataSisTableAdapters.Select_AuditoriaTableAdapter
End Class
