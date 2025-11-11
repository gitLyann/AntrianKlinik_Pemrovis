<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        pnlinfo = New Panel()
        pnlheading = New Panel()
        lblHeading = New Label()
        lblCurrent = New Label()
        lblNext = New Label()
        lblJumlah = New Label()
        lblJumlahPasien = New Label()
        lblNextAntri = New Label()
        lblCurrentAntri = New Label()
        lblPasien = New Label()
        dgvPasien = New DataGridView()
        btnDashboard = New Button()
        btnEdit = New Button()
        pnledit = New Panel()
        pnltabeldataEdit = New Panel()
        lblHeadingTabelEdit = New Label()
        DataGridView1 = New DataGridView()
        pnlupdateEdit = New Panel()
        rbUmum = New RadioButton()
        rbBPJS = New RadioButton()
        tbBiaya = New TextBox()
        tbTgl = New TextBox()
        tbHasil = New TextBox()
        tbKeluhan = New TextBox()
        btnSimpan = New Button()
        btnBatal = New Button()
        lblBiaya = New Label()
        lblJenisPasien = New Label()
        lblHasil = New Label()
        lblKeluhan = New Label()
        lblTgl = New Label()
        lblHeadingEdit = New Label()
        pnlsearch = New Panel()
        btnClear = New Button()
        btnCari = New Button()
        tbNoAntrian = New TextBox()
        lblEdit = New Label()
        pnlinfo.SuspendLayout()
        pnlheading.SuspendLayout()
        CType(dgvPasien, ComponentModel.ISupportInitialize).BeginInit()
        pnledit.SuspendLayout()
        pnltabeldataEdit.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlupdateEdit.SuspendLayout()
        pnlsearch.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlinfo
        ' 
        pnlinfo.BackColor = SystemColors.Control
        pnlinfo.Controls.Add(pnlheading)
        pnlinfo.Controls.Add(lblCurrent)
        pnlinfo.Controls.Add(lblNext)
        pnlinfo.Controls.Add(lblJumlah)
        pnlinfo.Controls.Add(lblJumlahPasien)
        pnlinfo.Controls.Add(lblNextAntri)
        pnlinfo.Controls.Add(lblCurrentAntri)
        pnlinfo.Controls.Add(lblPasien)
        pnlinfo.Controls.Add(dgvPasien)
        pnlinfo.Location = New Point(15, 81)
        pnlinfo.Name = "pnlinfo"
        pnlinfo.Size = New Size(744, 914)
        pnlinfo.TabIndex = 0
        ' 
        ' pnlheading
        ' 
        pnlheading.BackColor = SystemColors.ScrollBar
        pnlheading.Controls.Add(lblHeading)
        pnlheading.Location = New Point(0, 0)
        pnlheading.Name = "pnlheading"
        pnlheading.Size = New Size(741, 75)
        pnlheading.TabIndex = 1
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(0, 0)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(378, 70)
        lblHeading.TabIndex = 0
        lblHeading.Text = "WELCOME ADMIN"
        ' 
        ' lblCurrent
        ' 
        lblCurrent.AutoSize = True
        lblCurrent.BackColor = Color.Aqua
        lblCurrent.Font = New Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCurrent.Location = New Point(12, 130)
        lblCurrent.Name = "lblCurrent"
        lblCurrent.Size = New Size(136, 78)
        lblCurrent.TabIndex = 9
        lblCurrent.Text = "B109"
        ' 
        ' lblNext
        ' 
        lblNext.AutoSize = True
        lblNext.BackColor = Color.Aqua
        lblNext.Font = New Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNext.Location = New Point(221, 130)
        lblNext.Name = "lblNext"
        lblNext.Size = New Size(123, 78)
        lblNext.TabIndex = 8
        lblNext.Text = "B110"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.BackColor = Color.Aqua
        lblJumlah.Font = New Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJumlah.Location = New Point(539, 130)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(117, 78)
        lblJumlah.TabIndex = 7
        lblJumlah.Text = "250"
        ' 
        ' lblJumlahPasien
        ' 
        lblJumlahPasien.AutoSize = True
        lblJumlahPasien.Location = New Point(539, 105)
        lblJumlahPasien.Name = "lblJumlahPasien"
        lblJumlahPasien.Size = New Size(100, 20)
        lblJumlahPasien.TabIndex = 6
        lblJumlahPasien.Text = "Jumlah Pasien"
        ' 
        ' lblNextAntri
        ' 
        lblNextAntri.AutoSize = True
        lblNextAntri.Location = New Point(221, 105)
        lblNextAntri.Name = "lblNextAntri"
        lblNextAntri.Size = New Size(161, 20)
        lblNextAntri.TabIndex = 5
        lblNextAntri.Text = "No Antrian Selanjutnya"
        ' 
        ' lblCurrentAntri
        ' 
        lblCurrentAntri.AutoSize = True
        lblCurrentAntri.Location = New Point(12, 105)
        lblCurrentAntri.Name = "lblCurrentAntri"
        lblCurrentAntri.Size = New Size(146, 20)
        lblCurrentAntri.TabIndex = 4
        lblCurrentAntri.Text = "No Antrian Sekarang"
        ' 
        ' lblPasien
        ' 
        lblPasien.AutoSize = True
        lblPasien.Location = New Point(12, 225)
        lblPasien.Name = "lblPasien"
        lblPasien.Size = New Size(86, 20)
        lblPasien.TabIndex = 1
        lblPasien.Text = "Data Pasien"
        ' 
        ' dgvPasien
        ' 
        dgvPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPasien.Location = New Point(12, 260)
        dgvPasien.Name = "dgvPasien"
        dgvPasien.RowHeadersWidth = 51
        dgvPasien.Size = New Size(717, 644)
        dgvPasien.TabIndex = 0
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(18, 12)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(182, 55)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(206, 12)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(182, 55)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit Status"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' pnledit
        ' 
        pnledit.Controls.Add(pnltabeldataEdit)
        pnledit.Controls.Add(pnlupdateEdit)
        pnledit.Controls.Add(pnlsearch)
        pnledit.Location = New Point(13, 81)
        pnledit.Name = "pnledit"
        pnledit.Size = New Size(746, 914)
        pnledit.TabIndex = 1
        ' 
        ' pnltabeldataEdit
        ' 
        pnltabeldataEdit.Controls.Add(lblHeadingTabelEdit)
        pnltabeldataEdit.Controls.Add(DataGridView1)
        pnltabeldataEdit.Location = New Point(1, 558)
        pnltabeldataEdit.Name = "pnltabeldataEdit"
        pnltabeldataEdit.Size = New Size(745, 356)
        pnltabeldataEdit.TabIndex = 2
        ' 
        ' lblHeadingTabelEdit
        ' 
        lblHeadingTabelEdit.AutoSize = True
        lblHeadingTabelEdit.Location = New Point(15, 12)
        lblHeadingTabelEdit.Name = "lblHeadingTabelEdit"
        lblHeadingTabelEdit.Size = New Size(86, 20)
        lblHeadingTabelEdit.TabIndex = 15
        lblHeadingTabelEdit.Text = "Data Pasien"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(15, 46)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(717, 302)
        DataGridView1.TabIndex = 0
        ' 
        ' pnlupdateEdit
        ' 
        pnlupdateEdit.Controls.Add(rbUmum)
        pnlupdateEdit.Controls.Add(rbBPJS)
        pnlupdateEdit.Controls.Add(tbBiaya)
        pnlupdateEdit.Controls.Add(tbTgl)
        pnlupdateEdit.Controls.Add(tbHasil)
        pnlupdateEdit.Controls.Add(tbKeluhan)
        pnlupdateEdit.Controls.Add(btnSimpan)
        pnlupdateEdit.Controls.Add(btnBatal)
        pnlupdateEdit.Controls.Add(lblBiaya)
        pnlupdateEdit.Controls.Add(lblJenisPasien)
        pnlupdateEdit.Controls.Add(lblHasil)
        pnlupdateEdit.Controls.Add(lblKeluhan)
        pnlupdateEdit.Controls.Add(lblTgl)
        pnlupdateEdit.Controls.Add(lblHeadingEdit)
        pnlupdateEdit.Location = New Point(1, 130)
        pnlupdateEdit.Name = "pnlupdateEdit"
        pnlupdateEdit.Size = New Size(745, 403)
        pnlupdateEdit.TabIndex = 1
        ' 
        ' rbUmum
        ' 
        rbUmum.AutoSize = True
        rbUmum.Location = New Point(492, 184)
        rbUmum.Name = "rbUmum"
        rbUmum.Size = New Size(74, 24)
        rbUmum.TabIndex = 14
        rbUmum.TabStop = True
        rbUmum.Text = "Umum"
        rbUmum.UseVisualStyleBackColor = True
        ' 
        ' rbBPJS
        ' 
        rbBPJS.AutoSize = True
        rbBPJS.Location = New Point(492, 154)
        rbBPJS.Name = "rbBPJS"
        rbBPJS.Size = New Size(59, 24)
        rbBPJS.TabIndex = 13
        rbBPJS.TabStop = True
        rbBPJS.Text = "BPJS"
        rbBPJS.UseVisualStyleBackColor = True
        ' 
        ' tbBiaya
        ' 
        tbBiaya.Location = New Point(492, 283)
        tbBiaya.Name = "tbBiaya"
        tbBiaya.Size = New Size(219, 27)
        tbBiaya.TabIndex = 12
        ' 
        ' tbTgl
        ' 
        tbTgl.Location = New Point(268, 68)
        tbTgl.Name = "tbTgl"
        tbTgl.Size = New Size(188, 27)
        tbTgl.TabIndex = 4
        ' 
        ' tbHasil
        ' 
        tbHasil.Location = New Point(21, 283)
        tbHasil.Multiline = True
        tbHasil.Name = "tbHasil"
        tbHasil.Size = New Size(417, 111)
        tbHasil.TabIndex = 11
        ' 
        ' tbKeluhan
        ' 
        tbKeluhan.Location = New Point(21, 142)
        tbKeluhan.Multiline = True
        tbKeluhan.Name = "tbKeluhan"
        tbKeluhan.Size = New Size(417, 115)
        tbKeluhan.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(605, 358)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(106, 36)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(492, 358)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(106, 36)
        btnBatal.TabIndex = 4
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' lblBiaya
        ' 
        lblBiaya.AutoSize = True
        lblBiaya.Location = New Point(492, 260)
        lblBiaya.Name = "lblBiaya"
        lblBiaya.Size = New Size(131, 20)
        lblBiaya.TabIndex = 9
        lblBiaya.Text = "Biaya Pemeriksaan"
        ' 
        ' lblJenisPasien
        ' 
        lblJenisPasien.AutoSize = True
        lblJenisPasien.Location = New Point(492, 119)
        lblJenisPasien.Name = "lblJenisPasien"
        lblJenisPasien.Size = New Size(85, 20)
        lblJenisPasien.TabIndex = 8
        lblJenisPasien.Text = "Jenis Pasien"
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(21, 260)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(128, 20)
        lblHasil.TabIndex = 7
        lblHasil.Text = "Hasil Pemeriksaan"
        ' 
        ' lblKeluhan
        ' 
        lblKeluhan.AutoSize = True
        lblKeluhan.Location = New Point(21, 119)
        lblKeluhan.Name = "lblKeluhan"
        lblKeluhan.Size = New Size(62, 20)
        lblKeluhan.TabIndex = 6
        lblKeluhan.Text = "Keluhan"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Location = New Point(268, 45)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(61, 20)
        lblTgl.TabIndex = 5
        lblTgl.Text = "Tanggal"
        ' 
        ' lblHeadingEdit
        ' 
        lblHeadingEdit.AutoSize = True
        lblHeadingEdit.Location = New Point(17, 27)
        lblHeadingEdit.Name = "lblHeadingEdit"
        lblHeadingEdit.Size = New Size(86, 20)
        lblHeadingEdit.TabIndex = 4
        lblHeadingEdit.Text = "Data Pasien"
        ' 
        ' pnlsearch
        ' 
        pnlsearch.Controls.Add(btnClear)
        pnlsearch.Controls.Add(btnCari)
        pnlsearch.Controls.Add(tbNoAntrian)
        pnlsearch.Controls.Add(lblEdit)
        pnlsearch.Location = New Point(0, 0)
        pnlsearch.Name = "pnlsearch"
        pnlsearch.Size = New Size(746, 113)
        pnlsearch.TabIndex = 0
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(606, 38)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 36)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(493, 38)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(106, 36)
        btnCari.TabIndex = 2
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' tbNoAntrian
        ' 
        tbNoAntrian.Location = New Point(21, 49)
        tbNoAntrian.Name = "tbNoAntrian"
        tbNoAntrian.Size = New Size(417, 27)
        tbNoAntrian.TabIndex = 1
        ' 
        ' lblEdit
        ' 
        lblEdit.AutoSize = True
        lblEdit.Location = New Point(21, 16)
        lblEdit.Name = "lblEdit"
        lblEdit.Size = New Size(188, 20)
        lblEdit.TabIndex = 0
        lblEdit.Text = "Masukan No Antrian Pasien"
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(772, 1007)
        Controls.Add(btnEdit)
        Controls.Add(pnledit)
        Controls.Add(btnDashboard)
        Controls.Add(pnlinfo)
        Name = "FormAdmin"
        Text = "FormAdmin"
        pnlinfo.ResumeLayout(False)
        pnlinfo.PerformLayout()
        pnlheading.ResumeLayout(False)
        pnlheading.PerformLayout()
        CType(dgvPasien, ComponentModel.ISupportInitialize).EndInit()
        pnledit.ResumeLayout(False)
        pnltabeldataEdit.ResumeLayout(False)
        pnltabeldataEdit.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlupdateEdit.ResumeLayout(False)
        pnlupdateEdit.PerformLayout()
        pnlsearch.ResumeLayout(False)
        pnlsearch.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlinfo As Panel
    Friend WithEvents pnlheading As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblPasien As Label
    Friend WithEvents dgvPasien As DataGridView
    Friend WithEvents lblNextAntri As Label
    Friend WithEvents lblCurrentAntri As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblJumlahPasien As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblNext As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents pnledit As Panel
    Friend WithEvents pnlsearch As Panel
    Friend WithEvents tbNoAntrian As TextBox
    Friend WithEvents lblEdit As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents pnlupdateEdit As Panel
    Friend WithEvents tbBiaya As TextBox
    Friend WithEvents tbTgl As TextBox
    Friend WithEvents tbHasil As TextBox
    Friend WithEvents tbKeluhan As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblBiaya As Label
    Friend WithEvents lblJenisPasien As Label
    Friend WithEvents lblHasil As Label
    Friend WithEvents lblKeluhan As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblHeadingEdit As Label
    Friend WithEvents rbUmum As RadioButton
    Friend WithEvents rbBPJS As RadioButton
    Friend WithEvents pnltabeldataEdit As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblHeadingTabelEdit As Label
End Class
