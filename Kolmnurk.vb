'Matemaatika funktsioonide kaasamine
'Including math functions
Imports System.Math
Public Class Kolmnurk
    Inherits Kujund

    Private korgus As Double

    'Konstruktor baasklassi atribuutide v22rtustamiseks
    'Constructor to give values for base class' attributes
    Public Sub New(ByVal alus As Double, ByVal haar As Double)
        'Kutsume v2lja baasklassi konstruktori
        'Calling base class constructor
        MyBase.New("Võrdhaarne kolmnurk", alus, haar, haar)

        'Kolmnurga k6rgus
        'Height of triangle
        Me.korgus = Sqrt(haar * haar - (alus * alus / 4))
    End Sub

    'Kolmnurga 6mberm66du arvutamine
    'Calculate the circumference of triangle
    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC
    End Function

    'Kolmnurga pindala arvutamine
    'Calculate the surface area of triangle
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus / 2
    End Function
End Class
