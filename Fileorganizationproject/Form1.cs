using System;
using System.Collections;
using System.IO;

namespace Fileorganizationproject
{
    public partial class Form1 : Form
    {

        public static PictureBox[] baslamaPoz�syonu = new PictureBox[16];
        public static PictureBox[] tahtaPozisyonu = new PictureBox[52];

        //men�

        public Form1()
        {
            InitializeComponent();

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            oyunS�ras�[0] = k�rm�z�;
            oyunS�ras�[1] = ye�il;
            oyunS�ras�[2] = sar�;
            oyunS�ras�[3] = mavi;

            oyunS�ras�[0].piyonIsimleri[0] = "K1"; oyunS�ras�[0].piyonIsimleri[1] = "K2"; oyunS�ras�[0].piyonIsimleri[2] = "K3"; oyunS�ras�[0].piyonIsimleri[3] = "K4";
            oyunS�ras�[1].piyonIsimleri[0] = "Y1"; oyunS�ras�[1].piyonIsimleri[1] = "Y2"; oyunS�ras�[1].piyonIsimleri[2] = "Y3"; oyunS�ras�[1].piyonIsimleri[3] = "Y4";
            oyunS�ras�[2].piyonIsimleri[0] = "S1"; oyunS�ras�[2].piyonIsimleri[1] = "S2"; oyunS�ras�[2].piyonIsimleri[2] = "S3"; oyunS�ras�[2].piyonIsimleri[3] = "S4";
            oyunS�ras�[3].piyonIsimleri[0] = "M1"; oyunS�ras�[3].piyonIsimleri[1] = "M2"; oyunS�ras�[3].piyonIsimleri[2] = "M3"; oyunS�ras�[3].piyonIsimleri[3] = "M4";

            k�rm�z�.s�ra = 1; // s�ray� ata
            ye�il.s�ra = 2;
            sar�.s�ra = 3;
            mavi.s�ra = 4;

            k�rm�z�.�s�m = �s�mler[0];      // isimleri ata
            ye�il.�s�m = �s�mler[1];
            sar�.�s�m = �s�mler[2];
            mavi.�s�m = �s�mler[3];



            piyonResimleri[0] = k�rm�z�ImageList; piyonResimleri[1] = ye�il�mageList;
            piyonResimleri[2] = sar��mageList; piyonResimleri[3] = mavi�mageList;

            baslamaPoz�syonu[0] = K1; baslamaPoz�syonu[1] = K2; baslamaPoz�syonu[2] = K3; baslamaPoz�syonu[3] = K4;
            baslamaPoz�syonu[4] = Y1; baslamaPoz�syonu[5] = Y2; baslamaPoz�syonu[6] = Y3; baslamaPoz�syonu[7] = Y4;
            baslamaPoz�syonu[8] = S1; baslamaPoz�syonu[9] = S2; baslamaPoz�syonu[10] = S3; baslamaPoz�syonu[11] = S4;
            baslamaPoz�syonu[12] = M1; baslamaPoz�syonu[13] = M2; baslamaPoz�syonu[14] = M3; baslamaPoz�syonu[15] = M4;

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
                baslamaPoz�syonu[i].Visible = true;
            }
            
            
            StreamReader tahtaKay�t = new StreamReader("tahta.txt");
            string[] kelime = tahtaKay�t.ReadToEnd().Split(' ');
            tahtaKay�t.Close();
            int say�=4;
            switch (kelime.Length / 8)
            {
                case 2:
                    say� = 2;
                    oyunS�ras�[2].oyundaM� = false;
                    oyunS�ras�[3].oyundaM� = false;
                    break;
                case 3:
                    say� = 3;
                    oyunS�ras�[3].oyundaM� = false;
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

                        oyunS�ras�[0].piyon_ev[i / 2] = true;
                        baslamaPoz�syonu[i / 2].Image = piyonResimleri[0].Images[i / 2];
                        
                    }
                    else
                    {
                        int temp = Int32.Parse(kelime[i]);
                        oyunS�ras�[0].piyon_kordinatlar�[i / 2] = temp;
                        tahtaPozisyonu[temp].Image = piyonResimleri[0].Images[i / 2];
                        yerDoluMu[temp] = true;
                        yerIsm�[temp]=oyunS�ras�[0].piyonIsimleri[i/2];
                        oyunS�ras�[0].piyon_ev[i / 2] = false;
                    }
                }
                
            }
            for (int i = 1; i < kelime.Length; i += 2 )
            {
                if(i < 16 && i > 8)
                {
                    if (kelime[i] == "yuvada")
                    {
                        oyunS�ras�[1].piyon_ev[i / 2 -4] = true;
                        baslamaPoz�syonu[i / 2].Image = piyonResimleri[1].Images[i / 2 - 4];
                    }
                    else
                    {

                        int temp = Int32.Parse(kelime[i]);
                        oyunS�ras�[1].piyon_kordinatlar�[i / 2 -4] = temp;
                        tahtaPozisyonu[temp].Image = piyonResimleri[1].Images[i / 2 - 4];
                        yerDoluMu[temp] = true;
                        yerIsm�[temp] = oyunS�ras�[1].piyonIsimleri[i / 2-4];
                        oyunS�ras�[1].piyon_ev[i / 2 - 4] = false;
                    }
                }
                
            }
            for (int i = 1; i < kelime.Length; i += 2)
            {
                if(i < 24 && i > 16)
                {
                    if (kelime[i] == "yuvada")
                    {
                        oyunS�ras�[2].piyon_ev[i / 2 -8] = true;
                        baslamaPoz�syonu[i / 2].Image = piyonResimleri[2].Images[i / 2 -8];
                    }
                    else
                    {

                        int temp = Int32.Parse(kelime[i]);
                        oyunS�ras�[2].piyon_kordinatlar�[i / 2 -8] = temp;
                        tahtaPozisyonu[temp].Image = piyonResimleri[2].Images[i / 2 -8];
                        yerDoluMu[temp] = true;
                        yerIsm�[temp] = oyunS�ras�[2].piyonIsimleri[i / 2-8];
                        oyunS�ras�[2].piyon_ev[i / 2 - 8] = false;
                    }
                }
                
            }
            for (int i = 1; i < kelime.Length; i += 2)
            {
                if( i < 33 && i > 24)
                {
                    if (kelime[i] == "yuvada")
                    {
                        oyunS�ras�[3].piyon_ev[i / 2 -12] = true;
                        baslamaPoz�syonu[i / 2].Image = piyonResimleri[3].Images[i / 2 -12];

                    }
                    else
                    {

                        int temp = Int32.Parse(kelime[i]);
                        oyunS�ras�[3].piyon_kordinatlar�[i / 2 -12] = temp;
                        tahtaPozisyonu[temp].Image = piyonResimleri[3].Images[i / 2 -12];
                        yerDoluMu[temp] = true;
                        yerIsm�[temp] = oyunS�ras�[3].piyonIsimleri[i / 2-12];
                        oyunS�ras�[3].piyon_ev[i / 2 - 12] = false;
                    }
                }
                
            }

            

            
            

            groupBox1.Hide();
        }



        // oyuncu say�s� belirleme combobox
        static int oyuncuSay�s�;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "2")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                oyuncuSay�s� = 2;

                mavi.oyundaM�=false;
                sar�.oyundaM� = false;
            }

            else if (comboBox1.Text == "3")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                oyuncuSay�s� = 3;
                mavi.oyundaM�=false;

            }
            else if (comboBox1.Text == "4")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                oyuncuSay�s� = 4;
            }
        }




        // oyuncu isimlerini alma
        string[] �s�mler = new string[4];
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            �s�mler[0] = textBox1.Text;

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            �s�mler[1] = textBox2.Text;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            �s�mler[2] = textBox3.Text;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            �s�mler[3] = textBox4.Text;
        }

        

        // oyun s�ras� belirlemek i�in kullan�lacak diziler
        static int[] atemp = new int[4];
        static string[] oyuncular = new string[4] { "kr�m�z�", "ye�il", "sar�", "mavi" };
        StreamWriter File = new StreamWriter("s�ra.txt");


        // s�rala butonu
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
            for (int i = 0; i < oyuncuSay�s�; i++)
            {
                for (int j = i + 1; j < oyuncuSay�s�; j++)
                {
                    if (atemp[i] > atemp[j])
                    {
                        temp1 = atemp[i];
                        atemp[i] = atemp[j];
                        atemp[j] = temp1;
                        
                        temp = �s�mler[i];
                        �s�mler[i] = �s�mler[j];
                        �s�mler[j] = temp;
                       

                    }
                }
            }
            for(int i = 0; i < 4; i++)
                Console.WriteLine(atemp[i]);

            for (int i = 0; i < oyuncuSay�s�; i++)
            {
                File.Write(�s�mler[i] + " ");
                File.WriteLine(oyuncular[i]);

            }
            
            string message = �s�mler[0] + " " + oyuncular[0] + "\n";
            for (int i = 1; i < oyuncuSay�s�; i++)
            {
                message = message + �s�mler[i] + " " + oyuncular[i] + "\n";
            }
            MessageBox.Show(message);

            
        }
        
        int zarCount = 0; // her oyuncu bir zar atabilir

        // men�den ��k�� ve oyuna ba�lama
        Oyuncu k�rm�z� = new Oyuncu();
        Oyuncu ye�il = new Oyuncu();
        Oyuncu sar� = new Oyuncu();
        Oyuncu mavi = new Oyuncu();
        
        Oyuncu[] oyunS�ras� = new Oyuncu[4] ;

        ImageList[] piyonResimleri = new ImageList[4];

        // ba�la butonu

        private void basla_Click(object sender, EventArgs e)
        {


            oyunS�ras�[0] = k�rm�z�;
            oyunS�ras�[1] = ye�il;
            oyunS�ras�[2] = sar�;
            oyunS�ras�[3] = mavi;

            oyunS�ras�[0].piyonIsimleri[0] = "K1"; oyunS�ras�[0].piyonIsimleri[1] = "K2"; oyunS�ras�[0].piyonIsimleri[2] = "K3"; oyunS�ras�[0].piyonIsimleri[3] = "K4";
            oyunS�ras�[1].piyonIsimleri[0] = "Y1"; oyunS�ras�[1].piyonIsimleri[1] = "Y2"; oyunS�ras�[1].piyonIsimleri[2] = "Y3"; oyunS�ras�[1].piyonIsimleri[3] = "Y4";
            oyunS�ras�[2].piyonIsimleri[0] = "S1"; oyunS�ras�[2].piyonIsimleri[1] = "S2"; oyunS�ras�[2].piyonIsimleri[2] = "S3"; oyunS�ras�[2].piyonIsimleri[3] = "S4";
            oyunS�ras�[3].piyonIsimleri[0] = "M1"; oyunS�ras�[3].piyonIsimleri[1] = "M2"; oyunS�ras�[3].piyonIsimleri[2] = "M3"; oyunS�ras�[3].piyonIsimleri[3] = "M4";

            k�rm�z�.s�ra = 1; // s�ray� ata
            ye�il.s�ra = 2;
            sar�.s�ra = 3;
            mavi.s�ra = 4;

            k�rm�z�.�s�m = �s�mler[0];      // isimleri ata
            ye�il.�s�m = �s�mler[1];
            sar�.�s�m = �s�mler[2];
            mavi.�s�m = �s�mler[3];

            

            piyonResimleri[0] = k�rm�z�ImageList; piyonResimleri[1] = ye�il�mageList;
            piyonResimleri[2] =sar��mageList ; piyonResimleri[3] = mavi�mageList;

            baslamaPoz�syonu[0] = K1; baslamaPoz�syonu[1] = K2; baslamaPoz�syonu[2] = K3; baslamaPoz�syonu[3] = K4;
            baslamaPoz�syonu[4] = Y1; baslamaPoz�syonu[5] = Y2; baslamaPoz�syonu[6] = Y3; baslamaPoz�syonu[7] = Y4;
            baslamaPoz�syonu[8] = S1; baslamaPoz�syonu[9] = S2; baslamaPoz�syonu[10] = S3; baslamaPoz�syonu[11] = S4;
            baslamaPoz�syonu[12] = M1; baslamaPoz�syonu[13] = M2; baslamaPoz�syonu[14] = M3; baslamaPoz�syonu[15] = M4;

            for(int i = 0; i < 4; i++)
            {
                baslamaPoz�syonu[i].Image=piyonResimleri[0].Images[i];
                baslamaPoz�syonu[i+4].Image=piyonResimleri[1].Images[i];
                baslamaPoz�syonu[i+8].Image=piyonResimleri[2].Images[i];
                baslamaPoz�syonu[i+12].Image=piyonResimleri[3].Images[i];
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
                baslamaPoz�syonu[i].Visible = true;
            }
            for (int i = 0; i < 52; i++)
            {
                yerDoluMu[i] = false; // her yer bo�
            }

            

            groupBox1.Hide();
        }

        
        private void zar_Click(object sender, EventArgs e)
        {

            Zar.gelenZar = Zar.zarAt();
            pictureBox1.Image = imageList1.Images[Zar.gelenZar - 1]; // imageList1 elemanlar�n� imageBox a ata
            zarCount++;
            if (zarCount == 5 || (zarCount == 4 && oyuncuSay�s� == 3) || (zarCount==3&&oyuncuSay�s�==2))
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
        string[] yerIsm� = new string[52];

        public void baslang�cHamles�( int piyonS�ras�, int baslama_pozisyonu, int tahtayaGelecekDe�er, int ka��nc�Oyuncu)
        {
            
            if (oyunS�ras�[ka��nc�Oyuncu].piyon_ev[piyonS�ras�]==true && oyunS�ras�[ka��nc�Oyuncu].s�ra == zarCount && Zar.gelenZar==6 && oyunS�ras�[ka��nc�Oyuncu].oyundaM� == true)
            {
                
                if (yerDoluMu[tahtayaGelecekDe�er]==false)
                {
                    File.WriteLine(oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�] + " yuvadan ��kt�");
                    //FileTahta.WriteLine(tahtayaGelecekDe�er + " " + oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�]);

                    baslamaPoz�syonu[baslama_pozisyonu+piyonS�ras�].Image = null;
                    tahtaPozisyonu[tahtayaGelecekDe�er].Image= piyonResimleri[ka��nc�Oyuncu].Images[piyonS�ras�];
                    oyunS�ras�[ka��nc�Oyuncu].piyon_ev[piyonS�ras�] = false;
                    yerIsm�[tahtayaGelecekDe�er] = oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�];
                    oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] = tahtayaGelecekDe�er;
                    yerDoluMu[tahtayaGelecekDe�er] = true;
                  
                    
                }
                else if(yerDoluMu[tahtayaGelecekDe�er]==true && yerIsm�[tahtayaGelecekDe�er]!= oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[0] && yerIsm�[tahtayaGelecekDe�er] != oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[1] && yerIsm�[tahtayaGelecekDe�er] != oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[2] && yerIsm�[tahtayaGelecekDe�er] != oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[3])
                {
                    for (int i = 0; i < 16; i++)
                        for (int j = 0; j < 4; j++)
                        {
                            if (tahtaPozisyonu[tahtayaGelecekDe�er].Image == piyonResimleri[i/4].Images[j])
                            {
                                File.WriteLine(oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�] + " " + yerIsm�[tahtayaGelecekDe�er] + "'� yedi");
                                //FileTahta.WriteLine(tahtayaGelecekDe�er + " " + oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�]);

                                baslamaPoz�syonu[i].Image = piyonResimleri[i/4].Images[j]; // ��k�lacak yeri bulduk ve ba�lama poziyonuna yerle�t�rd�k
                                oyunS�ras�[i / 4].piyon_ev[j] = true; // ba�lang�c�n� true olarak ayarlad�k ki sonradan tekrar oyuna ��kabilsin

                                baslamaPoz�syonu[baslama_pozisyonu+piyonS�ras�].Image = null; // ��kan ta�
                                tahtaPozisyonu[tahtayaGelecekDe�er].Image = piyonResimleri[ka��nc�Oyuncu].Images[piyonS�ras�]; // ��k�lan yer
                                oyunS�ras�[ka��nc�Oyuncu].piyon_ev[piyonS�ras�] = false; // ��kan ta� yuvada de�il

                                yerIsm�[tahtayaGelecekDe�er] = oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�];
                                oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�]=tahtayaGelecekDe�er;
                                yerDoluMu[tahtayaGelecekDe�er] = true;


                            }
                        }
                }
                else
                {
                    File.WriteLine(oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�] + " yuvadan ��kamad�");

                }
               
            }
        }

        public void ortakYolHamle(int piyonS�ras�, int ka��nc�Oyuncu)
        {
            
            if (oyunS�ras�[ka��nc�Oyuncu].piyon_ev[piyonS�ras�] == false && oyunS�ras�[ka��nc�Oyuncu].s�ra == zarCount && oyunS�ras�[ka��nc�Oyuncu].oyundaM� == true)
            {
                
                if (yerDoluMu[(oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] + Zar.gelenZar)%51] == false) // ileriki pozisyon bo� mu dolu mu kontrol et
                {

                    int yeniDe�er = (oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] + Zar.gelenZar)%51;
                    int eskiDe�er = (oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�]) %51;

                    File.WriteLine(oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�] + " "+ Zar.gelenZar +" kadar ilerledi ve " + yeniDe�er+" noktas�na ula�t�");
                    //FileTahta.WriteLine(yeniDe�er + " " + oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�]);

                    oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] = yeniDe�er; // pozisyonu zar kadar artt�r.
                    
                    tahtaPozisyonu[eskiDe�er].Image = null; // ilk de�er null
                    yerDoluMu[eskiDe�er] = false; // eski de�er bo�
          
                    tahtaPozisyonu[yeniDe�er].Image = piyonResimleri[ka��nc�Oyuncu].Images[piyonS�ras�]; // yeni de�ere piyon ata
                    yerDoluMu[yeniDe�er] = true; // yeni de�er dolu
                    yerIsm�[yeniDe�er] = oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�];
                }
                else if(yerDoluMu[oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] + Zar.gelenZar] == true 
                    && yerIsm�[oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] + Zar.gelenZar]!= oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[0]
                    && yerIsm�[oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] + Zar.gelenZar] != oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[1]
                    && yerIsm�[oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] + Zar.gelenZar] != oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[2]
                    && yerIsm�[oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] + Zar.gelenZar] != oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[3]) // yer doluysa ve kendi piyonu yoksa 
                   
                {
                    int yeniDe�er = (oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] + Zar.gelenZar)%51;
                    int eskiDe�er = (oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�])%51;
                    
                    

                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                        {
                            if (tahtaPozisyonu[yeniDe�er].Image == piyonResimleri[i].Images[j]) // yeni de�erdeki piyonu bulma
                            {
                                File.WriteLine(oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�] + " " + yerIsm�[yeniDe�er] + "'� yedi");

                                baslamaPoz�syonu[4*i+j].Image = piyonResimleri[i].Images[j]; // yenilecek piyonu bulduk ve ba�lama poziyonuna yerle�t�rd�k
                                oyunS�ras�[i].piyon_ev[j] = true; // ba�lang�c�n� true olarak ayarlad�k ki sonradan tekrar oyuna ��kabilsin

                                tahtaPozisyonu[eskiDe�er].Image = null; // yerinden oynayan ta�
                                tahtaPozisyonu[yeniDe�er].Image = piyonResimleri[ka��nc�Oyuncu].Images[piyonS�ras�]; // yeni de�ere piyon ata
                                oyunS�ras�[ka��nc�Oyuncu].piyon_ev[piyonS�ras�] = false; // ��kan ta� yuvada de�il (zaten olmamas� laz�m)

                                yerIsm�[yeniDe�er] = oyunS�ras�[ka��nc�Oyuncu].piyonIsimleri[piyonS�ras�];
                                oyunS�ras�[ka��nc�Oyuncu].piyon_kordinatlar�[piyonS�ras�] = yeniDe�er; //pozisyonu zar kadar artt�r.
                                yerDoluMu[yeniDe�er] = true; // zaten true olmas� laz�m ama ne olur ne olmaz

                                

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
            // S1  oyuns�ras� 2 baslamapozisyonu 8 
            
            ortakYolHamle(0, 2);


            // M1 baslamaPoz�syonu[12] tahtaPozisyonu[39] oyunS�ras�[3]
            
            ortakYolHamle(0, 3);

            piyonBox.Visible = false;
        }

        private void piyon2_Click(object sender, EventArgs e)
        {
            //K2
            
            ortakYolHamle(1, 0);

            //Y2
            
            ortakYolHamle(1, 1);

            // S2 oyuns�ras� 2 baslamapozisyonu 8 
            
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

            // S3 oyuns�ras� 2 baslamapozisyonu 8 
           
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

            // S4 oyuns�ras� 2 baslamapozisyonu 8 
            
            ortakYolHamle(3, 2);

            // M4 
            
            ortakYolHamle(3, 3);

            piyonBox.Visible = false;

        }

        private void kaydetve��k_Click(object sender, EventArgs e)
        {
            File.Close();
            StreamWriter FileTahta = new StreamWriter("tahta.txt");
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (oyunS�ras�[i].piyon_ev[j] == false)
                    {
                        FileTahta.Write(oyunS�ras�[i].piyonIsimleri[j] + " " + (oyunS�ras�[i].piyon_kordinatlar�[j] ) % 51 + " ");
                    }

                    else
                    {
                        FileTahta.Write(oyunS�ras�[i].piyonIsimleri[j] + " " + "yuvada" + " ");
                    }
                    
                }
            }
            FileTahta.Close();


        }

        private void K1_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(0, 0, 0, 0);
            piyonBox.Visible = false;
        }

        private void K2_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(1, 0, 0, 0);
            piyonBox.Visible = false;
        }

        private void K3_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(2, 0, 0, 0);
            piyonBox.Visible = false;
        }

        private void K4_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(3, 0, 0, 0);
            piyonBox.Visible = false;
        }

        private void Y1_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(0, 4, 13, 1);
            piyonBox.Visible = false;
        }

        private void Y2_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(1, 4, 13, 1);
            piyonBox.Visible = false;
        }

        private void Y3_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(2, 4, 13, 1);
            piyonBox.Visible = false;

        }

        private void Y4_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(3, 4, 13, 1);
            piyonBox.Visible = false;
        }
        private void S1_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(0, 8, 26, 2);
            piyonBox.Visible = false;
        }

        private void S2_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(1, 8, 26, 2);
            piyonBox.Visible = false;
        }

        private void S3_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(2, 8, 26, 2);
            piyonBox.Visible = false;
        }

        private void S4_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(3, 8, 26, 2);
            piyonBox.Visible = false;
        }
        private void M1_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(0, 12, 39, 3);
            piyonBox.Visible = false;
        }

        private void M2_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(1, 12, 39, 3);
            piyonBox.Visible = false;
        }

        private void M3_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(2, 12, 39, 3);
            piyonBox.Visible = false;
        }

        private void M4_Click(object sender, EventArgs e)
        {
            baslang�cHamles�(3, 12, 39, 3);
            piyonBox.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            piyonBox.Visible = false;
        }
    }
}