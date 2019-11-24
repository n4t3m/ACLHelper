namespace PTHelper
{
    partial class btnClickThis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Status = new System.Windows.Forms.Label();
            this.ExtendedACL = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ExtendedACLNumberInput = new System.Windows.Forms.TextBox();
            this.ExtendedACLPermitInput = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ExtendedACLDenyInput = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ExtendedACLProtocolInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ExtendedACLSourceIPInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ExtendedACLSourceMask = new System.Windows.Forms.TextBox();
            this.ExtendedACLSourceIPAnyInput = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.labelsomething = new System.Windows.Forms.Label();
            this.ExtendedACLDestinationIPInput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ExtendedACLDestinationMask = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ExtendedACLDestinationIPAnyInput = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ExtendedACLOperatorInput = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ExtendedACLPortInput = new System.Windows.Forms.TextBox();
            this.ExtendedACLGenerateCommand = new System.Windows.Forms.Button();
            this.ExtendedACLCommandOutput = new System.Windows.Forms.TextBox();
            this.ExtendedACLCommandStatus = new System.Windows.Forms.Label();
            this.StandardACL = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.standardACLNumberInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StandardACLHostInput = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StandardACLIPInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StandardACLSubnetMaskInput = new System.Windows.Forms.TextBox();
            this.StandardACLPermitInput = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StandardACLDenyInput = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StandardACLCalculate = new System.Windows.Forms.Button();
            this.StandardACLCommandConfirmation = new System.Windows.Forms.Label();
            this.StandardACLCommandDIsplayOutput = new System.Windows.Forms.TextBox();
            this.CommandList = new System.Windows.Forms.TabPage();
            this.GlobalBox = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CopyGloablBoxtoCliboard = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ExtendedACL.SuspendLayout();
            this.StandardACL.SuspendLayout();
            this.CommandList.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(344, 393);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            this.Status.TabIndex = 7;
            // 
            // ExtendedACL
            // 
            this.ExtendedACL.Controls.Add(this.ExtendedACLCommandStatus);
            this.ExtendedACL.Controls.Add(this.ExtendedACLCommandOutput);
            this.ExtendedACL.Controls.Add(this.ExtendedACLPortInput);
            this.ExtendedACL.Controls.Add(this.ExtendedACLOperatorInput);
            this.ExtendedACL.Controls.Add(this.ExtendedACLDestinationMask);
            this.ExtendedACL.Controls.Add(this.ExtendedACLDestinationIPInput);
            this.ExtendedACL.Controls.Add(this.ExtendedACLSourceMask);
            this.ExtendedACL.Controls.Add(this.ExtendedACLSourceIPInput);
            this.ExtendedACL.Controls.Add(this.ExtendedACLProtocolInput);
            this.ExtendedACL.Controls.Add(this.ExtendedACLNumberInput);
            this.ExtendedACL.Controls.Add(this.ExtendedACLGenerateCommand);
            this.ExtendedACL.Controls.Add(this.label21);
            this.ExtendedACL.Controls.Add(this.label20);
            this.ExtendedACL.Controls.Add(this.label19);
            this.ExtendedACL.Controls.Add(this.ExtendedACLDestinationIPAnyInput);
            this.ExtendedACL.Controls.Add(this.label18);
            this.ExtendedACL.Controls.Add(this.label17);
            this.ExtendedACL.Controls.Add(this.labelsomething);
            this.ExtendedACL.Controls.Add(this.label16);
            this.ExtendedACL.Controls.Add(this.ExtendedACLSourceIPAnyInput);
            this.ExtendedACL.Controls.Add(this.label15);
            this.ExtendedACL.Controls.Add(this.label14);
            this.ExtendedACL.Controls.Add(this.label13);
            this.ExtendedACL.Controls.Add(this.label12);
            this.ExtendedACL.Controls.Add(this.ExtendedACLDenyInput);
            this.ExtendedACL.Controls.Add(this.label11);
            this.ExtendedACL.Controls.Add(this.ExtendedACLPermitInput);
            this.ExtendedACL.Controls.Add(this.label10);
            this.ExtendedACL.Controls.Add(this.label9);
            this.ExtendedACL.Location = new System.Drawing.Point(4, 49);
            this.ExtendedACL.Name = "ExtendedACL";
            this.ExtendedACL.Size = new System.Drawing.Size(792, 397);
            this.ExtendedACL.TabIndex = 8;
            this.ExtendedACL.Text = "Extended ACL";
            this.ExtendedACL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(332, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Extended ACL Number MUST be between 100-199.";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Choose ACL Number:";
            // 
            // ExtendedACLNumberInput
            // 
            this.ExtendedACLNumberInput.Location = new System.Drawing.Point(159, 51);
            this.ExtendedACLNumberInput.Name = "ExtendedACLNumberInput";
            this.ExtendedACLNumberInput.Size = new System.Drawing.Size(100, 22);
            this.ExtendedACLNumberInput.TabIndex = 2;
            // 
            // ExtendedACLPermitInput
            // 
            this.ExtendedACLPermitInput.AutoSize = true;
            this.ExtendedACLPermitInput.Location = new System.Drawing.Point(11, 81);
            this.ExtendedACLPermitInput.Name = "ExtendedACLPermitInput";
            this.ExtendedACLPermitInput.Size = new System.Drawing.Size(70, 21);
            this.ExtendedACLPermitInput.TabIndex = 3;
            this.ExtendedACLPermitInput.Text = "Permit";
            this.ExtendedACLPermitInput.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "OR";
            // 
            // ExtendedACLDenyInput
            // 
            this.ExtendedACLDenyInput.AutoSize = true;
            this.ExtendedACLDenyInput.Location = new System.Drawing.Point(134, 82);
            this.ExtendedACLDenyInput.Name = "ExtendedACLDenyInput";
            this.ExtendedACLDenyInput.Size = new System.Drawing.Size(63, 21);
            this.ExtendedACLDenyInput.TabIndex = 5;
            this.ExtendedACLDenyInput.Text = "Deny";
            this.ExtendedACLDenyInput.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Protocol:";
            // 
            // ExtendedACLProtocolInput
            // 
            this.ExtendedACLProtocolInput.Location = new System.Drawing.Point(79, 114);
            this.ExtendedACLProtocolInput.Name = "ExtendedACLProtocolInput";
            this.ExtendedACLProtocolInput.Size = new System.Drawing.Size(120, 22);
            this.ExtendedACLProtocolInput.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(205, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(314, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Protcol Examples: AHP, TCP, UDP, ICMP, EIGRP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Source IP:";
            // 
            // ExtendedACLSourceIPInput
            // 
            this.ExtendedACLSourceIPInput.Location = new System.Drawing.Point(88, 154);
            this.ExtendedACLSourceIPInput.Name = "ExtendedACLSourceIPInput";
            this.ExtendedACLSourceIPInput.Size = new System.Drawing.Size(130, 22);
            this.ExtendedACLSourceIPInput.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(234, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Source Mask:";
            // 
            // ExtendedACLSourceMask
            // 
            this.ExtendedACLSourceMask.Location = new System.Drawing.Point(334, 151);
            this.ExtendedACLSourceMask.Name = "ExtendedACLSourceMask";
            this.ExtendedACLSourceMask.Size = new System.Drawing.Size(157, 22);
            this.ExtendedACLSourceMask.TabIndex = 12;
            // 
            // ExtendedACLSourceIPAnyInput
            // 
            this.ExtendedACLSourceIPAnyInput.AutoSize = true;
            this.ExtendedACLSourceIPAnyInput.Location = new System.Drawing.Point(532, 150);
            this.ExtendedACLSourceIPAnyInput.Name = "ExtendedACLSourceIPAnyInput";
            this.ExtendedACLSourceIPAnyInput.Size = new System.Drawing.Size(245, 21);
            this.ExtendedACLSourceIPAnyInput.TabIndex = 13;
            this.ExtendedACLSourceIPAnyInput.Text = "ANY (ACL wll apply to any source)";
            this.ExtendedACLSourceIPAnyInput.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(497, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "OR";
            // 
            // labelsomething
            // 
            this.labelsomething.AutoSize = true;
            this.labelsomething.Location = new System.Drawing.Point(8, 191);
            this.labelsomething.Name = "labelsomething";
            this.labelsomething.Size = new System.Drawing.Size(99, 17);
            this.labelsomething.TabIndex = 15;
            this.labelsomething.Text = "Destination IP:";
            // 
            // ExtendedACLDestinationIPInput
            // 
            this.ExtendedACLDestinationIPInput.Location = new System.Drawing.Point(114, 191);
            this.ExtendedACLDestinationIPInput.Name = "ExtendedACLDestinationIPInput";
            this.ExtendedACLDestinationIPInput.Size = new System.Drawing.Size(122, 22);
            this.ExtendedACLDestinationIPInput.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(260, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Destination Mask:";
            // 
            // ExtendedACLDestinationMask
            // 
            this.ExtendedACLDestinationMask.Location = new System.Drawing.Point(387, 191);
            this.ExtendedACLDestinationMask.Name = "ExtendedACLDestinationMask";
            this.ExtendedACLDestinationMask.Size = new System.Drawing.Size(100, 22);
            this.ExtendedACLDestinationMask.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(500, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "OR";
            this.label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // ExtendedACLDestinationIPAnyInput
            // 
            this.ExtendedACLDestinationIPAnyInput.AutoSize = true;
            this.ExtendedACLDestinationIPAnyInput.Location = new System.Drawing.Point(535, 190);
            this.ExtendedACLDestinationIPAnyInput.Name = "ExtendedACLDestinationIPAnyInput";
            this.ExtendedACLDestinationIPAnyInput.Size = new System.Drawing.Size(220, 21);
            this.ExtendedACLDestinationIPAnyInput.TabIndex = 20;
            this.ExtendedACLDestinationIPAnyInput.Text = "ANY (apply to all destinations)";
            this.ExtendedACLDestinationIPAnyInput.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 229);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Operator:";
            // 
            // ExtendedACLOperatorInput
            // 
            this.ExtendedACLOperatorInput.Location = new System.Drawing.Point(90, 229);
            this.ExtendedACLOperatorInput.Name = "ExtendedACLOperatorInput";
            this.ExtendedACLOperatorInput.Size = new System.Drawing.Size(100, 22);
            this.ExtendedACLOperatorInput.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(208, 233);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(220, 17);
            this.label20.TabIndex = 23;
            this.label20.Text = "Example Operators: eq, neg, lt, gt";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(435, 233);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 17);
            this.label21.TabIndex = 24;
            this.label21.Text = "Port Number:";
            // 
            // ExtendedACLPortInput
            // 
            this.ExtendedACLPortInput.Location = new System.Drawing.Point(535, 229);
            this.ExtendedACLPortInput.Name = "ExtendedACLPortInput";
            this.ExtendedACLPortInput.Size = new System.Drawing.Size(100, 22);
            this.ExtendedACLPortInput.TabIndex = 25;
            // 
            // ExtendedACLGenerateCommand
            // 
            this.ExtendedACLGenerateCommand.Location = new System.Drawing.Point(304, 262);
            this.ExtendedACLGenerateCommand.Name = "ExtendedACLGenerateCommand";
            this.ExtendedACLGenerateCommand.Size = new System.Drawing.Size(170, 62);
            this.ExtendedACLGenerateCommand.TabIndex = 26;
            this.ExtendedACLGenerateCommand.Text = "Generate ACL Command";
            this.ExtendedACLGenerateCommand.UseVisualStyleBackColor = true;
            this.ExtendedACLGenerateCommand.Click += new System.EventHandler(this.ExtendedACLGenerateCommand_Click);
            // 
            // ExtendedACLCommandOutput
            // 
            this.ExtendedACLCommandOutput.Location = new System.Drawing.Point(8, 352);
            this.ExtendedACLCommandOutput.Name = "ExtendedACLCommandOutput";
            this.ExtendedACLCommandOutput.Size = new System.Drawing.Size(769, 22);
            this.ExtendedACLCommandOutput.TabIndex = 27;
            this.ExtendedACLCommandOutput.Text = "Your Command Will Be Displayed Here";
            this.ExtendedACLCommandOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExtendedACLCommandOutput.TextChanged += new System.EventHandler(this.ExtendedACLCommandOutput_TextChanged);
            // 
            // ExtendedACLCommandStatus
            // 
            this.ExtendedACLCommandStatus.AutoSize = true;
            this.ExtendedACLCommandStatus.Location = new System.Drawing.Point(373, 381);
            this.ExtendedACLCommandStatus.Name = "ExtendedACLCommandStatus";
            this.ExtendedACLCommandStatus.Size = new System.Drawing.Size(0, 17);
            this.ExtendedACLCommandStatus.TabIndex = 28;
            // 
            // StandardACL
            // 
            this.StandardACL.Controls.Add(this.StandardACLCommandDIsplayOutput);
            this.StandardACL.Controls.Add(this.StandardACLSubnetMaskInput);
            this.StandardACL.Controls.Add(this.StandardACLIPInput);
            this.StandardACL.Controls.Add(this.standardACLNumberInput);
            this.StandardACL.Controls.Add(this.StandardACLCommandConfirmation);
            this.StandardACL.Controls.Add(this.StandardACLCalculate);
            this.StandardACL.Controls.Add(this.label8);
            this.StandardACL.Controls.Add(this.StandardACLDenyInput);
            this.StandardACL.Controls.Add(this.label7);
            this.StandardACL.Controls.Add(this.StandardACLPermitInput);
            this.StandardACL.Controls.Add(this.label6);
            this.StandardACL.Controls.Add(this.label5);
            this.StandardACL.Controls.Add(this.StandardACLHostInput);
            this.StandardACL.Controls.Add(this.label4);
            this.StandardACL.Controls.Add(this.label3);
            this.StandardACL.Controls.Add(this.label2);
            this.StandardACL.Location = new System.Drawing.Point(4, 49);
            this.StandardACL.Name = "StandardACL";
            this.StandardACL.Size = new System.Drawing.Size(792, 397);
            this.StandardACL.TabIndex = 7;
            this.StandardACL.Text = "Standard ACL";
            this.StandardACL.UseVisualStyleBackColor = true;
            this.StandardACL.Click += new System.EventHandler(this.StandardACL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ACL Number MUST be between 1-99.";
            // 
            // standardACLNumberInput
            // 
            this.standardACLNumberInput.Location = new System.Drawing.Point(158, 45);
            this.standardACLNumberInput.Name = "standardACLNumberInput";
            this.standardACLNumberInput.Size = new System.Drawing.Size(100, 22);
            this.standardACLNumberInput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose ACL Number:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // StandardACLHostInput
            // 
            this.StandardACLHostInput.AutoSize = true;
            this.StandardACLHostInput.Location = new System.Drawing.Point(11, 80);
            this.StandardACLHostInput.Name = "StandardACLHostInput";
            this.StandardACLHostInput.Size = new System.Drawing.Size(367, 21);
            this.StandardACLHostInput.TabIndex = 4;
            this.StandardACLHostInput.Text = "Check this box if you are making an ACL for one host.";
            this.StandardACLHostInput.UseVisualStyleBackColor = true;
            this.StandardACLHostInput.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter the Source Network Address or Host:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // StandardACLIPInput
            // 
            this.StandardACLIPInput.Location = new System.Drawing.Point(298, 108);
            this.StandardACLIPInput.Name = "StandardACLIPInput";
            this.StandardACLIPInput.Size = new System.Drawing.Size(133, 22);
            this.StandardACLIPInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Enter Subnet Mask (Only if you are NOT making an ACL for one host):";
            // 
            // StandardACLSubnetMaskInput
            // 
            this.StandardACLSubnetMaskInput.Location = new System.Drawing.Point(469, 147);
            this.StandardACLSubnetMaskInput.Name = "StandardACLSubnetMaskInput";
            this.StandardACLSubnetMaskInput.Size = new System.Drawing.Size(100, 22);
            this.StandardACLSubnetMaskInput.TabIndex = 8;
            // 
            // StandardACLPermitInput
            // 
            this.StandardACLPermitInput.AutoSize = true;
            this.StandardACLPermitInput.Location = new System.Drawing.Point(11, 185);
            this.StandardACLPermitInput.Name = "StandardACLPermitInput";
            this.StandardACLPermitInput.Size = new System.Drawing.Size(70, 21);
            this.StandardACLPermitInput.TabIndex = 9;
            this.StandardACLPermitInput.Text = "Permit";
            this.StandardACLPermitInput.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "OR";
            // 
            // StandardACLDenyInput
            // 
            this.StandardACLDenyInput.AutoSize = true;
            this.StandardACLDenyInput.Location = new System.Drawing.Point(131, 185);
            this.StandardACLDenyInput.Name = "StandardACLDenyInput";
            this.StandardACLDenyInput.Size = new System.Drawing.Size(63, 21);
            this.StandardACLDenyInput.TabIndex = 11;
            this.StandardACLDenyInput.Text = "Deny";
            this.StandardACLDenyInput.UseVisualStyleBackColor = true;
            this.StandardACLDenyInput.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sample Input: 24";
            // 
            // StandardACLCalculate
            // 
            this.StandardACLCalculate.Location = new System.Drawing.Point(298, 234);
            this.StandardACLCalculate.Name = "StandardACLCalculate";
            this.StandardACLCalculate.Size = new System.Drawing.Size(171, 23);
            this.StandardACLCalculate.TabIndex = 13;
            this.StandardACLCalculate.Text = "Calculate ACL Command";
            this.StandardACLCalculate.UseVisualStyleBackColor = true;
            this.StandardACLCalculate.Click += new System.EventHandler(this.StandardACLCalculate_Click);
            // 
            // StandardACLCommandConfirmation
            // 
            this.StandardACLCommandConfirmation.AutoSize = true;
            this.StandardACLCommandConfirmation.Location = new System.Drawing.Point(352, 351);
            this.StandardACLCommandConfirmation.Name = "StandardACLCommandConfirmation";
            this.StandardACLCommandConfirmation.Size = new System.Drawing.Size(0, 17);
            this.StandardACLCommandConfirmation.TabIndex = 14;
            // 
            // StandardACLCommandDIsplayOutput
            // 
            this.StandardACLCommandDIsplayOutput.Location = new System.Drawing.Point(14, 294);
            this.StandardACLCommandDIsplayOutput.Name = "StandardACLCommandDIsplayOutput";
            this.StandardACLCommandDIsplayOutput.Size = new System.Drawing.Size(757, 22);
            this.StandardACLCommandDIsplayOutput.TabIndex = 15;
            this.StandardACLCommandDIsplayOutput.Text = "Your Command Will Be Displayed Here.";
            this.StandardACLCommandDIsplayOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CommandList
            // 
            this.CommandList.Controls.Add(this.CopyGloablBoxtoCliboard);
            this.CommandList.Controls.Add(this.button1);
            this.CommandList.Controls.Add(this.label22);
            this.CommandList.Controls.Add(this.GlobalBox);
            this.CommandList.Location = new System.Drawing.Point(4, 49);
            this.CommandList.Name = "CommandList";
            this.CommandList.Size = new System.Drawing.Size(792, 397);
            this.CommandList.TabIndex = 6;
            this.CommandList.Text = "CommandList";
            this.CommandList.UseVisualStyleBackColor = true;
            // 
            // GlobalBox
            // 
            this.GlobalBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GlobalBox.Location = new System.Drawing.Point(0, 106);
            this.GlobalBox.Name = "GlobalBox";
            this.GlobalBox.Size = new System.Drawing.Size(792, 291);
            this.GlobalBox.TabIndex = 0;
            this.GlobalBox.Text = "";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(219, 11);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(330, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "All Of Your ACL Commands will be displayed below.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export To TXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // CopyGloablBoxtoCliboard
            // 
            this.CopyGloablBoxtoCliboard.Location = new System.Drawing.Point(407, 31);
            this.CopyGloablBoxtoCliboard.Name = "CopyGloablBoxtoCliboard";
            this.CopyGloablBoxtoCliboard.Size = new System.Drawing.Size(270, 37);
            this.CopyGloablBoxtoCliboard.TabIndex = 3;
            this.CopyGloablBoxtoCliboard.Text = "Copy Commands to Clipboard";
            this.CopyGloablBoxtoCliboard.UseVisualStyleBackColor = true;
            this.CopyGloablBoxtoCliboard.Click += new System.EventHandler(this.CopyGloablBoxtoCliboard_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CommandList);
            this.tabControl1.Controls.Add(this.StandardACL);
            this.tabControl1.Controls.Add(this.ExtendedACL);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 45);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 12;
            // 
            // btnClickThis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Status);
            this.Name = "btnClickThis";
            this.Text = "CISCO ACL Helper - Made by NateM135";
            this.Load += new System.EventHandler(this.BtnClickThis_Load);
            this.ExtendedACL.ResumeLayout(false);
            this.ExtendedACL.PerformLayout();
            this.StandardACL.ResumeLayout(false);
            this.StandardACL.PerformLayout();
            this.CommandList.ResumeLayout(false);
            this.CommandList.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TabPage ExtendedACL;
        private System.Windows.Forms.Label ExtendedACLCommandStatus;
        private System.Windows.Forms.TextBox ExtendedACLCommandOutput;
        private System.Windows.Forms.TextBox ExtendedACLPortInput;
        private System.Windows.Forms.TextBox ExtendedACLOperatorInput;
        private System.Windows.Forms.TextBox ExtendedACLDestinationMask;
        private System.Windows.Forms.TextBox ExtendedACLDestinationIPInput;
        private System.Windows.Forms.TextBox ExtendedACLSourceMask;
        private System.Windows.Forms.TextBox ExtendedACLSourceIPInput;
        private System.Windows.Forms.TextBox ExtendedACLProtocolInput;
        private System.Windows.Forms.TextBox ExtendedACLNumberInput;
        private System.Windows.Forms.Button ExtendedACLGenerateCommand;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ExtendedACLDestinationIPAnyInput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelsomething;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox ExtendedACLSourceIPAnyInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ExtendedACLDenyInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ExtendedACLPermitInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage StandardACL;
        private System.Windows.Forms.TextBox StandardACLCommandDIsplayOutput;
        private System.Windows.Forms.TextBox StandardACLSubnetMaskInput;
        private System.Windows.Forms.TextBox StandardACLIPInput;
        private System.Windows.Forms.TextBox standardACLNumberInput;
        private System.Windows.Forms.Label StandardACLCommandConfirmation;
        private System.Windows.Forms.Button StandardACLCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox StandardACLDenyInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox StandardACLPermitInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox StandardACLHostInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage CommandList;
        private System.Windows.Forms.Button CopyGloablBoxtoCliboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox GlobalBox;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

