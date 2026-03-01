Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Private txtPredikat As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double

        If Double.TryParse(txtIPSemester.Text, ipSemester) Then

            totalIP = totalIP + ipSemester
            jumlahSemester = jumlahSemester + 1

            txtIPKumulatif.Text = totalIP.ToString("0.00")

            Dim rataIP As Double = totalIP / jumlahSemester

            If rataIP >= 2.0 And rataIP <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf rataIP >= 2.76 And rataIP <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf rataIP > 3.0 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

            txtIPSemester.Text = ""

        Else
            MessageBox.Show("IP Semester harus berupa angka!", "Peringatan")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0

        txtIPSemester.Text = ""
        txtIPKumulatif.Text = ""
        lblPredikat.Text = ""
    End Sub

End Class

