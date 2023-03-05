'Abstraktne baasklass kujundite jaoks
Public MustInherit Class Kujund
    Private tyyp As String
    Protected kylgA As Double
    Protected kylgB As Double
    Protected kylgC As Double

    'Konstruktor atribuutide algv22rtustamiseks
    'Atribuudid: kylg_a, kylg_b, kylg_c
    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double, ByVal kylgB As Double, ByVal kylgC As Double)
        Me.tyyp = tyyp
        Me.kylgA = kylgA
        Me.kylgB = kylgB
        Me.kylgC = kylgC
    End Sub

    'Funktsioon tagastab kujundi t66bi
    Public Function annaTyyp() As String
        Return tyyp
    End Function

    'Abstraktne funktsioon kujundi 6mberm66du arvutamiseks
    Public MustOverride Function leiaYmberMoot() As Double

    'Abstraktne funktsioon kujundi pindala arvutamiseks
    Public MustOverride Function leiaPindala() As Double
End Class
