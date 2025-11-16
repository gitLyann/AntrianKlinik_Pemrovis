<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPesan
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
        pnlPesanNo = New Panel()
        btnKembali = New Button()
        Label3 = New Label()
        lblYour = New Label()
        Label13 = New Label()
        pnlKuitansi = New Panel()
        dgvJenisBiaya = New DataGridView()
        dgvInfo = New DataGridView()
        btnKembali2 = New Button()
        Label1 = New Label()
        pnlPesanNo.SuspendLayout()
        pnlKuitansi.SuspendLayout()
        CType(dgvJenisBiaya, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlPesanNo
        ' 
        pnlPesanNo.BackColor = SystemColors.ScrollBar
        pnlPesanNo.Controls.Add(btnKembali)
        pnlPesanNo.Controls.Add(Label3)
        pnlPesanNo.Controls.Add(lblYour)
        pnlPesanNo.Controls.Add(Label13)
        pnlPesanNo.Location = New Point(61, 76)
        pnlPesanNo.Name = "pnlPesanNo"
        pnlPesanNo.Size = New Size(309, 314)
        pnlPesanNo.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.LimeGreen
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = SystemColors.ButtonHighlight
        btnKembali.Location = New Point(99, 251)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(106, 36)
        btnKembali.TabIndex = 17
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins Medium", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(90, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 23)
        Label3.TabIndex = 16
        Label3.Text = "No Antrian Anda"
        ' 
        ' lblYour
        ' 
        lblYour.AutoSize = True
        lblYour.BackColor = Color.Aqua
        lblYour.Font = New Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblYour.Location = New Point(85, 137)
        lblYour.Name = "lblYour"
        lblYour.Size = New Size(136, 78)
        lblYour.TabIndex = 13
        lblYour.Text = "B109"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(12, 30)
        Label13.Name = "Label13"
        Label13.Size = New Size(288, 60)
        Label13.TabIndex = 3
        Label13.Text = "Harap Menunggu Antrian Anda" & vbCrLf & vbCrLf
        ' 
        ' pnlKuitansi
        ' 
        pnlKuitansi.BackColor = SystemColors.ScrollBar
        pnlKuitansi.Controls.Add(dgvJenisBiaya)
        pnlKuitansi.Controls.Add(dgvInfo)
        pnlKuitansi.Controls.Add(btnKembali2)
        pnlKuitansi.Controls.Add(Label1)
        pnlKuitansi.Location = New Point(12, 12)
        pnlKuitansi.Name = "pnlKuitansi"
        pnlKuitansi.Size = New Size(411, 452)
        pnlKuitansi.TabIndex = 1
        ' 
        ' dgvJenisBiaya
        ' 
        dgvJenisBiaya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJenisBiaya.Location = New Point(18, 238)
        dgvJenisBiaya.Name = "dgvJenisBiaya"
        dgvJenisBiaya.RowHeadersWidth = 51
        dgvJenisBiaya.Size = New Size(374, 140)
        dgvJenisBiaya.TabIndex = 20
        ' 
        ' dgvInfo
        ' 
        dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInfo.Location = New Point(18, 84)
        dgvInfo.Name = "dgvInfo"
        dgvInfo.RowHeadersWidth = 51
        dgvInfo.Size = New Size(374, 140)
        dgvInfo.TabIndex = 19
        ' 
        ' btnKembali2
        ' 
        btnKembali2.BackColor = Color.LimeGreen
        btnKembali2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali2.ForeColor = SystemColors.ButtonHighlight
        btnKembali2.Location = New Point(148, 384)
        btnKembali2.Name = "btnKembali2"
        btnKembali2.Size = New Size(106, 36)
        btnKembali2.TabIndex = 18
        btnKembali2.Text = "Kembali"
        btnKembali2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(54, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(301, 30)
        Label1.TabIndex = 4
        Label1.Text = "Silahkan Menuju Ke Administrasi" & vbCrLf
        ' 
        ' FormPesan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(435, 476)
        Controls.Add(pnlKuitansi)
        Controls.Add(pnlPesanNo)
        Name = "FormPesan"
        Text = "FormPesan"
        pnlPesanNo.ResumeLayout(False)
        pnlPesanNo.PerformLayout()
        pnlKuitansi.ResumeLayout(False)
        pnlKuitansi.PerformLayout()
        CType(dgvJenisBiaya, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlPesanNo As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents lblYour As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents pnlKuitansi As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvJenisBiaya As DataGridView
    Friend WithEvents dgvInfo As DataGridView
    Friend WithEvents btnKembali2 As Button
End Class
