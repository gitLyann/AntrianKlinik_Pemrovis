Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleApp.InitSampleData()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname = tbUsername.Text.Trim()
        Dim pwd = tbPass.Text.Trim()

        If String.IsNullOrEmpty(uname) OrElse String.IsNullOrEmpty(pwd) Then
            MessageBox.Show("Username dan password harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim role = ModuleApp.Authenticate(uname, pwd)
        If role = "admin" Then
            Dim f As New FormAdmin()
            f.Show()
            Me.Hide()
        ElseIf role = "user" Then
            Dim f As New FormUsers()
            ' opsional: kirim info user ke dashboard
            f.Tag = uname
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login gagal. Periksa username/password.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegis.LinkClicked
        Dim r As New FormRegis()
        r.ShowDialog()
    End Sub
End Class
