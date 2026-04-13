<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form2
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblBaju = New System.Windows.Forms.Label()
        Me.txtBaju = New System.Windows.Forms.TextBox()
        Me.lblPinjam = New System.Windows.Forms.Label()
        Me.dtpPinjam = New System.Windows.Forms.DateTimePicker()
        Me.lblKembali = New System.Windows.Forms.Label()
        Me.dtpKembali = New System.Windows.Forms.DateTimePicker()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.numJumlah = New System.Windows.Forms.NumericUpDown()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.numJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(12, 15)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(96, 15)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama Peminjam :"

        Me.txtNama.Location = New System.Drawing.Point(120, 12)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(250, 23)
        Me.txtNama.TabIndex = 1

        Me.lblBaju.AutoSize = True
        Me.lblBaju.Location = New System.Drawing.Point(12, 48)
        Me.lblBaju.Name = "lblBaju"
        Me.lblBaju.Size = New System.Drawing.Size(73, 15)
        Me.lblBaju.TabIndex = 2
        Me.lblBaju.Text = "Nama Baju :"

        Me.txtBaju.Location = New System.Drawing.Point(120, 45)
        Me.txtBaju.Name = "txtBaju"
        Me.txtBaju.Size = New System.Drawing.Size(250, 23)
        Me.txtBaju.TabIndex = 3

        Me.lblPinjam.AutoSize = True
        Me.lblPinjam.Location = New System.Drawing.Point(12, 82)
        Me.lblPinjam.Name = "lblPinjam"
        Me.lblPinjam.Size = New System.Drawing.Size(80, 15)
        Me.lblPinjam.TabIndex = 4
        Me.lblPinjam.Text = "Tanggal Pinjam :"

        Me.dtpPinjam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPinjam.Location = New System.Drawing.Point(120, 78)
        Me.dtpPinjam.Name = "dtpPinjam"
        Me.dtpPinjam.Size = New System.Drawing.Size(120, 23)
        Me.dtpPinjam.TabIndex = 5

        Me.lblKembali.AutoSize = True
        Me.lblKembali.Location = New System.Drawing.Point(12, 116)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(97, 15)
        Me.lblKembali.TabIndex = 6
        Me.lblKembali.Text = "Tanggal Kembali :"

        Me.dtpKembali.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpKembali.Location = New System.Drawing.Point(120, 112)
        Me.dtpKembali.Name = "dtpKembali"
        Me.dtpKembali.Size = New System.Drawing.Size(120, 23)
        Me.dtpKembali.TabIndex = 7

        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(12, 149)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(50, 15)
        Me.lblJumlah.TabIndex = 8
        Me.lblJumlah.Text = "Jumlah :"

        Me.numJumlah.Location = New System.Drawing.Point(120, 147)
        Me.numJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJumlah.Name = "numJumlah"
        Me.numJumlah.Size = New System.Drawing.Size(80, 23)
        Me.numJumlah.TabIndex = 9
        Me.numJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})

        Me.btnOK.Location = New System.Drawing.Point(120, 190)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 27)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True

        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(201, 190)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 27)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True

        Me.AcceptButton = Me.btnOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 235)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.numJumlah)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.dtpKembali)
        Me.Controls.Add(Me.lblKembali)
        Me.Controls.Add(Me.dtpPinjam)
        Me.Controls.Add(Me.lblPinjam)
        Me.Controls.Add(Me.txtBaju)
        Me.Controls.Add(Me.lblBaju)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblNama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detail Peminjaman"
        CType(Me.numJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private lblNama As System.Windows.Forms.Label
    Private txtNama As System.Windows.Forms.TextBox
    Private lblBaju As System.Windows.Forms.Label
    Private txtBaju As System.Windows.Forms.TextBox
    Private lblPinjam As System.Windows.Forms.Label
    Private dtpPinjam As System.Windows.Forms.DateTimePicker
    Private lblKembali As System.Windows.Forms.Label
    Private dtpKembali As System.Windows.Forms.DateTimePicker
    Private lblJumlah As System.Windows.Forms.Label
    Private numJumlah As System.Windows.Forms.NumericUpDown
    Private btnOK As System.Windows.Forms.Button
    Private btnCancel As System.Windows.Forms.Button
End Class
