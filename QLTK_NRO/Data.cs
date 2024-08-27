using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.Security.Policy;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
namespace QLTK_NRO
{
    class Data
    {
        
        public DataGridView DataGridView {  get; set; }
       
        public TextBox Username { get; set; }

        public Data(DataGridView dataGridView, TextBox username)
        {
            this.DataGridView = dataGridView;
            this.Username = username;
        }
        public Data(TextBox username)
        {
            this.Username = username;
        }
        public Data(DataGridView dataGridView)
        {
            this.DataGridView = dataGridView;
        }

        public void ExportFile()
        {
            
            TextWriter textWriter = new StreamWriter("Account.ini");
            for (int j = 0; j < this.DataGridView.Rows.Count; j++)
            {
                for (int k = 1; k < this.DataGridView.Columns.Count ; k++)
                {
                   textWriter.Write(this.DataGridView.Rows[j].Cells[k].Value + "|");
                }
                textWriter.WriteLine("");
            }
            textWriter.Close();
        }
        public void LoadFile()
        {            
            string[] array = File.ReadAllLines("Account.ini");
            #region forData         
            #endregion
            foreach (string row in array)
            {
                string[] columns = row.Split('|');
                DataGridView.Rows.Add(new object[] { false, columns[0], columns[1],columns[2],columns[3],columns[4],columns[5],});
            }
        }
    }
}
