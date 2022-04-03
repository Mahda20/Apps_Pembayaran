Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Public Class Form1
    Public id As String

    Private Sub carinis()
        Try
            DataGridView1.Rows.Clear()
            Dim uriString As String = "http://localhost/apiKon/index.php/Welcome/getDataPembayaranWhere/" & txt_search.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(item("id_jenis_pembayaran").ToString, item("nis").ToString, item("nama_siswa").ToString,
                                       item("nama_jenis_pembayaran").ToString, item("durasi").ToString, item("nominal").ToString, item("id_group_bayar").ToString, item("id_tahun_ajaran").ToString, item("tahun_ajaran").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        carinis()
    End Sub

    Private Sub pembayaran_ke()
        Try
            DataGridView2.Rows.Clear()
            Dim uriString As String = "http://localhost/apiKon/index.php/Welcome/getDataJoinWhereJumlah/" & txt_search.Text.Trim & "/" & id_grup_bayar.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)

            For Each item As Object In dict
                DataGridView2.Rows.Add(item("jumlahbayar").ToString)

            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        id = Nothing
        id = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_nis.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txt_nama.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_jenis_bayar.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txt_durasi.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txt_nominal.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        id_jenis.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        id_tahunajar.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        txt_tahunajar.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        id_grup_bayar.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        pembayaran_ke()
        Dim tanggal As Date = Now
        Dim month As String

        month = tanggal.Month

        txt_bulan.Text = month


    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        id = Nothing
        txt_search.Text = ""
        txt_nis.Text = "----------------------------------------------"
        txt_nama.Text = "----------------------------------------------"
        txt_jenis_bayar.Text = "----------------------------------------------"
        txt_durasi.Text = "----------------------------------------------"
        txt_nominal.Text = "----------------------------------------------"
        txt_bulan.Text = ""
        txt_ket.Text = ""
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nis.Text = "----------------------------------------------"
        txt_nama.Text = "----------------------------------------------"
        txt_jenis_bayar.Text = "----------------------------------------------"
        txt_durasi.Text = "----------------------------------------------"
        txt_nominal.Text = "----------------------------------------------"
    End Sub

    Private Sub bayar_Click(sender As Object, e As EventArgs) Handles bayar.Click

        If MessageBox.Show("Lanjut ke pembayaran?", "Konfirm Perubahan", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Form3.DataGridView1.Rows.Add(txt_nis.Text, txt_nama.Text, id_jenis.Text, txt_jenis_bayar.Text, txt_bulan.Text, txt_nominal.Text, id_tahunajar.Text, txt_tahunajar.Text, txt_ket.Text)
            MsgBox("Terima Kasih!, silahkan menuju kasir untuk melakukan pembayaran", MsgBoxStyle.Information, "Pemberitahuan")
            Me.Close()
        Else

        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
