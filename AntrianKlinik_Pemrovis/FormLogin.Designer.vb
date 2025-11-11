<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tbUsername = New TextBox()
        tbPass = New TextBox()
        lblUsername = New Label()
        lblPass = New Label()
        linkRegis = New LinkLabel()
        btnLogin = New Button()
        lblHeading = New Label()
        SuspendLayout()
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(120, 166)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(236, 27)
        tbUsername.TabIndex = 0
        ' 
        ' tbPass
        ' 
        tbPass.Location = New Point(120, 231)
        tbPass.Name = "tbPass"
        tbPass.Size = New Size(236, 27)
        tbPass.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(120, 134)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 20)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(120, 201)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(70, 20)
        lblPass.TabIndex = 3
        lblPass.Text = "Password"
        ' 
        ' linkRegis
        ' 
        linkRegis.AutoSize = True
        linkRegis.Location = New Point(200, 336)
        linkRegis.Name = "linkRegis"
        linkRegis.Size = New Size(80, 20)
        linkRegis.TabIndex = 4
        linkRegis.TabStop = True
        linkRegis.Text = "Registrasi?"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(175, 286)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(130, 36)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Location = New Point(107, 61)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(263, 20)
        lblHeading.TabIndex = 6
        lblHeading.Text = "Selamat Datang di Klinik Waras Kabeh"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 482)
        Controls.Add(lblHeading)
        Controls.Add(btnLogin)
        Controls.Add(linkRegis)
        Controls.Add(lblPass)
        Controls.Add(lblUsername)
        Controls.Add(tbPass)
        Controls.Add(tbUsername)
        Name = "FormLogin"
        Text = "FormLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents linkRegis As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblHeading As Label

End Class
