<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsers
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
        pnlDashboard = New Panel()
        pnlInfo = New Panel()
        Label4 = New Label()
        btnKuitansi = New Button()
        Label3 = New Label()
        Label2 = New Label()
        lblNext = New Label()
        lblYour = New Label()
        DataGridView1 = New DataGridView()
        lblCurrent = New Label()
        Label1 = New Label()
        pnlHeading = New Panel()
        lblHeading = New Label()
        btnDashboard = New Button()
        btnPendaftaran = New Button()
        btnRiwayat = New Button()
        pnlPendaftaran = New Panel()
        btnKonfirm = New Button()
        btnBatal = New Button()
        rbtnUmum = New RadioButton()
        rbtnBPJS = New RadioButton()
        tbUsia = New TextBox()
        tbKeluhan = New TextBox()
        tbAlamat = New TextBox()
        tbNama = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        pnlRiwayat = New Panel()
        DataGridView2 = New DataGridView()
        Label13 = New Label()
        pnlDashboard.SuspendLayout()
        pnlInfo.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeading.SuspendLayout()
        pnlPendaftaran.SuspendLayout()
        pnlRiwayat.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.Controls.Add(pnlInfo)
        pnlDashboard.Controls.Add(pnlHeading)
        pnlDashboard.Location = New Point(15, 95)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(442, 602)
        pnlDashboard.TabIndex = 0
        ' 
        ' pnlInfo
        ' 
        pnlInfo.BackColor = SystemColors.ScrollBar
        pnlInfo.Controls.Add(Label4)
        pnlInfo.Controls.Add(btnKuitansi)
        pnlInfo.Controls.Add(Label3)
        pnlInfo.Controls.Add(Label2)
        pnlInfo.Controls.Add(lblNext)
        pnlInfo.Controls.Add(lblYour)
        pnlInfo.Controls.Add(DataGridView1)
        pnlInfo.Controls.Add(lblCurrent)
        pnlInfo.Controls.Add(Label1)
        pnlInfo.Location = New Point(0, 79)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Size = New Size(442, 520)
        pnlInfo.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins Medium", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(5, 267)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 23)
        Label4.TabIndex = 16
        Label4.Text = "Hasil Pemerikasaan"
        ' 
        ' btnKuitansi
        ' 
        btnKuitansi.BackColor = Color.Lime
        btnKuitansi.Location = New Point(256, 201)
        btnKuitansi.Name = "btnKuitansi"
        btnKuitansi.Size = New Size(135, 44)
        btnKuitansi.TabIndex = 4
        btnKuitansi.Text = "Cek Kuitansi"
        btnKuitansi.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins Medium", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(39, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 23)
        Label3.TabIndex = 15
        Label3.Text = "No Antrian Anda"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins Medium", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(231, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 23)
        Label2.TabIndex = 14
        Label2.Text = "No Antrian Selanjutnya"
        ' 
        ' lblNext
        ' 
        lblNext.AutoSize = True
        lblNext.BackColor = Color.MintCream
        lblNext.Font = New Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNext.Location = New Point(255, 40)
        lblNext.Name = "lblNext"
        lblNext.Size = New Size(136, 78)
        lblNext.TabIndex = 13
        lblNext.Text = "B100"
        ' 
        ' lblYour
        ' 
        lblYour.AutoSize = True
        lblYour.BackColor = Color.Aqua
        lblYour.Font = New Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblYour.Location = New Point(40, 158)
        lblYour.Name = "lblYour"
        lblYour.Size = New Size(136, 78)
        lblYour.TabIndex = 12
        lblYour.Text = "B109"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 293)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(442, 224)
        DataGridView1.TabIndex = 11
        ' 
        ' lblCurrent
        ' 
        lblCurrent.AutoSize = True
        lblCurrent.BackColor = Color.MintCream
        lblCurrent.Font = New Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCurrent.Location = New Point(37, 40)
        lblCurrent.Name = "lblCurrent"
        lblCurrent.Size = New Size(120, 78)
        lblCurrent.TabIndex = 10
        lblCurrent.Text = "B99"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins Medium", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 23)
        Label1.TabIndex = 0
        Label1.Text = "No Antrian Saat Ini"
        ' 
        ' pnlHeading
        ' 
        pnlHeading.BackColor = SystemColors.ScrollBar
        pnlHeading.Controls.Add(lblHeading)
        pnlHeading.Location = New Point(0, 0)
        pnlHeading.Name = "pnlHeading"
        pnlHeading.Size = New Size(442, 67)
        pnlHeading.TabIndex = 0
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(5, 5)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(395, 60)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Selamat Datang di Dashboard Pendaftaran" & vbCrLf & "Klinik ""Waras Kabeh"""
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(15, 33)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(144, 44)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnPendaftaran
        ' 
        btnPendaftaran.Location = New Point(165, 33)
        btnPendaftaran.Name = "btnPendaftaran"
        btnPendaftaran.Size = New Size(144, 44)
        btnPendaftaran.TabIndex = 2
        btnPendaftaran.Text = "Pendaftaran"
        btnPendaftaran.UseVisualStyleBackColor = True
        ' 
        ' btnRiwayat
        ' 
        btnRiwayat.Location = New Point(313, 33)
        btnRiwayat.Name = "btnRiwayat"
        btnRiwayat.Size = New Size(144, 44)
        btnRiwayat.TabIndex = 3
        btnRiwayat.Text = "Riwayat"
        btnRiwayat.UseVisualStyleBackColor = True
        ' 
        ' pnlPendaftaran
        ' 
        pnlPendaftaran.Controls.Add(btnKonfirm)
        pnlPendaftaran.Controls.Add(btnBatal)
        pnlPendaftaran.Controls.Add(rbtnUmum)
        pnlPendaftaran.Controls.Add(rbtnBPJS)
        pnlPendaftaran.Controls.Add(tbUsia)
        pnlPendaftaran.Controls.Add(tbKeluhan)
        pnlPendaftaran.Controls.Add(tbAlamat)
        pnlPendaftaran.Controls.Add(tbNama)
        pnlPendaftaran.Controls.Add(Label12)
        pnlPendaftaran.Controls.Add(Label11)
        pnlPendaftaran.Controls.Add(Label10)
        pnlPendaftaran.Controls.Add(Label9)
        pnlPendaftaran.Controls.Add(Label8)
        pnlPendaftaran.Controls.Add(Label7)
        pnlPendaftaran.Controls.Add(Label6)
        pnlPendaftaran.Controls.Add(Label5)
        pnlPendaftaran.Location = New Point(12, 95)
        pnlPendaftaran.Name = "pnlPendaftaran"
        pnlPendaftaran.Size = New Size(448, 602)
        pnlPendaftaran.TabIndex = 4
        ' 
        ' btnKonfirm
        ' 
        btnKonfirm.BackColor = Color.LimeGreen
        btnKonfirm.ForeColor = SystemColors.ControlLightLight
        btnKonfirm.Location = New Point(326, 555)
        btnKonfirm.Name = "btnKonfirm"
        btnKonfirm.Size = New Size(106, 36)
        btnKonfirm.TabIndex = 16
        btnKonfirm.Text = "Konfirmasi"
        btnKonfirm.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Red
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = SystemColors.ControlLightLight
        btnBatal.Location = New Point(217, 555)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(106, 36)
        btnBatal.TabIndex = 15
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' rbtnUmum
        ' 
        rbtnUmum.AutoSize = True
        rbtnUmum.Location = New Point(234, 345)
        rbtnUmum.Name = "rbtnUmum"
        rbtnUmum.Size = New Size(74, 24)
        rbtnUmum.TabIndex = 14
        rbtnUmum.TabStop = True
        rbtnUmum.Text = "Umum"
        rbtnUmum.UseVisualStyleBackColor = True
        ' 
        ' rbtnBPJS
        ' 
        rbtnBPJS.AutoSize = True
        rbtnBPJS.Location = New Point(234, 316)
        rbtnBPJS.Name = "rbtnBPJS"
        rbtnBPJS.Size = New Size(59, 24)
        rbtnBPJS.TabIndex = 13
        rbtnBPJS.TabStop = True
        rbtnBPJS.Text = "BPJS"
        rbtnBPJS.UseVisualStyleBackColor = True
        ' 
        ' tbUsia
        ' 
        tbUsia.Location = New Point(8, 317)
        tbUsia.Name = "tbUsia"
        tbUsia.Size = New Size(112, 27)
        tbUsia.TabIndex = 12
        ' 
        ' tbKeluhan
        ' 
        tbKeluhan.Location = New Point(8, 388)
        tbKeluhan.Multiline = True
        tbKeluhan.Name = "tbKeluhan"
        tbKeluhan.Size = New Size(424, 148)
        tbKeluhan.TabIndex = 11
        ' 
        ' tbAlamat
        ' 
        tbAlamat.Location = New Point(8, 214)
        tbAlamat.Multiline = True
        tbAlamat.Name = "tbAlamat"
        tbAlamat.Size = New Size(301, 60)
        tbAlamat.TabIndex = 10
        ' 
        ' tbNama
        ' 
        tbNama.Location = New Point(8, 145)
        tbNama.Name = "tbNama"
        tbNama.Size = New Size(301, 27)
        tbNama.TabIndex = 9
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(126, 319)
        Label12.Name = "Label12"
        Label12.Size = New Size(50, 23)
        Label12.TabIndex = 8
        Label12.Text = "Tahun"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(234, 289)
        Label11.Name = "Label11"
        Label11.Size = New Size(89, 23)
        Label11.TabIndex = 7
        Label11.Text = "Jenis Pasien"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(8, 362)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 23)
        Label10.TabIndex = 6
        Label10.Text = "Keluhan"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(8, 289)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 23)
        Label9.TabIndex = 5
        Label9.Text = "Usia"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(8, 183)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 23)
        Label8.TabIndex = 4
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(8, 119)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 23)
        Label7.TabIndex = 3
        Label7.Text = "Nama"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(8, 67)
        Label6.Name = "Label6"
        Label6.Size = New Size(424, 23)
        Label6.TabIndex = 2
        Label6.Text = "Silahkan isi data diri dan juga keluhan yang sedang anda alami." & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(8, 7)
        Label5.Name = "Label5"
        Label5.Size = New Size(370, 60)
        Label5.TabIndex = 1
        Label5.Text = "Selamat Datang di Formulir Pendaftaran" & vbCrLf & "Klinik ""Waras Kabeh"""
        ' 
        ' pnlRiwayat
        ' 
        pnlRiwayat.Controls.Add(DataGridView2)
        pnlRiwayat.Controls.Add(Label13)
        pnlRiwayat.Location = New Point(12, 95)
        pnlRiwayat.Name = "pnlRiwayat"
        pnlRiwayat.Size = New Size(448, 599)
        pnlRiwayat.TabIndex = 5
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(3, 73)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(442, 523)
        DataGridView2.TabIndex = 12
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(8, 7)
        Label13.Name = "Label13"
        Label13.Size = New Size(417, 30)
        Label13.TabIndex = 2
        Label13.Text = "Riwayat Pemeriksaan di Klinik ""Waras Kabeh""" & vbCrLf
        ' 
        ' FormUsers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 709)
        Controls.Add(pnlRiwayat)
        Controls.Add(pnlPendaftaran)
        Controls.Add(btnRiwayat)
        Controls.Add(btnPendaftaran)
        Controls.Add(btnDashboard)
        Controls.Add(pnlDashboard)
        Name = "FormUsers"
        Text = "FormUsers"
        pnlDashboard.ResumeLayout(False)
        pnlInfo.ResumeLayout(False)
        pnlInfo.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlHeading.ResumeLayout(False)
        pnlHeading.PerformLayout()
        pnlPendaftaran.ResumeLayout(False)
        pnlPendaftaran.PerformLayout()
        pnlRiwayat.ResumeLayout(False)
        pnlRiwayat.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnPendaftaran As Button
    Friend WithEvents btnRiwayat As Button
    Friend WithEvents pnlHeading As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblNext As Label
    Friend WithEvents lblYour As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnKuitansi As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlPendaftaran As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbtnUmum As RadioButton
    Friend WithEvents rbtnBPJS As RadioButton
    Friend WithEvents tbUsia As TextBox
    Friend WithEvents tbKeluhan As TextBox
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnKonfirm As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents pnlRiwayat As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label13 As Label
End Class
