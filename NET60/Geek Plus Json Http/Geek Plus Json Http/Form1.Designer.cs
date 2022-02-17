namespace Geek_Plus_Json_Http
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
            this.Send_BT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.responseId_textBox = new System.Windows.Forms.TextBox();
            this.msgType_textBox = new System.Windows.Forms.TextBox();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msg_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.robot_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.robotConnectStatus_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.robotStopStatus_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.robotError_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.powerPercent_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.speed_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.location_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.locationIndex_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.locationCode_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.robotPathMode_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.robotTaskId_textBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.Label();
            this.voltage_textBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.current_textBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.temperature_textBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.instanceId_textBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.angle_textBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_BT
            // 
            this.Send_BT.Location = new System.Drawing.Point(759, 12);
            this.Send_BT.Name = "Send_BT";
            this.Send_BT.Size = new System.Drawing.Size(157, 23);
            this.Send_BT.TabIndex = 0;
            this.Send_BT.Text = "Send 155-156";
            this.Send_BT.UseVisualStyleBackColor = true;
            this.Send_BT.Click += new System.EventHandler(this.Send_BT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send 156-155";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(759, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(759, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "RobotInfoMsg";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "responseId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "msgType";
            // 
            // responseId_textBox
            // 
            this.responseId_textBox.Location = new System.Drawing.Point(130, 12);
            this.responseId_textBox.Name = "responseId_textBox";
            this.responseId_textBox.Size = new System.Drawing.Size(312, 23);
            this.responseId_textBox.TabIndex = 9;
            // 
            // msgType_textBox
            // 
            this.msgType_textBox.Location = new System.Drawing.Point(130, 41);
            this.msgType_textBox.Name = "msgType_textBox";
            this.msgType_textBox.Size = new System.Drawing.Size(312, 23);
            this.msgType_textBox.TabIndex = 10;
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(130, 70);
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(312, 23);
            this.code_textBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "code";
            // 
            // msg_textBox
            // 
            this.msg_textBox.Location = new System.Drawing.Point(130, 100);
            this.msg_textBox.Name = "msg_textBox";
            this.msg_textBox.Size = new System.Drawing.Size(312, 23);
            this.msg_textBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "msg";
            // 
            // robot_textBox
            // 
            this.robot_textBox.Location = new System.Drawing.Point(130, 129);
            this.robot_textBox.Name = "robot_textBox";
            this.robot_textBox.Size = new System.Drawing.Size(312, 23);
            this.robot_textBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "robot";
            // 
            // robotConnectStatus_textBox
            // 
            this.robotConnectStatus_textBox.Location = new System.Drawing.Point(130, 158);
            this.robotConnectStatus_textBox.Name = "robotConnectStatus_textBox";
            this.robotConnectStatus_textBox.Size = new System.Drawing.Size(312, 23);
            this.robotConnectStatus_textBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "robotConnectStatus";
            // 
            // robotStopStatus_textBox
            // 
            this.robotStopStatus_textBox.Location = new System.Drawing.Point(130, 187);
            this.robotStopStatus_textBox.Name = "robotStopStatus_textBox";
            this.robotStopStatus_textBox.Size = new System.Drawing.Size(312, 23);
            this.robotStopStatus_textBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "robotStopStatus";
            // 
            // robotError_textBox
            // 
            this.robotError_textBox.Location = new System.Drawing.Point(130, 216);
            this.robotError_textBox.Name = "robotError_textBox";
            this.robotError_textBox.Size = new System.Drawing.Size(312, 23);
            this.robotError_textBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "robotError";
            // 
            // powerPercent_textBox
            // 
            this.powerPercent_textBox.Location = new System.Drawing.Point(130, 274);
            this.powerPercent_textBox.Name = "powerPercent_textBox";
            this.powerPercent_textBox.Size = new System.Drawing.Size(312, 23);
            this.powerPercent_textBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "powerPercent";
            // 
            // speed_textBox
            // 
            this.speed_textBox.Location = new System.Drawing.Point(130, 303);
            this.speed_textBox.Name = "speed_textBox";
            this.speed_textBox.Size = new System.Drawing.Size(312, 23);
            this.speed_textBox.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "speed";
            // 
            // location_textBox
            // 
            this.location_textBox.Location = new System.Drawing.Point(130, 332);
            this.location_textBox.Name = "location_textBox";
            this.location_textBox.Size = new System.Drawing.Size(312, 23);
            this.location_textBox.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "location";
            // 
            // locationIndex_textBox
            // 
            this.locationIndex_textBox.Location = new System.Drawing.Point(130, 361);
            this.locationIndex_textBox.Name = "locationIndex_textBox";
            this.locationIndex_textBox.Size = new System.Drawing.Size(312, 23);
            this.locationIndex_textBox.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "locationIndex";
            // 
            // locationCode_textBox
            // 
            this.locationCode_textBox.Location = new System.Drawing.Point(130, 390);
            this.locationCode_textBox.Name = "locationCode_textBox";
            this.locationCode_textBox.Size = new System.Drawing.Size(312, 23);
            this.locationCode_textBox.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "locationCode";
            // 
            // robotPathMode_textBox
            // 
            this.robotPathMode_textBox.Location = new System.Drawing.Point(130, 419);
            this.robotPathMode_textBox.Name = "robotPathMode_textBox";
            this.robotPathMode_textBox.Size = new System.Drawing.Size(312, 23);
            this.robotPathMode_textBox.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 423);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "robotPathMode";
            // 
            // robotTaskId_textBox
            // 
            this.robotTaskId_textBox.Location = new System.Drawing.Point(130, 448);
            this.robotTaskId_textBox.Name = "robotTaskId_textBox";
            this.robotTaskId_textBox.Size = new System.Drawing.Size(312, 23);
            this.robotTaskId_textBox.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 452);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "robotTaskId";
            // 
            // path_textBox
            // 
            this.path_textBox.Location = new System.Drawing.Point(130, 477);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(312, 23);
            this.path_textBox.TabIndex = 38;
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(6, 481);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(33, 15);
            this.path.TabIndex = 37;
            this.path.Text = "path";
            // 
            // voltage_textBox
            // 
            this.voltage_textBox.Location = new System.Drawing.Point(130, 506);
            this.voltage_textBox.Name = "voltage_textBox";
            this.voltage_textBox.Size = new System.Drawing.Size(312, 23);
            this.voltage_textBox.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 510);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "voltage";
            // 
            // current_textBox
            // 
            this.current_textBox.Location = new System.Drawing.Point(130, 535);
            this.current_textBox.Name = "current_textBox";
            this.current_textBox.Size = new System.Drawing.Size(312, 23);
            this.current_textBox.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 539);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 15);
            this.label19.TabIndex = 41;
            this.label19.Text = "current";
            // 
            // temperature_textBox
            // 
            this.temperature_textBox.Location = new System.Drawing.Point(130, 564);
            this.temperature_textBox.Name = "temperature_textBox";
            this.temperature_textBox.Size = new System.Drawing.Size(312, 23);
            this.temperature_textBox.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 568);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 15);
            this.label20.TabIndex = 43;
            this.label20.Text = "temperature";
            // 
            // instanceId_textBox
            // 
            this.instanceId_textBox.Location = new System.Drawing.Point(130, 622);
            this.instanceId_textBox.Name = "instanceId_textBox";
            this.instanceId_textBox.Size = new System.Drawing.Size(312, 23);
            this.instanceId_textBox.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 626);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "instanceId";
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(130, 593);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(312, 23);
            this.ip_textBox.TabIndex = 46;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 607);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 15);
            this.label21.TabIndex = 45;
            this.label21.Text = "ip";
            // 
            // angle_textBox
            // 
            this.angle_textBox.Location = new System.Drawing.Point(130, 245);
            this.angle_textBox.Name = "angle_textBox";
            this.angle_textBox.Size = new System.Drawing.Size(312, 23);
            this.angle_textBox.TabIndex = 50;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 15);
            this.label22.TabIndex = 49;
            this.label22.Text = "angle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 675);
            this.Controls.Add(this.angle_textBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.instanceId_textBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ip_textBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.temperature_textBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.current_textBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.voltage_textBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.path);
            this.Controls.Add(this.robotTaskId_textBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.robotPathMode_textBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.locationCode_textBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.locationIndex_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.location_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.speed_textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.powerPercent_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.robotError_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.robotStopStatus_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.robotConnectStatus_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.robot_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msg_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.code_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msgType_textBox);
            this.Controls.Add(this.responseId_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Send_BT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Send_BT;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private TextBox responseId_textBox;
        private TextBox msgType_textBox;
        private TextBox code_textBox;
        private Label label4;
        private TextBox msg_textBox;
        private Label label5;
        private TextBox robot_textBox;
        private Label label6;
        private TextBox robotConnectStatus_textBox;
        private Label label7;
        private TextBox robotStopStatus_textBox;
        private Label label8;
        private TextBox robotError_textBox;
        private Label label9;
        private TextBox powerPercent_textBox;
        private Label label10;
        private TextBox speed_textBox;
        private Label label11;
        private TextBox location_textBox;
        private Label label12;
        private TextBox locationIndex_textBox;
        private Label label13;
        private TextBox locationCode_textBox;
        private Label label14;
        private TextBox robotPathMode_textBox;
        private Label label15;
        private TextBox robotTaskId_textBox;
        private Label label16;
        private TextBox path_textBox;
        private Label path;
        private TextBox voltage_textBox;
        private Label label18;
        private TextBox current_textBox;
        private Label label19;
        private TextBox temperature_textBox;
        private Label label20;
        private TextBox instanceId_textBox;
        private Label label17;
        private TextBox ip_textBox;
        private Label label21;
        private TextBox angle_textBox;
        private Label label22;
    }
}