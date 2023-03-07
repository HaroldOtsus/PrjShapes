Public Class Roopkulik
    Inherits Nelinurk

    Private korgus As Double

    ' Konstruktor baasklassi atribuutide väärtustamiseks
    Public Sub New(ByVal alus As Double, ByVal kylg As Double, ByVal korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Rööpkülik", alus, kylg, alus, kylg)

        'Roopkuliku k6rgus
        Me.korgus = korgus
    End Sub

    ' Funktsioon arvutab ja tagastab roopkuliku pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
