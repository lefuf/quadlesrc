namespace quadlesrc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            studioBtn = new Button();
            joinBtn = new Button();
            hostBtn = new Button();
            label2 = new Label();
            nameLabel = new Label();
            ipLabel = new Label();
            jport = new TextBox();
            mapLabel = new Label();
            mapinp = new TextBox();
            portLabel = new Label();
            hostLabel = new Label();
            sportinp = new TextBox();
            jname = new TextBox();
            jip = new TextBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 83);
            label1.TabIndex = 0;
            label1.Text = "Quadle";
            // 
            // studioBtn
            // 
            studioBtn.Location = new Point(357, 479);
            studioBtn.Margin = new Padding(3, 4, 3, 4);
            studioBtn.Name = "studioBtn";
            studioBtn.Size = new Size(68, 50);
            studioBtn.TabIndex = 1;
            studioBtn.Text = "Open Studio";
            studioBtn.UseVisualStyleBackColor = true;
            studioBtn.Click += studioBtn_Click;
            // 
            // joinBtn
            // 
            joinBtn.Location = new Point(12, 537);
            joinBtn.Margin = new Padding(3, 4, 3, 4);
            joinBtn.Name = "joinBtn";
            joinBtn.Size = new Size(273, 50);
            joinBtn.TabIndex = 2;
            joinBtn.Text = "Join game";
            joinBtn.UseVisualStyleBackColor = true;
            joinBtn.Click += joinBtn_Click;
            // 
            // hostBtn
            // 
            hostBtn.Location = new Point(291, 537);
            hostBtn.Margin = new Padding(3, 4, 3, 4);
            hostBtn.Name = "hostBtn";
            hostBtn.Size = new Size(134, 50);
            hostBtn.TabIndex = 4;
            hostBtn.Text = "Host";
            hostBtn.UseVisualStyleBackColor = true;
            hostBtn.Click += hostBtn_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 126);
            label2.Name = "label2";
            label2.Size = new Size(65, 37);
            label2.TabIndex = 7;
            label2.Text = "Join";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 176);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Location = new Point(178, 176);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(21, 20);
            ipLabel.TabIndex = 10;
            ipLabel.Text = "IP";
            // 
            // jport
            // 
            jport.Location = new Point(299, 200);
            jport.Margin = new Padding(3, 4, 3, 4);
            jport.MaxLength = 5;
            jport.Name = "jport";
            jport.Size = new Size(126, 27);
            jport.TabIndex = 11;
            jport.Text = "53640";
            // 
            // mapLabel
            // 
            mapLabel.AutoSize = true;
            mapLabel.Location = new Point(160, 288);
            mapLabel.Name = "mapLabel";
            mapLabel.Size = new Size(39, 20);
            mapLabel.TabIndex = 17;
            mapLabel.Text = "Map";
            // 
            // mapinp
            // 
            mapinp.Location = new Point(160, 312);
            mapinp.Margin = new Padding(3, 4, 3, 4);
            mapinp.Name = "mapinp";
            mapinp.Size = new Size(265, 27);
            mapinp.TabIndex = 16;
            mapinp.Text = "Baseplate.rbxl";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(12, 288);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(35, 20);
            portLabel.TabIndex = 15;
            portLabel.Text = "Port";
            // 
            // hostLabel
            // 
            hostLabel.AutoSize = true;
            hostLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            hostLabel.Location = new Point(5, 242);
            hostLabel.Name = "hostLabel";
            hostLabel.Size = new Size(72, 37);
            hostLabel.TabIndex = 14;
            hostLabel.Text = "Host";
            // 
            // sportinp
            // 
            sportinp.Location = new Point(12, 312);
            sportinp.Margin = new Padding(3, 4, 3, 4);
            sportinp.MaxLength = 5;
            sportinp.Name = "sportinp";
            sportinp.Size = new Size(142, 27);
            sportinp.TabIndex = 13;
            sportinp.Text = "53640";
            // 
            // jname
            // 
            jname.Location = new Point(12, 200);
            jname.Margin = new Padding(3, 4, 3, 4);
            jname.MaxLength = 20;
            jname.Name = "jname";
            jname.Size = new Size(159, 27);
            jname.TabIndex = 18;
            jname.Text = "Guest";
            // 
            // jip
            // 
            jip.Location = new Point(178, 200);
            jip.Margin = new Padding(3, 4, 3, 4);
            jip.MaxLength = 64;
            jip.Name = "jip";
            jip.Size = new Size(114, 27);
            jip.TabIndex = 19;
            jip.Text = "127.0.0.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 176);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 20;
            label3.Text = "Port";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(12, 346);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(413, 126);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "We encourage the usage of RadminVPN";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(291, 479);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(60, 50);
            button1.TabIndex = 22;
            button1.Text = "Avatar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(74, 43);
            label4.TabIndex = 23;
            label4.Text = "a0.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 600);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(jip);
            Controls.Add(jname);
            Controls.Add(mapLabel);
            Controls.Add(mapinp);
            Controls.Add(portLabel);
            Controls.Add(hostLabel);
            Controls.Add(sportinp);
            Controls.Add(jport);
            Controls.Add(ipLabel);
            Controls.Add(nameLabel);
            Controls.Add(label2);
            Controls.Add(hostBtn);
            Controls.Add(joinBtn);
            Controls.Add(studioBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Quadle Launcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button studioBtn;
        private Button joinBtn;
        private Button hostBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label nameLabel;
        private Label ipLabel;
        private TextBox textBox3;
        private TextBox jport;
        private Label mapLabel;
        private TextBox mapinp;
        private Label portLabel;
        private Label hostLabel;
        private TextBox sportinp;
        private TextBox jname;
        private TextBox jip;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label4;
    }
}
