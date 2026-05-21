Imports MySql.Data.MySqlClient

Public Class uc_StatusKandang

    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT " &
                "nomor_kandang, " &
                "tipe_kandang, " &
                "harga_per_hari, " &
                "status_kandang " &
                "FROM kandang",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            dgvKandang.DataSource = DT

            ' =========================
            ' HEADER TEXT
            ' =========================
            dgvKandang.Columns(0).HeaderText = "Nomor Kandang"
            dgvKandang.Columns(1).HeaderText = "Tipe Kandang"
            dgvKandang.Columns(2).HeaderText = "Harga Per Hari"
            dgvKandang.Columns(3).HeaderText = "Status"

            ' =========================
            ' DESIGN DATAGRIDVIEW
            ' =========================
            With dgvKandang

                .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill

                .BackgroundColor = Color.White

                .BorderStyle = BorderStyle.None

                .AllowUserToAddRows = False

                .AllowUserToResizeRows = False

                .ReadOnly = True

                .RowHeadersVisible = False

                .SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect

                .MultiSelect = False

                .EnableHeadersVisualStyles = False

                .GridColor =
                    Color.FromArgb(230, 230, 230)

                ' =========================
                ' FONT
                ' =========================
                .DefaultCellStyle.Font =
                    New Font("Microsoft PhagsPa", 11)

                .ColumnHeadersDefaultCellStyle.Font =
                    New Font("Microsoft PhagsPa", 11, FontStyle.Bold)

                ' =========================
                ' HEADER STYLE
                ' =========================
                .ColumnHeadersDefaultCellStyle.BackColor =
                    Color.SteelBlue

                .ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White

                .ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter

                .ColumnHeadersBorderStyle =
                    DataGridViewHeaderBorderStyle.None

                .ColumnHeadersHeight = 45

                ' =========================
                ' CELL STYLE
                ' =========================
                .DefaultCellStyle.BackColor =
                    Color.White

                .DefaultCellStyle.ForeColor =
                    Color.Black

                .DefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(210, 230, 255)

                .DefaultCellStyle.SelectionForeColor =
                    Color.Black

                .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter

                .DefaultCellStyle.Padding =
                    New Padding(8)

                .AlternatingRowsDefaultCellStyle.BackColor =
                    Color.FromArgb(248, 249, 250)

                .RowTemplate.Height = 50

                ' BORDER
                .CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal

            End With

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub dgvKandang_CellFormatting(sender As Object,
    e As DataGridViewCellFormattingEventArgs) _
    Handles dgvKandang.CellFormatting

        If dgvKandang.Columns(e.ColumnIndex).Name =
        dgvKandang.Columns(3).Name Then

            If e.Value IsNot Nothing Then

                Dim status As String =
                e.Value.ToString().ToLower()

                ' =========================
                ' STATUS KOSONG = HIJAU
                ' =========================
                If status = "kosong" Then

                    e.CellStyle.ForeColor =
                    Color.Green

                    e.CellStyle.Font =
                    New Font("Microsoft PhagsPa",
                    11,
                    FontStyle.Bold)

                End If

                ' =========================
                ' STATUS TERISI = MERAH
                ' =========================
                If status = "terisi" Then

                    e.CellStyle.ForeColor =
                    Color.Red

                    e.CellStyle.Font =
                    New Font("Microsoft PhagsPa",
                    11,
                    FontStyle.Bold)

                End If

            End If

        End If

    End Sub

    Private Sub uc_StatusKandang_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub



End Class