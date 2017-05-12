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
            this.lb_prefix = new System.Windows.Forms.Label();
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
            this.pbar_total.Location = new System.Drawing.Point(14, 406);
            this.pbar_total.Name = "pbar_total";
            this.pbar_total.Size = new System.Drawing.Size(598, 23);
            this.pbar_total.TabIndex = 0;
            // 
            // lv_result
            // 
            this.lv_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_result.Location = new System.Drawing.Point(146, 39);
            this.lv_result.Name = "lv_result";
            this.lv_result.Size = new System.Drawing.Size(466, 361);
            this.lv_result.TabIndex = 1;
            this.lv_result.UseCompatibleStateImageBehavior = false;
            // 
            // bt_generate
            // 
            this.bt_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_generate.Location = new System.Drawing.Point(480, 12);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(63, 21);
            this.bt_generate.TabIndex = 2;
            this.bt_generate.Text = "generate";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_clear.Location = new System.Drawing.Point(549, 12);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(63, 21);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // tb_prefix
            // 
            this.tb_prefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_prefix.Location = new System.Drawing.Point(72, 12);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(333, 21);
            this.tb_prefix.TabIndex = 5;
            // 
            // lb_prefix
            // 
            this.lb_prefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_prefix.AutoSize = true;
            this.lb_prefix.Location = new System.Drawing.Point(12, 15);
            this.lb_prefix.Name = "lb_prefix";
            this.lb_prefix.Size = new System.Drawing.Size(41, 12);
            this.lb_prefix.TabIndex = 6;
            this.lb_prefix.Text = "Prefix";
            // 
            // bt_reset
            // 
            this.bt_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reset.Location = new System.Drawing.Point(411, 12);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(63, 21);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // num_pic_hao
            // 
            this.num_pic_hao.Location = new System.Drawing.Point(72, 39);
            this.num_pic_hao.Name = "num_pic_hao";
            this.num_pic_hao.Size = new System.Drawing.Size(68, 21);
            this.num_pic_hao.TabIndex = 12;
            // 
            // num_pic_shi
            // 
            this.num_pic_shi.Location = new System.Drawing.Point(72, 120);
            this.num_pic_shi.Name = "num_pic_shi";
            this.num_pic_shi.Size = new System.Drawing.Size(68, 21);
            this.num_pic_shi.TabIndex = 13;
            // 
            // lb_hao
            // 
            this.lb_hao.AutoSize = true;
            this.lb_hao.Location = new System.Drawing.Point(17, 41);
            this.lb_hao.Name = "lb_hao";
            this.lb_hao.Size = new System.Drawing.Size(23, 12);
            this.lb_hao.TabIndex = 8;
            this.lb_hao.Text = "Hao";
            // 
            // num_pic_danyuan
            // 
            this.num_pic_danyuan.Location = new System.Drawing.Point(72, 93);
            this.num_pic_danyuan.Name = "num_pic_danyuan";
            this.num_pic_danyuan.Size = new System.Drawing.Size(68, 21);
            this.num_pic_danyuan.TabIndex = 14;
            // 
            // lb_haolou
            // 
            this.lb_haolou.AutoSize = true;
            this.lb_haolou.Location = new System.Drawing.Point(17, 68);
            this.lb_haolou.Name = "lb_haolou";
            this.lb_haolou.Size = new System.Drawing.Size(41, 12);
            this.lb_haolou.TabIndex = 9;
            this.lb_haolou.Text = "HaoLou";
            // 
            // lb_danyuan
            // 
            this.lb_danyuan.AutoSize = true;
            this.lb_danyuan.Location = new System.Drawing.Point(17, 95);
            this.lb_danyuan.Name = "lb_danyuan";
            this.lb_danyuan.Size = new System.Drawing.Size(47, 12);
            this.lb_danyuan.TabIndex = 10;
            this.lb_danyuan.Text = "DanYuan";
            // 
            // num_pic_haolou
            // 
            this.num_pic_haolou.Location = new System.Drawing.Point(72, 66);
            this.num_pic_haolou.Name = "num_pic_haolou";
            this.num_pic_haolou.Size = new System.Drawing.Size(68, 21);
            this.num_pic_haolou.TabIndex = 15;
            // 
            // lb_shi
            // 
            this.lb_shi.AutoSize = true;
            this.lb_shi.Location = new System.Drawing.Point(17, 122);
            this.lb_shi.Name = "lb_shi";
            this.lb_shi.Size = new System.Drawing.Size(23, 12);
            this.lb_shi.TabIndex = 11;
            this.lb_shi.Text = "Shi";
            // 
            // lb_total_gen
            // 
            this.lb_total_gen.AutoSize = true;
            this.lb_total_gen.Location = new System.Drawing.Point(17, 149);
            this.lb_total_gen.Name = "lb_total_gen";
            this.lb_total_gen.Size = new System.Drawing.Size(35, 12);
            this.lb_total_gen.TabIndex = 11;
            this.lb_total_gen.Text = "Total";
            // 
            // num_pic_total_gen
            // 
            this.num_pic_total_gen.Location = new System.Drawing.Point(72, 147);
            this.num_pic_total_gen.Name = "num_pic_total_gen";
            this.num_pic_total_gen.Size = new System.Drawing.Size(68, 21);
            this.num_pic_total_gen.TabIndex = 13;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
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
            this.Controls.Add(this.lb_prefix);
            this.Controls.Add(this.tb_prefix);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.lv_result);
            this.Controls.Add(this.pbar_total);
            this.MinimumSize = new System.Drawing.Size(640, 480);
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
        private System.Windows.Forms.Label lb_prefix;
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
    }
}

