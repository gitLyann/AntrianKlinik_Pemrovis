<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblHeading = New Label()
        lblUsername = New Label()
        lblPass = New Label()
        tbUsername = New TextBox()
        tbPass = New TextBox()
        btnRegis = New Button()
        Button2 = New Button()
        linkBatal = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Location = New Point(141, 61)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(186, 20)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Silahkan Daftar Akun Anda"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(120, 134)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 20)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(120, 201)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(70, 20)
        lblPass.TabIndex = 2
        lblPass.Text = "Password"
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(120, 166)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(236, 27)
        tbUsername.TabIndex = 3
        ' 
        ' tbPass
        ' 
        tbPass.Location = New Point(120, 231)
        tbPass.Name = "tbPass"
        tbPass.Size = New Size(236, 27)
        tbPass.TabIndex = 4
        ' 
        ' btnRegis
        ' 
        btnRegis.Location = New Point(175, 286)
        btnRegis.Name = "btnRegis"
        btnRegis.Size = New Size(130, 36)
        btnRegis.TabIndex = 5
        btnRegis.Text = "Registrasi"
        btnRegis.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(171, 340)
        Button2.Name = "Button2"
        Button2.Size = New Size(0, 0)
        Button2.TabIndex = 6
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' linkBatal
        ' 
        linkBatal.AutoSize = True
        linkBatal.LinkColor = Color.Black
        linkBatal.Location = New Point(214, 336)
        linkBatal.Name = "linkBatal"
        linkBatal.Size = New Size(43, 20)
        linkBatal.TabIndex = 7
        linkBatal.TabStop = True
        linkBatal.Text = "Batal"
        ' 
        ' FormRegis
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 482)
        Controls.Add(linkBatal)
        Controls.Add(Button2)
        Controls.Add(btnRegis)
        Controls.Add(tbPass)
        Controls.Add(tbUsername)
        Controls.Add(lblPass)
        Controls.Add(lblUsername)
        Controls.Add(lblHeading)
        Name = "FormRegis"
        Text = "FormRegis"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents btnRegis As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents linkBatal As LinkLabel
End Class
