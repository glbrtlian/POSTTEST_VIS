Public Class Peminjaman
    Public Property Id As Integer
    Public Property NamaPeminjam As String
    Public Property NamaBaju As String
    Public Property TanggalPinjam As Date
    Public Property TanggalKembali As Date
    Public Property Jumlah As Integer

    Public Overrides Function ToString() As String
        Return $"{NamaPeminjam} - {NamaBaju}"
    End Function
End Class
