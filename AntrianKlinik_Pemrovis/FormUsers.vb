Public Class FormUsers
    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form pertama kali dibuka, tampilkan Panel Dashboard
        pnlDashboard.Visible = True
        pnlPendaftaran.Visible = False
        pnlRiwayat.Visible = False
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlDashboard.Visible = True
        pnlPendaftaran.Visible = False
        pnlRiwayat.Visible = False
    End Sub

    Private Sub btnPendaftaran_Click(sender As Object, e As EventArgs) Handles btnPendaftaran.Click
        pnlDashboard.Visible = False
        pnlPendaftaran.Visible = True
        pnlRiwayat.Visible = False
    End Sub

    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        pnlDashboard.Visible = False
        pnlPendaftaran.Visible = False
        pnlRiwayat.Visible = True
    End Sub

    Private Sub btnKuitansi_Click(sender As Object, e As EventArgs) Handles btnKuitansi.Click
        Dim f As New FormPesan()
        f.TampilKuitansi()
        f.Show()
    End Sub

    Private Sub btnKonfirm_Click(sender As Object, e As EventArgs) Handles btnKonfirm.Click
        Dim f As New FormPesan()
        f.TampilPesanNo()
        f.Show()
    End Sub
End Class