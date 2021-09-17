
namespace SearchHelper
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtKey = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbBaiduHot = new Dio.DioCheckBox();
            this.btnBookMark = new Dio.DioButton();
            this.cbSearch = new Dio.DioButton();
            this.cbYandx = new Dio.DioCheckBox();
            this.cbKmm = new Dio.DioCheckBox();
            this.cbbilibili = new Dio.DioCheckBox();
            this.cbZhihu = new Dio.DioCheckBox();
            this.cbFanyi = new Dio.DioCheckBox();
            this.cbBing = new Dio.DioCheckBox();
            this.cbGoogle = new Dio.DioCheckBox();
            this.cbBaidu = new Dio.DioCheckBox();
            this.dioLabel2 = new Dio.DioLabel();
            this.dioLabel1 = new Dio.DioLabel();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(88, 14);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(312, 21);
            this.txtKey.TabIndex = 1;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            this.txtKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKey_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(88, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 4);
            this.listBox1.TabIndex = 11;
            this.listBox1.Visible = false;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseUp);
            // 
            // cbBaiduHot
            // 
            this.cbBaiduHot.AutoSize = true;
            this.cbBaiduHot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbBaiduHot.BorderColor = System.Drawing.Color.Empty;
            this.cbBaiduHot.Checked = true;
            this.cbBaiduHot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBaiduHot.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbBaiduHot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbBaiduHot.Location = new System.Drawing.Point(318, 17);
            this.cbBaiduHot.Name = "cbBaiduHot";
            this.cbBaiduHot.Size = new System.Drawing.Size(81, 15);
            this.cbBaiduHot.TabIndex = 12;
            this.cbBaiduHot.Text = "关键字补全";
            this.cbBaiduHot.UseVisualStyleBackColor = false;
            this.cbBaiduHot.CheckedChanged += new System.EventHandler(this.cbBaiduHot_CheckedChanged);
            // 
            // btnBookMark
            // 
            this.btnBookMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(165)))), ((int)(((byte)(215)))));
            this.btnBookMark.BorderColor = System.Drawing.Color.Empty;
            this.btnBookMark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnBookMark.ForeColor = System.Drawing.Color.White;
            this.btnBookMark.Location = new System.Drawing.Point(416, 57);
            this.btnBookMark.Name = "btnBookMark";
            this.btnBookMark.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBookMark.ShadowSize = 1;
            this.btnBookMark.Size = new System.Drawing.Size(75, 23);
            this.btnBookMark.TabIndex = 9;
            this.btnBookMark.Text = "我的书签";
            this.btnBookMark.UseVisualStyleBackColor = false;
            this.btnBookMark.Click += new System.EventHandler(this.btnBookMark_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.cbSearch.BorderColor = System.Drawing.Color.Empty;
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbSearch.ForeColor = System.Drawing.Color.White;
            this.cbSearch.Location = new System.Drawing.Point(416, 14);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbSearch.ShadowSize = 1;
            this.cbSearch.Size = new System.Drawing.Size(75, 23);
            this.cbSearch.TabIndex = 9;
            this.cbSearch.Text = "搜索";
            this.cbSearch.UseVisualStyleBackColor = false;
            this.cbSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbYandx
            // 
            this.cbYandx.AutoSize = true;
            this.cbYandx.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbYandx.BorderColor = System.Drawing.Color.Empty;
            this.cbYandx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbYandx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbYandx.Location = new System.Drawing.Point(284, 58);
            this.cbYandx.Name = "cbYandx";
            this.cbYandx.Size = new System.Drawing.Size(58, 15);
            this.cbYandx.TabIndex = 4;
            this.cbYandx.Tag = "https://yandex.com/search/?text=";
            this.cbYandx.Text = "Yandex";
            this.cbYandx.UseVisualStyleBackColor = false;
            // 
            // cbKmm
            // 
            this.cbKmm.AutoSize = true;
            this.cbKmm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbKmm.BorderColor = System.Drawing.Color.Empty;
            this.cbKmm.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbKmm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbKmm.Location = new System.Drawing.Point(224, 88);
            this.cbKmm.Name = "cbKmm";
            this.cbKmm.Size = new System.Drawing.Size(48, 15);
            this.cbKmm.TabIndex = 4;
            this.cbKmm.Tag = "https://my.8kmm.com/?q=";
            this.cbKmm.Text = "More";
            this.cbKmm.UseVisualStyleBackColor = false;
            // 
            // cbbilibili
            // 
            this.cbbilibili.AutoSize = true;
            this.cbbilibili.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbbilibili.BorderColor = System.Drawing.Color.Empty;
            this.cbbilibili.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbbilibili.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbbilibili.Location = new System.Drawing.Point(151, 88);
            this.cbbilibili.Name = "cbbilibili";
            this.cbbilibili.Size = new System.Drawing.Size(40, 15);
            this.cbbilibili.TabIndex = 4;
            this.cbbilibili.Tag = "https://search.bilibili.com/all?keyword=";
            this.cbbilibili.Text = "B站";
            this.cbbilibili.UseVisualStyleBackColor = false;
            // 
            // cbZhihu
            // 
            this.cbZhihu.AutoSize = true;
            this.cbZhihu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbZhihu.BorderColor = System.Drawing.Color.Empty;
            this.cbZhihu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbZhihu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbZhihu.Location = new System.Drawing.Point(91, 88);
            this.cbZhihu.Name = "cbZhihu";
            this.cbZhihu.Size = new System.Drawing.Size(45, 15);
            this.cbZhihu.TabIndex = 4;
            this.cbZhihu.Tag = "https://www.zhihu.com/search?type=content&q=";
            this.cbZhihu.Text = "知乎";
            this.cbZhihu.UseVisualStyleBackColor = false;
            // 
            // cbFanyi
            // 
            this.cbFanyi.AutoSize = true;
            this.cbFanyi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbFanyi.BorderColor = System.Drawing.Color.Empty;
            this.cbFanyi.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbFanyi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbFanyi.Location = new System.Drawing.Point(354, 58);
            this.cbFanyi.Name = "cbFanyi";
            this.cbFanyi.Size = new System.Drawing.Size(45, 15);
            this.cbFanyi.TabIndex = 4;
            this.cbFanyi.Tag = "https://fanyi.baidu.com/translate?smartresult=dict&lang=zh#zh/en/";
            this.cbFanyi.Text = "翻译";
            this.cbFanyi.UseVisualStyleBackColor = false;
            // 
            // cbBing
            // 
            this.cbBing.AutoSize = true;
            this.cbBing.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbBing.BorderColor = System.Drawing.Color.Empty;
            this.cbBing.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbBing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbBing.Location = new System.Drawing.Point(224, 58);
            this.cbBing.Name = "cbBing";
            this.cbBing.Size = new System.Drawing.Size(44, 15);
            this.cbBing.TabIndex = 4;
            this.cbBing.Tag = "https://www.bing.com/search?q=";
            this.cbBing.Text = "Bing";
            this.cbBing.UseVisualStyleBackColor = false;
            // 
            // cbGoogle
            // 
            this.cbGoogle.AutoSize = true;
            this.cbGoogle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbGoogle.BorderColor = System.Drawing.Color.Empty;
            this.cbGoogle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbGoogle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbGoogle.Location = new System.Drawing.Point(151, 58);
            this.cbGoogle.Name = "cbGoogle";
            this.cbGoogle.Size = new System.Drawing.Size(58, 15);
            this.cbGoogle.TabIndex = 4;
            this.cbGoogle.Tag = "https://www.google.com/search?q=";
            this.cbGoogle.Text = "Google";
            this.cbGoogle.UseVisualStyleBackColor = false;
            // 
            // cbBaidu
            // 
            this.cbBaidu.AutoSize = true;
            this.cbBaidu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbBaidu.BorderColor = System.Drawing.Color.Empty;
            this.cbBaidu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbBaidu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbBaidu.Location = new System.Drawing.Point(91, 58);
            this.cbBaidu.Name = "cbBaidu";
            this.cbBaidu.Size = new System.Drawing.Size(45, 15);
            this.cbBaidu.TabIndex = 3;
            this.cbBaidu.Tag = "https://www.baidu.com/baidu?ie=UTF-8&word=";
            this.cbBaidu.Text = "百度";
            this.cbBaidu.UseVisualStyleBackColor = false;
            // 
            // dioLabel2
            // 
            this.dioLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dioLabel2.DrawSide = true;
            this.dioLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dioLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.dioLabel2.Location = new System.Drawing.Point(19, 155);
            this.dioLabel2.Name = "dioLabel2";
            this.dioLabel2.Size = new System.Drawing.Size(445, 64);
            this.dioLabel2.TabIndex = 8;
            this.dioLabel2.Text = "快捷键：\r\n【Alt+1】、2、3……切换搜索引擎；【Alt+X】获取搜索框焦点；\r\n【Enter】键直接搜索；【F2】老板键；【ESC】清空；\r\n\r\n";
            this.dioLabel2.Title = null;
            this.dioLabel2.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F);
            // 
            // dioLabel1
            // 
            this.dioLabel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dioLabel1.DrawSide = true;
            this.dioLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dioLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dioLabel1.Location = new System.Drawing.Point(19, 14);
            this.dioLabel1.Name = "dioLabel1";
            this.dioLabel1.Size = new System.Drawing.Size(63, 23);
            this.dioLabel1.TabIndex = 8;
            this.dioLabel1.Text = "关键字：";
            this.dioLabel1.Title = null;
            this.dioLabel1.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 205);
            this.Controls.Add(this.cbBaiduHot);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnBookMark);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.cbYandx);
            this.Controls.Add(this.cbKmm);
            this.Controls.Add(this.cbbilibili);
            this.Controls.Add(this.cbZhihu);
            this.Controls.Add(this.cbFanyi);
            this.Controls.Add(this.cbBing);
            this.Controls.Add(this.cbGoogle);
            this.Controls.Add(this.cbBaidu);
            this.Controls.Add(this.dioLabel2);
            this.Controls.Add(this.dioLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "搜索器 v1.0.1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dio.DioCheckBox cbGoogle;
        private Dio.DioCheckBox cbBaidu;
        private Dio.DioLabel dioLabel1;
        private Dio.DioLabel dioLabel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Dio.DioCheckBox cbBing;
        private Dio.DioCheckBox cbFanyi;
        private Dio.DioButton cbSearch;
        private Dio.DioButton btnBookMark;
        private Dio.DioCheckBox cbYandx;
        private Dio.DioCheckBox cbZhihu;
        private Dio.DioCheckBox cbbilibili;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.ListBox listBox1;
        private Dio.DioCheckBox cbBaiduHot;
        private Dio.DioCheckBox cbKmm;
    }
}

