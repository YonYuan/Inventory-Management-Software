namespace WinFormsMarket2
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.储存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.统计前三ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计当前仓库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelmain = new System.Windows.Forms.Label();
            this.labelpath = new System.Windows.Forms.Label();
            this.textIn = new System.Windows.Forms.TextBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.储存ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.打开ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 储存ToolStripMenuItem
            // 
            this.储存ToolStripMenuItem.Name = "储存ToolStripMenuItem";
            this.储存ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.储存ToolStripMenuItem.Text = "储存";
            this.储存ToolStripMenuItem.Click += new System.EventHandler(this.储存ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仓库ToolStripMenuItem,
            this.货架ToolStripMenuItem,
            this.商品ToolStripMenuItem,
            this.统计前三ToolStripMenuItem,
            this.统计当前仓库ToolStripMenuItem,
            this.出库ToolStripMenuItem,
            this.入库ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 仓库ToolStripMenuItem
            // 
            this.仓库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.查询ToolStripMenuItem});
            this.仓库ToolStripMenuItem.Name = "仓库ToolStripMenuItem";
            this.仓库ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.仓库ToolStripMenuItem.Text = "仓库";
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.增加ToolStripMenuItem.Text = "增加";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 货架ToolStripMenuItem
            // 
            this.货架ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem1,
            this.删除ToolStripMenuItem1,
            this.查找ToolStripMenuItem,
            this.修改ToolStripMenuItem1});
            this.货架ToolStripMenuItem.Name = "货架ToolStripMenuItem";
            this.货架ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.货架ToolStripMenuItem.Text = "货架";
            // 
            // 增加ToolStripMenuItem1
            // 
            this.增加ToolStripMenuItem1.Name = "增加ToolStripMenuItem1";
            this.增加ToolStripMenuItem1.Size = new System.Drawing.Size(128, 30);
            this.增加ToolStripMenuItem1.Text = "增加";
            this.增加ToolStripMenuItem1.Click += new System.EventHandler(this.增加ToolStripMenuItem1_Click);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(128, 30);
            this.删除ToolStripMenuItem1.Text = "删除";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem1_Click);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.查找ToolStripMenuItem.Text = "查找";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem1
            // 
            this.修改ToolStripMenuItem1.Name = "修改ToolStripMenuItem1";
            this.修改ToolStripMenuItem1.Size = new System.Drawing.Size(128, 30);
            this.修改ToolStripMenuItem1.Text = "修改";
            this.修改ToolStripMenuItem1.Click += new System.EventHandler(this.修改ToolStripMenuItem1_Click);
            // 
            // 商品ToolStripMenuItem
            // 
            this.商品ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem2,
            this.删除ToolStripMenuItem2,
            this.查找ToolStripMenuItem1,
            this.修改ToolStripMenuItem2});
            this.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
            this.商品ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.商品ToolStripMenuItem.Text = "商品";
            // 
            // 增加ToolStripMenuItem2
            // 
            this.增加ToolStripMenuItem2.Name = "增加ToolStripMenuItem2";
            this.增加ToolStripMenuItem2.Size = new System.Drawing.Size(128, 30);
            this.增加ToolStripMenuItem2.Text = "增加";
            this.增加ToolStripMenuItem2.Click += new System.EventHandler(this.增加ToolStripMenuItem2_Click);
            // 
            // 删除ToolStripMenuItem2
            // 
            this.删除ToolStripMenuItem2.Name = "删除ToolStripMenuItem2";
            this.删除ToolStripMenuItem2.Size = new System.Drawing.Size(128, 30);
            this.删除ToolStripMenuItem2.Text = "删除";
            this.删除ToolStripMenuItem2.Click += new System.EventHandler(this.删除ToolStripMenuItem2_Click);
            // 
            // 查找ToolStripMenuItem1
            // 
            this.查找ToolStripMenuItem1.Name = "查找ToolStripMenuItem1";
            this.查找ToolStripMenuItem1.Size = new System.Drawing.Size(128, 30);
            this.查找ToolStripMenuItem1.Text = "查找";
            this.查找ToolStripMenuItem1.Click += new System.EventHandler(this.查找ToolStripMenuItem1_Click);
            // 
            // 修改ToolStripMenuItem2
            // 
            this.修改ToolStripMenuItem2.Name = "修改ToolStripMenuItem2";
            this.修改ToolStripMenuItem2.Size = new System.Drawing.Size(128, 30);
            this.修改ToolStripMenuItem2.Text = "修改";
            this.修改ToolStripMenuItem2.Click += new System.EventHandler(this.修改ToolStripMenuItem2_Click);
            // 
            // 统计前三ToolStripMenuItem
            // 
            this.统计前三ToolStripMenuItem.Name = "统计前三ToolStripMenuItem";
            this.统计前三ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.统计前三ToolStripMenuItem.Text = "统计前三";
            this.统计前三ToolStripMenuItem.Click += new System.EventHandler(this.统计前三ToolStripMenuItem_Click);
            // 
            // 统计当前仓库ToolStripMenuItem
            // 
            this.统计当前仓库ToolStripMenuItem.Name = "统计当前仓库ToolStripMenuItem";
            this.统计当前仓库ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.统计当前仓库ToolStripMenuItem.Text = "统计当前仓库";
            this.统计当前仓库ToolStripMenuItem.Click += new System.EventHandler(this.统计当前仓库ToolStripMenuItem_Click);
            // 
            // 出库ToolStripMenuItem
            // 
            this.出库ToolStripMenuItem.Name = "出库ToolStripMenuItem";
            this.出库ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.出库ToolStripMenuItem.Text = "出库";
            this.出库ToolStripMenuItem.Click += new System.EventHandler(this.出库ToolStripMenuItem_Click);
            // 
            // 入库ToolStripMenuItem
            // 
            this.入库ToolStripMenuItem.Name = "入库ToolStripMenuItem";
            this.入库ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.入库ToolStripMenuItem.Text = "入库";
            this.入库ToolStripMenuItem.Click += new System.EventHandler(this.入库ToolStripMenuItem_Click);
            // 
            // labelmain
            // 
            this.labelmain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelmain.Location = new System.Drawing.Point(13, 87);
            this.labelmain.Name = "labelmain";
            this.labelmain.Size = new System.Drawing.Size(775, 375);
            this.labelmain.TabIndex = 1;
            this.labelmain.Text = "窗口";
            // 
            // labelpath
            // 
            this.labelpath.AutoSize = true;
            this.labelpath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelpath.Location = new System.Drawing.Point(10, 51);
            this.labelpath.Name = "labelpath";
            this.labelpath.Size = new System.Drawing.Size(80, 18);
            this.labelpath.TabIndex = 2;
            this.labelpath.Text = "仓库目录";
            // 
            // textIn
            // 
            this.textIn.Location = new System.Drawing.Point(12, 480);
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(636, 28);
            this.textIn.TabIndex = 3;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(654, 477);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(134, 36);
            this.bSubmit.TabIndex = 4;
            this.bSubmit.Text = "提交(Enter)";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(654, 42);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(133, 36);
            this.bBack.TabIndex = 5;
            this.bBack.Text = "上一级(Back)";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(654, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.labelpath);
            this.Controls.Add(this.labelmain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 储存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.Label labelmain;
        private System.Windows.Forms.ToolStripMenuItem 仓库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.Label labelpath;
        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.ToolStripMenuItem 货架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 统计前三ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计当前仓库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

