Public Class FormRegis
    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Dim uname = tbUsername.Text.Trim()
        Dim pwd = tbPass.Text.Trim()

        ' Cek jika username sudah ada
        For Each u In Users
            If u.Username = uname Then
                MessageBox.Show("Username sudah digunakan. Pakai yang lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        Dim newU As ModuleApp.UserAccount
        newU.Username = uname
        newU.Password = pwd

        Users.Add(newU)
        MessageBox.Show("Registrasi berhasil. Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub linkBatal_Click(sender As Object, e As EventArgs) Handles linkBatal.Click
        Me.Close()
    End Sub
End Class
