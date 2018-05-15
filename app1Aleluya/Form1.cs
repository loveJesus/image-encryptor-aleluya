//Praise God from whom all blessings flow
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

namespace app1Aleluya
{
    public partial class Form1 : Form
    {
        public int owidthAleluya, oheightAleluya;
        public long olengthAleluya;
        public System.Drawing.Bitmap oimgAleluya;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link linkAleluya = new LinkLabel.Link();
            linkAleluya.LinkData = "http://www.jesusfilm.org/watch/jesus.html/english.html";
            linkLabel1.Links.Add(linkAleluya);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //Decode image Aleluya :D
        private void button4_Click(object sender, EventArgs e)
        {
            //Hallelujah
            //Hallelujah

            //Make sure form is filled enough
            if (!(inputImageAleluya.Text.Length > 0 &&
                    passwordAleluya.Text.Length > 0 
                  ))
            {

                quickAlertAleluya("Praise God :D \n\nThis will not work,\nfirst you must fill:\n\n - Password - Hallelujah\n - Input Image - Hallelujah\n \n Praise God",
                     "Error Detected - Hallelujah");
                return;

            }

           
            //Ok get input bits
            byte[] responseAleluya = new byte[(oheightAleluya * owidthAleluya) *3];
            long bitCountAleluya = 0;

            for (int y = 0; y < oheightAleluya; y++)
            {
                for (int x = 0; x < owidthAleluya; x++)
                {
                    System.Drawing.Color cAleluya = oimgAleluya.GetPixel(x, y);
                    long cPtrAleluya;
                    bool dBoolAleluya;
                    byte dByteAleluya;
                    byte[] colsAleluya = { cAleluya.R, cAleluya.G, cAleluya.B };

                    for (int iAleluya = 0; iAleluya < 3; iAleluya++)
                    {
                        byte valAleluya = colsAleluya[iAleluya];
                        cPtrAleluya = (bitCountAleluya >> 3);

                        if((valAleluya & 0x1) == 1)
                        {
                            responseAleluya[cPtrAleluya] |= (byte)(1 << (((int)bitCountAleluya) & 7));
                        }
                        else
                        {
                            responseAleluya[cPtrAleluya] &= (byte)(0xff ^ (1 << (((int)bitCountAleluya) & 7)));
                        }                        
                        bitCountAleluya++;
                    }

                }
            }
            byte[] decryptedAleluya = CryptAleluya.Decrypt(responseAleluya, passwordAleluya.Text);

            //Ok attempt to decrypt the data
            
            byte[] bCheckAleluya = new ArraySegment<byte>(decryptedAleluya, 0, 2).ToArray();
            if (BitConverter.IsLittleEndian == false) Array.Reverse(bCheckAleluya);
            Int16 checksumFAleluya = BitConverter.ToInt16(bCheckAleluya, 0);

            byte[] bSizeAleluya = new ArraySegment<byte>(decryptedAleluya, 2, 4).ToArray();
            if (BitConverter.IsLittleEndian == false) Array.Reverse(bSizeAleluya); //Work on macG5
            int sizeComposedAleluya = BitConverter.ToInt32(bSizeAleluya, 0);
            int fnSizeAleluya       = sizeComposedAleluya & 0xff;
            int fSizeAleluya        = sizeComposedAleluya >> 8;
            if ( (fSizeAleluya + fnSizeAleluya > decryptedAleluya.Length) || (fSizeAleluya+fnSizeAleluya < 0)) {
                quickAlertAleluya("God be praised, wrong image or password :)" , "Hallelujah");
                return;
            }
            byte[] bToCheckAleluya = new ArraySegment<byte>(decryptedAleluya, 2, fSizeAleluya + fnSizeAleluya + 4).ToArray();
            int checksumAleluya = 0;
            foreach (int vAleluya in bToCheckAleluya) { checksumAleluya += vAleluya; }
            Int16 checksumVAleluya = (Int16)checksumAleluya;
            if (checksumFAleluya != checksumVAleluya)
            {
                quickAlertAleluya("God be praised, wrong image or password :)", "Hallelujah");
                return;
            }                      

            byte[] fnAleluya    = new ArraySegment<byte>(decryptedAleluya, 6, fnSizeAleluya).ToArray();
            byte[] dtOutAleluya = new ArraySegment<byte>(decryptedAleluya, 6 + fnSizeAleluya, fSizeAleluya).ToArray();
            string fnStringAleluya  = Encoding.UTF8.GetString(fnAleluya);
            
            //quickAlertAleluya( Convert.ToBase64String(encryptedAleluya), "Hallelujah");

            SaveFileDialog fdlgAleluya = new SaveFileDialog();
            fdlgAleluya.Title = "Select Output File";
            fdlgAleluya.Filter = "Original - Aleluya ("+fnStringAleluya+")|"+fnStringAleluya+"|All files (*.*)|*.*";
            fdlgAleluya.FilterIndex      = 1;
            fdlgAleluya.FileName         = fnStringAleluya;
            fdlgAleluya.RestoreDirectory = true;
            if (fdlgAleluya.ShowDialog() == DialogResult.OK)
            {
                string destFileNameAleluya = fdlgAleluya.FileName;
                File.WriteAllBytes(destFileNameAleluya, dtOutAleluya);
                quickAlertAleluya("God be praised, decoded file should have saved ok", "Hallelujah");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thanks Jesus for Alireza0000 and Josh R
            OpenFileDialog fdlgAleluya = new OpenFileDialog();
            fdlgAleluya.Title = "Select input image";
            //fdlgAleluya.InitialDirectory = @"c:\";
            fdlgAleluya.Filter = "Png Files (*.png)|*.png|All files (*.*)|*.*";
            fdlgAleluya.FilterIndex = 1;
            fdlgAleluya.RestoreDirectory = true;
            if (fdlgAleluya.ShowDialog() == DialogResult.OK)
            {
                inputImageAleluya.Text  = fdlgAleluya.FileName;
                oimgAleluya    = new System.Drawing.Bitmap(fdlgAleluya.FileName);
                owidthAleluya  = oimgAleluya.Width;
                oheightAleluya = oimgAleluya.Height;
                previewImgAleluya.Image = oimgAleluya;
            } 
        }

        static public void quickAlertAleluya(string messageAleluya, string captionAleluya)
        {     
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(messageAleluya, captionAleluya, buttons);
            return;
        }

        private void encodeBtnAleluya_Click(object sender, EventArgs e)
        {
            //Hallelujah

            //Make sure form is filled enough
            if( ! ( inputImageAleluya.Text.Length > 0 &&
                    passwordAleluya.Text.Length   > 0 &&
                    inputDataAleluya.Text.Length  > 0
                  ) ) {

                quickAlertAleluya("Praise God :D \n\nThis will not work,\nfirst you must fill:\n\n - Password - Hallelujah\n - Input Image - Hallelujah\n - Input Data - Hallelujah",
                     "Error Detected - Hallelujah");
                return;

            }

            
            //Make sure data can easily fit in the image
            long dataLengthAleluya = olengthAleluya + 32;
            int imgDimsAleluya = owidthAleluya * oheightAleluya;
            if ((imgDimsAleluya / 4) < dataLengthAleluya)
            {
                quickAlertAleluya("Praise God :D \n\nTo be on the safe side, we require the file to be fewer bytes than the image height*width / 4.",
                    "Error Detected - Hallelujah");
                return;
            }

            //Ok attempt to encrypt the data
            int tLengthAleluya = (int)olengthAleluya;
            tLengthAleluya <<= 8;
            string basenameAleluya = new FileInfo(inputDataAleluya.Text).Name;
            tLengthAleluya += basenameAleluya.Length; // pack in filename
            byte[] bSizeAleluya = BitConverter.GetBytes(tLengthAleluya);
            if (BitConverter.IsLittleEndian == false) Array.Reverse(bSizeAleluya);            
            byte[] dtInAleluya = bSizeAleluya.Concat(Encoding.ASCII.GetBytes(basenameAleluya).Concat(System.IO.File.ReadAllBytes(inputDataAleluya.Text)).ToArray()).ToArray();
            int checksumAleluya = 0;
            foreach (int vAleluya in dtInAleluya) { checksumAleluya += vAleluya; }
            Int16 checksumFAleluya = (Int16)checksumAleluya;
            byte[] bCheckAleluya = BitConverter.GetBytes(checksumFAleluya);
            if (BitConverter.IsLittleEndian == false) Array.Reverse(bCheckAleluya);
            byte[] encryptedAleluya = CryptAleluya.Encrypt( bCheckAleluya.Concat(dtInAleluya).ToArray() , passwordAleluya.Text );

            
            //byte[] responseAleluya = new byte[(oheightAleluya * owidthAleluya) >> 2];
            //quickAlertAleluya( Convert.ToBase64String(new ArraySegment<byte>(encryptedAleluya,0,32).ToArray()), "Hallelujah");
            
            long bitCountAleluya = 0;

            Random rndAleluya = new Random();

            
            for (int y = 0; y < oheightAleluya; y++) {
                for (int x = 0; x < owidthAleluya; x++) {
                    System.Drawing.Color cAleluya =  oimgAleluya.GetPixel(x, y);                    
                    long cPtrAleluya;
                    bool dBoolAleluya;
                    byte dByteAleluya;
                    byte[] colsAleluya={cAleluya.R, cAleluya.G, cAleluya.B};

                    for (int iAleluya = 0; iAleluya < 3; iAleluya++)
                    {
                        byte valAleluya = colsAleluya[iAleluya];
                        cPtrAleluya = (bitCountAleluya >> 3);

                        if (cPtrAleluya < encryptedAleluya.Length)
                        {
                            dByteAleluya = encryptedAleluya[cPtrAleluya];
                            dBoolAleluya = ((dByteAleluya & (1 << (((int)bitCountAleluya) & 7))) > 0 ? true : false);
                        }
                        else
                        {
                            dBoolAleluya = rndAleluya.Next(0, 2) > 0;
                        }
                        //dBoolAleluya = rndAleluya.Next(0, 2) > 0;

                        if (dBoolAleluya)
                        {
                            valAleluya |= 1;
                        }
                        else
                        {
                            valAleluya &= 0xff ^ 1;
                        }
                        colsAleluya[iAleluya] = valAleluya;
                        bitCountAleluya++;
                    }
                    oimgAleluya.SetPixel( x,y, Color.FromArgb(cAleluya.A, colsAleluya[0], colsAleluya[1], colsAleluya[2]));             
                    
                }
            }

            SaveFileDialog fdlgAleluya = new SaveFileDialog();
            fdlgAleluya.Title = "Select Output File";
            fdlgAleluya.Filter = "All files (*.png)|*.png";
            fdlgAleluya.FilterIndex = 1;
            fdlgAleluya.RestoreDirectory = true;
            if (fdlgAleluya.ShowDialog() == DialogResult.OK)
            {
                string destFileNameAleluya = fdlgAleluya.FileName;
                if (System.IO.File.Exists(destFileNameAleluya))
                    System.IO.File.Delete(destFileNameAleluya);
                oimgAleluya.Save(destFileNameAleluya);
                quickAlertAleluya("God be praised, encoded image saved ok God willing.", "Hallelujah");
            }

            
        }

        private void selectInputDataAleluya_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlgAleluya = new OpenFileDialog();
            fdlgAleluya.Title = "Select input data";
            //fdlgAleluya.InitialDirectory = @"c:\";
            fdlgAleluya.Filter = "All files (*.*)|*.*";
            fdlgAleluya.FilterIndex = 1;
            fdlgAleluya.RestoreDirectory = true;
            if (fdlgAleluya.ShowDialog() == DialogResult.OK)
            {
                inputDataAleluya.Text = fdlgAleluya.FileName;
                olengthAleluya = new System.IO.FileInfo(inputDataAleluya.Text).Length;
            } 
        }

        private void inputImageAleluya_Click(object sender, EventArgs eAleluya)
        {
            button1_Click(sender, eAleluya);
        }

        private void inputDataAleluya_Click(object sender, EventArgs eAleluya)
        {
            selectInputDataAleluya_Click(sender, eAleluya);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
