using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SearchHelper
{
    public partial class Main : Form
    {
        IniFileHelper iniFileHelper = new IniFileHelper();

        public Main()
        {
            InitializeComponent();
        }

        #region 重载FromA中的WndProc函数
        /// 
        /// 监视Windows消息
        /// 重载WndProc方法，用于实现热键响应
        /// 
        /// 
        protected override void WndProc(ref Message m)
        {

            const int WM_HOTKEY = 0x0312;
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:
                            if (this.Visible)
                            {
                                this.Hide();
                            }
                            else
                            {
                                this.Show();
                                this.Activate();
                            }
                            break;
                        case 101:    //按下的是Ctrl+B
                                     //此处填写快捷键响应代码
                            break;
                        case 102:    //按下的是Alt+D
                                     //此处填写快捷键响应代码
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        #endregion

        private void Main_Activated(object sender, EventArgs e)
        {
            ////注册热键Shift+S，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。
            //HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Shift, Keys.S);
            ////注册热键Ctrl+B，Id号为101。HotKey.KeyModifiers.Ctrl也可以直接使用数字2来表示。
            //HotKey.RegisterHotKey(Handle, 101, HotKey.KeyModifiers.Ctrl, Keys.B);
            ////注册热键Alt+D，Id号为102。HotKey.KeyModifiers.Alt也可以直接使用数字1来表示。
            //HotKey.RegisterHotKey(Handle, 102, HotKey.KeyModifiers.Alt, Keys.D);


            //HotKey.RegisterHotKey(Handle, 100, 0, Keys.F2);
            //HotKey.RegisterHotKey(Handle, 101, 0, Keys.F3);
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            //////注销Id号为100的热键设定
            ////HotKey.UnregisterHotKey(Handle, 100);
            //////注销Id号为101的热键设定
            ////HotKey.UnregisterHotKey(Handle, 101);// 
            ////                                     //注销Id号为102的热键设定
            ////HotKey.UnregisterHotKey(Handle, 102);
            ////注销Id号为100的热键设定
            HotKey.UnregisterHotKey(Handle, 100);
            ////注销Id号为101的热键设定
            //HotKey.UnregisterHotKey(Handle, 101);


        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtKey.Focus();
            HotKey.RegisterHotKey(Handle, 100, 0, Keys.F2);
            notifyIcon1.Visible = true;

            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.ItemHeight = 20;
            listBox1.Height = 0;
            pList.Y = this.listBox1.Location.Y;
            pList.X = this.listBox1.Location.X;


            //Control.ControlCollection sonControls = this.Controls;
            ////遍历所有控件
            //foreach (Control control in sonControls)
            //{
            //    if (control is ListBox)
            //    {
            //    }
            //    else
            //    {
            //        ((Control)control).MouseClick += new MouseEventHandler(Form1_MouseClick);
            //    }
            //}
            string defaultV = iniFileHelper.GetIniString("设置", "搜索默认", "Baidu");
            cbBaiduHot.Checked = Convert.ToBoolean(iniFileHelper.GetIniString("设置", "自动补全", "true"));
            switch (defaultV)
            {
                case "Baidu":
                    cbBaidu.Checked = true;
                    break;
                case "Google":
                    cbGoogle.Checked = true;
                    break;
                case "Bing":
                    cbBing.Checked = true;
                    break;
                case "Yandx":
                    cbYandx.Checked = true;
                    break;
                case "Fanyi":
                    cbFanyi.Checked = true;
                    break;
                case "Zhihu":
                    cbZhihu.Checked = true;
                    break;
                case "bilibili":
                    cbbilibili.Checked = true;
                    break;
                case "Kmm":
                    cbKmm.Checked = true;
                    break;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Visible = false;
        }

        Point pList = new Point();

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.X)
            {
                txtKey.Focus();
            }
            if (e.Alt && e.KeyCode == Keys.D1)
            {
                InitCB();
                cbBaidu.Checked = true;
            }
            if (e.Alt && e.KeyCode == Keys.D2)
            {
                InitCB();
                cbGoogle.Checked = true;
            }
            if (e.Alt && e.KeyCode == Keys.D3)
            {
                InitCB();
                cbBing.Checked = true;
            }
            if (e.Alt && e.KeyCode == Keys.D4)
            {
                InitCB();
                cbYandx.Checked = true;
            }
            if (e.Alt && e.KeyCode == Keys.D5)
            {
                InitCB();
                cbFanyi.Checked = true;
            }
            if (e.Alt && e.KeyCode == Keys.D6)
            {
                InitCB();
                cbZhihu.Checked = true;
            }
            if (e.Alt && e.KeyCode == Keys.D7)
            {
                InitCB();
                cbbilibili.Checked = true;
            }
            if (e.Alt && e.KeyCode == Keys.D8)
            {
                InitCB();
                cbKmm.Checked = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (this.listBox1.Visible)
                {
                    this.listBox1.Visible = false;
                }
                else
                    txtKey.Text = "";
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter && this.listBox1.Visible && this.listBox1.SelectedItems.Count > 0)
                {
                    this.txtKey.Text = this.listBox1.SelectedItems[0].ToString();

                    this.listBox1.Visible = false;
                    this.txtKey.Focus();
                }
                else
                    btnSearch_Click(null, null);
            }
        }

        private void SetDefaultVal(string val)
        {
            iniFileHelper.WriteIniString("设置", "搜索默认", val);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.listBox1.SelectedItems.Count > 0)
            //if (e.KeyCode == Keys.Enter && this.listBox1.Visible && this.listBox1.SelectedItems.Count > 0)
            {
                this.txtKey.TextChanged -= new EventHandler(txtKey_TextChanged);
                this.txtKey.Text = this.listBox1.SelectedItems[0].ToString();
                this.txtKey.TextChanged += new EventHandler(txtKey_TextChanged);
                this.listBox1.Visible = false;
                this.txtKey.Focus();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            Control.ControlCollection sonControls = this.Controls;
            //遍历所有控件
            foreach (Control control in sonControls)
            {
                if (control is Dio.DioCheckBox)
                {
                    var c = (Dio.DioCheckBox)control;
                    if (c.Checked && c.Tag != null)
                    {
                        SetDefaultVal(c.Name.Replace("cb", ""));
                        var url = c.Tag + txtKey.Text.Trim();
                        System.Diagnostics.Process.Start(url);
                    }
                }
            }
        }

        private void InitCB()
        {
            Control.ControlCollection sonControls = this.Controls;
            //遍历所有控件
            foreach (Control control in sonControls)
            {
                if (control is Dio.DioCheckBox)
                {
                    var c = (Dio.DioCheckBox)control;
                    c.Checked = false;
                }
            }
        }

        private void btnBookMark_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.8kmm.com/bookmark/");
        }


        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Set the DrawMode property to draw fixed sized items.
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;
            FontFamily fontFamily = new FontFamily("宋体");

            System.Drawing.Font myFont = new Font(fontFamily, 11);

            // Determine the color of the brush to draw each item based on the index of the item to draw.


            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                //e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
                if (e.Index > -1)
                {
                    e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), myFont, Brushes.White, e.Bounds, StringFormat.GenericDefault);
                }

            }
            else
            {
                //e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                if (e.Index > -1)
                {
                    e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
                }

            }

            // Draw the current item text based on the current Font and the custom brush settings.
            //e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point m = new Point(e.X, e.Y);
            int index = GetItemAt(this.listBox1, e.X, e.Y);
            if (this.listBox1.SelectedItems.Count > 0 && this.listBox1.SelectedIndex != index)
            {
                this.listBox1.SetSelected(this.listBox1.SelectedIndex, false);
            }

            if (index != -1 && this.listBox1.SelectedIndex != index)
            {

                this.listBox1.SetSelected(index, true);
            }
        }

        private bool GetItemAt(Point Mousep, int index)
        {
            int ph = this.listBox1.GetItemHeight(index) * index;
            int ph1 = this.listBox1.GetItemHeight(index) * index + this.listBox1.GetItemHeight(index);

            if (Mousep.Y > ph && Mousep.Y < ph1 && Mousep.X > 0 && Mousep.X < this.listBox1.Width)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private int GetItemAt(ListBox listBox, int X, int Y)
        {
            int index = -1;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                System.Drawing.Rectangle r = listBox.GetItemRectangle(i);
                if (r.Contains(new Point(X, Y)))
                {
                    index = i; ;
                    break;
                }
            }
            return index;
        }


        private void getBaiduTxt(string key)
        {
            try
            {

                if (key.Length < 2)
                {
                    return;
                }
                using (WebClient client = new WebClient())
                {
                    client.Headers["Type"] = "GET";
                    client.Headers["Accept"] = "application/json";
                    client.Encoding = Encoding.UTF8;
                    client.DownloadStringCompleted += (senderobj, es) =>
                    {
                        var obj = es.Result;
                        this.listBox1.Items.Clear();

                        obj = obj.Trim('[').Trim(']');
                        obj = obj.Substring(obj.IndexOf('[') + 1).Trim();
                        var list = obj.Split(',');


                        if (list.Length == 1)
                        {
                            this.listBox1.Visible = false;
                        }
                        else
                        {
                            for (int i = 0; i < list.Length; i++)
                            {
                                listBox1.Items.Add(list[i].Trim('"'));
                            }
                            if (list.Length < 11)
                            {
                                this.listBox1.Height = 15 * list.Length + 15;
                            }
                            else
                            {
                                this.listBox1.Height = 200;
                            }
                            this.listBox1.Visible = true;
                        }
                    };
                    client.DownloadStringAsync(new Uri("https://suggestion.baidu.com/su?action=opensearch&ie=UTF-8&wd=" + key));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (!cbBaiduHot.Checked) return;
            if (this.txtKey.Text.Trim() != "")
            {
                getBaiduTxt(this.txtKey.Text.Trim());

                this.listBox1.Visible = true;

            }
            else
            {
                this.listBox1.Items.Clear();
                this.listBox1.Visible = false;
            }
        }


        private void txtKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (!cbBaiduHot.Checked) return;
            if (e.KeyCode == Keys.Down && this.listBox1.Visible)
            {
                this.listBox1.Focus();

                if (this.listBox1.SelectedItems.Count > 0)
                {
                    this.listBox1.SetSelected(this.listBox1.SelectedIndex, false);
                }

                if (this.listBox1.Items.Count > 0)
                {
                    this.listBox1.SetSelected(0, true);

                }


            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.listBox1.SelectedItems.Count > 0)
            {
                this.txtKey.Text = this.listBox1.SelectedItems[0].ToString();

                this.listBox1.Visible = false;
                this.txtKey.Focus();
            }
        }

        private void cbBaiduHot_CheckedChanged(object sender, EventArgs e)
        {
            iniFileHelper.WriteIniString("设置", "自动补全", cbBaiduHot.Checked.ToString());
        }
    }




    #region 快捷键区
    class HotKey
    {
        //如果函数执行成功，返回值不为0。
        //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
                        IntPtr hWnd,                //要定义热键的窗口的句柄
            int id,                     //定义热键ID（不能与其它ID重复）
            KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
            Keys vk                     //定义热键的内容
            );
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,                //要取消热键的窗口的句柄
            int id                      //要取消热键的ID
            );
        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
    }
    #endregion
}
