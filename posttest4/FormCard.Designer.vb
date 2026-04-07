<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBoxCard = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCommunity = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblHobbies = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.PictureBoxCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxCard
        '
        Me.PictureBoxCard.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxCard.Name = "PictureBoxCard"
        Me.PictureBoxCard.Size = New System.Drawing.Size(120, 160)
        Me.PictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCard.TabIndex = 0
        Me.PictureBoxCard.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = False
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(140, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(280, 26)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Nama"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblID
        '
        Me.lblID.AutoSize = False
        Me.lblID.Location = New System.Drawing.Point(140, 60)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(280, 18)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCommunity
        '
        Me.lblCommunity.AutoSize = False
        Me.lblCommunity.Location = New System.Drawing.Point(140, 85)
        Me.lblCommunity.Name = "lblCommunity"
        Me.lblCommunity.Size = New System.Drawing.Size(280, 18)
        Me.lblCommunity.TabIndex = 3
        Me.lblCommunity.Text = "Komunitas"
        Me.lblCommunity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContact
        '
        Me.lblContact.AutoSize = False
        Me.lblContact.Location = New System.Drawing.Point(140, 110)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(280, 18)
        Me.lblContact.TabIndex = 4
        Me.lblContact.Text = "Kontak"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHobbies
        '
        Me.lblHobbies.AutoSize = False
        Me.lblHobbies.Location = New System.Drawing.Point(140, 135)
        Me.lblHobbies.Name = "lblHobbies"
        Me.lblHobbies.Size = New System.Drawing.Size(280, 40)
        Me.lblHobbies.TabIndex = 5
        Me.lblHobbies.Text = "Hobi/Aktivitas"
        Me.lblHobbies.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(230, 170)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 30)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Cetak"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'FormCard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 220)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblHobbies)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblCommunity)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBoxCard)
        Me.Name = "FormCard"
        Me.Text = "Kartu Komunitas"
        CType(Me.PictureBoxCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private PictureBoxCard As System.Windows.Forms.PictureBox
    Private lblName As System.Windows.Forms.Label
    Private lblID As System.Windows.Forms.Label
    Private lblCommunity As System.Windows.Forms.Label
    Private lblContact As System.Windows.Forms.Label
    Private lblHobbies As System.Windows.Forms.Label
    Private btnPrint As System.Windows.Forms.Button
End Class
