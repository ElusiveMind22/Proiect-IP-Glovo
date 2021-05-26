using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Magazine : Form
    {
        public Magazine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void magazineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicev\OneDrive\Documents\Dayta.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter adapter=new SqlDataAdapter();
            String sql = "Select produs From Magazine INNER JOIN MENU ON MAGAZINE.ID_MENU = MENU.ID_MENU' where Magazine.Nume_Magazin = '" + magazineComboBox.Text + "'";

            adapter = new SqlDataAdapter(sql, conn);

            Console.WriteLine(magazineComboBox.Text);

            command = new SqlCommand(sql, conn);
     
            string result = command.ExecuteScalar().ToString();
            Console.WriteLine(result);
            command.Dispose();
            conn.Close();

          
/*            sql.Fill(dta);

            Console.WriteLine(dta.Rows[0][0].ToString());*/
        }

    }
}
