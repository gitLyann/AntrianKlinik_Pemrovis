Public Class FormPesan
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub btnKembali2_Click(sender As Object, e As EventArgs) Handles btnKembali2.Click
        Me.Close()
    End Sub

    Public Sub TampilPesanNo()
        pnlPesanNo.Visible = True
        pnlKuitansi.Visible = False
    End Sub

    Public Sub TampilKuitansi()
        pnlPesanNo.Visible = False
        pnlKuitansi.Visible = True
    End Sub
End Class