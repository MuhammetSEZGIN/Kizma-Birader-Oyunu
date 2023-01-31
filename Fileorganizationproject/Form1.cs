using System;
using System.Collections;
using System.IO;

namespace Fileorganizationproject
{
    public partial class Form1 : Form
    {

        public static PictureBox[] baslamaPozýsyonu = new PictureBox[16];
        public static PictureBox[] tahtaPozisyonu = new PictureBox[52];

        //menü

        public Form1()
        {
            InitializeComponent();

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            oyunSýrasý[0] = kýrmýzý;
            oyunSýrasý[1] = yeþil;
            oyunSýrasý[2] = sarý;
            oyunSýrasý[3] = mavi;

            oyunSýrasý[0].piyonIsimleri[0] = "K1"; oyunSýrasý[0].piyonIsimleri[1] = "K2"; oyunSýrasý[0].piyonIsimleri[2] = "K3"; oyunSýrasý[0].piyonIsimleri[3] = "K4";
            oyunSýrasý[1].piyonIsimleri[0] = "Y1"; oyunSýrasý[1].piyonIsimleri[1] = "Y2"; oyunSýrasý[1].piyonIsimleri[2] = "Y3"; oyunSýrasý[1].piyonIsimleri[3] = "Y4";
            oyunSýrasý[2].piyonIsimleri[0] = "S1"; oyunSýrasý[2].piyonIsimleri[1] = "S2"; oyunSýrasý[2].piyonIsimleri[2] = "S3"; oyunSýrasý[2].piyonIsimleri[3] = "S4";
            oyunSýrasý[3].piyonIsimleri[0] = "M1"; oyunSýrasý[3].piyonIsimleri[1] = "M2"; oyunSýrasý[3].piyonIsimleri[2] = "M3"; oyunSýrasý[3].piyonIsimleri[3] = "M4";

            kýrmýzý.sýra = 1; // sýrayý ata
            yeþil.sýra = 2;
            sarý.sýra = 3;
            mavi.sýra = 4;

            kýrmýzý.ýsým = ýsýmler[0];      // isimleri ata
            yeþil.ýsým = ýsýmler[1];
            sarý.ýsým = ýsýmler[2];
            mavi.ýsým = ýsýmler[3];



            piyonResimleri[0] = kýrmýzýImageList; piyonResimleri[1] = yeþilÝmageList;
            piyonResimleri[2] = sarýÝmageList; piyonResimleri[3] = maviÝmageList;

            baslamaPozýsyonu[0] = K1; baslamaPozýsyonu[1] = K2; baslamaPozýsyonu[2] = K3; baslamaPozýsyonu[3] = K4;
            baslamaPozýsyonu[4] = Y1; baslamaPozýsyonu[5] = Y2; baslamaPozýsyonu[6] = Y3; baslamaPozýsyonu[7] = Y4;
            baslamaPozýsyonu[8] = S1; baslamaPozýsyonu[9] = S2; baslamaPozýsyonu[10] = S3; baslamaPozýsyonu[11] = S4;
            baslamaPozýsyonu[12] = M1; baslamaPozýsyonu[13] = M2; baslamaPozýsyonu[14] = M3; baslamaPozýsyonu[15] = M4;

            tahtaPozisyonu[0] = T1; tahtaPozisyonu[1] = T2; tahtaPozisyonu[2] = T3; tahtaPozisyonu[3] = T4;
            tahtaPozisyonu[4] = T5; tahtaPozisyonu[5] = T6; tahtaPozisyonu[6] = T7; tahtaPozisyonu[7] = T8;
            tahtaPozisyonu[8] = T9; tahtaPozisyonu[9] = T10; tahtaPozisyonu[10] = T11; tahtaPozisyonu[11] = T12;
            tahtaPozisyonu[12] = T13; tahtaPozisyonu[13] = T14; tahtaPozisyonu[14] = T15; tahtaPozisyonu[15] = T16;
            tahtaPozisyonu[16] = T17; tahtaPozisyonu[17] = T18; tahtaPozisyonu[18] = T19; tahtaPozisyonu[19] = T20;
            tahtaPozisyonu[20] = T21; tahtaPozisyonu[21] = T22; tahtaPozisyonu[22] = T23; tahtaPozisyonu[23] = T24;
            tahtaPozisyonu[24] = T25; tahtaPozisyonu[25] = T26; tahtaPozisyonu[26] = T27; tahtaPozisyonu[27] = T28;
            tahtaPozisyonu[28] = T29; tahtaPozisyonu[29] = T30; tahtaPozisyonu[30] = T31; tahtaPozisyonu[31] = T32;
            tahtaPozisyonu[32] = T33; tahtaPozisyonu[33] = T34; tahtaPozisyonu[34] = T35; tahtaPozisyonu[35] = T36;
            tahtaPozisyonu[36] = T37; tahtaPozisyonu[37] = T38; tahtaPozisyonu[38] = T39; tahtaPozisyonu[39] = T40;
            tahtaPozisyonu[40] = T41; tahtaPozisyonu[41] = T42; tahtaPozisyonu[42] = T43; tahtaPozisyonu[43] = T44;
            tahtaPozisyonu[44] = T45; tahtaPozisyonu[45] = T46; tahtaPozisyonu[46] = T47; tahtaPozisyonu[47] = T48;
            tahtaPozisyonu[48] = T49; tahtaPozisyonu[49] = T50; tahtaPozisyonu[50] = T51; tahtaPozisyonu[51] = T52;
            for (int i = 0; i < 52; i++)
            {
                tahtaPozisyonu[i].Visible = true;
            }
            for (int i = 0; i < 16; i++)
            {
                baslamaPozýsyonu[i].Visible = true;
            }
            
            
            StreamReader tahtaKayýt = new StreamReader("tahta.txt");
            string[] kelime = tahtaKayýt.ReadToEnd().Split(' ');
            tahtaKayýt.Close();
            int sayý=4;
            switch (kelime.Length / 8)
            {
                case 2:
                    sayý = 2;
                    oyunSýrasý[2].oyundaMý = false;
                    oyunSýrasý[3].oyundaMý = false;
                    break;
                case 3:
                    sayý = 3;
                    oyunSýrasý[3].oyundaMý = false;
                    break;
            }

            for(int i = 0; i < 52; i++)
            {
                yerDoluMu[i] = false;
            }

            for (int i = 1; i <kelime.Length ; i += 2)
            {
                if(i < 8)
                {
                    if (kelime[i] == "yuvada")
                    {

                        oyunSýrasý[0].piyon_ev[i / 2] = true;
                        baslamaPozýsyonu[i / 2].Image = piyonResimleri[0].Images[i / 2];
                        
                    }
                    else
                    {
                        int temp = Int32.Parse(kelime[i]);
                        oyunSýrasý[0].piyon_kordinatlarý[i / 2] = temp;
                        tahtaPozisyonu[temp].Image = piyonResimleri[0].Images[i / 2];
                        yerDoluMu[temp] = true;
                        yerIsmý[temp]=oyunSýrasý[0].piyonIsimleri[i/2];
                        oyunSýrasý[0].piyon_ev[i / 2] = false;
                    }
                }
                
            }
            for (int i = 1; i < kelime.Length; i += 2 )
            {
                if(i < 16 && i > 8)
                {
                    if (kelime[i] == "yuvada")
                    {
                        oyunSýrasý[1].piyon_ev[i / 2 -4] = true;
                        baslamaPozýsyonu[i / 2].Image = piyonResimleri[1].Images[i / 2 - 4];
                    }
                    else
                    {

                        int temp = Int32.Parse(kelime[i]);
                        oyunSýrasý[1].piyon_kordinatlarý[i / 2 -4] = temp;
                        tahtaPozisyonu[temp].Image = piyonResimleri[1].Images[i / 2 - 4];
                        yerDoluMu[temp] = true;
                        yerIsmý[temp] = oyunSýrasý[1].piyonIsimleri[i / 2-4];
                        oyunSýrasý[1].piyon_ev[i / 2 - 4] = false;
                    }
                }
                
            }
            for (int i = 1; i < kelime.Length; i += 2)
            {
                if(i < 24 && i > 16)
                {
                    if (kelime[i] == "yuvada")
                    {
                        oyunSýrasý[2].piyon_ev[i / 2 -8] = true;
                        baslamaPozýsyonu[i / 2].Image = piyonResimleri[2].Images[i / 2 -8];
                    }
                    else
                    {

                        int temp = Int32.Parse(kelime[i]);
                        oyunSýrasý[2].piyon_kordinatlarý[i / 2 -8] = temp;
                        tahtaPozisyonu[temp].Image = piyonResimleri[2].Images[i / 2 -8];
                        yerDoluMu[temp] = true;
                        yerIsmý[temp] = oyunSýrasý[2].piyonIsimleri[i / 2-8];
                        oyunSýrasý[2].piyon_ev[i / 2 - 8] = false;
                    }
                }
                
            }
            for (int i = 1; i < kelime.Length; i += 2)
            {
                if( i < 33 && i > 24)
                {
                    if (kelime[i] == "yuvada")
                    {
                        oyunSýrasý[3].piyon_ev[i / 2 -12] = true;
                        baslamaPozýsyonu[i / 2].Image = piyonResimleri[3].Images[i / 2 -12];

                    }
                    else
                    {

                        int temp = Int32.Parse(kelime[i]);
                        oyunSýrasý[3].piyon_kordinatlarý[i / 2 -12] = temp;
                        tahtaPozisyonu[temp].Image = piyonResimleri[3].Images[i / 2 -12];
                        yerDoluMu[temp] = true;
                        yerIsmý[temp] = oyunSýrasý[3].piyonIsimleri[i / 2-12];
                        oyunSýrasý[3].piyon_ev[i / 2 - 12] = false;
                    }
                }
                
            }

            

            
            

            groupBox1.Hide();
        }



        // oyuncu sayýsý belirleme combobox
        static int oyuncuSayýsý;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "2")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                oyuncuSayýsý = 2;

                mavi.oyundaMý=false;
                sarý.oyundaMý = false;
            }

            else if (comboBox1.Text == "3")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                oyuncuSayýsý = 3;
                mavi.oyundaMý=false;

            }
            else if (comboBox1.Text == "4")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                oyuncuSayýsý = 4;
            }
        }




        // oyuncu isimlerini alma
        string[] ýsýmler = new string[4];
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ýsýmler[0] = textBox1.Text;

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            ýsýmler[1] = textBox2.Text;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            ýsýmler[2] = textBox3.Text;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            ýsýmler[3] = textBox4.Text;
        }

        

        // oyun sýrasý belirlemek için kullanýlacak diziler
        static int[] atemp = new int[4];
        static string[] oyuncular = new string[4] { "krýmýzý", "yeþil", "sarý", "mavi" };
        StreamWriter File = new StreamWriter("sýra.txt");


        // sýrala butonu
        private void button2_Click(object sender, EventArgs e)
        {

            
            for(int i = 0; i < 4; i++)
            {
                atemp[i] =Zar.zarAt();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i != j)
                    {
                        while (atemp[i] == atemp[j])
                        {
                            atemp[j] = Zar.zarAt();
                        }
                    }
                        
                    
                }
            }

            string temp;
            int temp1;
            for (int i = 0; i < oyuncuSayýsý; i++)
            {
                for (int j = i + 1; j < oyuncuSayýsý; j++)
                {
                    if (atemp[i] > atemp[j])
                    {
                        temp1 = atemp[i];
                        atemp[i] = atemp[j];
                        atemp[j] = temp1;
                        
                        temp = ýsýmler[i];
                        ýsýmler[i] = ýsýmler[j];
                        ýsýmler[j] = temp;
                       

                    }
                }
            }
            for(int i = 0; i < 4; i++)
                Console.WriteLine(atemp[i]);

            for (int i = 0; i < oyuncuSayýsý; i++)
            {
                File.Write(ýsýmler[i] + " ");
                File.WriteLine(oyuncular[i]);

            }
            
            string message = ýsýmler[0] + " " + oyuncular[0] + "\n";
            for (int i = 1; i < oyuncuSayýsý; i++)
            {
                message = message + ýsýmler[i] + " " + oyuncular[i] + "\n";
            }
            MessageBox.Show(message);

            
        }
        
        int zarCount = 0; // her oyuncu bir zar atabilir

        // menüden çýkýþ ve oyuna baþlama
        Oyuncu kýrmýzý = new Oyuncu();
        Oyuncu yeþil = new Oyuncu();
        Oyuncu sarý = new Oyuncu();
        Oyuncu mavi = new Oyuncu();
        
        Oyuncu[] oyunSýrasý = new Oyuncu[4] ;

        ImageList[] piyonResimleri = new ImageList[4];

        // baþla butonu

        private void basla_Click(object sender, EventArgs e)
        {


            oyunSýrasý[0] = kýrmýzý;
            oyunSýrasý[1] = yeþil;
            oyunSýrasý[2] = sarý;
            oyunSýrasý[3] = mavi;

            oyunSýrasý[0].piyonIsimleri[0] = "K1"; oyunSýrasý[0].piyonIsimleri[1] = "K2"; oyunSýrasý[0].piyonIsimleri[2] = "K3"; oyunSýrasý[0].piyonIsimleri[3] = "K4";
            oyunSýrasý[1].piyonIsimleri[0] = "Y1"; oyunSýrasý[1].piyonIsimleri[1] = "Y2"; oyunSýrasý[1].piyonIsimleri[2] = "Y3"; oyunSýrasý[1].piyonIsimleri[3] = "Y4";
            oyunSýrasý[2].piyonIsimleri[0] = "S1"; oyunSýrasý[2].piyonIsimleri[1] = "S2"; oyunSýrasý[2].piyonIsimleri[2] = "S3"; oyunSýrasý[2].piyonIsimleri[3] = "S4";
            oyunSýrasý[3].piyonIsimleri[0] = "M1"; oyunSýrasý[3].piyonIsimleri[1] = "M2"; oyunSýrasý[3].piyonIsimleri[2] = "M3"; oyunSýrasý[3].piyonIsimleri[3] = "M4";

            kýrmýzý.sýra = 1; // sýrayý ata
            yeþil.sýra = 2;
            sarý.sýra = 3;
            mavi.sýra = 4;

            kýrmýzý.ýsým = ýsýmler[0];      // isimleri ata
            yeþil.ýsým = ýsýmler[1];
            sarý.ýsým = ýsýmler[2];
            mavi.ýsým = ýsýmler[3];

            

            piyonResimleri[0] = kýrmýzýImageList; piyonResimleri[1] = yeþilÝmageList;
            piyonResimleri[2] =sarýÝmageList ; piyonResimleri[3] = maviÝmageList;

            baslamaPozýsyonu[0] = K1; baslamaPozýsyonu[1] = K2; baslamaPozýsyonu[2] = K3; baslamaPozýsyonu[3] = K4;
            baslamaPozýsyonu[4] = Y1; baslamaPozýsyonu[5] = Y2; baslamaPozýsyonu[6] = Y3; baslamaPozýsyonu[7] = Y4;
            baslamaPozýsyonu[8] = S1; baslamaPozýsyonu[9] = S2; baslamaPozýsyonu[10] = S3; baslamaPozýsyonu[11] = S4;
            baslamaPozýsyonu[12] = M1; baslamaPozýsyonu[13] = M2; baslamaPozýsyonu[14] = M3; baslamaPozýsyonu[15] = M4;

            for(int i = 0; i < 4; i++)
            {
                baslamaPozýsyonu[i].Image=piyonResimleri[0].Images[i];
                baslamaPozýsyonu[i+4].Image=piyonResimleri[1].Images[i];
                baslamaPozýsyonu[i+8].Image=piyonResimleri[2].Images[i];
                baslamaPozýsyonu[i+12].Image=piyonResimleri[3].Images[i];
            }

            tahtaPozisyonu[0] = T1; tahtaPozisyonu[1] = T2; tahtaPozisyonu[2] = T3; tahtaPozisyonu[3] = T4;
            tahtaPozisyonu[4] = T5; tahtaPozisyonu[5] = T6; tahtaPozisyonu[6] = T7; tahtaPozisyonu[7] = T8;
            tahtaPozisyonu[8] = T9; tahtaPozisyonu[9] = T10; tahtaPozisyonu[10] = T11; tahtaPozisyonu[11] = T12;
            tahtaPozisyonu[12] = T13; tahtaPozisyonu[13] = T14; tahtaPozisyonu[14] = T15; tahtaPozisyonu[15] = T16;
            tahtaPozisyonu[16] = T17; tahtaPozisyonu[17] = T18; tahtaPozisyonu[18] = T19; tahtaPozisyonu[19] = T20;
            tahtaPozisyonu[20] = T21; tahtaPozisyonu[21] = T22; tahtaPozisyonu[22] = T23; tahtaPozisyonu[23] = T24;
            tahtaPozisyonu[24] = T25; tahtaPozisyonu[25] = T26; tahtaPozisyonu[26] = T27; tahtaPozisyonu[27] = T28;
            tahtaPozisyonu[28] = T29; tahtaPozisyonu[29] = T30; tahtaPozisyonu[30] = T31; tahtaPozisyonu[31] = T32;
            tahtaPozisyonu[32] = T33; tahtaPozisyonu[33] = T34; tahtaPozisyonu[34] = T35; tahtaPozisyonu[35] = T36;
            tahtaPozisyonu[36] = T37; tahtaPozisyonu[37] = T38; tahtaPozisyonu[38] = T39; tahtaPozisyonu[39] = T40;
            tahtaPozisyonu[40] = T41; tahtaPozisyonu[41] = T42; tahtaPozisyonu[42] = T43; tahtaPozisyonu[43] = T44;
            tahtaPozisyonu[44] = T45; tahtaPozisyonu[45] = T46; tahtaPozisyonu[46] = T47; tahtaPozisyonu[47] = T48;
            tahtaPozisyonu[48] = T49; tahtaPozisyonu[49] = T50; tahtaPozisyonu[50] = T51; tahtaPozisyonu[51] = T52;
            for(int i = 0; i < 52; i++)
            {
                tahtaPozisyonu[i].Visible = true;
            }
            for (int i = 0; i < 16; i++)
            {
                baslamaPozýsyonu[i].Visible = true;
            }
            for (int i = 0; i < 52; i++)
            {
                yerDoluMu[i] = false; // her yer boþ
            }

            

            groupBox1.Hide();
        }

        
        private void zar_Click(object sender, EventArgs e)
        {

            Zar.gelenZar = Zar.zarAt();
            pictureBox1.Image = imageList1.Images[Zar.gelenZar - 1]; // imageList1 elemanlarýný imageBox a ata
            zarCount++;
            if (zarCount == 5 || (zarCount == 4 && oyuncuSayýsý == 3) || (zarCount==3&&oyuncuSayýsý==2))
            {
                zarCount = 1;
            }
    
            if (zarCount == 1)
            {
                piyonBox.BackColor = Color.Red;
            }
            else if(zarCount == 2)
            {
                piyonBox.BackColor = Color.Green;
            }
            else if(zarCount == 3)
            {
                piyonBox.BackColor= Color.Yellow;
            }
            else if (zarCount == 4)
            {
                piyonBox.BackColor=Color.Blue;
            }
            piyonBox.Visible = true;
            

        }
        bool[] yerDoluMu= new bool[52];
        string[] yerIsmý = new string[52];

        public void baslangýcHamlesý( int piyonSýrasý, int baslama_pozisyonu, int tahtayaGelecekDeðer, int kaçýncýOyuncu)
        {
            
            if (oyunSýrasý[kaçýncýOyuncu].piyon_ev[piyonSýrasý]==true && oyunSýrasý[kaçýncýOyuncu].sýra == zarCount && Zar.gelenZar==6 && oyunSýrasý[kaçýncýOyuncu].oyundaMý == true)
            {
                
                if (yerDoluMu[tahtayaGelecekDeðer]==false)
                {
                    File.WriteLine(oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý] + " yuvadan çýktý");
                    //FileTahta.WriteLine(tahtayaGelecekDeðer + " " + oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý]);

                    baslamaPozýsyonu[baslama_pozisyonu+piyonSýrasý].Image = null;
                    tahtaPozisyonu[tahtayaGelecekDeðer].Image= piyonResimleri[kaçýncýOyuncu].Images[piyonSýrasý];
                    oyunSýrasý[kaçýncýOyuncu].piyon_ev[piyonSýrasý] = false;
                    yerIsmý[tahtayaGelecekDeðer] = oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý];
                    oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] = tahtayaGelecekDeðer;
                    yerDoluMu[tahtayaGelecekDeðer] = true;
                  
                    
                }
                else if(yerDoluMu[tahtayaGelecekDeðer]==true && yerIsmý[tahtayaGelecekDeðer]!= oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[0] && yerIsmý[tahtayaGelecekDeðer] != oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[1] && yerIsmý[tahtayaGelecekDeðer] != oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[2] && yerIsmý[tahtayaGelecekDeðer] != oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[3])
                {
                    for (int i = 0; i < 16; i++)
                        for (int j = 0; j < 4; j++)
                        {
                            if (tahtaPozisyonu[tahtayaGelecekDeðer].Image == piyonResimleri[i/4].Images[j])
                            {
                                File.WriteLine(oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý] + " " + yerIsmý[tahtayaGelecekDeðer] + "'ý yedi");
                                //FileTahta.WriteLine(tahtayaGelecekDeðer + " " + oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý]);

                                baslamaPozýsyonu[i].Image = piyonResimleri[i/4].Images[j]; // çýkýlacak yeri bulduk ve baþlama poziyonuna yerleþtýrdýk
                                oyunSýrasý[i / 4].piyon_ev[j] = true; // baþlangýcýný true olarak ayarladýk ki sonradan tekrar oyuna çýkabilsin

                                baslamaPozýsyonu[baslama_pozisyonu+piyonSýrasý].Image = null; // çýkan taþ
                                tahtaPozisyonu[tahtayaGelecekDeðer].Image = piyonResimleri[kaçýncýOyuncu].Images[piyonSýrasý]; // çýkýlan yer
                                oyunSýrasý[kaçýncýOyuncu].piyon_ev[piyonSýrasý] = false; // çýkan taþ yuvada deðil

                                yerIsmý[tahtayaGelecekDeðer] = oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý];
                                oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý]=tahtayaGelecekDeðer;
                                yerDoluMu[tahtayaGelecekDeðer] = true;


                            }
                        }
                }
                else
                {
                    File.WriteLine(oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý] + " yuvadan çýkamadý");

                }
               
            }
        }

        public void ortakYolHamle(int piyonSýrasý, int kaçýncýOyuncu)
        {
            
            if (oyunSýrasý[kaçýncýOyuncu].piyon_ev[piyonSýrasý] == false && oyunSýrasý[kaçýncýOyuncu].sýra == zarCount && oyunSýrasý[kaçýncýOyuncu].oyundaMý == true)
            {
                
                if (yerDoluMu[(oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] + Zar.gelenZar)%51] == false) // ileriki pozisyon boþ mu dolu mu kontrol et
                {

                    int yeniDeðer = (oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] + Zar.gelenZar)%51;
                    int eskiDeðer = (oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý]) %51;

                    File.WriteLine(oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý] + " "+ Zar.gelenZar +" kadar ilerledi ve " + yeniDeðer+" noktasýna ulaþtý");
                    //FileTahta.WriteLine(yeniDeðer + " " + oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý]);

                    oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] = yeniDeðer; // pozisyonu zar kadar arttýr.
                    
                    tahtaPozisyonu[eskiDeðer].Image = null; // ilk deðer null
                    yerDoluMu[eskiDeðer] = false; // eski deðer boþ
          
                    tahtaPozisyonu[yeniDeðer].Image = piyonResimleri[kaçýncýOyuncu].Images[piyonSýrasý]; // yeni deðere piyon ata
                    yerDoluMu[yeniDeðer] = true; // yeni deðer dolu
                    yerIsmý[yeniDeðer] = oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý];
                }
                else if(yerDoluMu[oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] + Zar.gelenZar] == true 
                    && yerIsmý[oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] + Zar.gelenZar]!= oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[0]
                    && yerIsmý[oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] + Zar.gelenZar] != oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[1]
                    && yerIsmý[oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] + Zar.gelenZar] != oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[2]
                    && yerIsmý[oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] + Zar.gelenZar] != oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[3]) // yer doluysa ve kendi piyonu yoksa 
                   
                {
                    int yeniDeðer = (oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] + Zar.gelenZar)%51;
                    int eskiDeðer = (oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý])%51;
                    
                    

                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                        {
                            if (tahtaPozisyonu[yeniDeðer].Image == piyonResimleri[i].Images[j]) // yeni deðerdeki piyonu bulma
                            {
                                File.WriteLine(oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý] + " " + yerIsmý[yeniDeðer] + "'ý yedi");

                                baslamaPozýsyonu[4*i+j].Image = piyonResimleri[i].Images[j]; // yenilecek piyonu bulduk ve baþlama poziyonuna yerleþtýrdýk
                                oyunSýrasý[i].piyon_ev[j] = true; // baþlangýcýný true olarak ayarladýk ki sonradan tekrar oyuna çýkabilsin

                                tahtaPozisyonu[eskiDeðer].Image = null; // yerinden oynayan taþ
                                tahtaPozisyonu[yeniDeðer].Image = piyonResimleri[kaçýncýOyuncu].Images[piyonSýrasý]; // yeni deðere piyon ata
                                oyunSýrasý[kaçýncýOyuncu].piyon_ev[piyonSýrasý] = false; // çýkan taþ yuvada deðil (zaten olmamasý lazým)

                                yerIsmý[yeniDeðer] = oyunSýrasý[kaçýncýOyuncu].piyonIsimleri[piyonSýrasý];
                                oyunSýrasý[kaçýncýOyuncu].piyon_kordinatlarý[piyonSýrasý] = yeniDeðer; //pozisyonu zar kadar arttýr.
                                yerDoluMu[yeniDeðer] = true; // zaten true olmasý lazým ama ne olur ne olmaz

                                

                            }
                        }

                }

                  
            }
        }
        SortedList tahta = new SortedList();
        private void piyon1_Click(object sender, EventArgs e)
        {

            //K1
            
            ortakYolHamle(0, 0);
            //Y1
            
            ortakYolHamle(0, 1);
            // S1  oyunsýrasý 2 baslamapozisyonu 8 
            
            ortakYolHamle(0, 2);


            // M1 baslamaPozýsyonu[12] tahtaPozisyonu[39] oyunSýrasý[3]
            
            ortakYolHamle(0, 3);

            piyonBox.Visible = false;
        }

        private void piyon2_Click(object sender, EventArgs e)
        {
            //K2
            
            ortakYolHamle(1, 0);

            //Y2
            
            ortakYolHamle(1, 1);

            // S2 oyunsýrasý 2 baslamapozisyonu 8 
            
            ortakYolHamle(1, 2);

            // M2 
            
            ortakYolHamle(1, 3);

            piyonBox.Visible = false;
        }

        private void piyon3_Click(object sender, EventArgs e)
        {
            //K3
            
            ortakYolHamle(2, 0);

            //Y3
            ortakYolHamle(2, 1);

            // S3 oyunsýrasý 2 baslamapozisyonu 8 
           
            ortakYolHamle(2, 2);

            // M3
           
            ortakYolHamle(2, 3);

            piyonBox.Visible = false;
        }

        private void piyon4_Click(object sender, EventArgs e)
        {
            //K4
            
            ortakYolHamle(3, 0);

            //Y4
            
            ortakYolHamle(3, 1);

            // S4 oyunsýrasý 2 baslamapozisyonu 8 
            
            ortakYolHamle(3, 2);

            // M4 
            
            ortakYolHamle(3, 3);

            piyonBox.Visible = false;

        }

        private void kaydetveçýk_Click(object sender, EventArgs e)
        {
            File.Close();
            StreamWriter FileTahta = new StreamWriter("tahta.txt");
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (oyunSýrasý[i].piyon_ev[j] == false)
                    {
                        FileTahta.Write(oyunSýrasý[i].piyonIsimleri[j] + " " + (oyunSýrasý[i].piyon_kordinatlarý[j] ) % 51 + " ");
                    }

                    else
                    {
                        FileTahta.Write(oyunSýrasý[i].piyonIsimleri[j] + " " + "yuvada" + " ");
                    }
                    
                }
            }
            FileTahta.Close();


        }

        private void K1_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(0, 0, 0, 0);
            piyonBox.Visible = false;
        }

        private void K2_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(1, 0, 0, 0);
            piyonBox.Visible = false;
        }

        private void K3_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(2, 0, 0, 0);
            piyonBox.Visible = false;
        }

        private void K4_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(3, 0, 0, 0);
            piyonBox.Visible = false;
        }

        private void Y1_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(0, 4, 13, 1);
            piyonBox.Visible = false;
        }

        private void Y2_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(1, 4, 13, 1);
            piyonBox.Visible = false;
        }

        private void Y3_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(2, 4, 13, 1);
            piyonBox.Visible = false;

        }

        private void Y4_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(3, 4, 13, 1);
            piyonBox.Visible = false;
        }
        private void S1_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(0, 8, 26, 2);
            piyonBox.Visible = false;
        }

        private void S2_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(1, 8, 26, 2);
            piyonBox.Visible = false;
        }

        private void S3_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(2, 8, 26, 2);
            piyonBox.Visible = false;
        }

        private void S4_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(3, 8, 26, 2);
            piyonBox.Visible = false;
        }
        private void M1_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(0, 12, 39, 3);
            piyonBox.Visible = false;
        }

        private void M2_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(1, 12, 39, 3);
            piyonBox.Visible = false;
        }

        private void M3_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(2, 12, 39, 3);
            piyonBox.Visible = false;
        }

        private void M4_Click(object sender, EventArgs e)
        {
            baslangýcHamlesý(3, 12, 39, 3);
            piyonBox.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            piyonBox.Visible = false;
        }
    }
}