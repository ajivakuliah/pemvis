Imports MySql.Data.MySqlClient

Public Class uc_dgvOwner

    ' =========================
    ' TAMPIL DATA OWNER
    ' =========================
    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT " &
                "id_owner, " &
                "nama_owner, " &
                "no_hp, " &
                "alamat, " &
                "email " &
                "FROM owner",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            DataGridView1.DataSource = DT

            ' =========================
            ' HEADER TEXT
            ' =========================
            DataGridView1.Columns(0).HeaderText = "ID Owner"
            DataGridView1.Columns(1).HeaderText = "Nama Owner"
            DataGridView1.Columns(2).HeaderText = "No HP"
            DataGridView1.Columns(3).HeaderText = "Alamat"
            DataGridView1.Columns(4).HeaderText = "Email"

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

                ' =========================
                ' GRID COLOR
                ' =========================
                .GridColor = Color.Gainsboro

            End With

            ' =========================
            ' KHUSUS KOLOM ALAMAT
            ' =========================
            DataGridView1.Columns(3).DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub uc_dgvOwner_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object,
        e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

End Class