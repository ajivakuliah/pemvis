Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class uc_DataStaff

    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT * FROM data_staff", Conn)

            DT = New DataTable

            DA.Fill(DT)

            dgvStaff.DataSource = DT

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub uc_DataStaff_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub

    Private Sub btnTambah_Click(sender As Object,
        e As EventArgs) Handles btnTambah.Click

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "INSERT INTO data_staff " &
                "(nama_lengkap,email,no_telepon,shift) " &
                "VALUES " &
                "(@nama_lengkap,@email,@no_telepon,@shift)", Conn)

            CMD.Parameters.AddWithValue("@nama_lengkap", txtNamaLengkap.Text)
            CMD.Parameters.AddWithValue("@email", txtEmail.Text)
            CMD.Parameters.AddWithValue("@no_telepon", txtNoTelepon.Text)
            CMD.Parameters.AddWithValue("@shift", cbShift.Text)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Data staff berhasil ditambah")

            TampilData()

            Bersih()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object,
        e As EventArgs) Handles btnEdit.Click

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "UPDATE data_staff SET " &
                "nama_lengkap=@nama_lengkap, " &
                "email=@email, " &
                "no_telepon=@no_telepon, " &
                "shift=@shift " &
                "WHERE id_staff=@id", Conn)

            CMD.Parameters.AddWithValue("@id", lblID.Text)
            CMD.Parameters.AddWithValue("@nama_lengkap", txtNamaLengkap.Text)
            CMD.Parameters.AddWithValue("@email", txtEmail.Text)
            CMD.Parameters.AddWithValue("@no_telepon", txtNoTelepon.Text)
            CMD.Parameters.AddWithValue("@shift", cbShift.Text)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Data staff berhasil diubah")

            TampilData()

            Bersih()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub btnHapus_Click(sender As Object,
        e As EventArgs) Handles btnHapus.Click

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "DELETE FROM data_staff " &
                "WHERE id_staff=@id", Conn)

            CMD.Parameters.AddWithValue("@id", lblID.Text)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Data staff berhasil dihapus")

            TampilData()

            Bersih()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub dgvStaff_CellClick(sender As Object,
        e As DataGridViewCellEventArgs) _
        Handles dgvStaff.CellClick

        If e.RowIndex >= 0 Then

            lblID.Text =
                dgvStaff.Rows(e.RowIndex).Cells(0).Value.ToString()

            txtNamaLengkap.Text =
                dgvStaff.Rows(e.RowIndex).Cells(2).Value.ToString()

            txtEmail.Text =
                dgvStaff.Rows(e.RowIndex).Cells(3).Value.ToString()

            txtNoTelepon.Text =
                dgvStaff.Rows(e.RowIndex).Cells(4).Value.ToString()

            cbShift.Text =
                dgvStaff.Rows(e.RowIndex).Cells(5).Value.ToString()

        End If

    End Sub

    Sub Bersih()

        txtNamaLengkap.Clear()
        txtEmail.Clear()
        txtNoTelepon.Clear()

        cbShift.SelectedIndex = -1

        lblID.Text = ""

    End Sub

End Class