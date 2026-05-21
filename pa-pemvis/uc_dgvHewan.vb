Imports MySql.Data.MySqlClient

Public Class uc_dgvHewan

    ' =========================
    ' TAMPIL DATA HEWAN
    ' =========================
    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT " &
                "hewan.id_hewan, " &
                "hewan.id_owner, " &
                "owner.nama_owner, " &
                "hewan.nama_hewan, " &
                "hewan.jenis_hewan, " &
                "hewan.ras, " &
                "hewan.jenis_kelamin, " &
                "hewan.umur, " &
                "hewan.warna, " &
                "hewan.berat " &
                "FROM hewan " &
                "JOIN owner " &
                "ON hewan.id_owner = owner.id_owner",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            DataGridView1.DataSource = DT

            ' =========================
            ' HEADER TEXT
            ' =========================
            DataGridView1.Columns(0).HeaderText = "ID Hewan"
            DataGridView1.Columns(1).HeaderText = "ID Owner"
            DataGridView1.Columns(2).HeaderText = "Nama Owner"
            DataGridView1.Columns(3).HeaderText = "Nama Hewan"
            DataGridView1.Columns(4).HeaderText = "Jenis Hewan"
            DataGridView1.Columns(5).HeaderText = "Ras"
            DataGridView1.Columns(6).HeaderText = "Jenis Kelamin"
            DataGridView1.Columns(7).HeaderText = "Umur"
            DataGridView1.Columns(8).HeaderText = "Warna"
            DataGridView1.Columns(9).HeaderText = "Berat (Kg)"

            ' =========================
            ' DESIGN DATAGRIDVIEW
            ' =========================
            With DataGridView1

                .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill

                .BackgroundColor = Color.White

                .BorderStyle = BorderStyle.None

                .AllowUserToAddRows = False

                .AllowUserToDeleteRows = False

                .ReadOnly = True

                .RowHeadersVisible = False

                .SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect

                .MultiSelect = False

                .EnableHeadersVisualStyles = False

                ' =========================
                ' FONT
                ' =========================
                .DefaultCellStyle.Font =
                    New Font("Microsoft PhagsPa", 11)

                .ColumnHeadersDefaultCellStyle.Font =
                    New Font(
                        "Microsoft PhagsPa",
                        11,
                        FontStyle.Bold)

                ' =========================
                ' HEADER STYLE
                ' =========================
                .ColumnHeadersDefaultCellStyle.BackColor =
                    Color.SteelBlue

                .ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White

                .ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter

                .ColumnHeadersHeight = 45

                ' =========================
                ' CELL STYLE
                ' =========================
                .DefaultCellStyle.SelectionBackColor =
                    Color.LightSteelBlue

                .DefaultCellStyle.SelectionForeColor =
                    Color.Black

                .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter

                .RowsDefaultCellStyle.BackColor =
                    Color.White

                .AlternatingRowsDefaultCellStyle.BackColor =
                    Color.FromArgb(245, 245, 245)

                .RowTemplate.Height = 40

                .GridColor = Color.Gainsboro

            End With

            ' =========================
            ' FORMAT KOLOM
            ' =========================

            ' KOLOM NAMA OWNER & HEWAN
            DataGridView1.Columns(2).DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft

            DataGridView1.Columns(3).DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft

            ' BERAT FORMAT
            DataGridView1.Columns(9).DefaultCellStyle.Format =
                "N2"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub uc_dgvHewan_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object,
        e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

End Class