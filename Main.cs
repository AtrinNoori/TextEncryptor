using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEncryptorAndDecryptor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Key_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Text_TXT.Focus();

                e.SuppressKeyPress = true;
            }
        }

        private void Text_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Flag_CHBX.Focus();

                e.SuppressKeyPress = true;
            }
        }

        private void Flag_CHBX_Click(object sender, EventArgs e)
        {
            if (Flag_CHBX.Checked)
                Flag_CHBX.Text = "Decrypt";
            else
                Flag_CHBX.Text = "Encrypt";
        }

        private void Start_BTN_Click(object sender, EventArgs e)
        {
            if (Flag_CHBX.Checked) // DECRYPT
            {
                Result_TXT.Clear();

                Result_TXT.Text = TextDecryptor(Text_TXT.Text, Key_TXT.Text);
            }
            else // ENCRYPT
            {
                Result_TXT.Clear();

                Result_TXT.Text = TextEncryptor(Text_TXT.Text, Key_TXT.Text);
            }
        }

        private string TextEncryptor(string input_, string key_)
        {

            try
            {

                byte[] clearData = Encoding.Unicode.GetBytes(input_);

                using (Aes encrypt = Aes.Create())
                using (MemoryStream memS = new MemoryStream())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(key_.ToUpper(), new byte[]
                    {
                        0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
                        0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                    });

                    encrypt.Key = pdb.GetBytes(32);
                    encrypt.IV = pdb.GetBytes(16);

                    CryptoStream cyrptS = new CryptoStream(memS, encrypt.CreateEncryptor(), CryptoStreamMode.Write);
                    cyrptS.Write(clearData, 0, clearData.Length);
                    cyrptS.FlushFinalBlock();
                    cyrptS.Close();


                    return Convert.ToBase64String(memS.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "Error";
        }


        private string TextDecryptor(string input_, string key_)
        {

            try
            {
                byte[] cipherData = Convert.FromBase64String(input_);

                using (Aes encrypt = Aes.Create())
                using (MemoryStream memS = new MemoryStream())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(key_.ToUpper(), new byte[]
                    {
                        0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
                        0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                    });

                    encrypt.Key = pdb.GetBytes(32);
                    encrypt.IV = pdb.GetBytes(16);

                    CryptoStream cryptS = new CryptoStream(memS, encrypt.CreateDecryptor(), CryptoStreamMode.Write);
                    cryptS.Write(cipherData, 0, cipherData.Length);
                    cryptS.FlushFinalBlock();
                    cryptS.Close();

                    return Encoding.Unicode.GetString(memS.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "Error";
        }
    }
}
