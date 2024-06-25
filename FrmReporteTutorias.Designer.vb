<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteTutorias
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
        Me.Select_TutoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSis = New Proyecto_Final.DataSis()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Select_TutoriaTableAdapter = New Proyecto_Final.DataSisTableAdapters.Select_TutoriaTableAdapter()
        CType(Me.Select_TutoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Select_TutoriaBindingSource
        '
        Me.Select_TutoriaBindingSource.DataMember = "Select_Tutoria"
        Me.Select_TutoriaBindingSource.DataSource = Me.DataSis
        '
        'DataSis
        '
        Me.DataSis.DataSetName = "DataSis"
        Me.DataSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Select_TutoriaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.ReportTutorias.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(58, 87)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(817, 330)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Location = New System.Drawing.Point(172, 33)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(185, 20)
        Me.dtpFecha1.TabIndex = 1
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Location = New System.Drawing.Point(374, 33)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(185, 20)
        Me.dtpFecha2.TabIndex = 2
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(633, 34)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(112, 23)
        Me.btnMostrar.TabIndex = 3
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Select_TutoriaTableAdapter
        '
        Me.Select_TutoriaTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteTutorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(927, 450)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteTutorias"
        Me.Text = "FrmReporteTutorias"
        CType(Me.Select_TutoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtpFecha1 As DateTimePicker
    Friend WithEvents dtpFecha2 As DateTimePicker
    Friend WithEvents btnMostrar As Button
    Friend WithEvents Select_TutoriaBindingSource As BindingSource
    Friend WithEvents DataSis As DataSis
    Friend WithEvents Select_TutoriaTableAdapter As DataSisTableAdapters.Select_TutoriaTableAdapter
End Class
