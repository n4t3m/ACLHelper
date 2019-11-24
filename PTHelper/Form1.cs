using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTHelper
{
    public partial class btnClickThis : Form
    {
        public btnClickThis()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnClickThis_Load(object sender, EventArgs e)
        {

        }

        private void BannerMOTDButton_Click(object sender, EventArgs e)
        {

        }

        private void SecretPasswordInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SetSecretPassword_Click(object sender, EventArgs e)
        {


        }

        private void SetPassLength_Click(object sender, EventArgs e)
        {


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StandardACLCalculate_Click(object sender, EventArgs e)
        {
            String command = "access-list " + standardACLNumberInput.Text + " ";
            if(StandardACLPermitInput.Checked==true)
            {
                command = command + "permit ";
            }
            if(StandardACLDenyInput.Checked==true)
            {
                command = command + "deny ";
            }
            if (StandardACLHostInput.Checked==false)
            {
                command = command + StandardACLIPInput.Text + " " + calculateWildcardMask(StandardACLSubnetMaskInput.Text);

            }
            else
            {
                command = command + "host " + StandardACLIPInput.Text;
            }

            Clipboard.SetText(command);
            StandardACLCommandDIsplayOutput.Text = command;
            StandardACLCommandConfirmation.Text = "Command Coppied to Clipboard";
            GlobalBox.Text = GlobalBox.Text + "\n" + command;
            


        }

        private String calculateWildcardMask(String smask)
        {
            String[] wildcards = new String[32];
            wildcards[0] = "255.255.255.255";
            wildcards[1] = "127.255.255.255";
            wildcards[2] = "63.255.255.255";
            wildcards[3] = "31.255.255.255";
            wildcards[4] = "15.25.255.255";
            wildcards[5] = "7.255.255.255";
            wildcards[6] = "3.255.255.255";
            wildcards[7] = "1.255.255.255";
            wildcards[8] = "0.255.255.255";
            wildcards[9] = "0.127.255.255";
            wildcards[10] = "0.63.255.255";
            wildcards[11] = "0.31.255.255";
            wildcards[12] = "0.15.255.255";
            wildcards[13] = "0.7.255.255";
            wildcards[14] = "0.3.255.255";
            wildcards[15] = "0.1.255.255";
            wildcards[16] = "0.0.255.255";
            wildcards[17] = "0.0.127.255";
            wildcards[18] = "0.0.63.255";
            wildcards[19] = "0.0.31.255";
            wildcards[20] = "0.0.15.255";
            wildcards[21] = "0.0.7.255";
            wildcards[22] = "0.0.3.255";
            wildcards[23] = "0.0.1.255";
            wildcards[24] = "0.0.0.255";
            wildcards[25] = "0.0.0.127";
            wildcards[26] = "0.0.0.63";
            wildcards[27] = "0.0.0.31";
            wildcards[28] = "0.0.0.15";
            wildcards[29] = "0.0.0.7";
            wildcards[30] = "0.0.0.3";



            return wildcards[Convert.ToInt32(smask)];
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void StandardACL_Click(object sender, EventArgs e)
        {

        }

        private void ExtendedACLGenerateCommand_Click(object sender, EventArgs e)
        {
            String command = "access-list ";
            command = command + ExtendedACLNumberInput.Text + " ";
            if(ExtendedACLPermitInput.Checked==true)
            {
                command = command + "permit ";
            }
            if(ExtendedACLDenyInput.Checked==true)
            {
                command = command + "deny ";
            }
            command = command + ExtendedACLProtocolInput.Text + " ";
            if (ExtendedACLSourceIPAnyInput.Checked == true)
            {
                command = command + "any ";
            }
            else
            {
                command = command + ExtendedACLSourceIPInput.Text + " " + calculateWildcardMask(ExtendedACLSourceMask.Text) + " ";

            }
            if(ExtendedACLDestinationIPAnyInput.Checked==true)
            {
                command = command + "any ";
            }
            else
            {
                command = command + ExtendedACLDestinationIPInput.Text + " " + calculateWildcardMask(ExtendedACLDestinationMask.Text) + " ";
            }
            command = command + ExtendedACLOperatorInput.Text + " " + ExtendedACLPortInput.Text;
            Clipboard.SetText(command);
            ExtendedACLCommandOutput.Text = command;
            ExtendedACLCommandStatus.Text = "Your command has been copied to your clipboard!";
            GlobalBox.Text = GlobalBox.Text + "\n" + command;
            


        }

        private void ExtendedACLCommandOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            String path = "./output.txt";
            System.IO.File.WriteAllText(path, GlobalBox.Text);             
        }

        private void CopyGloablBoxtoCliboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GlobalBox.Text);
        }
    }
}
