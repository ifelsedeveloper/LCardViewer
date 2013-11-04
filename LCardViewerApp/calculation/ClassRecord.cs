using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading;

namespace Record
{
    class ClassRecord
    {
        public string title;//заголовок
        public string ExperimentTime;//время эксперимента
        public int NumberOfChannels;//количество каналов
        public int KadrsNumber;//число элементов записи
        public double InputRateInkHz;//входная частота в кГц
        public double InputTimeInSec;//время записи
        public int Decimation;
        public string Time_markers_scale;
        public double []time;//время 
        public double [][]ch;//записанные каналы

        public string[] head = new string[20];

        public bool[] flags_ch = new bool[4];

        

        public ClassRecord()
        {
            Thread.CurrentThread.CurrentCulture =new CultureInfo("en-CA");
            int j;
                for(j=0;j<4;j++)
                    flags_ch[j]=true;
        }

        public int ValidateRecord(string path)//возвращает 1 если запись корректна, 0 если нет
        {
            //открытие файла
            StreamReader file = new StreamReader(path, System.Text.Encoding.GetEncoding(1251));
            int j;
            int kol_d = 0;//количесво двоеточий
            int kol_n = 0;//количество строк

            string line;
            char d = ':';

            if (file != null)
            {
                //проверка первой строки
                line = file.ReadLine();
                if (line == null)
                {
                    file.Close();
                    return 0; 
                }
                else
                {
                    head[kol_n] = line;
                    kol_n++;
                }

                //проверка второй строки
                line = file.ReadLine();
                if (line == null) { file.Close(); return 0; }
                else
                {
                    head[kol_n] = line;
                    kol_d = kol_d + line.Split(d).Length-1;
                    kol_n++;
                }
                if (kol_d != 3) {file.Close();return 0;}

                //проверка оставшихся семи строк
                for (j = 0; j < 7; j++)
                {
                    line = file.ReadLine();
                    if (line == null) { file.Close(); return 0; }
                    else
                    {
                        head[kol_n] = line;
                        kol_d = kol_d+ line.Split(d).Length-1;
                        kol_n++;
                    }
                    if (kol_d != 4 + j) { file.Close(); return 0; }
                }
            }
            else { file.Close(); return 0; }

            file.Close();

            return 1;
        }

        public int ValidateRecordWindows7(string path)//возвращает 1 если запись корректна, 0 если нет
        {
            //открытие файла
            StreamReader file = new StreamReader(path, System.Text.Encoding.GetEncoding(1251));
            int j;
            int kol_d = 0;//количесво двоеточий
            int kol_n = 0;//количество строк

            string line;
            char d = ':';

            if (file != null)
            {
                //проверка первой строки
                line = file.ReadLine();
                if (line == null)
                {
                    file.Close();
                    return 0;
                }
                else
                {
                    head[kol_n] = line;
                    kol_n++;
                }

                //проверка второй строки
                line = file.ReadLine();
                if (line == null) { file.Close(); return 0; }
                else
                {
                    head[kol_n] = line;
                    kol_d = kol_d + line.Split(d).Length - 1;
                    kol_n++;
                }
                if (kol_d != 3) { file.Close(); return 0; }

                //проверка оставшихся 12 строк
                for (j = 0; j < 12; j++)
                {
                    line = file.ReadLine();
                    if (line == null) { file.Close(); return 0; }
                    else
                    {
                        head[kol_n] = line;
                        kol_d = kol_d + line.Split(d).Length - 1;
                        kol_n++;
                    }
                    
                }
                if (kol_d != 13) { file.Close(); return 0; }
            }
            else { file.Close(); return 0; }

            file.Close();

            return 1;
        }

        public int ReadRecordWindows7(string path)//считывает данные из текстового файла 
        {
            file_path = path;
            //открытие файла
            StreamReader file = new StreamReader(path, System.Text.Encoding.GetEncoding(1251));

            string line;
            string[] spline;
            string[] spline2 = new string[5];
            char d = ':', l = ' ';

            //ввод шапки
            if (file != null)
            {
                //первая строка заголовок
                title = file.ReadLine();
                head[0] = title;

                //вторая строка время эксперимента
                line = file.ReadLine();
                head[1] = line;
                ExperimentTime = line.Split(d)[1] + line.Split(d)[2] + line.Split(d)[3];

                //3 строка число кадров
                line = file.ReadLine();
                head[3] = line;
                KadrsNumber = Convert.ToInt32(line.Split(d)[1]);

                //4 пустая строка
                line = file.ReadLine();
                //5 модуль
                line = file.ReadLine();
                //6 пустая строка
                line = file.ReadLine();

                //7 строка число каналов
                line = file.ReadLine();
                head[2] = line;
                NumberOfChannels = Convert.ToInt32(line.Split(d)[1]);

                //8 строка частота в КГц
                line = file.ReadLine();
                head[4] = line;
                InputRateInkHz = Convert.ToDouble(line.Split(d)[1]);

                //9 время записи
                line = file.ReadLine();
                head[5] = line;
                InputTimeInSec = Convert.ToDouble(line.Split(d)[1]);

                //10 Decimation
                line = file.ReadLine();
                head[6] = line;
                Decimation = Convert.ToInt32(line.Split(d)[1]);

                //11 формат данных
                line = file.ReadLine();

                //12 еденизы измерения времени
                line = file.ReadLine();
                head[7] = line;
                Time_markers_scale = line.Split(d)[1];
                

                //13 
                head[8] = file.ReadLine();

                //14
                head[9] = file.ReadLine();

                //15
                head[10] = file.ReadLine();

                //16
                head[11] = file.ReadLine();

                //17
                head[12] = file.ReadLine();
            }

            //ввод основного потока данных
            int i, j, s, k;
            time = new double[KadrsNumber];
            ch = new double[NumberOfChannels][];

            for (i = 0; i < NumberOfChannels; i++) ch[i] = new double[KadrsNumber];

            for (i = 0; i < KadrsNumber; i++)
            {
                line = file.ReadLine();
                spline = line.Split(l);
                for (k = 0, s = 0; k < spline.Count(); k++)
                    if (spline[k].Count() != 0)
                    {
                        spline2[s] = spline[k];
                        s++;
                    }

                time[i] = Convert.ToDouble(spline2[0]);

                for (j = 0; j < NumberOfChannels; j++)
                    ch[j][i] = Convert.ToDouble(spline2[j + 1]);


            }
            //закрытие файла

            file.Close();
            return 1;
        }

        public int ReadRecord(string path)//считывает данные из текстового файла 
        {
            file_path = path;
            //открытие файла
            StreamReader file = new StreamReader(path, System.Text.Encoding.GetEncoding(1251));

            string line;
            string[] spline;
            string[] spline2 = new string[5];
            char d = ':', l = ' ';

            //ввод шапки
            if (file != null)
            {
                //первая строка заголовок
                title = file.ReadLine();
                head[0] = title;

                //вторая строка время эксперимента
                line = file.ReadLine();
                head[1] = line;
                ExperimentTime = line.Split(d)[1] + line.Split(d)[2] + line.Split(d)[3];

                //третья строка число каналов
                line = file.ReadLine();
                head[2] = line;
                NumberOfChannels = Convert.ToInt32(line.Split(d)[1]);

                //4 строка число кадров
                line = file.ReadLine();
                head[3] = line;
                KadrsNumber = Convert.ToInt32(line.Split(d)[1]);

                //5 строка частота в КГц
                line = file.ReadLine();
                head[4] = line;
                InputRateInkHz = Convert.ToDouble(line.Split(d)[1]);

                //6 время записи
                line = file.ReadLine();
                head[5] = line;
                InputTimeInSec = Convert.ToDouble(line.Split(d)[1]);

                //7 Decimation
                line = file.ReadLine();
                head[6] = line;
                Decimation = Convert.ToInt32(line.Split(d)[1]);

                //8 еденизы измерения времени
                line = file.ReadLine();
                Time_markers_scale = line.Split(d)[1];
                head[7] = line;

                //9 
                head[8] = file.ReadLine();

                //10
                head[9] = file.ReadLine();
            }

            //ввод основного потока данных
            int i,j,s,k;
            time = new double[KadrsNumber];
            ch = new double[NumberOfChannels][];

            for(i=0;i<NumberOfChannels;i++) ch[i]=new double[KadrsNumber];
            
            for (i = 0; i < KadrsNumber; i++)
            {
                line = file.ReadLine();
                spline = line.Split(l);
                for(k=0,s=0;k<spline.Count();k++)
                    if (spline[k].Count() != 0)
                    {
                        spline2[s] = spline[k];
                        s++;
                    }

                time[i] = Convert.ToDouble( spline2[0]);

                for (j = 0; j < NumberOfChannels; j++)
                    ch[j][i] = Convert.ToDouble(spline2[j+1]);
                
                
            }
            //закрытие файла

            file.Close();
            return 1;
        }

        bool flag_head=false;
        string file_path;
        public string file_name;

        public bool ValidateReadHead(string path)
        {
            file_path = path;
            //открытие файла
            StreamReader file = new StreamReader(path, System.Text.Encoding.GetEncoding(1251));
            int j;
            int kol_d = 0;//количесво двоеточий
            int kol_n = 0;//количество строк

            string line;
            char d = ':';

            file_name = Path.GetFileName(path);

            if (file != null)
            {
                //проверка первой строки
                line = file.ReadLine();
                if (line == null)
                {
                    file.Close();
                    return false;
                }
                else
                {
                    head[kol_n] = line;
                    kol_n++;
                }

                //проверка второй строки
                line = file.ReadLine();
                if (line == null) { file.Close(); return false; }
                else
                {
                    head[kol_n] = line;
                    kol_d = kol_d + line.Split(d).Length - 1;
                    kol_n++;
                }
                if (kol_d != 3) { file.Close(); return false; }

                //проверка оставшихся семи строк
                for (j = 0; j < 7; j++)
                {
                    line = file.ReadLine();
                    if (line == null) { file.Close(); return false; }
                    else
                    {
                        head[kol_n] = line;
                        kol_d = kol_d + line.Split(d).Length - 1;
                        kol_n++;
                    }
                    if (kol_d != 4 + j) { file.Close(); return false; }
                }
            }
            else { file.Close(); return false; }

            file.Close();

            //создание заголовка файла
            //первая строка заголовок
            title=head[0];

            //вторая строка время эксперимента
            line = head[1];
            ExperimentTime = line.Split(d)[1] + ":" +line.Split(d)[2];

            //третья строка число каналов
            line = head[2];
            NumberOfChannels = Convert.ToInt32(line.Split(d)[1]);

            //4 строка число кадров
            line = head[3];
            KadrsNumber = Convert.ToInt32(line.Split(d)[1]);

            //5 строка частота в КГц
            line = head[4];
            InputRateInkHz = Convert.ToDouble(line.Split(d)[1]);

            //6 время записи
            line=head[5];
            InputTimeInSec = Convert.ToDouble(line.Split(d)[1]);

            //7 Decimation
            line=head[6];
            Decimation = Convert.ToInt32(line.Split(d)[1]);

            //8 еденизы измерения времени
            line = head[7];
            Time_markers_scale = line.Split(d)[1];

            flag_head = true;

            return true;
        }
        public bool ValidateReadHeadWindows7(string path)
        {
            file_path = path;
            //открытие файла
            StreamReader file = new StreamReader(path, System.Text.Encoding.GetEncoding(1251));
            int j;
            int kol_d = 0;//количесво двоеточий
            int kol_n = 0;//количество строк

            string line;
            char d = ':';

            file_name = Path.GetFileName(path);

            if (file != null)
            {
                //проверка первой строки
                line = file.ReadLine();
                if (line == null)
                {
                    file.Close();
                    return false;
                }
                else
                {
                    head[kol_n] = line;
                    kol_n++;
                }

                //проверка второй строки
                line = file.ReadLine();
                if (line == null) { file.Close(); return false; }
                else
                {
                    head[kol_n] = line;
                    kol_d = kol_d + line.Split(d).Length - 1;
                    kol_n++;
                }
                if (kol_d != 3) { file.Close(); return false; }

                //проверка оставшихся 12 строк
                for (j = 0; j < 12; j++)
                {
                    line = file.ReadLine();
                    if (line == null) { file.Close(); return false; }
                    else
                    {
                        head[kol_n] = line;
                        kol_d = kol_d + line.Split(d).Length - 1;
                        kol_n++;
                    }

                }
                if (kol_d != 13) { file.Close(); return false; }
            }
            else { file.Close(); return false; }

            file.Close();

            //создание заголовка файла
            //первая строка заголовок
            title = head[0];

            //вторая строка время эксперимента
            line = head[1];
            ExperimentTime = line.Split(d)[1]+':' + line.Split(d)[2];

            //3 строка число кадров
            line = head[2];
            KadrsNumber = Convert.ToInt32(line.Split(d)[1]);

            //4 пустая строка
            
            //5 модуль
            
            //6 пустая строка
            

            //7 строка число каналов
            line = head[6];
            NumberOfChannels = Convert.ToInt32(line.Split(d)[1]);

            //8 строка частота в КГц
            line = head[7];
            InputRateInkHz = Convert.ToDouble(line.Split(d)[1]);

            //9 время записи
            line = head[8];
            InputTimeInSec = Convert.ToDouble(line.Split(d)[1]);

            //10 Decimation
            line = head[9];
            Decimation = Convert.ToInt32(line.Split(d)[1]);

            //11 формат данных

            //12 еденизы измерения времени
            line =head[11];
            Time_markers_scale = line.Split(d)[1];

            //13 
            
            //14
            
            //15
            
            //16
            
            //17
            

            flag_head = true;

            return true;
        }
    }
}
