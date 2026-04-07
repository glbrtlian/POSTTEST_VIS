Imports System.IO
Public Class Form1
    Private profilePath As String = String.Empty

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' populate communities
        cmbCommunity.Items.AddRange(New String() {"Fotografi", "Programming", "Karang Taruna", "Paskibra", "Music", "Olahraga"})
        cmbCommunity.SelectedIndex = 0
        cmbFrequency.SelectedIndex = 0

        ' wire menu events
        AddHandler mnuInput.Click, AddressOf mnuInput_Click
        AddHandler mnuLihat.Click, AddressOf mnuLihat_Click
        AddHandler mnuSimpan.Click, AddressOf mnuSimpan_Click
        AddHandler mnuBuka.Click, AddressOf mnuBuka_Click
        AddHandler mnuKeluar.Click, AddressOf mnuKeluar_Click

        ' other handlers
        AddHandler btnBrowsePhoto.Click, AddressOf btnBrowsePhoto_Click
        AddHandler btnSavePrint.Click, AddressOf btnSavePrint_Click

        ' input restrictions
        AddHandler txtName.KeyPress, AddressOf txtName_KeyPress
        AddHandler txtAge.KeyPress, AddressOf txtAge_KeyPress

        ' mask guidance
        mtbPhone.Text = "+62 "
    End Sub

    Private Sub mnuInput_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub mnuLihat_Click(sender As Object, e As EventArgs)
        If Not ValidateInputs(False) Then Return
        Dim card As New FormCard()
        card.LoadData(GetDataDictionary())
        card.StartPosition = FormStartPosition.CenterParent
        card.ShowDialog(Me)
    End Sub

    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs)
        SaveDataToFile()
    End Sub

    Private Sub mnuBuka_Click(sender As Object, e As EventArgs)
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            Try
                Dim lines = File.ReadAllLines(OpenFileDialog1.FileName)
                If lines.Length > 0 Then
                    Dim parts = lines(0).Split("|"c)
                    ' simple mapping: name|id|dob|gender|age|community|phone|email|address|photo|hobbies
                    txtName.Text = parts(0)
                    txtID.Text = parts(1)
                    dtpDOB.Value = Date.Parse(parts(2))
                    If parts(3) = "L" Then rbMale.Checked = True Else rbFemale.Checked = True
                    txtAge.Text = parts(4)
                    cmbCommunity.SelectedItem = parts(5)
                    mtbPhone.Text = parts(6)
                    txtEmail.Text = parts(7)
                    txtAddress.Text = parts(8)
                    profilePath = parts(9)
                    If File.Exists(profilePath) Then
                        pbProfile.Image = System.Drawing.Image.FromFile(profilePath)
                    End If
                    ' new mapping: parts(10)=frequency, parts(11)=times(comma separated)
                    If parts.Length > 10 Then
                        cmbFrequency.SelectedItem = parts(10)
                    End If
                    If parts.Length > 11 Then
                        Dim times = parts(11).Split(","c)
                        For Each t In times
                            Select Case t.Trim().ToLower()
                                Case "pagi" : chkPagi.Checked = True
                                Case "siang" : chkSiang.Checked = True
                                Case "sore" : chkSore.Checked = True
                                Case "malam" : chkMalam.Checked = True
                            End Select
                        Next
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(Me, "Gagal membuka file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs)
        If MessageBox.Show(Me, "Keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBrowsePhoto_Click(sender As Object, e As EventArgs)
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            profilePath = OpenFileDialog1.FileName
            Try
                pbProfile.Image = System.Drawing.Image.FromFile(profilePath)
            Catch ex As Exception
                MessageBox.Show(Me, "Gagal memuat gambar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs)
        If Not ValidateInputs(True) Then Return
        If MessageBox.Show(Me, "Cetak kartu sekarang?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim card As New FormCard()
            card.LoadData(GetDataDictionary())
            card.StartPosition = FormStartPosition.Manual
            card.Location = New Point(Me.Left + 20, Me.Top + 60)
            card.ShowDialog(Me)
        End If
        SaveDataToFile()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidateInputs(showMessage As Boolean) As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong: Nama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong: ID Anggota", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtAge.Text) Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong: Umur", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Not rbMale.Checked AndAlso Not rbFemale.Checked Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong: Jenis Kelamin", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cmbCommunity.SelectedItem Is Nothing Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong: Komunitas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Not mtbPhone.MaskCompleted Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong / format salah: Nomor Telepon", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong: Email", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong: Alamat", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        ' at least one time selected
        If Not (chkPagi.Checked Or chkSiang.Checked Or chkSore.Checked Or chkMalam.Checked) Then
            If showMessage Then MessageBox.Show(Me, "Inputan tidak boleh kosong: Pilih minimal satu waktu kegiatan (Pagi/Siang/Sore/Malam)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Function GetDataDictionary() As Dictionary(Of String, String)
        Dim data As New Dictionary(Of String, String)()
        data("Nama") = txtName.Text.Trim()
        data("ID") = txtID.Text.Trim()
        data("DOB") = dtpDOB.Value.ToShortDateString()
        data("Gender") = If(rbMale.Checked, "L", "P")
        data("Age") = txtAge.Text.Trim()
        data("Community") = cmbCommunity.SelectedItem.ToString()
        data("Phone") = mtbPhone.Text
        data("Email") = txtEmail.Text.Trim()
        data("Address") = txtAddress.Text.Trim()
        data("Photo") = profilePath
        data("Frequency") = If(cmbFrequency.SelectedItem IsNot Nothing, cmbFrequency.SelectedItem.ToString(), String.Empty)
        Dim times As New System.Text.StringBuilder()
        If chkPagi.Checked Then times.Append("Pagi")
        If chkSiang.Checked Then If times.Length > 0 Then times.Append(",") : times.Append("Siang") Else times.Append("Siang")
        If chkSore.Checked Then If times.Length > 0 Then times.Append(",") : times.Append("Sore") Else times.Append("Sore")
        If chkMalam.Checked Then If times.Length > 0 Then times.Append(",") : times.Append("Malam") Else times.Append("Malam")
        data("Times") = times.ToString()
        Return data
    End Function

    Private Sub SaveDataToFile()
        If Not ValidateInputs(True) Then Return
        If SaveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            Try
                Dim d = GetDataDictionary()
                ' new format: name|id|dob|gender|age|community|phone|email|address|photo|frequency|times
                Dim line = String.Join("|", New String() {d("Nama"), d("ID"), d("DOB"), d("Gender"), d("Age"), d("Community"), d("Phone"), d("Email"), d("Address"), d("Photo"), d("Frequency"), d("Times")})
                File.WriteAllText(SaveFileDialog1.FileName, line)
                MessageBox.Show(Me, "Data berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(Me, "Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Empty handlers removed because controls are wired with AddHandler in Form1_Load
End Class
