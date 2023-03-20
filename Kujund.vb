'Abstraktne baasklass kujundite jaoks
'Abstract base class for all the shapes
Public MustInherit Class Kujund
    Private tyyp As String
    Protected kylgA As Double
    Protected kylgB As Double
    Protected kylgC As Double

    'Konstruktor atribuutide algv22rtustamiseks
    'Constructor to give values to attributes
    'Atribuudid: kylg_a, kylg_b, kylg_c
    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double, ByVal kylgB As Double, ByVal kylgC As Double)
        Me.tyyp = tyyp
        Me.kylgA = kylgA
        Me.kylgB = kylgB
        Me.kylgC = kylgC
    End Sub

    'Funktsioon tagastab kujundi t66bi
    'Function to return the type of the shape
    Public Function annaTyyp() As String
        Return tyyp
    End Function

    'Abstraktne funktsioon kujundi 6mberm66du arvutamiseks
    'Abstract function to calculate the circumference of shape
    Public MustOverride Function leiaYmberMoot() As Double

    'Abstraktne funktsioon kujundi pindala arvutamiseks
    'Abstract function to calculate the surface area of shape
    Public MustOverride Function leiaPindala() As Double
End Class
