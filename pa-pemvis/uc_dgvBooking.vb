Imports MySql.Data.MySqlClient

Public Class uc_dgvBooking

    ' =========================
    ' TAMPIL DATA BOOKING
    ' =========================
    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT " &
                "booking.id_booking, " &
                "booking.id_hewan, " &
                "hewan.nama_hewan, " &
                "booking.id_kandang, " &
                "kandang.nomor_kandang, " &
                "booking.tanggal_checkin, " &
                "booking.tanggal_checkout, " &
                "booking.status_booking, " &
                "booking.catatan " &
                "FROM booking " &
                "JOIN hewan " &
                "ON booking.id_hewan = hewan.id_hewan " &
                "JOIN kandang " &
                "ON booking.id_kandang = kandang.id_kandang",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            DataGridView1.DataSource = DT

            ' =========================
            ' HEADER TEXT
            ' =========================
            DataGridView1.Columns(0).HeaderText = "ID Booking"
            DataGridView1.Columns(1).HeaderText = "ID Hewan"
            DataGridView1.Columns(2).HeaderText = "Nama Hewan"
            DataGridView1.Columns(3).HeaderText = "ID Kandang"
            DataGridView1.Columns(4).HeaderText = "Nomor Kandang"
            DataGridView1.Columns(5).HeaderText = "Check In"
            DataGridView1.Columns(6).HeaderText = "Check Out"
            DataGridView1.Columns(7).HeaderText = "Status Booking"
            DataGridView1.Columns(8).HeaderText = "Catatan"

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
            DataGridView1.Columns(5).DefaultCellStyle.Format =
                "dd MMM yyyy"

            DataGridView1.Columns(6).DefaultCellStyle.Format =
                "dd MMM yyyy"

            ' =========================
            ' ALIGNMENT KHUSUS
            ' =========================
            DataGridView1.Columns(2).DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft

            DataGridView1.Columns(8).DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft

            ' =========================
            ' WARNA STATUS
            ' =========================
            For Each row As DataGridViewRow In DataGridView1.Rows

                Dim status As String =
                    row.Cells(7).Value.ToString()

                If status = "Booking" Then

                    row.Cells(7).Style.ForeColor =
                        Color.DarkOrange

                    row.Cells(7).Style.Font =
                        New Font(
                            "Microsoft PhagsPa",
                            11,
                            FontStyle.Bold)

                ElseIf status = "Check In" Then

                    row.Cells(7).Style.ForeColor =
                        Color.Green

                    row.Cells(7).Style.Font =
                        New Font(
                            "Microsoft PhagsPa",
                            11,
                            FontStyle.Bold)

                ElseIf status = "Check Out" Then

                    row.Cells(7).Style.ForeColor =
                        Color.SteelBlue

                    row.Cells(7).Style.Font =
                        New Font(
                            "Microsoft PhagsPa",
                            11,
                            FontStyle.Bold)

                ElseIf status = "Batal" Then

                    row.Cells(7).Style.ForeColor =
                        Color.Red

                    row.Cells(7).Style.Font =
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
    Private Sub uc_dgvBooking_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object,
        e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

End Class