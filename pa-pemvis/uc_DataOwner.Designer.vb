<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_DataOwner
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtNoHP = New TextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        dgvOwner = New DataGridView()
        lblID = New Label()
        CType(dgvOwner, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F)
        Label1.Location = New Point(100, 125)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 38)
        Label1.TabIndex = 0
        Label1.Text = "Nama Owner"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.0F)
        Label2.Location = New Point(100, 250)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 38)
        Label2.TabIndex = 1
        Label2.Text = "No HP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.0F)
        Label3.Location = New Point(100, 375)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 38)
        Label3.TabIndex = 2
        Label3.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.0F)
        Label4.Location = New Point(100, 625)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 38)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 12.0F)
        txtNama.Location = New Point(400, 125)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(624, 39)
        txtNama.TabIndex = 4
        ' 
        ' txtNoHP
        ' 
        txtNoHP.Font = New Font("Segoe UI", 12.0F)
        txtNoHP.Location = New Point(400, 250)
        txtNoHP.Margin = New Padding(4, 5, 4, 5)
        txtNoHP.Name = "txtNoHP"
        txtNoHP.Size = New Size(624, 39)
        txtNoHP.TabIndex = 5
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Segoe UI", 12.0F)
        txtAlamat.Location = New Point(400, 375)
        txtAlamat.Margin = New Padding(4, 5, 4, 5)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(624, 185)
        txtAlamat.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12.0F)
        txtEmail.Location = New Point(400, 625)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(624, 39)
        txtEmail.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnTambah.Location = New Point(1250, 125)
        btnTambah.Margin = New Padding(4, 5, 4, 5)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(225, 94)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnEdit.Location = New Point(1250, 281)
        btnEdit.Margin = New Padding(4, 5, 4, 5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(225, 94)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnHapus.Location = New Point(1250, 438)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(225, 94)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' dgvOwner
        ' 
        dgvOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOwner.Location = New Point(100, 812)
        dgvOwner.Margin = New Padding(4, 5, 4, 5)
        dgvOwner.Name = "dgvOwner"
        dgvOwner.RowHeadersWidth = 51
        dgvOwner.RowTemplate.Height = 24
        dgvOwner.Size = New Size(2188, 859)
        dgvOwner.TabIndex = 11
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(1250, 625)
        lblID.Margin = New Padding(4, 0, 4, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(27, 25)
        lblID.TabIndex = 12
        lblID.Text = "id"
        lblID.Visible = False
        ' 
        ' uc_DataOwner
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(txtNama)
        Controls.Add(txtNoHP)
        Controls.Add(txtAlamat)
        Controls.Add(txtEmail)
        Controls.Add(btnTambah)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(dgvOwner)
        Controls.Add(lblID)
        Margin = New Padding(4, 5, 4, 5)
        Name = "uc_DataOwner"
        Size = New Size(2444, 1847)
        CType(dgvOwner, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

    Friend WithEvents dgvOwner As DataGridView

    Friend WithEvents lblID As Label

End Class