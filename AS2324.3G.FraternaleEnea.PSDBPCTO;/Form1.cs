using System.Data.SQLite;
using System.Data;

namespace AS2324._3G.FraternaleEnea.PSDBPCTO_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void piloti_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data Source=" + @"C:\Users\PC05\Downloads\AS2324.3G.Prof.PCTODB-master\AS2324.3G.Prof.PCTODB-master\AS2324.3G.Prof.PCTODB\DB\MotoGP.db" + ";Version=3;";

            DataTable dtDati = new DataTable();

            query = "SELECT * FROM Piloti";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void gare_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            strConnessione = "Data Source=" + @"C:\Users\PC05\Downloads\AS2324.3G.Prof.PCTODB-master\AS2324.3G.Prof.PCTODB-master\AS2324.3G.Prof.PCTODB\DB\MotoGP.db" + ";Version=3;";


            DataTable dtDati = new DataTable();

            query = "SELECT * FROM Gare";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                da.Fill(dtDati);

                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

        }
    }
}