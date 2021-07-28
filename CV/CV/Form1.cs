using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace CV
{
    public partial class Form1 : Form
    {
        CGlobalKeyboardHook hooker = new CGlobalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
        }

        int stack = 0;
        int delay_input = 400;

        private void Start_Click(object sender, EventArgs e)
        {
            if (listBox1.Enabled == false)
            {
                listBox1.BackColor = Color.FromArgb(250, 250, 250);
                listBox1.Enabled = true;
                Del.Enabled = true;
                Delay_Box.Enabled = false;
                Set_Delay.Enabled = false;
                Start.Text = "실행중...";
                hooker.hook();
                hooker.KeyDown += hooker_KeyDown;
            }
            else
            {
                listBox1.BackColor = Color.FromArgb(240, 240, 240);
                listBox1.Enabled = false;
                Del.Enabled = false;
                Delay_Box.Enabled = true;
                Set_Delay.Enabled = true;
                Start.Text = "시작";
                hooker.unhook();
                hooker.KeyDown -= hooker_KeyDown;
            }
        }
        private void hooker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                if(int.Parse(stack_show.Text) >= 10)
                {
                    MessageBox.Show("꽉 찼어.\n필요없는거 삭제 해");
                    return;
                }
                Thread.Sleep(delay_input);
                string temp = Clipboard.GetText();
                listBox1.Items.Add(temp);
                stack++;
                stack_show.Text = stack.ToString();
            }
            string input = e.KeyCode.ToString();
            
            int temp22 = e.KeyValue;
            switch (input)
            {
                case "D1":
                    if (e.KeyCode == Keys.D1)
                    {
                        if (stack == 0)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) +"번은 비어있어");

                            SendKeys.Send("{BS}");
                            return;
                        } //
                        Clipboard.SetText(listBox1.Items[0].ToString()); // 배열 이미 빼버렸음 필요 없으니까 이 부분을 인덱스접근으로 바꿔
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;
                case "D2":
                    if (e.KeyCode == Keys.D2)
                    {
                        if (stack < 2)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[1].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;

                case "D3":
                    if (e.KeyCode == Keys.D3)
                    {
                        if (stack < 3)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[2].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;

                case "D4":
                    if (e.KeyCode == Keys.D4)
                    {
                        if (stack < 4)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[3].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;

                case "D5":
                    if (e.KeyCode == Keys.D5)
                    {
                        if (stack < 5)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[4].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;

                case "D6":
                    if (e.KeyCode == Keys.D6)
                    {
                        if (stack < 6)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[5].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;

                case "D7":
                    if (e.KeyCode == Keys.D7)
                    {
                        if (stack < 7)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[6].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;

                case "D8":
                    if (e.KeyCode == Keys.D8)
                    {
                        if (stack < 8)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[7].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;

                case "D9":
                    if (e.KeyCode == Keys.D9)
                    {
                        if (stack < 9)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[8].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;

                case "D0":
                    if (e.KeyCode == Keys.D0)
                    {
                        if (stack < 10)
                        {
                            MessageBox.Show(new Form { TopMost = true }, (stack + 1) + "번은 비어있어");
                            return;
                        }
                        Clipboard.SetText(listBox1.Items[9].ToString());
                        SendKeys.Send("^{v}");
                        Thread.Sleep(delay_input);
                        SendKeys.Send("{BS}");
                    }
                    break;
            }
        }
        private void Del_Click(object sender, EventArgs e)
        {
            string delete = "";
            if(stack == 0)
            {
                MessageBox.Show("삭제할 텍스트가 없어");
                return;
            }
            if ((listBox1.SelectedItem) != null)
            {
              delete = listBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("선택 안했어");
                return;
            }
            listBox1.Items.Remove(delete); 
             stack--;
            stack_show.Text = stack.ToString();
            Thread.Sleep(delay_input);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double opa = (trackBar1.Value + 1) * 0.1;
            if(opa > 1)
            {
                opa = 1;
            }
            this.Opacity = opa;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Box.Text.ToString());
            Thread.Sleep(delay_input);
            stack++;
            Box.Text = "";
        }
        private void Set_Delay_Click(object sender, EventArgs e)
        {
            int re;
            if (!int.TryParse(Delay_Box.Text, out re))
            {
                MessageBox.Show("자연수만 입력해");
                return;
            }
            delay_input = re;
            label5.Text = re.ToString();
            Delay_Box.Text = "";
        }
    }
}