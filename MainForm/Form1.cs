using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string UsrManMV;
       //1. level
       const string sInternal= ".Internal";
       const string sUser = ".User";
        //2. level
        const string sMpUserXLib = ".MpUserXLib";
        const string sArTextSysLib = ".ArTextSysLib";
        const string sInfo = ".Info";
        //3. level
        const string sMpUserXManagerUIConnect = ".MpUserXManagerUIConnect[";
        const string sLangDropDownText = ".DropDownText";
        const string sUserName = ".UserName";
        const string sFullName = ".FullName";
        const string sLanguage = ".Language";
        const string sCreation = ".Creation";
        const string sFirstLogin = ".FirstLogin";
        const string sLastLogin = ".LastLogin";
        //4. level
        const string sLangDropDown = ".DropDown";
        string finalText;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UsrManMV = textBox1.Text.ToString();
            finalText = "VAR_CONFIG" + Environment.NewLine;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                finalText = finalText + getUser(i);
            }
            finalText = finalText + "END_VAR";
        }
        private string getUser(int i)
        {
            return getUser_Info(i);
        }
        private string getUser_Info(int i)
        {
                return getUser_Info_UserName(i) + getUser_Info_FullName(i) + getUser_Info_Language(i) + getUser_Info_Creation(i) + getUser_Info_FirstLogin(i) + getUser_Info_LastLogin(i);
        }
        private string getUser_Info_UserName(int i)
        {
                return UsrManMV + sInternal + sMpUserXLib + sMpUserXManagerUIConnect + i.ToString() + "]" + sUser + sInfo + sUserName + " AT %Q." + UsrManMV + sUser + "[" + i.ToString() + "]" + sInfo + sUserName + "; (*Automatic generted text*)" + Environment.NewLine;
        }
        private string getUser_Info_FullName(int i)
        {
            return UsrManMV + sInternal + sMpUserXLib + sMpUserXManagerUIConnect + i.ToString() + "]" + sUser + sInfo + sFullName + " AT %Q." + UsrManMV + sUser + "[" + i.ToString() + "]" + sInfo + sFullName + "; (*Automatic generted text*)" + Environment.NewLine;
        }
        private string getUser_Info_Creation(int i)
        {
            return UsrManMV + sInternal + sMpUserXLib + sMpUserXManagerUIConnect + i.ToString() + "]" + sUser + sInfo + sCreation + " AT %Q." + UsrManMV + sUser + "[" + i.ToString() + "]" + sInfo + sCreation + "; (*Automatic generted text*)" + Environment.NewLine;
        }
        private string getUser_Info_FirstLogin(int i)
        {
            return UsrManMV + sInternal + sMpUserXLib + sMpUserXManagerUIConnect + i.ToString() + "]" + sUser + sInfo + sFirstLogin + " AT %Q." + UsrManMV + sUser + "[" + i.ToString() + "]" + sInfo + sFirstLogin + "; (*Automatic generted text*)" + Environment.NewLine;
        }
        private string getUser_Info_LastLogin(int i)
        {
            return UsrManMV + sInternal + sMpUserXLib + sMpUserXManagerUIConnect + i.ToString() + "]" + sUser + sInfo + sLastLogin + " AT %Q." + UsrManMV + sUser + "[" + i.ToString() + "]" + sInfo + sLastLogin + "; (*Automatic generted text*)" + Environment.NewLine;
        }
        private string getUser_Info_Language(int i)
        {
            return getUser_Info_Language_DropDown(i);
        }
        private string getUser_Info_Language_DropDown(int i)
        {
            return UsrManMV + sInternal + sArTextSysLib + sLangDropDownText + " AT %Q." + UsrManMV + sUser + "[" + i.ToString() + "]" + sInfo + sLanguage + sLangDropDown + "; (*Automatic generted text*)" + Environment.NewLine;
        }

    }
}
