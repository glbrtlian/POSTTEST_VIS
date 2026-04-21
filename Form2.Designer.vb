Imports MySqlConnector

Module DataModule

    Public Function GetAllBaju() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tb_baju"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal tampil data baju: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function GetAllPeminjaman() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT tb_peminjaman.id, tb_peminjaman.namaPeminjam, " &
                "tb_baju.namaBaju, tb_peminjaman.tanggalPinjam, " &
                "tb_peminjaman.tanggalKembali, tb_peminjaman.jumlah " &
                "FROM tb_peminjaman " &
                "INNER JOIN tb_baju ON tb_peminjaman.kodeBaju = tb_baju.kodeBaju " &
                "ORDER BY id ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal tampil data: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function SearchData(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT tb_peminjaman.id, tb_peminjaman.namaPeminjam, tb_baju.namaBaju " &
                "FROM tb_peminjaman " &
                "INNER JOIN tb_baju ON tb_peminjaman.kodeBaju = tb_baju.kodeBaju " &
                "WHERE namaPeminjam LIKE @key"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal search: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Sub SimpanPeminjaman(nama As String, kode As String,
                                tglPinjam As Date, tglKembali As Date, jumlah As Integer)

        Try
            Dim query As String =
                "INSERT INTO tb_peminjaman(namaPeminjam,kodeBaju,tanggalPinjam,tanggalKembali,jumlah) " &
                "VALUES(@nama,@kode,@pinjam,@kembali,@jumlah)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@pinjam", tglPinjam)
                    cmd.Parameters.AddWithValue("@kembali", tglKembali)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
        End Try

    End Sub

    Public Function GetById(id As Integer) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tb_peminjaman WHERE id=@id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal ambil data: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Sub UpdateData(id As Integer, nama As String, kode As String,
                          tglPinjam As Date, tglKembali As Date, jumlah As Integer)

        Try
            Dim query As String =
                "UPDATE tb_peminjaman SET " &
                "namaPeminjam=@nama, " &
                "kodeBaju=@kode, " &
                "tanggalPinjam=@pinjam, " &
                "tanggalKembali=@kembali, " &
                "jumlah=@jumlah " &
                "WHERE id=@id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@pinjam", tglPinjam)
                    cmd.Parameters.AddWithValue("@kembali", tglKembali)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message)
        End Try

    End Sub
    Public Sub DeleteData(id As Integer)

        Try
            Dim query As String = "DELETE FROM tb_peminjaman WHERE id=@id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
        End Try

    End Sub

End Module