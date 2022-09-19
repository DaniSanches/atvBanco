<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Saldo = New System.Windows.Forms.Label()
        Me.lblAniversario = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.TxtConta = New System.Windows.Forms.TextBox()
        Me.txtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtAniversario = New System.Windows.Forms.TextBox()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.btnCriar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnSacar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(90, 55)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(35, 13)
        Me.lblConta.TabIndex = 0
        Me.lblConta.Text = "Conta"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(90, 88)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'Saldo
        '
        Me.Saldo.AutoSize = True
        Me.Saldo.Location = New System.Drawing.Point(90, 114)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(34, 13)
        Me.Saldo.TabIndex = 2
        Me.Saldo.Text = "Saldo"
        '
        'lblAniversario
        '
        Me.lblAniversario.AutoSize = True
        Me.lblAniversario.Location = New System.Drawing.Point(90, 144)
        Me.lblAniversario.Name = "lblAniversario"
        Me.lblAniversario.Size = New System.Drawing.Size(59, 13)
        Me.lblAniversario.TabIndex = 3
        Me.lblAniversario.Text = "Aniversário"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(156, 212)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(31, 13)
        Me.lblValor.TabIndex = 4
        Me.lblValor.Text = "Valor"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(364, 212)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(34, 13)
        Me.lblSaldo.TabIndex = 5
        Me.lblSaldo.Text = "Saldo"
        '
        'TxtConta
        '
        Me.TxtConta.Location = New System.Drawing.Point(171, 52)
        Me.TxtConta.Name = "TxtConta"
        Me.TxtConta.Size = New System.Drawing.Size(100, 20)
        Me.TxtConta.TabIndex = 6
        '
        'txtSaldoTotal
        '
        Me.txtSaldoTotal.Location = New System.Drawing.Point(335, 228)
        Me.txtSaldoTotal.Name = "txtSaldoTotal"
        Me.txtSaldoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoTotal.TabIndex = 7
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(122, 228)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(100, 20)
        Me.TxtValor.TabIndex = 8
        '
        'TxtAniversario
        '
        Me.TxtAniversario.Location = New System.Drawing.Point(171, 137)
        Me.TxtAniversario.Name = "TxtAniversario"
        Me.TxtAniversario.Size = New System.Drawing.Size(100, 20)
        Me.TxtAniversario.TabIndex = 9
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Location = New System.Drawing.Point(171, 111)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldo.TabIndex = 10
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(171, 85)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtCliente.TabIndex = 11
        '
        'btnCriar
        '
        Me.btnCriar.Location = New System.Drawing.Point(313, 98)
        Me.btnCriar.Name = "btnCriar"
        Me.btnCriar.Size = New System.Drawing.Size(75, 23)
        Me.btnCriar.TabIndex = 12
        Me.btnCriar.Text = "&Criar"
        Me.btnCriar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(239, 202)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(75, 23)
        Me.btnDepositar.TabIndex = 13
        Me.btnDepositar.Text = "&Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'btnSacar
        '
        Me.btnSacar.Location = New System.Drawing.Point(239, 246)
        Me.btnSacar.Name = "btnSacar"
        Me.btnSacar.Size = New System.Drawing.Size(75, 23)
        Me.btnSacar.TabIndex = 14
        Me.btnSacar.Text = "&Sacar"
        Me.btnSacar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSacar)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.btnCriar)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.TxtAniversario)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.txtSaldoTotal)
        Me.Controls.Add(Me.TxtConta)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblAniversario)
        Me.Controls.Add(Me.Saldo)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblConta)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConta As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Saldo As Label
    Friend WithEvents lblAniversario As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents TxtConta As TextBox
    Friend WithEvents txtSaldoTotal As TextBox
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents TxtAniversario As TextBox
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents btnCriar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnSacar As Button
End Class
