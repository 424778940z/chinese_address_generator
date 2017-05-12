namespace chinese_address_generator
{
    partial class Form
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
            this.pbar_total = new System.Windows.Forms.ProgressBar();
            this.lv_result = new System.Windows.Forms.ListView();
            this.bt_generate = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.num_pic_hao = new System.Windows.Forms.NumericUpDown();
            this.num_pic_shi = new System.Windows.Forms.NumericUpDown();
            this.lb_hao = new System.Windows.Forms.Label();
            this.num_pic_danyuan = new System.Windows.Forms.NumericUpDown();
            this.lb_haolou = new System.Windows.Forms.Label();
            this.lb_danyuan = new System.Windows.Forms.Label();
            this.num_pic_haolou = new System.Windows.Forms.NumericUpDown();
            this.lb_shi = new System.Windows.Forms.Label();
            this.lb_total_gen = new System.Windows.Forms.Label();
            this.num_pic_total_gen = new System.Windows.Forms.NumericUpDown();
            this.tb_db_province = new System.Windows.Forms.TextBox();
            this.tb_db_city = new System.Windows.Forms.TextBox();
            this.tb_db_road = new System.Windows.Forms.TextBox();
            this.bt_sel_db_province = new System.Windows.Forms.Button();
            this.bt_sel_db_city = new System.Windows.Forms.Button();
            this.bt_sel_db_road = new System.Windows.Forms.Button();
            this.bt_sel_db_community = new System.Windows.Forms.Button();
            this.tb_db_community = new System.Windows.Forms.TextBox();
            this.bt_sel_db_all_default = new System.Windows.Forms.Button();
            this.cb_prefix = new System.Windows.Forms.CheckBox();
            this.cb_province = new System.Windows.Forms.CheckBox();
            this.cb_city = new System.Windows.Forms.CheckBox();
            this.cb_road = new System.Windows.Forms.CheckBox();
            this.cb_community = new System.Windows.Forms.CheckBox();
            this.bt_about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_hao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_shi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_danyuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_haolou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_total_gen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbar_total
            // 
            this.pbar_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbar_total.Location = new System.Drawing.Point(12, 406);
            this.pbar_total.Name = "pbar_total";
            this.pbar_total.Size = new System.Drawing.Size(785, 23);
            this.pbar_total.TabIndex = 0;
            // 
            // lv_result
            // 
            this.lv_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_result.Location = new System.Drawing.Point(12, 145);
            this.lv_result.Name = "lv_result";
            this.lv_result.Size = new System.Drawing.Size(785, 255);
            this.lv_result.TabIndex = 1;
            this.lv_result.UseCompatibleStateImageBehavior = false;
            // 
            // bt_generate
            // 
            this.bt_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_generate.Location = new System.Drawing.Point(734, 62);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(63, 21);
            this.bt_generate.TabIndex = 2;
            this.bt_generate.Text = "Generate";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_clear.Location = new System.Drawing.Point(734, 89);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(63, 21);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // tb_prefix
            // 
            this.tb_prefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_prefix.Location = new System.Drawing.Point(78, 10);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(249, 21);
            this.tb_prefix.TabIndex = 5;
            // 
            // bt_reset
            // 
            this.bt_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reset.Location = new System.Drawing.Point(734, 37);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(63, 21);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // num_pic_hao
            // 
            this.num_pic_hao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_pic_hao.Location = new System.Drawing.Point(456, 91);
            this.num_pic_hao.Name = "num_pic_hao";
            this.num_pic_hao.Size = new System.Drawing.Size(68, 21);
            this.num_pic_hao.TabIndex = 12;
            // 
            // num_pic_shi
            // 
            this.num_pic_shi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_pic_shi.Location = new System.Drawing.Point(727, 117);
            this.num_pic_shi.Name = "num_pic_shi";
            this.num_pic_shi.Size = new System.Drawing.Size(68, 21);
            this.num_pic_shi.TabIndex = 13;
            // 
            // lb_hao
            // 
            this.lb_hao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_hao.AutoSize = true;
            this.lb_hao.Location = new System.Drawing.Point(402, 95);
            this.lb_hao.Name = "lb_hao";
            this.lb_hao.Size = new System.Drawing.Size(23, 12);
            this.lb_hao.TabIndex = 8;
            this.lb_hao.Text = "Hao";
            // 
            // num_pic_danyuan
            // 
            this.num_pic_danyuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_pic_danyuan.Location = new System.Drawing.Point(587, 118);
            this.num_pic_danyuan.Name = "num_pic_danyuan";
            this.num_pic_danyuan.Size = new System.Drawing.Size(68, 21);
            this.num_pic_danyuan.TabIndex = 14;
            // 
            // lb_haolou
            // 
            this.lb_haolou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_haolou.AutoSize = true;
            this.lb_haolou.Location = new System.Drawing.Point(402, 121);
            this.lb_haolou.Name = "lb_haolou";
            this.lb_haolou.Size = new System.Drawing.Size(41, 12);
            this.lb_haolou.TabIndex = 9;
            this.lb_haolou.Text = "HaoLou";
            // 
            // lb_danyuan
            // 
            this.lb_danyuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_danyuan.AutoSize = true;
            this.lb_danyuan.Location = new System.Drawing.Point(532, 120);
            this.lb_danyuan.Name = "lb_danyuan";
            this.lb_danyuan.Size = new System.Drawing.Size(47, 12);
            this.lb_danyuan.TabIndex = 10;
            this.lb_danyuan.Text = "DanYuan";
            // 
            // num_pic_haolou
            // 
            this.num_pic_haolou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_pic_haolou.Location = new System.Drawing.Point(456, 117);
            this.num_pic_haolou.Name = "num_pic_haolou";
            this.num_pic_haolou.Size = new System.Drawing.Size(68, 21);
            this.num_pic_haolou.TabIndex = 15;
            // 
            // lb_shi
            // 
            this.lb_shi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_shi.AutoSize = true;
            this.lb_shi.Location = new System.Drawing.Point(672, 119);
            this.lb_shi.Name = "lb_shi";
            this.lb_shi.Size = new System.Drawing.Size(23, 12);
            this.lb_shi.TabIndex = 11;
            this.lb_shi.Text = "Shi";
            // 
            // lb_total_gen
            // 
            this.lb_total_gen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_total_gen.AutoSize = true;
            this.lb_total_gen.Location = new System.Drawing.Point(605, 64);
            this.lb_total_gen.Name = "lb_total_gen";
            this.lb_total_gen.Size = new System.Drawing.Size(35, 12);
            this.lb_total_gen.TabIndex = 11;
            this.lb_total_gen.Text = "Total";
            // 
            // num_pic_total_gen
            // 
            this.num_pic_total_gen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_pic_total_gen.Location = new System.Drawing.Point(660, 62);
            this.num_pic_total_gen.Name = "num_pic_total_gen";
            this.num_pic_total_gen.Size = new System.Drawing.Size(68, 21);
            this.num_pic_total_gen.TabIndex = 13;
            // 
            // tb_db_province
            // 
            this.tb_db_province.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_db_province.Location = new System.Drawing.Point(78, 37);
            this.tb_db_province.Name = "tb_db_province";
            this.tb_db_province.Size = new System.Drawing.Size(249, 21);
            this.tb_db_province.TabIndex = 5;
            // 
            // tb_db_city
            // 
            this.tb_db_city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_db_city.Location = new System.Drawing.Point(78, 64);
            this.tb_db_city.Name = "tb_db_city";
            this.tb_db_city.Size = new System.Drawing.Size(249, 21);
            this.tb_db_city.TabIndex = 5;
            // 
            // tb_db_road
            // 
            this.tb_db_road.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_db_road.Location = new System.Drawing.Point(78, 91);
            this.tb_db_road.Name = "tb_db_road";
            this.tb_db_road.Size = new System.Drawing.Size(249, 21);
            this.tb_db_road.TabIndex = 5;
            // 
            // bt_sel_db_province
            // 
            this.bt_sel_db_province.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sel_db_province.Location = new System.Drawing.Point(333, 36);
            this.bt_sel_db_province.Name = "bt_sel_db_province";
            this.bt_sel_db_province.Size = new System.Drawing.Size(63, 21);
            this.bt_sel_db_province.TabIndex = 2;
            this.bt_sel_db_province.Text = "Select";
            this.bt_sel_db_province.UseVisualStyleBackColor = true;
            this.bt_sel_db_province.Click += new System.EventHandler(this.bt_sel_db_province_Click);
            // 
            // bt_sel_db_city
            // 
            this.bt_sel_db_city.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sel_db_city.Location = new System.Drawing.Point(333, 64);
            this.bt_sel_db_city.Name = "bt_sel_db_city";
            this.bt_sel_db_city.Size = new System.Drawing.Size(63, 21);
            this.bt_sel_db_city.TabIndex = 2;
            this.bt_sel_db_city.Text = "Select";
            this.bt_sel_db_city.UseVisualStyleBackColor = true;
            this.bt_sel_db_city.Click += new System.EventHandler(this.bt_sel_db_city_Click);
            // 
            // bt_sel_db_road
            // 
            this.bt_sel_db_road.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sel_db_road.Location = new System.Drawing.Point(333, 91);
            this.bt_sel_db_road.Name = "bt_sel_db_road";
            this.bt_sel_db_road.Size = new System.Drawing.Size(63, 21);
            this.bt_sel_db_road.TabIndex = 2;
            this.bt_sel_db_road.Text = "Select";
            this.bt_sel_db_road.UseVisualStyleBackColor = true;
            this.bt_sel_db_road.Click += new System.EventHandler(this.bt_sel_db_road_Click);
            // 
            // bt_sel_db_community
            // 
            this.bt_sel_db_community.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sel_db_community.Location = new System.Drawing.Point(333, 117);
            this.bt_sel_db_community.Name = "bt_sel_db_community";
            this.bt_sel_db_community.Size = new System.Drawing.Size(63, 21);
            this.bt_sel_db_community.TabIndex = 2;
            this.bt_sel_db_community.Text = "Select";
            this.bt_sel_db_community.UseVisualStyleBackColor = true;
            this.bt_sel_db_community.Click += new System.EventHandler(this.bt_sel_db_community_Click);
            // 
            // tb_db_community
            // 
            this.tb_db_community.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_db_community.Location = new System.Drawing.Point(78, 118);
            this.tb_db_community.Name = "tb_db_community";
            this.tb_db_community.Size = new System.Drawing.Size(249, 21);
            this.tb_db_community.TabIndex = 5;
            // 
            // bt_sel_db_all_default
            // 
            this.bt_sel_db_all_default.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sel_db_all_default.Location = new System.Drawing.Point(734, 10);
            this.bt_sel_db_all_default.Name = "bt_sel_db_all_default";
            this.bt_sel_db_all_default.Size = new System.Drawing.Size(63, 21);
            this.bt_sel_db_all_default.TabIndex = 2;
            this.bt_sel_db_all_default.Text = "Default";
            this.bt_sel_db_all_default.UseVisualStyleBackColor = true;
            this.bt_sel_db_all_default.Click += new System.EventHandler(this.bt_sel_db_all_default_Click);
            // 
            // cb_prefix
            // 
            this.cb_prefix.AutoSize = true;
            this.cb_prefix.Location = new System.Drawing.Point(12, 12);
            this.cb_prefix.Name = "cb_prefix";
            this.cb_prefix.Size = new System.Drawing.Size(60, 16);
            this.cb_prefix.TabIndex = 19;
            this.cb_prefix.Text = "Prefix";
            this.cb_prefix.UseVisualStyleBackColor = true;
            this.cb_prefix.CheckedChanged += new System.EventHandler(this.cb_prefix_CheckedChanged);
            // 
            // cb_province
            // 
            this.cb_province.AutoSize = true;
            this.cb_province.Location = new System.Drawing.Point(12, 39);
            this.cb_province.Name = "cb_province";
            this.cb_province.Size = new System.Drawing.Size(54, 16);
            this.cb_province.TabIndex = 19;
            this.cb_province.Text = "Sheng";
            this.cb_province.UseVisualStyleBackColor = true;
            this.cb_province.CheckedChanged += new System.EventHandler(this.cb_province_CheckedChanged);
            // 
            // cb_city
            // 
            this.cb_city.AutoSize = true;
            this.cb_city.Location = new System.Drawing.Point(12, 67);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(42, 16);
            this.cb_city.TabIndex = 19;
            this.cb_city.Text = "Shi";
            this.cb_city.UseVisualStyleBackColor = true;
            this.cb_city.CheckedChanged += new System.EventHandler(this.cb_city_CheckedChanged);
            // 
            // cb_road
            // 
            this.cb_road.AutoSize = true;
            this.cb_road.Location = new System.Drawing.Point(12, 94);
            this.cb_road.Name = "cb_road";
            this.cb_road.Size = new System.Drawing.Size(36, 16);
            this.cb_road.TabIndex = 19;
            this.cb_road.Text = "Lu";
            this.cb_road.UseVisualStyleBackColor = true;
            this.cb_road.CheckedChanged += new System.EventHandler(this.cb_road_CheckedChanged);
            // 
            // cb_community
            // 
            this.cb_community.AutoSize = true;
            this.cb_community.Location = new System.Drawing.Point(12, 120);
            this.cb_community.Name = "cb_community";
            this.cb_community.Size = new System.Drawing.Size(60, 16);
            this.cb_community.TabIndex = 19;
            this.cb_community.Text = "XiaoQu";
            this.cb_community.UseVisualStyleBackColor = true;
            this.cb_community.CheckedChanged += new System.EventHandler(this.cb_community_CheckedChanged);
            // 
            // bt_about
            // 
            this.bt_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_about.Location = new System.Drawing.Point(665, 10);
            this.bt_about.Name = "bt_about";
            this.bt_about.Size = new System.Drawing.Size(63, 21);
            this.bt_about.TabIndex = 2;
            this.bt_about.Text = "About";
            this.bt_about.UseVisualStyleBackColor = true;
            this.bt_about.Click += new System.EventHandler(this.bt_about_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 441);
            this.Controls.Add(this.cb_community);
            this.Controls.Add(this.cb_road);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.cb_province);
            this.Controls.Add(this.cb_prefix);
            this.Controls.Add(this.num_pic_hao);
            this.Controls.Add(this.num_pic_total_gen);
            this.Controls.Add(this.num_pic_shi);
            this.Controls.Add(this.lb_hao);
            this.Controls.Add(this.num_pic_danyuan);
            this.Controls.Add(this.lb_haolou);
            this.Controls.Add(this.lb_danyuan);
            this.Controls.Add(this.lb_total_gen);
            this.Controls.Add(this.num_pic_haolou);
            this.Controls.Add(this.lb_shi);
            this.Controls.Add(this.tb_db_community);
            this.Controls.Add(this.tb_db_road);
            this.Controls.Add(this.tb_db_city);
            this.Controls.Add(this.tb_db_province);
            this.Controls.Add(this.tb_prefix);
            this.Controls.Add(this.bt_sel_db_community);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_sel_db_road);
            this.Controls.Add(this.bt_sel_db_city);
            this.Controls.Add(this.bt_sel_db_province);
            this.Controls.Add(this.bt_about);
            this.Controls.Add(this.bt_sel_db_all_default);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.lv_result);
            this.Controls.Add(this.pbar_total);
            this.MinimumSize = new System.Drawing.Size(825, 480);
            this.Name = "Form";
            this.Text = "Chinese Address Generator";
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_hao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_shi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_danyuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_haolou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pic_total_gen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbar_total;
        private System.Windows.Forms.ListView lv_result;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.NumericUpDown num_pic_hao;
        private System.Windows.Forms.NumericUpDown num_pic_shi;
        private System.Windows.Forms.Label lb_hao;
        private System.Windows.Forms.NumericUpDown num_pic_danyuan;
        private System.Windows.Forms.Label lb_haolou;
        private System.Windows.Forms.Label lb_danyuan;
        private System.Windows.Forms.NumericUpDown num_pic_haolou;
        private System.Windows.Forms.Label lb_shi;
        private System.Windows.Forms.Label lb_total_gen;
        private System.Windows.Forms.NumericUpDown num_pic_total_gen;
        private System.Windows.Forms.TextBox tb_db_province;
        private System.Windows.Forms.TextBox tb_db_city;
        private System.Windows.Forms.TextBox tb_db_road;
        private System.Windows.Forms.Button bt_sel_db_province;
        private System.Windows.Forms.Button bt_sel_db_city;
        private System.Windows.Forms.Button bt_sel_db_road;
        private System.Windows.Forms.Button bt_sel_db_community;
        private System.Windows.Forms.TextBox tb_db_community;
        private System.Windows.Forms.Button bt_sel_db_all_default;
        private System.Windows.Forms.CheckBox cb_prefix;
        private System.Windows.Forms.CheckBox cb_province;
        private System.Windows.Forms.CheckBox cb_city;
        private System.Windows.Forms.CheckBox cb_road;
        private System.Windows.Forms.CheckBox cb_community;
        private System.Windows.Forms.Button bt_about;
    }
}

