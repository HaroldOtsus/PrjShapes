'Matemaatika funktsioonide kaasamine
Imports System.Math
Public Class Kolmnurk
    Inherits Kujund

    Private korgus As Double

    'Konstruktor baasklassi atribuutide v22rtustamiseks
    Public Sub New(ByVal alus As Double, ByVal haar As Double)
        'Kutsume v2lja baasklassi konstruktori
        MyBase.New("Võrdhaarne kolmnurk", alus, haar, haar)

        'Kolmnurga k6rgus
        Me.korgus = Sqrt(haar * haar - (alus * alus / 4))
    End Sub

    'Kolmnurga 6mberm66du arvutamine
    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC
    End Function

    'Kolmnurga pindala arvutamine
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus / 2
    End Function
End Class
