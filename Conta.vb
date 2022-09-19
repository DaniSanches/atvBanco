

Public Class Conta
    ' Vamos criar uma classe  privada para que  ele  não  possa  acessar uma  classe que não seja sua
    Private conta As Integer
    Private saldo As Decimal
    Private nome As String

    Public Sub New(conta As Integer, saldo As Decimal, nome As String)
        Me.conta = conta
        Me.saldo = saldo
        Me.nome = nome
    End Sub


    ' utiliza  os get e  set para obter e mostrar os  valores exibidos
    Public Property pconta As Integer
        Get
            Return conta
        End Get
        Set(value As Integer)

        End Set
    End Property



    Public Property pnome As String
        Get
            Return nome
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property psaldo As Decimal
        Get
            Return saldo
        End Get
        Set(value As Decimal)

        End Set
    End Property



End Class
