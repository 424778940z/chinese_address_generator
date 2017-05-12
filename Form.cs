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

namespace chinese_address_generator
{
    public partial class Form : System.Windows.Forms.Form
    {
        Random rdm;
        List<string> list_input_string_lu;
        List<string> list_input_string_xiaoqu;
        List<string> list_output_string;

        /*
        public event EventHandler event_refresh;
        private delegate void event_refresh_do(int curr, int total, string addr);
        */

        private void refresh(int curr, int total, string addr)
        {
            ListViewItem buf_item = new ListViewItem(curr.ToString());
            buf_item.SubItems.Add(addr);
            this.lv_result.Items.Add(buf_item);
        }

        private void load_db(string db_path)
        {
            if(File.Exists(db_path))
            {
                string buffer;
                string[] tmp_array;
                StreamReader sr = new StreamReader(db_path);
                while (!sr.EndOfStream)
                {
                    buffer = sr.ReadLine();
                    if (buffer[0] != '#')
                    {
                        tmp_array = buffer.Split(' ');
                        list_input_string_lu.Add(tmp_array[0]);
                        list_input_string_xiaoqu.Add(tmp_array[1]);
                    }
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("db.txt not found!");
                //this.Close();
                System.Environment.Exit(-1);
            }
        }
        private void refresh_pbar(int current, int total)
        {
            this.pbar_total.Maximum = total;
            this.pbar_total.Value = current;
        }

        private string gen_number(int max_bit)
        {
            string result;
            result = rdm.Next(max_bit*9).ToString();
            return result;
        }
        private string gen_lu()
        {
            return list_input_string_lu.ElementAt(rdm.Next(list_input_string_lu.Count-1));
        }
        private string gen_xiaoqu()
        {
            return list_input_string_xiaoqu.ElementAt(rdm.Next(list_input_string_xiaoqu.Count - 1));
        }

        private string gen_address(string prefix, decimal hao, decimal louhao, decimal danyuan, decimal shi)
        {
            return prefix +
                   gen_lu() + "路" +
                   gen_number(Convert.ToInt32(hao)) + "号" +
                   gen_xiaoqu() + "小区" +
                   gen_number(Convert.ToInt32(louhao)) + "号楼" +
                   gen_number(Convert.ToInt32(danyuan)) + "单元" +
                   gen_number(Convert.ToInt32(shi)) + "室";
        }

        /*
        private void _generator()
        {
            string buffer;
            StreamWriter sw = new StreamWriter("result.txt");
            for (int i = 1; i <= this.num_pic_total_gen.Value; i++)
            {
                ListViewItem buf_item = new ListViewItem(i.ToString());
                buffer = gen_address(this.tb_prefix.Text, this.num_pic_hao.Value, this.num_pic_haolou.Value, this.num_pic_danyuan.Value, this.num_pic_shi.Value);
                buf_item.SubItems.Add(buffer);
                this.lv_result.Items.Add(buf_item);
                sw.WriteLine(buffer);
                refresh_pbar(i, Convert.ToInt32(this.num_pic_total_gen.Value));
            }
            sw.Close();
        }
        */

        public Form()
        {
            InitializeComponent();

            this.Text = "Chinese Address Generator" + " Version 0.1";

            this.lv_result.View = View.Details;
            this.lv_result.Columns.Add("Number");
            this.lv_result.Columns.Add("Address");
            
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

            rdm = new Random();
            list_input_string_lu = new List<string>();
            list_input_string_xiaoqu = new List<string>();
            list_output_string = new List<string>();

            load_db("db.txt");
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            this.tb_prefix.Clear();
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
            string buffer;
            StreamWriter sw = new StreamWriter("result.txt");
            for(int i = 1; i <= this.num_pic_total_gen.Value; i++)
            {
                ListViewItem buf_item = new ListViewItem(i.ToString());
                buffer = gen_address(this.tb_prefix.Text, this.num_pic_hao.Value, this.num_pic_haolou.Value, this.num_pic_danyuan.Value, this.num_pic_shi.Value);
                buf_item.SubItems.Add(buffer);
                this.lv_result.Items.Add(buf_item);
                sw.WriteLine(buffer);
                refresh_pbar(i, Convert.ToInt32(this.num_pic_total_gen.Value));
            }
            sw.Close();
            this.lv_result.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}
