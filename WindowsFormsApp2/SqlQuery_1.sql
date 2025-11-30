using System.Data.SqlClient;

private void BtnSimpan_Click(object sender, EventArgs e)
{
    if (ValidateInput())
    {
        string connectionString = "your_connection_string_here";
        string query = "INSERT INTO RentalData (IDPenyewa, NamaPenyewa, TanggalRental, Email, IDPetugas, NamaPetugas, NoKontak, IDMobil, NamaMobil, HargaSewa) VALUES (@IDPenyewa, @NamaPenyewa, @TanggalRental, @Email, @IDPetugas, @NamaPetugas, @NoKontak, @IDMobil, @NamaMobil, @HargaSewa)";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IDPenyewa", txtIDPenyewa.Text);
            cmd.Parameters.AddWithValue("@NamaPenyewa", txtNamaPenyewa.Text);
            cmd.Parameters.AddWithValue("@TanggalRental", dtpTanggalRental.Value);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@IDPetugas", txtIDPetugas.Text);
            cmd.Parameters.AddWithValue("@NamaPetugas", txtNamaPetugas.Text);
            cmd.Parameters.AddWithValue("@NoKontak", txtNoKontak.Text);
            cmd.Parameters.AddWithValue("@IDMobil", txtIDMobil.Text);
            cmd.Parameters.AddWithValue("@NamaMobil", txtNamaMobil.Text);
            cmd.Parameters.AddWithValue("@HargaSewa", txtHargaSewa.Text);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}