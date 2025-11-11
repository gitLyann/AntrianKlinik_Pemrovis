Module ModuleApp
    Public Structure UserAccount
        Public Username As String
        Public Password As String ' NOTE: plain text for prototype only
        Public FullName As String
    End Structure

    Public Users As New List(Of UserAccount)

    ' Admin default (ubah sesuai kebutuhan)
    Public AdminUsername As String = "admin"
    Public AdminPassword As String = "admin123"

    ' Simple helper untuk inisialisasi (dipanggil di FormLogin.Load)
    Public Sub InitSampleData()
        If Users.Count = 0 Then
            Dim u As UserAccount
            u.Username = "user1"
            u.Password = "pass1"
            u.FullName = "User Satu"
            Users.Add(u)

            ' (Admin tidak dimasukkan ke Users list; dicek terpisah)
        End If
    End Sub

    Public Function Authenticate(username As String, password As String) As String
        ' Kembalikan "admin" atau "user" atau "" jika gagal
        If username = AdminUsername AndAlso password = AdminPassword Then
            Return "admin"
        End If

        For Each u In Users
            If u.Username = username AndAlso u.Password = password Then
                Return "user"
            End If
        Next

        Return ""
    End Function
End Module
