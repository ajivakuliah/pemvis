Imports MySql.Data.MySqlClient

Public Class uc_dgvPembayaran

    ' =========================
    ' TAMPIL DATA PEMBAYARAN
    ' =========================
    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT " &
                "pembayaran.id_pembayaran, " &
                "pembayaran.id_booking, " &
                "hewan.nama_hewan, " &
                "pembayaran.tanggal_bayar, " &
                "pembayaran.total_hotel, " &
                "pembayaran.total_perawatan, " &
                "pembayaran.total_bayar, " &
                "pembayaran.metode_pembayaran, " &
                "pembayaran.status_pembayaran " &
                "FROM pembayaran " &
                "JOIN booking " &
                "ON pembayaran.id_booking = booking.id_booking " &
                "JOIN hewan " &
                "ON booking.id_hewan = hewan.id_hewan",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            DataGridView1.DataSource = DT

            ' =========================
            ' HEADER TEXT
            ' =========================
            DataGridView1.Columns(0).HeaderText = "ID Pembayaran"
            DataGridView1.Columns(1).HeaderText = "ID Booking"
            DataGridView1.Columns(2).HeaderText = "Nama Hewan"
            DataGridView1.Columns(3).HeaderText = "Tanggal Bayar"
            DataGridView1.Columns(4).HeaderText = "Total Hotel"
            DataGridView1.Columns(5).HeaderText = "Total Perawatan"
            DataGridView1.Columns(6).HeaderText = "Total Bayar"
            DataGridView1.Columns(7).HeaderText = "Metode Pembayaran"
            DataGridView1.Columns(8).HeaderText = "Status Pembayaran"

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
            ' FORMAT TANGGAL
            ' =========================
            DataGridView1.Columns(3).DefaultCellStyle.Format =
                "dd MMM yyyy"

            ' =========================
            ' FORMAT RUPIAH
            ' =========================
            DataGridView1.Columns(4).DefaultCellStyle.Format =
                "N0"

            DataGridView1.Columns(5).DefaultCellStyle.Format =
                "N0"

            DataGridView1.Columns(6).DefaultCellStyle.Format =
                "N0"

            ' =========================
            ' ALIGNMENT KHUSUS
            ' =========================
            DataGridView1.Columns(2).DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft

            DataGridView1.Columns(7).DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft

            ' =========================
            ' WARNA STATUS
            ' =========================
            For Each row As DataGridViewRow In DataGridView1.Rows

                Dim status As String =
                    row.Cells(8).Value.ToString()

                If status = "Lunas" Then

                    row.Cells(8).Style.ForeColor =
                        Color.Green

                    row.Cells(8).Style.Font =
                        New Font(
                            "Microsoft PhagsPa",
                            11,
                            FontStyle.Bold)

                ElseIf status = "Belum Lunas" Then

                    row.Cells(8).Style.ForeColor =
                        Color.Red

                    row.Cells(8).Style.Font =
                        New Font(
                            "Microsoft PhagsPa",
                            11,
                            FontStyle.Bold)

                End If

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub uc_dgvPembayaran_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object,
        e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

End Class