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
        Me.components = New System.ComponentModel.Container()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.Location = New System.Drawing.Point(12, 50)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(760, 348)
        Me.dgv.TabIndex = 0
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        Me.txtSearch.Location = New System.Drawing.Point(72, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(420, 23)
        Me.txtSearch.TabIndex = 1

        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(12, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(54, 15)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Search :"

        Me.btnSearch.Location = New System.Drawing.Point(500, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True

        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(581, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 25)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True

        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(647, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(60, 25)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True

        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(713, 11)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 25)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True

        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Form1"
        Me.Text = "Sistem Peminjaman Baju Adat"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private dgv As System.Windows.Forms.DataGridView
    Private txtSearch As System.Windows.Forms.TextBox
    Private lblSearch As System.Windows.Forms.Label
    Private btnSearch As System.Windows.Forms.Button
    Private btnAdd As System.Windows.Forms.Button
    Private btnEdit As System.Windows.Forms.Button
    Private btnDelete As System.Windows.Forms.Button

End Class
