Public Class Form1
    Private Sub btnCriar_Click(sender As Object, e As EventArgs) Handles btnCriar.Click
        Dim obj_conta As New Poupanca("1234", "Vitória Cat", "10.000,00", "07/01/21")
        TxtConta.Text = obj_conta.pconta
        TxtCliente.Text = obj_conta.pnome
        TxtSaldo.Text = obj_conta.psaldo
        TxtAniversario.Text = obj_conta.pAniversario

    End Sub
End Class
