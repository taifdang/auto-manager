using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
namespace QLTK_NRO
{
    public partial class MainForm : Form
    {
        bool onFlag = false;       
        public MainForm()
        {
            InitializeComponent();
            addListMap();
            firstDataUpLoad();

        }
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveWindow(IntPtr handle, int x, int y, int w, int h, bool repaint);
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        #region function
        public bool canLogin()
        {
            if (!File.Exists("Data\\Dragonboy.exe"))
            {
                MessageBox.Show("No Found File...");
                return false;
            }
            if (File.Exists("Log"))
            {
                DialogResult result = MessageBox.Show("Loging...", "Error", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    File.Delete("Log");
                    return true;
                }
                return false;
            }
            return true;
        }
        public void Login(int index)
        {
            if (File.Exists("Log"))
            {
                File.Delete("Log");
            }
            TextWriter textWriter = new StreamWriter("Log");
            for (int i = 1; i < 7; i++)
            {
                textWriter.Write(dataGridView.Rows[index].Cells[i].Value.ToString() + "|");
            }
            textWriter.Close();
            var prc = Process.Start("Data\\Dragonboy.exe");
            Thread.Sleep(100);
            while (prc.MainWindowHandle == IntPtr.Zero)
            {
                Thread.Sleep(100);
            }
            SetWindowText(prc.MainWindowHandle, "NR_" + index);
        }
        public void LoginAll()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var cbxCell = (DataGridViewCheckBoxCell)dataGridView.Rows[i].Cells[0];
                if ((bool)cbxCell.Value == true)
                {
                    var handle = FindWindow(null!, "NR_" + i);
                    if (handle == IntPtr.Zero)
                    {
                        Login(i);
                        while (File.Exists("Log"))
                        {
                            Thread.Sleep(500);
                        }
                        Thread.Sleep(500);
                        sort();

                    }
                }
            }
        }
        public void findText(int index)
        {
            int position = dataGridView.Rows[index].Cells[4].Value.ToString().IndexOf("/");
            string mapKey = dataGridView.Rows[index].Cells[4].Value.ToString().Substring(0, position);         
            if (File.Exists("Map.ini"))
            {
                string[] _char = File.ReadAllLines("Map.ini");
                foreach (string line in _char)
                {
                    if (line.Contains(mapKey))
                    {
                        mapID.Text = line;
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy file !!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void closeAllProcess()
        {
            onFlag = false;
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.Contains("NR_"))
                {
                    process.Kill();
                }
            }
        }
        public void addAccount(string data, string idxSever)
        {
            dataGridView.Rows.Add(new object[]
                               {
                                    false,
                                    data,
                                    password.Text,
                                    idxSever,
                                    mapID.Text.Substring(0,mapID.Text.IndexOf('.')) +"/"+ zoneID.Value.ToString(),
                                    strProxy.Text,
                                    "",
                                   });
            new Data(dataGridView, username).ExportFile();
        }
        public void unSelect1row(int index)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.Contains("NR_" + index))
                {
                    process.Kill();
                }
            }
        }
        public void sort()
        {
            int witdh = Screen.PrimaryScreen.Bounds.Width;          
            int x = 0;
            int y = 0;
            var s = File.ReadAllText("Config.ini").Split("x");
            int w = int.Parse(s[0]);
            int h = int.Parse(s[1]);
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var cbxCell = (DataGridViewCheckBoxCell)dataGridView.Rows[i].Cells[0];
                if ((bool)cbxCell.Value == true)
                {
                    var handle = FindWindow(null!, "NR_" + i);
                    int num = w * x;
                    if (num > witdh)
                    {
                        num = 0;
                        x = 0;
                        y += h;
                    }
                    MoveWindow(handle, num, y, w, h, true);
                    x++;
                }
            }
        }
        Thread threadRunMain;
        Thread threadCheckTab;
        void CheckRunTab()
        {
            if (threadRunMain == null || threadRunMain.IsAlive == false)
            {
                threadRunMain = new Thread(new ThreadStart(RunMain));
                threadRunMain.Start();
            }
        }
        void RunMain()
        {
            int count = 0;
            while (onFlag)
            {               
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        var cbxCell = (DataGridViewCheckBoxCell)dataGridView.Rows[i].Cells[0];
                        if ((bool)cbxCell.Value == true)
                        {
                            var handle = FindWindow(null!, "NR_" + i);
                            if (handle == IntPtr.Zero)
                            {
                                count++;
                            }
                        }
                    }
                    if (count > 0)
                    {
                        threadCheckTab = new Thread(new ThreadStart(LoginAll));
                        threadCheckTab.Start();
                        threadCheckTab.Join(1000);
                        count = 0;
                    }
                    Thread.Sleep(5000);            
            }
        }
        #endregion
        #region general
        public void firstDataUpLoad()
        {
            indexServer.Text = "Vũ trụ 1";
            mapID.Text = mapID.Items[0].ToString();
            noProxy_rdb.Checked = true;
            pickType1.Checked = true;
            trainType1.Checked = true;
            trainAll.Checked = true;
        }
        public void addListMap()
        {
            string[] lines = File.ReadAllLines("Map.ini");
            foreach (string line in lines)
            {
                mapID.Items.Add(line);
            }
        }
        public bool checkAdd(bool Add)
        {
            bool check;
            if (string.IsNullOrEmpty(username.Text))
            {
                username.Focus();
                check = false;
            }
            else if (string.IsNullOrEmpty(password.Text))
            {
                password.Focus();
                check = false;
            }
            else if (string.IsNullOrEmpty(indexServer.Text))
            {
                indexServer.Focus();
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private void updateTextBoxProxy()
        {
            if (noProxy_rdb.Checked)
            {
                strProxy.Text = "";
                strProxy.ReadOnly = true;
                strProxy.BackColor = Color.WhiteSmoke;
            }
            else
            {
                strProxy.ReadOnly = false;
                strProxy.BackColor = Color.White;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            new Data(dataGridView, username).LoadFile();
        }     
        #endregion
        #region CRUD
        private void addBtn_Click(object sender, EventArgs e)
        {                               
            string idxSever = indexServer.Text.Substring(7);
            if (checkAdd(true))
            {
                try
                {
                    if (username.Text.Contains("["))
                    {
                        string strFirst = username.Text.Substring(0, username.Text.IndexOf('['));
                        int foundTo = username.Text.IndexOf("[");
                        int foundUp = username.Text.IndexOf("]");
                        int foundEnd = username.Text.IndexOf("-");
                        string to = username.Text.Substring(foundTo + 1, foundEnd - (foundTo + 1));
                        string up = username.Text.Substring(foundEnd + 1, foundUp - (foundEnd + 1));
                        string strEnd = username.Text.Substring(foundUp + 1);
                        int toValue = int.Parse(to);
                        int upValue = int.Parse(up);
                        string data;
                        if ((toValue >= 0 && upValue >= 0) && toValue < upValue)
                        {
                            for (int i = toValue; i <= upValue; i++)
                            {
                                int numberOfTimes = 0;//so ki tu chenh lech
                                string charInsert = "0";//ki tu can them
                                string countI = i.ToString();
                                numberOfTimes = up.Length - countI.Length;
                                if (numberOfTimes != 0)
                                {
                                    string alphabets = string.Concat(Enumerable.Repeat(charInsert, numberOfTimes));                             
                                    data = strFirst + alphabets + i + strEnd;
                                }
                                else
                                {
                                    data = strFirst + i + strEnd;
                                }
                                addAccount(data, idxSever);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi định dạng dữ liệu !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        addAccount(username.Text, idxSever);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi rồi Đại Vương ơi !!!\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (checkAdd(false) && dataGridView.SelectedRows.Count == 1)
            {

                int index = dataGridView.CurrentRow.Index;
                dataGridView.Rows[index].Cells[1].Value = username.Text;
                dataGridView.Rows[index].Cells[2].Value = password.Text;
                dataGridView.Rows[index].Cells[3].Value = indexServer.Text;
                dataGridView.Rows[index].Cells[4].Value = mapID.Text.Substring(0, mapID.Text.IndexOf('.')) + "/" + zoneID.Value.ToString();
                dataGridView.Rows[index].Cells[5].Value = strProxy.Text;

                new Data(dataGridView, username).ExportFile();


            }
            else if (dataGridView.Rows.Count > 0 && dataGridView.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows[row.Index].Cells[5].Value = strProxy.Text;
                }
                new Data(dataGridView, username).ExportFile();

            }
            else
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (!onFlag)
                    {
                        dataGridView.Rows.RemoveAt(row.Index);
                    }
                    else
                    {
                        MessageBox.Show("Thread đang chạy !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            new Data(dataGridView, username).ExportFile();        
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                int position = dataGridView.Rows[index].Cells[4].Value.ToString().IndexOf("/");
                string mapKey = dataGridView.Rows[index].Cells[4].Value.ToString().Substring(0, position);

                findText(index);
                dataGridView.Rows[e.RowIndex].Selected = true;
                username.Text = dataGridView.Rows[index].Cells[1].Value.ToString();
                password.Text = dataGridView.Rows[index].Cells[2].Value.ToString();
                indexServer.Text = dataGridView.Rows[index].Cells[3].Value.ToString();
                zoneID.Value = decimal.Parse(dataGridView.Rows[index].Cells[4].Value.ToString().Substring(position + 1));
                strProxy.Text = dataGridView.Rows[index].Cells[5].Value.ToString();
            }
        }
        private void selectBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                if (cell.ValueType == typeof(bool))
                {
                    cell.Value = true;                
                    dataGridView.Rows[cell.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }          
        }
        private void unSelectBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                if (cell.ValueType == typeof(bool))
                {
                    cell.Value = false;              
                    dataGridView.Rows[cell.RowIndex].DefaultCellStyle.BackColor = default;
                    var handle = FindWindow(null!, "NR_" + cell.RowIndex);
                    if (handle != IntPtr.Zero)
                    {
                        unSelect1row(cell.RowIndex);
                    }
                }
            }
            if (onFlag)
            {
                Thread.Sleep(500);
                sort();
            }
        }
        public void changeColorButton(Button onBtn,Button offBtn)
        {
            onBtn.BackColor = Color.WhiteSmoke;
            offBtn.BackColor = Color.LightGray;
        }
        private void onBtn_Click(object sender, EventArgs e)
        {
            onFlag = true;
            changeColorButton(onBtn,offBtn);         
            CheckRunTab();
        }
        private void offBtn_Click(object sender, EventArgs e)
        {        
            changeColorButton(offBtn, onBtn);
            closeAllProcess();

        }
        private void ConfigAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows[row.Index].Cells[4].Value = mapID.Text.Substring(0, mapID.Text.IndexOf('.')) + "/" + zoneID.Value;
                    new Data(dataGridView).ExportFile();

                }
            }
            else
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SortTabBtn_Click(object sender, EventArgs e)
        {
            sort();         
        }
        #endregion

        #region mouseEvent
        //bool isFlag = false;
        //int endRow;
        //int startRow;
        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    isFlag = true;
            //    startRow = dataGridView.HitTest(e.X, e.Y).RowIndex;
            //    endRow = startRow;
            //}
        }
        private void dataGridView_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Y > e.Location.Y)
            //{
            //    int row_temp2 = dataGridView.Rows.Count;
            //    int row_temp = dataGridView.HitTest(e.X, e.Y).RowIndex + 1;
            //    dataGridView.Rows[row_temp].Cells[0].Selected = true;
            //}
        }
        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            //if (isFlag)
            //{
            //    isFlag = false;
            //}
        }
        #endregion

        #region radioButton
        private void noProxy_RadioBtn(object sender, EventArgs e)
        {
            updateTextBoxProxy();
        }
        private void sockProxy_RadioBtn(object sender, EventArgs e)
        {
            updateTextBoxProxy();
        }
        private void httpProxy_RadioBtn(object sender, EventArgs e)
        {
            updateTextBoxProxy();
        }
        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {                   
            closeAllProcess();
            Application.Exit();          
        }
    }
}
