<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_DataStaff
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNamaLengkap = New TextBox()
        txtEmail = New TextBox()
        txtNoTelepon = New TextBox()
        cbShift = New ComboBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        dgvStaff = New DataGridView()
        lblID = New Label()
        CType(dgvStaff, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F)
        Label1.Location = New Point(80, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 38)
        Label1.TabIndex = 0
        Label1.Text = "Nama Lengkap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.0F)
        Label2.Location = New Point(80, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 38)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.0F)
        Label3.Location = New Point(80, 280)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 38)
        Label3.TabIndex = 2
        Label3.Text = "No Telepon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.0F)
        Label4.Location = New Point(80, 380)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 38)
        Label4.TabIndex = 3
        Label4.Text = "Shift"
        ' 
        ' txtNamaLengkap
        ' 
        txtNamaLengkap.Font = New Font("Segoe UI", 12.0F)
        txtNamaLengkap.Location = New Point(320, 80)
        txtNamaLengkap.Name = "txtNamaLengkap"
        txtNamaLengkap.Size = New Size(500, 39)
        txtNamaLengkap.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12.0F)
        txtEmail.Location = New Point(320, 180)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(500, 39)
        txtEmail.TabIndex = 5
        ' 
        ' txtNoTelepon
        ' 
        txtNoTelepon.Font = New Font("Segoe UI", 12.0F)
        txtNoTelepon.Location = New Point(320, 280)
        txtNoTelepon.Name = "txtNoTelepon"
        txtNoTelepon.Size = New Size(500, 39)
        txtNoTelepon.TabIndex = 6
        ' 
        ' cbShift
        ' 
        cbShift.Font = New Font("Segoe UI", 12.0F)
        cbShift.Items.AddRange(New Object() {"Pagi", "Siang", "Malam"})
        cbShift.Location = New Point(320, 380)
        cbShift.Name = "cbShift"
        cbShift.Size = New Size(500, 40)
        cbShift.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnTambah.Location = New Point(1000, 80)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(180, 60)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnEdit.Location = New Point(1000, 180)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(180, 60)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnHapus.Location = New Point(1000, 280)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(180, 60)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        ' 
        ' dgvStaff
        ' 
        dgvStaff.BackgroundColor = Color.AliceBlue
        dgvStaff.ColumnHeadersHeight = 34
        dgvStaff.Location = New Point(80, 550)
        dgvStaff.Name = "dgvStaff"
        dgvStaff.RowHeadersWidth = 62
        dgvStaff.Size = New Size(1750, 500)
        dgvStaff.TabIndex = 11
        ' 
        ' lblID
        ' 
        lblID.Location = New Point(0, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(100, 23)
        lblID.TabIndex = 12
        lblID.Visible = False
        ' 
        ' uc_DataStaff
        ' 
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(txtNamaLengkap)
        Controls.Add(txtEmail)
        Controls.Add(txtNoTelepon)
        Controls.Add(cbShift)
        Controls.Add(btnTambah)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(dgvStaff)
        Controls.Add(lblID)
        Name = "uc_DataStaff"
        Size = New Size(1955, 1182)
        CType(dgvStaff, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents txtNamaLengkap As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoTelepon As TextBox

    Friend WithEvents cbShift As ComboBox

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

    Friend WithEvents dgvStaff As DataGridView

    Friend WithEvents lblID As Label

End Class