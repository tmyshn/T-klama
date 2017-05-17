using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.IO;

namespace Tıklama
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetAsyncKeyState(long Tus);
        //string[] bol;
        List<string> parcalar = new List<string>();
        string parcalar2;
        string parcalar3;
        string parcalar4;
        string parcalar5;
        string parcalar6;
        int i=0;
        int j=0;
        int v1 = 0;
        int v2 = 0;
        int v3 = 0;
        int v4 = 0;
        int v5 = 0;
        int v6 = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Falcı İkizler";
        }
        byte tus1al = (byte)Keys.ControlKey;
        byte tus1 = (byte)49;
        byte tus2 = (byte)50;
        byte tus3 = (byte)51;
        byte tus4= (byte)52;
        byte tus5 = (byte)53;
        private void Form1_Load(object sender, EventArgs e)
        {
            dosyadanOku();
            dosyadanOku2();
            dosyadanOku3();
            dosyadanOku4();
            dosyadanOku5();
            dosyadanOku6();
            timer1.Start();

            DateTime dt = DateTime.Now;
            string dosya_yolu = @"D:\\logfal.txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);

            wr.WriteLine("Başlangıç Zamanı : " + dt);
            wr.Close();

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(log);

        }
        public static bool TusKontrol(byte Kod)

        {

            if (GetAsyncKeyState((long)Kod) == System.Int16.MinValue + 1)
                return true;
            else
                return false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TusKontrol(tus1al))
            {

                if (!parcalar[i].Any())
                {
                    i = 0;
                }

                else
                {

                    Clipboard.SetText(parcalar[i]);
                    SendKeys.Send("^V");
                    i++;
                    label3.Text = j.ToString();
                    j++;
                    v1++;
                }
               
                
            }
            else if (TusKontrol(tus1))
            {

                Clipboard.SetText(parcalar2);
                SendKeys.Send("{BACKSPACE}");
                label3.Text = j.ToString();
                SendKeys.Send("^V");
                j++;
                v2++;

            }

            else if (TusKontrol(tus2))
            {

                Clipboard.SetText(parcalar3);
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("^V");
                label3.Text = j.ToString();
                j++;
                v3++;

            }

            else if (TusKontrol(tus3))
            {

                Clipboard.SetText(parcalar4);
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("^V");
                label3.Text = j.ToString();
                j++;
                v4++;

            }

            else if (TusKontrol(tus4))
            {

                Clipboard.SetText(parcalar5);
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("^V");
                label3.Text = j.ToString();
                j++;
                v5++;

            }

            else if (TusKontrol(tus5))
            {

                Clipboard.SetText(parcalar6);
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("^V");
                label3.Text = j.ToString();
                j++;
                v6++;

            }

        }

        public  void dosyadanOku()
        {
            string dosya_yolu =@"C:\\tmy.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadToEnd();
            parcalar= yazi.Split('*').ToList();
            
          
            // MessageBox.Show(parcalar[1]);


            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }


        public void dosyadanOku2()
        {
            string dosya_yolu = @"C:\\tmy2.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            parcalar2 = sw.ReadToEnd();

            // MessageBox.Show(parcalar[1]);


            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

        public void dosyadanOku3()
        {
            string dosya_yolu = @"C:\\tmy3.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            parcalar3 = sw.ReadToEnd();

            // MessageBox.Show(parcalar[1]);


            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

        public void dosyadanOku4()
        {
            string dosya_yolu = @"C:\\tmy4.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            parcalar4 = sw.ReadToEnd();

            // MessageBox.Show(parcalar[1]);


            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

        public void dosyadanOku5()
        {
            string dosya_yolu = @"C:\\tmy5.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            parcalar5 = sw.ReadToEnd();

            // MessageBox.Show(parcalar[1]);


            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }
        public void dosyadanOku6()
        {
            string dosya_yolu = @"C:\\tmy6.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            parcalar6 = sw.ReadToEnd();

            // MessageBox.Show(parcalar[1]);


            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

       
        

        public void log(object sender , EventArgs e)
        {    
            DateTime dt = DateTime.Now;
            string dosya_yolu = @"D:\\logfal.txt";
        
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);
    
                wr.WriteLine("Cıkış zamanı : "+dt);
                wr.WriteLine("Fal Gönderim = "+v1+" kere");
                wr.WriteLine("1.Tuş = " + v2 + " kere");
                wr.WriteLine("2. Tuş = " + v3 + " kere");
                wr.WriteLine("3. Tuş = " + v4 + " kere");
                wr.WriteLine("4. Tuş = " + v5 + " kere");
                wr.WriteLine("5. Tuş = " + v6 + " kere");
                wr.Close();
          
           
         
        }
    }

   
}
    




  