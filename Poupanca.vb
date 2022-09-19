Public Class Poupanca
    ' Vamos criar um classe Herdeira de pessoa
    Inherits Conta
    Private aniversario As String


    Public Sub New(conta As Integer, saldo As Decimal, nome As String, aniversario As String)
        ' como essa  classe é herdeira, eu  vou  informar em  Mybase que as  informações são da classe  pai
        MyBase.New(conta, saldo, nome)
        Me.aniversario = aniversario



    End Sub



    ' utiliza  os get e  set para obter e mostrar os  valores exibidos
    Public Property pAniversario As String
        Get
            Return aniversario
        End Get
        Set(value As String)

            aniversario = value

        End Set
    End Property



End Class
