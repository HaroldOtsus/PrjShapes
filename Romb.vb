Public Class Romb
    Inherits Nelinurk

    Private korgus As Double

    ' Konstruktor baasklassi atribuutide väärtustamiseks
    Public Sub New(ByVal kylg As Double, ByVal korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Romb", kylg, kylg, kylg, kylg)

        'Rombi k6rgus
        Me.korgus = korgus
    End Sub

    ' Funktsioon arvutab ja tagastab rombi pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
