Public Class formKujundid

    Private Sub tootleKujund(ByRef kujund As Kujund)
        'Kujundi t66bi v2ljastamine
        lblTyyp.Text = kujund.annaTyyp

        'Pindala ja 6mberm66du arvutamine ja v2ljastamine
        'Vastavalt sellele v22rtusele, mis kasutaja on valinud ComboBoxis cbT2psus,
        'v2ljastab programm tulemuse teatud komakoha t2psusega
        If cbT2psus.SelectedItem = 0 Then
            'Komakohta ei ole
            txtPindala.Text = Math.Ceiling(kujund.leiaPindala)
            txtYmbermoot.Text = Math.Ceiling(kujund.leiaYmberMoot)
        ElseIf cbT2psus.SelectedItem = 1 Then
            'Komakoha t2psus esimese arvuni peale koma
            txtPindala.Text = Math.Ceiling(kujund.leiaPindala * 10) / 10
            txtYmbermoot.Text = Math.Ceiling(kujund.leiaYmberMoot * 10) / 10
        ElseIf cbT2psus.SelectedItem = 2 Then
            'Komakoha t2psus teise arvuni peale koma
            txtPindala.Text = Math.Ceiling(kujund.leiaPindala * 100) / 100
            txtYmbermoot.Text = Math.Ceiling(kujund.leiaYmberMoot * 100) / 100
        ElseIf cbT2psus.SelectedItem = 3 Then
            'Komakoha t2psus kolmanda arvuni peale koma
            txtPindala.Text = Math.Ceiling(kujund.leiaPindala * 1000) / 1000
            txtYmbermoot.Text = Math.Ceiling(kujund.leiaYmberMoot * 1000) / 1000
        Else
            txtPindala.Text = kujund.leiaPindala
            txtYmbermoot.Text = kujund.leiaYmberMoot
        End If

    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        'Objekt kolmnurga klassist
        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektKolmnurk)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        'Objekt ruudu klassist
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        'Otsene v2ljakutse meetodil tootleKujund
        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
    End Sub

End Class
