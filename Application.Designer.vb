
Public Class Form1

        Sub LoadData()
            dgvData.DataSource = GetAllPeminjaman()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        'SEARCH
        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            dgvData.DataSource = SearchData(txtSearch.Text)
        End Sub

        'ADD
        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            Form2.mode = "ADD"
            Form2.ShowDialog()
            LoadData()
        End Sub

        'EDIT
        Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
            If dgvData.CurrentRow Is Nothing Then Exit Sub

            Form2.mode = "EDIT"
            Form2.idEdit = dgvData.CurrentRow.Cells("id").Value
            Form2.ShowDialog()
            LoadData()
        End Sub

        'DELETE
        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If dgvData.CurrentRow Is Nothing Then Exit Sub

            Dim id As Integer = dgvData.CurrentRow.Cells("id").Value

            If MessageBox.Show("Hapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                DeleteData(id)
                LoadData()
            End If
        End Sub

    End Class

