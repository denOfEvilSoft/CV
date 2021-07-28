
namespace CV
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Start = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.stack_show = new System.Windows.Forms.Label();
            this.full_show = new System.Windows.Forms.Label();
            this.nanugi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Box = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delay_Box = new System.Windows.Forms.TextBox();
            this.Set_Delay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(28, 16);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 124);
            this.listBox1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(177, 28);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(69, 25);
            this.Start.TabIndex = 1;
            this.Start.Text = "시작";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Del
            // 
            this.Del.Enabled = false;
            this.Del.Location = new System.Drawing.Point(177, 57);
            this.Del.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(69, 25);
            this.Del.TabIndex = 3;
            this.Del.Text = "선택 삭제";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // stack_show
            // 
            this.stack_show.AutoSize = true;
            this.stack_show.Location = new System.Drawing.Point(188, 14);
            this.stack_show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stack_show.Name = "stack_show";
            this.stack_show.Size = new System.Drawing.Size(11, 12);
            this.stack_show.TabIndex = 4;
            this.stack_show.Text = "0";
            // 
            // full_show
            // 
            this.full_show.AutoSize = true;
            this.full_show.Location = new System.Drawing.Point(220, 14);
            this.full_show.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.full_show.Name = "full_show";
            this.full_show.Size = new System.Drawing.Size(17, 12);
            this.full_show.TabIndex = 5;
            this.full_show.Text = "10";
            // 
            // nanugi
            // 
            this.nanugi.AutoSize = true;
            this.nanugi.Location = new System.Drawing.Point(205, 14);
            this.nanugi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nanugi.Name = "nanugi";
            this.nanugi.Size = new System.Drawing.Size(11, 12);
            this.nanugi.TabIndex = 6;
            this.nanugi.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "문의 : denofevil.soft@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(2, 233);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label1.Size = new System.Drawing.Size(236, 74);
            this.label1.TabIndex = 13;
            this.label1.Text = "컨 + C로 등록 할 때 바로 등록이 안되고 이\r\n전에 복사했던 것들이 등록 된다면 지연시\r\n간올려라. 지금 지연시간 + 50 씩 하면 됨. \r\n" +
    "잘 된다 싶으면 -10 씩 하면서 최적 값 찾으\r\n면 된다.\r\n기본 값 : 400 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 120);
            this.label3.TabIndex = 14;
            this.label3.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n0";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(177, 87);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(69, 23);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(13, 143);
            this.Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(234, 21);
            this.Box.TabIndex = 15;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(177, 113);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(69, 25);
            this.Add.TabIndex = 16;
            this.Add.Text = "수동 추가";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delay_Box
            // 
            this.Delay_Box.Font = new System.Drawing.Font("굴림", 9F);
            this.Delay_Box.Location = new System.Drawing.Point(58, 175);
            this.Delay_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delay_Box.Name = "Delay_Box";
            this.Delay_Box.Size = new System.Drawing.Size(70, 21);
            this.Delay_Box.TabIndex = 17;
            // 
            // Set_Delay
            // 
            this.Set_Delay.Location = new System.Drawing.Point(132, 175);
            this.Set_Delay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Set_Delay.Name = "Set_Delay";
            this.Set_Delay.Size = new System.Drawing.Size(69, 21);
            this.Set_Delay.TabIndex = 18;
            this.Set_Delay.Text = "지연 시간";
            this.Set_Delay.UseVisualStyleBackColor = true;
            this.Set_Delay.Click += new System.EventHandler(this.Set_Delay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "지연 시간 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "400";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 357);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Set_Delay);
            this.Controls.Add(this.Delay_Box);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nanugi);
            this.Controls.Add(this.full_show);
            this.Controls.Add(this.stack_show);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ㅂ5ㄱ - BㅜE";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Label stack_show;
        private System.Windows.Forms.Label full_show;
        private System.Windows.Forms.Label nanugi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox Box;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Delay_Box;
        private System.Windows.Forms.Button Set_Delay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

