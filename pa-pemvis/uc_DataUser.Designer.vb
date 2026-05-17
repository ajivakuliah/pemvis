<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_DataUser
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cbRole = New ComboBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        dgvUser = New DataGridView()
        lblID = New Label()
        CType(dgvUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F)
        Label1.Location = New Point(80, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 38)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.0F)
        Label2.Location = New Point(80, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 38)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.0F)
        Label3.Location = New Point(80, 280)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 38)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.0F)
        Label4.Location = New Point(80, 380)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 38)
        Label4.TabIndex = 3
        Label4.Text = "Role"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 12.0F)
        txtNama.Location = New Point(320, 80)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(500, 39)
        txtNama.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12.0F)
        txtUsername.Location = New Point(320, 180)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(500, 39)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12.0F)
        txtPassword.Location = New Point(320, 280)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(500, 39)
        txtPassword.TabIndex = 6
        ' 
        ' cbRole
        ' 
        cbRole.Font = New Font("Segoe UI", 12.0F)
        cbRole.Items.AddRange(New Object() {"admin", "staff"})
        cbRole.Location = New Point(320, 380)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(500, 40)
        cbRole.TabIndex = 7
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
        ' dgvUser
        ' 
        dgvUser.ColumnHeadersHeight = 34
        dgvUser.Location = New Point(80, 550)
        dgvUser.Name = "dgvUser"
        dgvUser.RowHeadersWidth = 62
        dgvUser.Size = New Size(1750, 500)
        dgvUser.TabIndex = 11
        ' 
        ' lblID
        ' 
        lblID.Location = New Point(0, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(100, 23)
        lblID.TabIndex = 12
        lblID.Visible = False
        ' 
        ' uc_DataUser
        ' 
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(txtNama)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        Controls.Add(cbRole)
        Controls.Add(btnTambah)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(dgvUser)
        Controls.Add(lblID)
        Name = "uc_DataUser"
        Size = New Size(1955, 1182)
        CType(dgvUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox

    Friend WithEvents cbRole As ComboBox

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

    Friend WithEvents dgvUser As DataGridView

    Friend WithEvents lblID As Label

End Class