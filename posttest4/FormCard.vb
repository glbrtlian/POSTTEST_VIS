Public Class FormCard
    Public Sub New()
        InitializeComponent()
        AddHandler btnPrint.Click, AddressOf btnPrint_Click
    End Sub

    Public Sub LoadData(data As Dictionary(Of String, String))
        lblName.Text = data("Nama")
        lblID.Text = "ID: " & data("ID")
        lblCommunity.Text = "Komunitas: " & data("Community")
        lblContact.Text = "Kontak: " & data("Phone") & " / " & data("Email")
        ' show frequency and times
        Dim freq As String = If(data.ContainsKey("Frequency"), data("Frequency"), String.Empty)
        Dim times As String = If(data.ContainsKey("Times"), data("Times"), String.Empty)
        Dim info As New System.Text.StringBuilder()
        If Not String.IsNullOrWhiteSpace(freq) Then
            info.Append("Frekuensi: " & freq)
        End If
        If Not String.IsNullOrWhiteSpace(times) Then
            If info.Length > 0 Then info.Append(" | ")
            info.Append("Waktu: " & times)
        End If
        lblHobbies.Text = info.ToString()
        If Not String.IsNullOrWhiteSpace(data("Photo")) Then
            Try
                If System.IO.File.Exists(data("Photo")) Then
                    PictureBoxCard.Image = System.Drawing.Image.FromFile(data("Photo"))
                End If
            Catch ex As Exception
                ' ignore
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Cetak kartu ke printer?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("Proses cetak (simulasi) selesai.")
        End If
    End Sub
End Class
