Public Class FormAdmin

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form pertama kali dibuka, tampilkan Panel Dashboard
        pnlinfo.Visible = True
        pnledit.Visible = False
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ' Tampilkan Dashboard Panel
        pnlinfo.Visible = True
        pnledit.Visible = False
    End Sub

    Private Sub btnEditStatus_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Tampilkan Edit Panel
        pnlinfo.Visible = False
        pnledit.Visible = True
    End Sub

End Class
