<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        mnuInput = New ToolStripMenuItem()
        mnuLihat = New ToolStripMenuItem()
        mnuSimpan = New ToolStripMenuItem()
        mnuBuka = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        LabelTitle = New Label()
        PictureBoxLogo = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        txtAge = New TextBox()
        LabelAge = New Label()
        cmbCommunity = New ComboBox()
        LabelCommunity = New Label()
        rbFemale = New RadioButton()
        rbMale = New RadioButton()
        dtpDOB = New DateTimePicker()
        LabelDOB = New Label()
        txtID = New TextBox()
        LabelID = New Label()
        txtName = New TextBox()
        LabelName = New Label()
        TabPage2 = New TabPage()
        txtAddress = New TextBox()
        LabelAddress = New Label()
        txtEmail = New TextBox()
        LabelEmail = New Label()
        mtbPhone = New MaskedTextBox()
        LabelPhone = New Label()
        TabPage3 = New TabPage()
        pbProfile = New PictureBox()
        btnBrowsePhoto = New Button()
        grpRoles = New GroupBox()
        LabelFrequency = New Label()
        cmbFrequency = New ComboBox()
        LabelTimes = New Label()
        chkPagi = New CheckBox()
        chkSiang = New CheckBox()
        chkSore = New CheckBox()
        chkMalam = New CheckBox()
        LabelRoles = New Label()
        btnSavePrint = New Button()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        grpRoles.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuInput, mnuLihat, mnuSimpan, mnuBuka, mnuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(980, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "menuStrip1"
        ' 
        ' mnuInput
        ' 
        mnuInput.Name = "mnuInput"
        mnuInput.Size = New Size(93, 24)
        mnuInput.Text = "Input Data"
        ' 
        ' mnuLihat
        ' 
        mnuLihat.Name = "mnuLihat"
        mnuLihat.Size = New Size(94, 24)
        mnuLihat.Text = "Lihat Kartu"
        ' 
        ' mnuSimpan
        ' 
        mnuSimpan.Name = "mnuSimpan"
        mnuSimpan.Size = New Size(109, 24)
        mnuSimpan.Text = "Simpan Data"
        ' 
        ' mnuBuka
        ' 
        mnuBuka.Name = "mnuBuka"
        mnuBuka.Size = New Size(91, 24)
        mnuBuka.Text = "Buka Data"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(65, 24)
        mnuKeluar.Text = "Keluar"
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LabelTitle.Location = New Point(140, 40)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(441, 32)
        LabelTitle.TabIndex = 1
        LabelTitle.Text = "Aplikasi Pembuatan Kartu Komunitas"
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BorderStyle = BorderStyle.FixedSingle
        PictureBoxLogo.Location = New Point(12, 36)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(80, 80)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 2
        PictureBoxLogo.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 120)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(840, 320)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(txtAge)
        TabPage1.Controls.Add(LabelAge)
        TabPage1.Controls.Add(cmbCommunity)
        TabPage1.Controls.Add(LabelCommunity)
        TabPage1.Controls.Add(rbFemale)
        TabPage1.Controls.Add(rbMale)
        TabPage1.Controls.Add(dtpDOB)
        TabPage1.Controls.Add(LabelDOB)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(LabelID)
        TabPage1.Controls.Add(txtName)
        TabPage1.Controls.Add(LabelName)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(832, 291)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(120, 120)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(200, 27)
        txtAge.TabIndex = 11
        ' 
        ' LabelAge
        ' 
        LabelAge.AutoSize = True
        LabelAge.Location = New Point(20, 123)
        LabelAge.Name = "LabelAge"
        LabelAge.Size = New Size(45, 20)
        LabelAge.TabIndex = 10
        LabelAge.Text = "Umur"
        ' 
        ' cmbCommunity
        ' 
        cmbCommunity.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCommunity.FormattingEnabled = True
        cmbCommunity.Location = New Point(120, 160)
        cmbCommunity.Name = "cmbCommunity"
        cmbCommunity.Size = New Size(200, 28)
        cmbCommunity.TabIndex = 9
        ' 
        ' LabelCommunity
        ' 
        LabelCommunity.AutoSize = True
        LabelCommunity.Location = New Point(20, 163)
        LabelCommunity.Name = "LabelCommunity"
        LabelCommunity.Size = New Size(79, 20)
        LabelCommunity.TabIndex = 8
        LabelCommunity.Text = "Komunitas"
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(200, 80)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(104, 24)
        rbFemale.TabIndex = 7
        rbFemale.TabStop = True
        rbFemale.Text = "Perempuan"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(120, 80)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(85, 24)
        rbMale.TabIndex = 6
        rbMale.TabStop = True
        rbMale.Text = "Laki-laki"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' dtpDOB
        ' 
        dtpDOB.Format = DateTimePickerFormat.Short
        dtpDOB.Location = New Point(120, 48)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(200, 27)
        dtpDOB.TabIndex = 5
        ' 
        ' LabelDOB
        ' 
        LabelDOB.AutoSize = True
        LabelDOB.Location = New Point(20, 54)
        LabelDOB.Name = "LabelDOB"
        LabelDOB.Size = New Size(97, 20)
        LabelDOB.TabIndex = 4
        LabelDOB.Text = "Tanggal Lahir"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(120, 188)
        txtID.Name = "txtID"
        txtID.Size = New Size(200, 27)
        txtID.TabIndex = 3
        ' 
        ' LabelID
        ' 
        LabelID.AutoSize = True
        LabelID.Location = New Point(20, 191)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(86, 20)
        LabelID.TabIndex = 2
        LabelID.Text = "ID Anggota"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(120, 12)
        txtName.Name = "txtName"
        txtName.Size = New Size(400, 27)
        txtName.TabIndex = 1
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(20, 15)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(49, 20)
        LabelName.TabIndex = 0
        LabelName.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(txtAddress)
        TabPage2.Controls.Add(LabelAddress)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(LabelEmail)
        TabPage2.Controls.Add(mtbPhone)
        TabPage2.Controls.Add(LabelPhone)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(832, 291)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(120, 80)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(400, 120)
        txtAddress.TabIndex = 5
        ' 
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.Location = New Point(6, 80)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(57, 20)
        LabelAddress.TabIndex = 4
        LabelAddress.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(120, 44)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(300, 27)
        txtEmail.TabIndex = 3
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(6, 47)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(46, 20)
        LabelEmail.TabIndex = 2
        LabelEmail.Text = "Email"
        ' 
        ' mtbPhone
        ' 
        mtbPhone.Location = New Point(120, 12)
        mtbPhone.Mask = "+62 000-0000-000"
        mtbPhone.Name = "mtbPhone"
        mtbPhone.Size = New Size(200, 27)
        mtbPhone.TabIndex = 1
        ' 
        ' LabelPhone
        ' 
        LabelPhone.AutoSize = True
        LabelPhone.Location = New Point(6, 15)
        LabelPhone.Name = "LabelPhone"
        LabelPhone.Size = New Size(113, 20)
        LabelPhone.TabIndex = 0
        LabelPhone.Text = "Nomor Telepon"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(pbProfile)
        TabPage3.Controls.Add(btnBrowsePhoto)
        TabPage3.Controls.Add(grpRoles)
        TabPage3.Controls.Add(LabelRoles)
        TabPage3.Controls.Add(btnSavePrint)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(832, 291)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' pbProfile
        ' 
        pbProfile.BorderStyle = BorderStyle.FixedSingle
        pbProfile.Location = New Point(520, 12)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(200, 200)
        pbProfile.SizeMode = PictureBoxSizeMode.Zoom
        pbProfile.TabIndex = 6
        pbProfile.TabStop = False
        ' 
        ' btnBrowsePhoto
        ' 
        btnBrowsePhoto.Location = New Point(520, 220)
        btnBrowsePhoto.Name = "btnBrowsePhoto"
        btnBrowsePhoto.Size = New Size(240, 30)
        btnBrowsePhoto.TabIndex = 5
        btnBrowsePhoto.Text = "Browse Foto"
        btnBrowsePhoto.UseVisualStyleBackColor = True
        ' 
        ' grpRoles
        ' 
        grpRoles.Controls.Add(LabelFrequency)
        grpRoles.Controls.Add(cmbFrequency)
        grpRoles.Controls.Add(LabelTimes)
        grpRoles.Controls.Add(chkPagi)
        grpRoles.Controls.Add(chkSiang)
        grpRoles.Controls.Add(chkSore)
        grpRoles.Controls.Add(chkMalam)
        grpRoles.Location = New Point(20, 12)
        grpRoles.Name = "grpRoles"
        grpRoles.Size = New Size(480, 200)
        grpRoles.TabIndex = 4
        grpRoles.TabStop = False
        grpRoles.Text = "Peran & Hobi"
        ' 
        ' LabelFrequency
        '
        LabelFrequency.AutoSize = True
        LabelFrequency.Location = New Point(20, 30)
        LabelFrequency.Name = "LabelFrequency"
        LabelFrequency.Size = New Size(74, 24)
        LabelFrequency.TabIndex = 0
        LabelFrequency.Text = "Frekuensi"
        ' 
        ' cmbFrequency
        ' 
        cmbFrequency.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFrequency.FormattingEnabled = True
        cmbFrequency.Items.AddRange(New Object() {"Sering", "Jarang"})
        cmbFrequency.Location = New Point(120, 28)
        cmbFrequency.Name = "cmbFrequency"
        cmbFrequency.Size = New Size(160, 28)
        cmbFrequency.TabIndex = 1
        '
        ' LabelTimes
        '
        LabelTimes.AutoSize = True
        LabelTimes.Location = New Point(20, 70)
        LabelTimes.Name = "LabelTimes"
        LabelTimes.Size = New Size(110, 24)
        LabelTimes.TabIndex = 2
        LabelTimes.Text = "Waktu Kegiatan"
        '
        ' chkPagi
        '
        chkPagi.AutoSize = True
        chkPagi.Location = New Point(20, 100)
        chkPagi.Name = "chkPagi"
        chkPagi.Size = New Size(64, 24)
        chkPagi.TabIndex = 3
        chkPagi.Text = "Pagi"
        chkPagi.UseVisualStyleBackColor = True
        '
        ' chkSiang
        '
        chkSiang.AutoSize = True
        chkSiang.Location = New Point(120, 100)
        chkSiang.Name = "chkSiang"
        chkSiang.Size = New Size(68, 24)
        chkSiang.TabIndex = 4
        chkSiang.Text = "Siang"
        chkSiang.UseVisualStyleBackColor = True
        '
        ' chkSore
        '
        chkSore.AutoSize = True
        chkSore.Location = New Point(220, 100)
        chkSore.Name = "chkSore"
        chkSore.Size = New Size(62, 24)
        chkSore.TabIndex = 5
        chkSore.Text = "Sore"
        chkSore.UseVisualStyleBackColor = True
        '
        ' chkMalam
        '
        chkMalam.AutoSize = True
        chkMalam.Location = New Point(320, 100)
        chkMalam.Name = "chkMalam"
        chkMalam.Size = New Size(72, 24)
        chkMalam.TabIndex = 6
        chkMalam.Text = "Malam"
        chkMalam.UseVisualStyleBackColor = True
        ' 
        ' LabelRoles
        ' 
        LabelRoles.AutoSize = True
        LabelRoles.Location = New Point(20, 230)
        LabelRoles.Name = "LabelRoles"
        LabelRoles.Size = New Size(0, 20)
        LabelRoles.TabIndex = 2
        ' 
        ' btnSavePrint
        ' 
        btnSavePrint.Location = New Point(520, 260)
        btnSavePrint.Name = "btnSavePrint"
        btnSavePrint.Size = New Size(240, 30)
        btnSavePrint.TabIndex = 0
        btnSavePrint.Text = "Simpan & Cetak Kartu"
        btnSavePrint.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(980, 520)
        Controls.Add(TabControl1)
        Controls.Add(PictureBoxLogo)
        Controls.Add(LabelTitle)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Aplikasi Kartu Komunitas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        grpRoles.ResumeLayout(False)
        grpRoles.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private MenuStrip1 As System.Windows.Forms.MenuStrip
    Private mnuInput As System.Windows.Forms.ToolStripMenuItem
    Private mnuLihat As System.Windows.Forms.ToolStripMenuItem
    Private mnuSimpan As System.Windows.Forms.ToolStripMenuItem
    Private mnuBuka As System.Windows.Forms.ToolStripMenuItem
    Private mnuKeluar As System.Windows.Forms.ToolStripMenuItem
    Private LabelTitle As System.Windows.Forms.Label
    Private PictureBoxLogo As System.Windows.Forms.PictureBox
    Private TabControl1 As System.Windows.Forms.TabControl
    Private TabPage1 As System.Windows.Forms.TabPage
    Private TabPage2 As System.Windows.Forms.TabPage
    Private TabPage3 As System.Windows.Forms.TabPage
    Private txtName As System.Windows.Forms.TextBox
    Private LabelName As System.Windows.Forms.Label
    Private txtID As System.Windows.Forms.TextBox
    Private LabelID As System.Windows.Forms.Label
    Private dtpDOB As System.Windows.Forms.DateTimePicker
    Private LabelDOB As System.Windows.Forms.Label
    Private rbFemale As System.Windows.Forms.RadioButton
    Private rbMale As System.Windows.Forms.RadioButton
    Private cmbCommunity As System.Windows.Forms.ComboBox
    Private LabelCommunity As System.Windows.Forms.Label
    Private txtAge As System.Windows.Forms.TextBox
    Private LabelAge As System.Windows.Forms.Label
    Private mtbPhone As System.Windows.Forms.MaskedTextBox
    Private LabelPhone As System.Windows.Forms.Label
    Private txtEmail As System.Windows.Forms.TextBox
    Private LabelEmail As System.Windows.Forms.Label
    Private txtAddress As System.Windows.Forms.TextBox
    Private LabelAddress As System.Windows.Forms.Label
    Private pbProfile As System.Windows.Forms.PictureBox
    Private btnBrowsePhoto As System.Windows.Forms.Button
    Private grpRoles As System.Windows.Forms.GroupBox
    Private LabelFrequency As System.Windows.Forms.Label
    Private cmbFrequency As System.Windows.Forms.ComboBox
    Private LabelTimes As System.Windows.Forms.Label
    Private chkPagi As System.Windows.Forms.CheckBox
    Private chkSiang As System.Windows.Forms.CheckBox
    Private chkSore As System.Windows.Forms.CheckBox
    Private chkMalam As System.Windows.Forms.CheckBox
    Private LabelRoles As System.Windows.Forms.Label
    Private btnSavePrint As System.Windows.Forms.Button
    Private SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
