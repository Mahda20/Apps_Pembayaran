<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_bulan = New System.Windows.Forms.ComboBox()
        Me.txt_tahunajar = New System.Windows.Forms.TextBox()
        Me.id_tahunajar = New System.Windows.Forms.TextBox()
        Me.id_jenis = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.jumlahbayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bayar = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.txt_nominal = New System.Windows.Forms.TextBox()
        Me.txt_durasi = New System.Windows.Forms.TextBox()
        Me.txt_jenis_bayar = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_nis = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_jenis_pembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_jenis_pembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.durasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nominal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_group_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tahun_ajaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_ajaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_grup_bayar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(47, 65)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(299, 22)
        Me.txt_search.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.id_grup_bayar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_bulan)
        Me.GroupBox1.Controls.Add(Me.txt_tahunajar)
        Me.GroupBox1.Controls.Add(Me.id_tahunajar)
        Me.GroupBox1.Controls.Add(Me.id_jenis)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.bayar)
        Me.GroupBox1.Controls.Add(Me.cancel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_ket)
        Me.GroupBox1.Controls.Add(Me.txt_nominal)
        Me.GroupBox1.Controls.Add(Me.txt_durasi)
        Me.GroupBox1.Controls.Add(Me.txt_jenis_bayar)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.txt_nis)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 705)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran Online"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(585, 371)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(317, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "> Selalu Cek Pembayaran yang sudah di lakukan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(585, 340)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(297, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "> Lalu Cek kembali apakah data sesuai / tidak"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(585, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "> Pilih Jenis pembayaran yang akan di bayar"
        '
        'txt_bulan
        '
        Me.txt_bulan.FormattingEnabled = True
        Me.txt_bulan.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.txt_bulan.Location = New System.Drawing.Point(168, 517)
        Me.txt_bulan.Name = "txt_bulan"
        Me.txt_bulan.Size = New System.Drawing.Size(253, 24)
        Me.txt_bulan.TabIndex = 13
        '
        'txt_tahunajar
        '
        Me.txt_tahunajar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_tahunajar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tahunajar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_tahunajar.Location = New System.Drawing.Point(426, 280)
        Me.txt_tahunajar.Name = "txt_tahunajar"
        Me.txt_tahunajar.Size = New System.Drawing.Size(100, 22)
        Me.txt_tahunajar.TabIndex = 12
        Me.txt_tahunajar.Visible = False
        '
        'id_tahunajar
        '
        Me.id_tahunajar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.id_tahunajar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_tahunajar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.id_tahunajar.Location = New System.Drawing.Point(299, 280)
        Me.id_tahunajar.Name = "id_tahunajar"
        Me.id_tahunajar.Size = New System.Drawing.Size(100, 22)
        Me.id_tahunajar.TabIndex = 12
        Me.id_tahunajar.Visible = False
        '
        'id_jenis
        '
        Me.id_jenis.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.id_jenis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_jenis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.id_jenis.Location = New System.Drawing.Point(173, 280)
        Me.id_jenis.Name = "id_jenis"
        Me.id_jenis.Size = New System.Drawing.Size(100, 22)
        Me.id_jenis.TabIndex = 12
        Me.id_jenis.Visible = False
        '
        'DataGridView2
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jumlahbayar})
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.Location = New System.Drawing.Point(588, 429)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(269, 57)
        Me.DataGridView2.TabIndex = 10
        '
        'jumlahbayar
        '
        Me.jumlahbayar.HeaderText = "Sudah Bayar"
        Me.jumlahbayar.Name = "jumlahbayar"
        Me.jumlahbayar.Width = 140
        '
        'bayar
        '
        Me.bayar.Location = New System.Drawing.Point(729, 517)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(119, 65)
        Me.bayar.TabIndex = 6
        Me.bayar.Text = "Bayar"
        Me.bayar.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(588, 517)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(119, 65)
        Me.cancel.TabIndex = 6
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_ket
        '
        Me.txt_ket.Location = New System.Drawing.Point(168, 562)
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.Size = New System.Drawing.Size(253, 22)
        Me.txt_ket.TabIndex = 5
        '
        'txt_nominal
        '
        Me.txt_nominal.Location = New System.Drawing.Point(168, 471)
        Me.txt_nominal.Name = "txt_nominal"
        Me.txt_nominal.ReadOnly = True
        Me.txt_nominal.Size = New System.Drawing.Size(253, 22)
        Me.txt_nominal.TabIndex = 5
        '
        'txt_durasi
        '
        Me.txt_durasi.Location = New System.Drawing.Point(168, 429)
        Me.txt_durasi.Name = "txt_durasi"
        Me.txt_durasi.ReadOnly = True
        Me.txt_durasi.Size = New System.Drawing.Size(253, 22)
        Me.txt_durasi.TabIndex = 5
        '
        'txt_jenis_bayar
        '
        Me.txt_jenis_bayar.Location = New System.Drawing.Point(168, 388)
        Me.txt_jenis_bayar.Name = "txt_jenis_bayar"
        Me.txt_jenis_bayar.ReadOnly = True
        Me.txt_jenis_bayar.Size = New System.Drawing.Size(253, 22)
        Me.txt_jenis_bayar.TabIndex = 5
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(168, 351)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.ReadOnly = True
        Me.txt_nama.Size = New System.Drawing.Size(253, 22)
        Me.txt_nama.TabIndex = 5
        '
        'txt_nis
        '
        Me.txt_nis.Location = New System.Drawing.Point(168, 313)
        Me.txt_nis.Name = "txt_nis"
        Me.txt_nis.ReadOnly = True
        Me.txt_nis.Size = New System.Drawing.Size(253, 22)
        Me.txt_nis.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 565)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "KETERANGAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "BULAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "NOMINAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DURASI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "JENIS BAYAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NIS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_jenis_pembayaran, Me.nis, Me.nama_siswa, Me.nama_jenis_pembayaran, Me.durasi, Me.nominal, Me.id_group_bayar, Me.id_tahun_ajaran, Me.tahun_ajaran})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(895, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'id_jenis_pembayaran
        '
        Me.id_jenis_pembayaran.HeaderText = "No"
        Me.id_jenis_pembayaran.Name = "id_jenis_pembayaran"
        Me.id_jenis_pembayaran.Visible = False
        '
        'nis
        '
        Me.nis.HeaderText = "NIS"
        Me.nis.Name = "nis"
        '
        'nama_siswa
        '
        Me.nama_siswa.HeaderText = "Nama Siswa"
        Me.nama_siswa.Name = "nama_siswa"
        '
        'nama_jenis_pembayaran
        '
        Me.nama_jenis_pembayaran.HeaderText = "Jenis Pembayaran"
        Me.nama_jenis_pembayaran.Name = "nama_jenis_pembayaran"
        '
        'durasi
        '
        Me.durasi.HeaderText = "Durasi"
        Me.durasi.Name = "durasi"
        '
        'nominal
        '
        Me.nominal.HeaderText = "Nominal"
        Me.nominal.Name = "nominal"
        '
        'id_group_bayar
        '
        Me.id_group_bayar.HeaderText = "ID"
        Me.id_group_bayar.Name = "id_group_bayar"
        Me.id_group_bayar.Visible = False
        '
        'id_tahun_ajaran
        '
        Me.id_tahun_ajaran.HeaderText = "ID Tahun Ajaran"
        Me.id_tahun_ajaran.Name = "id_tahun_ajaran"
        Me.id_tahun_ajaran.Visible = False
        '
        'tahun_ajaran
        '
        Me.tahun_ajaran.HeaderText = "Tahun Ajaran"
        Me.tahun_ajaran.Name = "tahun_ajaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Masukan Nomor Siswa"
        '
        'id_grup_bayar
        '
        Me.id_grup_bayar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.id_grup_bayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_grup_bayar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.id_grup_bayar.Location = New System.Drawing.Point(47, 280)
        Me.id_grup_bayar.Name = "id_grup_bayar"
        Me.id_grup_bayar.Size = New System.Drawing.Size(100, 22)
        Me.id_grup_bayar.TabIndex = 15
        Me.id_grup_bayar.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 792)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_search As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents bayar As Button
    Friend WithEvents cancel As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_ket As TextBox
    Friend WithEvents txt_nominal As TextBox
    Friend WithEvents txt_durasi As TextBox
    Friend WithEvents txt_jenis_bayar As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_nis As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents id_jenis As TextBox
    Friend WithEvents id_jenis_pembayaran As DataGridViewTextBoxColumn
    Friend WithEvents nis As DataGridViewTextBoxColumn
    Friend WithEvents nama_siswa As DataGridViewTextBoxColumn
    Friend WithEvents nama_jenis_pembayaran As DataGridViewTextBoxColumn
    Friend WithEvents durasi As DataGridViewTextBoxColumn
    Friend WithEvents nominal As DataGridViewTextBoxColumn
    Friend WithEvents id_group_bayar As DataGridViewTextBoxColumn
    Friend WithEvents id_tahun_ajaran As DataGridViewTextBoxColumn
    Friend WithEvents tahun_ajaran As DataGridViewTextBoxColumn
    Friend WithEvents jumlahbayar As DataGridViewTextBoxColumn
    Friend WithEvents txt_bulan As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents id_tahunajar As TextBox
    Friend WithEvents txt_tahunajar As TextBox
    Friend WithEvents id_grup_bayar As TextBox
End Class
