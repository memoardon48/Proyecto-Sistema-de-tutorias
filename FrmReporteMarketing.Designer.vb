<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporteMarketing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Select_marketingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSis = New Proyecto_Final.DataSis()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Select_MarketingTableAdapter = New Proyecto_Final.DataSisTableAdapters.Select_MarketingTableAdapter()
        CType(Me.Select_marketingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Select_marketingBindingSource
        '
        Me.Select_marketingBindingSource.DataMember = "Select_marketing"
        Me.Select_marketingBindingSource.DataSource = Me.DataSis
        '
        'DataSis
        '
        Me.DataSis.DataSetName = "DataSis"
        Me.DataSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(554, 36)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(112, 23)
        Me.btnMostrar.TabIndex = 6
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Location = New System.Drawing.Point(295, 35)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(185, 20)
        Me.dtpFecha2.TabIndex = 5
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Location = New System.Drawing.Point(93, 35)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(185, 20)
        Me.dtpFecha1.TabIndex = 4
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Select_marketingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.ReportMarketing.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(52, 93)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(676, 277)
        Me.ReportViewer1.TabIndex = 7
        '
        'Select_MarketingTableAdapter
        '
        Me.Select_MarketingTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteMarketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Name = "FrmReporteMarketing"
        Me.Text = "FrmReporteMarketing"
        CType(Me.Select_marketingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMostrar As Button
    Friend WithEvents dtpFecha2 As DateTimePicker
    Friend WithEvents dtpFecha1 As DateTimePicker
    Friend WithEvents Select_marketingBindingSource As BindingSource
    Friend WithEvents DataSis As DataSis
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Select_MarketingTableAdapter As DataSisTableAdapters.Select_MarketingTableAdapter
End Class
