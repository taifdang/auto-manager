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
            //for (int i = 1; i < this.DataGridView.Rows.Count; i++)
            //{
            //    this.DataGridView.Rows[i].Cells[1].Value = i + 1;
            //}
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
            //this.DataGridView.Rows.Clear();
            string[] array = File.ReadAllLines("Account.ini");
            #region forData
            //for (int i = 0; i < array.Length; i++)
            //{
            //    string[] array2 = array[i].Split('|');
            //    this.DataGridView.Rows.Add(new object[]{ false, array2[0],  array2[1], array2[2],array2[3],array2[4], array2[5], });
            //}
            #endregion
            foreach (string row in array)
            {
                string[] columns = row.Split('|');
                DataGridView.Rows.Add(new object[] { false, columns[0], columns[1],columns[2],columns[3],columns[4],columns[5],});
            }
        }
    }
}
