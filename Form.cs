using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace chinese_address_generator
{
    public partial class Form : System.Windows.Forms.Form
    {
        Random rdm;
        List<string> list_input_string_province;
        List<string> list_input_string_city;
        List<string> list_input_string_road;
        List<string> list_input_string_community;
        List<string> list_output_string;
        OpenFileDialog file_dlg;

        private void load_db(string db_path,List<string> list, bool popup)
        {
            if(File.Exists(db_path))
            {
                StreamReader sr = new StreamReader(db_path);
                while (!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
                sr.Close();
            }
            else
            {
                if(popup)
                {
                    MessageBox.Show(db_path + " not found!");
                }
            }
        }
        private void load_db_selected()
        {
            if(this.cb_province.Checked)
            {
                load_db(this.tb_db_province.Text, list_input_string_province, true);
            }
            if(this.cb_city.Checked)
            {
                load_db(this.tb_db_city.Text, list_input_string_city, true);
            }
            if(this.cb_road.Checked)
            {
                load_db(this.tb_db_road.Text, list_input_string_road, true);
            }
            if(this.cb_community.Checked)
            {
                load_db(this.tb_db_community.Text, list_input_string_community, true);
            }
        }
        private void refresh_pbar(int current, int total)
        {
            this.pbar_total.Maximum = total;
            this.pbar_total.Value = current;
        }
        public void refresh(int curr, int total, string addr)
        {
            refresh_pbar(curr, total);
            ListViewItem buf_item = new ListViewItem(curr.ToString());
            buf_item.SubItems.Add(addr);
            buf_item.EnsureVisible();
            this.lv_result.Items.Add(buf_item);
            lv_result.Items[lv_result.Items.Count - 1].EnsureVisible();
        }

        private string gen_number(int max_bit)
        {
            string result;
            result = rdm.Next(1,max_bit*9).ToString();
            return result;
        }
        private string gen_from_db(List<string> list_db)
        {
            if(list_db.Count != 0)
            {
                return list_db.ElementAt(rdm.Next(list_db.Count - 1));
            }
            else
            {
                return "DB_EMPTY";
            }
        }
        private string gen_province()
        {
            return gen_from_db(list_input_string_province);
        }
        private string gen_city()
        {
            return gen_from_db(list_input_string_city);
        }
        private string gen_road()
        {
            //return gen_from_db(list_input_string_road) + "路";
            return gen_from_db(list_input_string_road);
        }
        private string gen_road_number(decimal hao)
        {
            return gen_number(Convert.ToInt32(hao)) + "号";
        }
        private string gen_community()
        {
            //return gen_from_db(list_input_string_community) + "小区";
            return gen_from_db(list_input_string_community);
        }
        private string gen_building_number(decimal louhao)
        {
            return gen_number(Convert.ToInt32(louhao)) + "号楼";
        }
        private string gen_unit_number(decimal danyuan)
        {
            return gen_number(Convert.ToInt32(danyuan)) + "单元";
        }
        private string gen_room_number(decimal shi)
        {
            return gen_number(Convert.ToInt32(shi)) + "室";
        }

        private string gen_address(string prefix, decimal hao, decimal louhao, decimal danyuan, decimal shi)
        {
            string buffer = "";
            if(this.cb_prefix.Checked)
            {
                buffer += prefix;
            }
            if (this.cb_province.Checked)
            {
                buffer += gen_province();
            }
            if (this.cb_city.Checked)
            {
                buffer += gen_city();
            }
            if (this.cb_road.Checked)
            {
                buffer += gen_road();
                buffer += gen_road_number(hao);
            }
            if (this.cb_community.Checked)
            {
                buffer += gen_community();
                buffer += gen_building_number(louhao);
                buffer += gen_unit_number(danyuan);
                buffer += gen_room_number(shi);
            }
            return buffer;
        }

        private string prefix;
        private decimal hao;
        private decimal haolou;
        private decimal danyuan;
        private decimal shi;
        private void _generator()
        {
            this.Enabled = false;
            string buffer;
            StreamWriter sw = new StreamWriter("result.txt");
            for (int i = 1; i <= this.num_pic_total_gen.Value; i++)
            {
                ListViewItem buf_item = new ListViewItem(i.ToString());
                buffer = gen_address(prefix,hao,haolou,danyuan,shi);
                sw.WriteLine(buffer);
                refresh(i, Convert.ToInt32(this.num_pic_total_gen.Value), buffer);
                this.lv_result.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            sw.Close();
            this.Enabled = true;
        }

        public Form()
        {
            InitializeComponent();

            //I know what I'm doing, no more stupid Microsoft call-recall endless events
            Control.CheckForIllegalCrossThreadCalls = false;

            this.Text = "Chinese Address Generator" + " Version 0.61";
            
            this.lv_result.View = View.Details;
            this.lv_result.Columns.Add("Number");
            this.lv_result.Columns.Add("Address");
            this.lv_result.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            this.num_pic_hao.Minimum = 1;
            this.num_pic_haolou.Minimum = 1;
            this.num_pic_danyuan.Minimum = 1;
            this.num_pic_shi.Minimum = 1;
            this.num_pic_total_gen.Minimum = 1;

            this.num_pic_hao.Maximum = int.MaxValue;
            this.num_pic_haolou.Maximum = int.MaxValue;
            this.num_pic_danyuan.Maximum = int.MaxValue;
            this.num_pic_shi.Maximum = int.MaxValue;
            this.num_pic_total_gen.Maximum = int.MaxValue;

            cb_prefix.Checked = true;
            cb_province.Checked = true;
            cb_city.Checked = true;
            cb_road.Checked = true;
            cb_community.Checked = true;

            rdm = new Random();
            list_input_string_province = new List<string>();
            list_input_string_city = new List<string>();
            list_input_string_road = new List<string>();
            list_input_string_community = new List<string>();
            list_output_string = new List<string>();
            file_dlg = new OpenFileDialog();
            file_dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            file_dlg.InitialDirectory = ".";
        }


        private void bt_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By 424778940");
        }

        private void bt_sel_db_all_default_Click(object sender, EventArgs e)
        {
            this.tb_db_province.Text = "db_province.txt";
            this.tb_db_city.Text = "db_city.txt";
            this.tb_db_road.Text = "db_road.txt";
            this.tb_db_community.Text = "db_community.txt";
            load_db_selected();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            this.tb_prefix.Clear();
            this.tb_db_province.Clear();
            this.tb_db_city.Clear();
            this.tb_db_road.Clear();
            this.tb_db_community.Clear();
            this.num_pic_hao.Value = 1;
            this.num_pic_haolou.Value = 1;
            this.num_pic_danyuan.Value = 1;
            this.num_pic_shi.Value = 1;
            this.num_pic_total_gen.Value = 1;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            this.lv_result.Items.Clear();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            this.lv_result.Items.Clear();
            prefix = this.tb_prefix.Text;
            hao = this.num_pic_hao.Value;
            haolou = this.num_pic_haolou.Value;
            danyuan = this.num_pic_danyuan.Value;
            shi = this.num_pic_shi.Value;
            Thread th = new Thread(_generator);
            th.Start();
        }

        private void cb_prefix_CheckedChanged(object sender, EventArgs e)
        {
            this.tb_prefix.Enabled = cb_prefix.Checked;
        }
        private void cb_province_CheckedChanged(object sender, EventArgs e)
        {
            this.tb_db_province.Enabled = cb_province.Checked;
            this.bt_sel_db_province.Enabled = cb_province.Checked;
        }
        private void cb_city_CheckedChanged(object sender, EventArgs e)
        {
            this.tb_db_city.Enabled = cb_city.Checked;
            this.bt_sel_db_city.Enabled = cb_city.Checked;
        }
        private void cb_road_CheckedChanged(object sender, EventArgs e)
        {
            this.tb_db_road.Enabled = cb_road.Checked;
            this.bt_sel_db_road.Enabled = cb_road.Checked;
            this.num_pic_hao.Enabled = cb_road.Checked;
        }
        private void cb_community_CheckedChanged(object sender, EventArgs e)
        {
            this.tb_db_community.Enabled = cb_community.Checked;
            this.bt_sel_db_community.Enabled = cb_community.Checked;
            this.num_pic_haolou.Enabled = cb_community.Checked;
            this.num_pic_danyuan.Enabled = cb_community.Checked;
            this.num_pic_shi.Enabled = cb_community.Checked;
        }

        private void bt_sel_db_province_Click(object sender, EventArgs e)
        {
            if(file_dlg.ShowDialog() == DialogResult.OK)
            {
                this.tb_db_province.Text = file_dlg.FileName;
                load_db(this.tb_db_province.Text, list_input_string_province, true);
            }
        }
        private void bt_sel_db_city_Click(object sender, EventArgs e)
        {
            if (file_dlg.ShowDialog() == DialogResult.OK)
            {
                this.tb_db_city.Text = file_dlg.FileName;
                load_db(this.tb_db_city.Text, list_input_string_city, true);
            }
        }
        private void bt_sel_db_road_Click(object sender, EventArgs e)
        {
            if (file_dlg.ShowDialog() == DialogResult.OK)
            {
                this.tb_db_road.Text = file_dlg.FileName;
                load_db(this.tb_db_road.Text, list_input_string_road, true);
            }
        }
        private void bt_sel_db_community_Click(object sender, EventArgs e)
        {
            if (file_dlg.ShowDialog() == DialogResult.OK)
            {
                this.tb_db_community.Text = file_dlg.FileName;
                load_db(this.tb_db_community.Text, list_input_string_community, true);
            }
        }
    }
}
