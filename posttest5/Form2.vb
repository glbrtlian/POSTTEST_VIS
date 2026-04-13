Partial Public Class Form2
    Private _record As Peminjaman

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    <System.ComponentModel.Browsable(False)>
    Public Property Record As Peminjaman
        Get
            Return _record
        End Get
        Set(value As Peminjaman)
            _record = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        AddHandler Me.Load, AddressOf Form2_Load
        AddHandler btnOK.Click, AddressOf BtnOK_Click
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)
        If _record IsNot Nothing Then
            txtNama.Text = _record.NamaPeminjam
            txtBaju.Text = _record.NamaBaju
            If _record.TanggalPinjam = Nothing Then
                dtpPinjam.Value = Date.Today
            Else
                dtpPinjam.Value = _record.TanggalPinjam
            End If
            If _record.TanggalKembali = Nothing Then
                dtpKembali.Value = Date.Today.AddDays(1)
            Else
                dtpKembali.Value = _record.TanggalKembali
            End If
            numJumlah.Value = If(_record.Jumlah <= 0, 1, _record.Jumlah)
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs)
        If _record Is Nothing Then
            _record = New Peminjaman()
        End If

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama peminjam harus diisi", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtBaju.Text) Then
            MessageBox.Show("Nama baju harus diisi", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dtpKembali.Value < dtpPinjam.Value Then
            MessageBox.Show("Tanggal kembali tidak boleh sebelum tanggal pinjam", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        _record.NamaPeminjam = txtNama.Text.Trim()
        _record.NamaBaju = txtBaju.Text.Trim()
        _record.TanggalPinjam = dtpPinjam.Value.Date
        _record.TanggalKembali = dtpKembali.Value.Date
        _record.Jumlah = CInt(numJumlah.Value)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
