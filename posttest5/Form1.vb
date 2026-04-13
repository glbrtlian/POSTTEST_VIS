Imports System.ComponentModel

Public Class Form1
    Private records As BindingList(Of Peminjaman)
    Private source As BindingSource
    Private nextId As Integer = 1

    Public Sub New()
        InitializeComponent()
        records = New BindingList(Of Peminjaman)()
        source = New BindingSource()
        source.DataSource = records
        dgv.DataSource = source

        AddHandler btnAdd.Click, AddressOf BtnAdd_Click
        AddHandler btnEdit.Click, AddressOf BtnEdit_Click
        AddHandler btnDelete.Click, AddressOf BtnDelete_Click
        AddHandler btnSearch.Click, AddressOf BtnSearch_Click
        AddHandler txtSearch.KeyDown, AddressOf TxtSearch_KeyDown
        AddHandler dgv.DoubleClick, AddressOf Dgv_DoubleClick

        ' sample data
        records.Add(New Peminjaman With {.Id = GetNextId(), .NamaPeminjam = "Andi", .NamaBaju = "Baju Jawa", .TanggalPinjam = Date.Today, .TanggalKembali = Date.Today.AddDays(3), .Jumlah = 1})
        records.Add(New Peminjaman With {.Id = GetNextId(), .NamaPeminjam = "Siti", .NamaBaju = "Baju Bali", .TanggalPinjam = Date.Today, .TanggalKembali = Date.Today.AddDays(1), .Jumlah = 2})
    End Sub

    Private Function GetNextId() As Integer
        Dim id = nextId
        nextId += 1
        Return id
    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs)
        Dim f As New Form2()
        Dim p As New Peminjaman()
        f.Record = p
        If f.ShowDialog() = DialogResult.OK Then
            p.Id = GetNextId()
            records.Add(p)
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs)
        EditSelected()
    End Sub

    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs)
        EditSelected()
    End Sub

    Private Sub EditSelected()
        If dgv.CurrentRow Is Nothing Then Return
        Dim selected = TryCast(dgv.CurrentRow.DataBoundItem, Peminjaman)
        If selected Is Nothing Then Return


        Dim copy As New Peminjaman With {
            .Id = selected.Id,
            .NamaPeminjam = selected.NamaPeminjam,
            .NamaBaju = selected.NamaBaju,
            .TanggalPinjam = selected.TanggalPinjam,
            .TanggalKembali = selected.TanggalKembali,
            .Jumlah = selected.Jumlah
        }

        Dim f As New Form2()
        f.Record = copy
        If f.ShowDialog() = DialogResult.OK Then

            selected.NamaPeminjam = copy.NamaPeminjam
            selected.NamaBaju = copy.NamaBaju
            selected.TanggalPinjam = copy.TanggalPinjam
            selected.TanggalKembali = copy.TanggalKembali
            selected.Jumlah = copy.Jumlah
            source.ResetBindings(False)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs)
        If dgv.CurrentRow Is Nothing Then Return
        Dim selected = TryCast(dgv.CurrentRow.DataBoundItem, Peminjaman)
        If selected Is Nothing Then Return
        If MessageBox.Show($"Hapus record '{selected.NamaPeminjam}' ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            records.Remove(selected)
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs)
        ApplySearch()
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ApplySearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ApplySearch()
        Dim q = txtSearch.Text.Trim().ToLower()
        If String.IsNullOrEmpty(q) Then
            source.DataSource = records
        Else
            Dim filtered = records.Where(Function(r) r.NamaPeminjam?.ToLower().Contains(q) OrElse r.NamaBaju?.ToLower().Contains(q)).ToList()
            source.DataSource = New BindingList(Of Peminjaman)(filtered)
        End If
        dgv.DataSource = source
    End Sub

End Class
