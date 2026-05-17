<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_DataHewan
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        cbOwner = New ComboBox()
        txtNama = New TextBox()
        cbJenis = New ComboBox()
        txtRas = New TextBox()
        cbJK = New ComboBox()
        txtUmur = New TextBox()
        txtWarna = New TextBox()
        txtBerat = New TextBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        dgvHewan = New DataGridView()
        lblID = New Label()
        CType(dgvHewan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.Location = New Point(80, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 33)
        Label1.TabIndex = 0
        Label1.Text = "Owner"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12.0F)
        Label2.Location = New Point(80, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 31)
        Label2.TabIndex = 1
        Label2.Text = "Nama Hewan"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12.0F)
        Label3.Location = New Point(80, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 33)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Hewan"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12.0F)
        Label4.Location = New Point(80, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 31)
        Label4.TabIndex = 3
        Label4.Text = "Ras"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 12.0F)
        Label5.Location = New Point(80, 330)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 33)
        Label5.TabIndex = 4
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 12.0F)
        Label6.Location = New Point(80, 400)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 31)
        Label6.TabIndex = 5
        Label6.Text = "Umur"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 12.0F)
        Label7.Location = New Point(80, 470)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 31)
        Label7.TabIndex = 6
        Label7.Text = "Warna"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 12.0F)
        Label8.Location = New Point(80, 540)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 31)
        Label8.TabIndex = 7
        Label8.Text = "Berat"
        ' 
        ' cbOwner
        ' 
        cbOwner.Location = New Point(320, 50)
        cbOwner.Name = "cbOwner"
        cbOwner.Size = New Size(400, 33)
        cbOwner.TabIndex = 8
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(320, 120)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(400, 31)
        txtNama.TabIndex = 9
        ' 
        ' cbJenis
        ' 
        cbJenis.Items.AddRange(New Object() {"Kucing", "Anjing", "Kelinci", "Hamster"})
        cbJenis.Location = New Point(320, 190)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(400, 33)
        cbJenis.TabIndex = 10
        ' 
        ' txtRas
        ' 
        txtRas.Location = New Point(320, 260)
        txtRas.Name = "txtRas"
        txtRas.Size = New Size(400, 31)
        txtRas.TabIndex = 11
        ' 
        ' cbJK
        ' 
        cbJK.Items.AddRange(New Object() {"Jantan", "Betina"})
        cbJK.Location = New Point(320, 330)
        cbJK.Name = "cbJK"
        cbJK.Size = New Size(400, 33)
        cbJK.TabIndex = 12
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(320, 400)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(400, 31)
        txtUmur.TabIndex = 13
        ' 
        ' txtWarna
        ' 
        txtWarna.Location = New Point(320, 470)
        txtWarna.Name = "txtWarna"
        txtWarna.Size = New Size(400, 31)
        txtWarna.TabIndex = 14
        ' 
        ' txtBerat
        ' 
        txtBerat.Location = New Point(320, 540)
        txtBerat.Name = "txtBerat"
        txtBerat.Size = New Size(400, 31)
        txtBerat.TabIndex = 15
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(900, 80)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(180, 60)
        btnTambah.TabIndex = 16
        btnTambah.Text = "Tambah"
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(900, 180)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(180, 60)
        btnEdit.TabIndex = 17
        btnEdit.Text = "Edit"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(900, 280)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(180, 60)
        btnHapus.TabIndex = 18
        btnHapus.Text = "Hapus"
        ' 
        ' dgvHewan
        ' 
        dgvHewan.ColumnHeadersHeight = 34
        dgvHewan.Location = New Point(80, 650)
        dgvHewan.Name = "dgvHewan"
        dgvHewan.RowHeadersWidth = 62
        dgvHewan.Size = New Size(1750, 450)
        dgvHewan.TabIndex = 19
        ' 
        ' lblID
        ' 
        lblID.Location = New Point(0, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(100, 23)
        lblID.TabIndex = 20
        lblID.Visible = False
        ' 
        ' uc_DataHewan
        ' 
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(cbOwner)
        Controls.Add(txtNama)
        Controls.Add(cbJenis)
        Controls.Add(txtRas)
        Controls.Add(cbJK)
        Controls.Add(txtUmur)
        Controls.Add(txtWarna)
        Controls.Add(txtBerat)
        Controls.Add(btnTambah)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(dgvHewan)
        Controls.Add(lblID)
        Name = "uc_DataHewan"
        Size = New Size(1955, 1182)
        CType(dgvHewan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

    Friend WithEvents cbOwner As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtRas As TextBox
    Friend WithEvents cbJK As ComboBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtWarna As TextBox
    Friend WithEvents txtBerat As TextBox

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

    Friend WithEvents dgvHewan As DataGridView

    Friend WithEvents lblID As Label

End Class