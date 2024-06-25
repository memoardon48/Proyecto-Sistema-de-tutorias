Public Class MenuA
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (tipo = "1") Then
            btnTutor.Enabled = True
            btnCliente.Enabled = True
        ElseIf (tipo = "2") Then
            btnContabilidad.Enabled = True
        ElseIf (tipo = "3") Then
            btnMarketing.Enabled = True
        ElseIf (tipo = "4") Then
            btnGerencia.Enabled = True
            btnTutor.Enabled = True
            btnCliente.Enabled = True
            btnContabilidad.Enabled = True
            btnMarketing.Enabled = True
            btnRecursoshumanos.Enabled = True
            btnUsuarios.Enabled = True
            btnAuditoria.Enabled = True
        ElseIf (tipo = "5") Then
            btnRecursoshumanos.Enabled = True
        End If

    End Sub

    Private Sub btningresaartutor_Click(sender As Object, e As EventArgs) Handles btnTutor.Click
        MenuTutores.Show()

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        MenuClientes.Show()

    End Sub

    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click
        BalanceGenereal.Show()

    End Sub

    Private Sub btnMarketing_Click(sender As Object, e As EventArgs) Handles btnMarketing.Click
        Marketing.Show()

    End Sub

    Private Sub btnGerencia_Click(sender As Object, e As EventArgs) Handles btnGerencia.Click
        gerencia.Show()

    End Sub

    Private Sub btnRecursoshumanos_Click(sender As Object, e As EventArgs) Handles btnRecursoshumanos.Click
        MenuRRHH.Show()

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Usuarios.Show()

    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        FrmAuditoria.Show()

    End Sub
End Class