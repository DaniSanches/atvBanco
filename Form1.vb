Public Class Form1
    Private valor As Decimal
    Private quantia As Decimal
    Private saldoTotal As Decimal

    Private Sub btnCriar_Click(sender As Object, e As EventArgs) Handles btnCriar.Click
        Dim obj_conta As New Poupanca("1234", "Vitória Cat", "10.000,00", "07/01/21")
        TxtConta.Text = obj_conta.pconta
        TxtCliente.Text = obj_conta.pnome
        TxtSaldo.Text = obj_conta.psaldo
        TxtAniversario.Text = obj_conta.pAniversario

    End Sub



    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        valor = Decimal.Parse(TxtValor.Text)
        quantia = Decimal.Parse(TxtSaldo.Text)
        saldoTotal = quantia + valor
        txtSaldoTotal.Text = saldoTotal
        TxtSaldo.Text = saldoTotal
    End Sub

    Private Sub btnSacar_Click(sender As Object, e As EventArgs) Handles btnSacar.Click
        valor = Decimal.Parse(TxtValor.Text)
        quantia = Decimal.Parse(TxtSaldo.Text)
        saldoTotal = quantia - valor
        txtSaldoTotal.Text = saldoTotal
        TxtSaldo.Text = saldoTotal
    End Sub
End Class
