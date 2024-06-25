<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteClientes
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cboUniversidad = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSis = New Proyecto_Final.DataSis()
        Me.Select_ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_ClientesTableAdapter = New Proyecto_Final.DataSisTableAdapters.Select_ClientesTableAdapter()
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select_ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Select_ClientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.ReportClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(23, 82)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(902, 345)
        Me.ReportViewer1.TabIndex = 0
        '
        'cboUniversidad
        '
        Me.cboUniversidad.FormattingEnabled = True
        Me.cboUniversidad.Items.AddRange(New Object() {"UNAH", "UNICAH", "CEUTEC", "UNITEC", "UTH"})
        Me.cboUniversidad.Location = New System.Drawing.Point(364, 33)
        Me.cboUniversidad.Name = "cboUniversidad"
        Me.cboUniversidad.Size = New System.Drawing.Size(167, 21)
        Me.cboUniversidad.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(607, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(117, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar por universidad"
        '
        'DataSis
        '
        Me.DataSis.DataSetName = "DataSis"
        Me.DataSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_ClientesBindingSource
        '
        Me.Select_ClientesBindingSource.DataMember = "Select_Clientes"
        Me.Select_ClientesBindingSource.DataSource = Me.DataSis
        '
        'Select_ClientesTableAdapter
        '
        Me.Select_ClientesTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(949, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cboUniversidad)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteClientes"
        Me.Text = "FrmReporteClientes"
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select_ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cboUniversidad As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Select_ClientesBindingSource As BindingSource
    Friend WithEvents DataSis As DataSis
    Friend WithEvents Select_ClientesTableAdapter As DataSisTableAdapters.Select_ClientesTableAdapter
End Class
