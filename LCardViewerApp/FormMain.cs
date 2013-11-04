using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Management;
using System.Globalization;
using System.Reflection;
using System.Collections.Generic;
using System.Threading;
using DW.RtfWriter;
using Record;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;
using ZedGraph;
using Microsoft.Office.Interop.Word;
using System.Xml;
using System.Drawing.Drawing2D;
using System.Diagnostics;


namespace WindowsFormsGraphickOpenGL
{
    public partial class FormMain : Form
    {
        ClassRecord record = new ClassRecord();
        bool flag_record=false;
        bool flag_graph = false;
        bool flag_calc = false;
        ClassOpenGLGraphick2D cl2d=new ClassOpenGLGraphick2D();
        ClassCalc calc_record;
        string home_directory = @"";

        public int with_diff_parm = 5;
        int number_zub = 360;

        int width_w=1374;
        int height_w=772;

        public FormMain()
        {

            InitializeComponent();
            LoadParametrs();

            OpenGlControlGraph.InitializeContexts();

            // инициализация Glut
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH  );

        }

        bool flag_load = false;
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            LoadFileList(explorerTreeMain.SelectedPath);
            ShowFileList();
            pictureBoxGraphData.Hide();
            OpenGlControlGraph.Invalidate();

            dataGridViewFiles.ColumnHeadersHeight = dataGridViewFiles.ColumnHeadersHeight * 2;
          
            pos_splitX2=pos_splitX1 = splitContainerMain.SplitterDistance;
            cl2d.width = OpenGlControlGraph.Width;
            cl2d.height = OpenGlControlGraph.Height;
            ClearDrawArea();
            //add type channel
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Тип";
            cmb.Name = "TypeChannel";
            cmb.MaxDropDownItems = 4;
            cmb.Width = 230;
            cmb.Items.Add(types_ch[0]);
            cmb.Items.Add(types_ch[1]);
            dataGridViewFileProp.Columns.Add(cmb);
            dataGridViewFileProp.AllowUserToAddRows = false;
            if(vrecords.Count>0)
            ShowChannels(vrecords[dataGridViewFiles.SelectedCells[0].RowIndex].NumberOfChannels);
            

            flag_load = true;

        }

        int posX_window;
        int posY_window;
        int split_tree_file_list;
        int height_split_tree_file_list;
        int split_main;
        int width_split_main;
        int TypeSmooth=0;

        int split_file_property;
        int height_split_file_property;

        void LoadParametrs()
        {
            FileInfo aFile = new FileInfo("config");
            if (aFile.Exists == false)
            {
                goto M1;
            }
            else 
            {
                try
                {
                    System.IO.StreamReader fconfig = new System.IO.StreamReader(@"config", System.Text.Encoding.GetEncoding("windows-1251"));

                    //дериктория
                    home_directory = fconfig.ReadLine();
                    DirectoryInfo di = new DirectoryInfo(home_directory);
                    if (di.Exists)
                        explorerTreeMain.SelectedPath = home_directory;
                    else
                        explorerTreeMain.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    explorerTreeMain.Refresh();
                    string sfile;

                    //позиция+разрешение
                    sfile = fconfig.ReadLine();
                    if (sfile == null) goto M1;
                    posX_window = Convert.ToInt32(sfile.Split(' ')[0]);
                    posY_window = Convert.ToInt32(sfile.Split(' ')[1]);
                    width_w = Convert.ToInt32(sfile.Split(' ')[2]);
                    height_w = Convert.ToInt32(sfile.Split(' ')[3]);
                    bool resolut = false;

                    if (posX_window >= 0 && (posX_window + width_w) <= Screen.PrimaryScreen.WorkingArea.Width && posY_window >= 0 && (posY_window + height_w) <= Screen.PrimaryScreen.WorkingArea.Height)
                    {
                        this.Size = new System.Drawing.Size(width_w, height_w);
                        this.Location = new System.Drawing.Point(posX_window, posY_window);
                        resolut = true;
                    }
                    else
                    {
                        posX_window = posY_window = 0;
                        width_w = Screen.PrimaryScreen.WorkingArea.Width;
                        height_w = Screen.PrimaryScreen.WorkingArea.Height;
                        this.Size = new System.Drawing.Size(width_w, height_w);
                    }

                    //настройки меню
                    sfile = fconfig.ReadLine();
                    if (sfile == null) goto M1;
                    bool[] bmn = new bool[8];
                    string[] smn;
                    smn = sfile.Split(' ');

                    int i;
                    for (i = 0; i < 8; i++)
                        bmn[i] = Convert.ToBoolean(smn[i]);

                    mnuSA.Checked = bmn[0];
                    mnuST.Checked = bmn[1];
                    mnuSD.Checked = bmn[2];
                    mnuSN.Checked = bmn[3];
                    mnuSF.Checked = bmn[4];
                    mnuSFExperimentTime.Checked = bmn[5];
                    mnuSFKadrsNumber.Checked = bmn[6];
                    mnuSFInputTimeInSec.Checked = bmn[7];

                    explorerTreeMain.ShowAddressbar = mnuSA.Checked;
                    explorerTreeMain.ShowToolbar = mnuST.Checked;
                    explorerTreeMain.ShowMyDocuments = mnuSD.Checked;
                    explorerTreeMain.ShowMyNetwork = mnuSN.Checked;
                    explorerTreeMain.ShowMyFavorites = mnuSF.Checked;

                    fKadrsNumber = mnuSFKadrsNumber.Checked;
                    if (!fKadrsNumber) fNumCol--;
                    fInputTimeInSec = mnuSFInputTimeInSec.Checked;
                    if (!fInputTimeInSec) fNumCol--;
                    fExperimentTime = mnuSFExperimentTime.Checked;
                    if (!fExperimentTime) fNumCol--;
                    //разделитель дерево-список файлов
                    sfile = fconfig.ReadLine();
                    if (sfile == null) goto M1;
                    split_tree_file_list = Convert.ToInt32(sfile.Split(' ')[0]);
                    height_split_tree_file_list = Convert.ToInt32(sfile.Split(' ')[1]);
                    if (resolut)
                        splitContainerTreeFilePath.SplitterDistance = split_tree_file_list;
                    else
                    {
                        double value;
                        value = (double)split_tree_file_list / (double)height_split_tree_file_list * (double)splitContainerTreeFilePath.Height;
                        splitContainerTreeFilePath.SplitterDistance = Convert.ToInt32(value);
                    }

                    //разделитель главный
                    sfile = fconfig.ReadLine();
                    if (sfile == null) goto M1;
                    split_main = Convert.ToInt32(sfile.Split(' ')[0]);
                    width_split_main = Convert.ToInt32(sfile.Split(' ')[1]);
                    if (resolut)
                        splitContainerMain.SplitterDistance = split_main;
                    else
                    {
                        double value;
                        value = (double)split_main / (double)width_split_main * (double)splitContainerMain.Width;
                        splitContainerMain.SplitterDistance = Convert.ToInt32(value);
                    }

                    //разделитель список файлов -  опции канала
                    sfile = fconfig.ReadLine();
                    if (sfile == null) goto M1;
                    split_file_property = Convert.ToInt32(sfile.Split(' ')[0]);
                    height_split_file_property = Convert.ToInt32(sfile.Split(' ')[1]);
                    if (resolut)
                        splitContainerFileList_FileProp.SplitterDistance = split_file_property;
                    else
                    {
                        double value;
                        value = (double)split_file_property / (double)height_split_file_property * (double)splitContainerFileList_FileProp.Height;
                        splitContainerFileList_FileProp.SplitterDistance = Convert.ToInt32(value);
                    }



                    //toolStripComboBoxSmooth.SelectedIndex = 0;
                    
                    fconfig.Close();
                    return;
                }
                catch
                {
                    goto M1;
                }
            }
            M1:
            width_w = Screen.PrimaryScreen.WorkingArea.Width;
            height_w = Screen.PrimaryScreen.WorkingArea.Height;
            this.Size = new System.Drawing.Size(width_w, height_w);
            return;

        }

        void SaveParametrs()
        {
            try
            {
                System.IO.StreamWriter fconfig = new System.IO.StreamWriter(@"config", false, System.Text.Encoding.GetEncoding("windows-1251"));

                //дериктория
                string sfile;
                home_directory = explorerTreeMain.SelectedPath;
                fconfig.WriteLine(home_directory);
                //позиция+разрешение
                width_w = this.Size.Width;
                height_w = this.Size.Height;
                posX_window = this.Location.X;
                posY_window = this.Location.Y;
                sfile = posX_window.ToString() + ' ' + posY_window.ToString() + ' ' + width_w.ToString() + ' ' + height_w.ToString();
                fconfig.WriteLine(sfile);

                //настройки меню
                sfile = mnuSA.Checked.ToString() + ' ' + mnuST.Checked.ToString() + ' ' + mnuSD.Checked.ToString() + ' ' + mnuSN.Checked.ToString() + ' ' + mnuSF.Checked.ToString() + ' ' +
                mnuSFExperimentTime.Checked.ToString() + ' ' + mnuSFKadrsNumber.Checked.ToString() + ' ' + mnuSFInputTimeInSec.Checked.ToString();
                fconfig.WriteLine(sfile);

                //разделитель дерево-список файлов
                split_tree_file_list = splitContainerTreeFilePath.SplitterDistance;
                height_split_tree_file_list = splitContainerTreeFilePath.Height;
                sfile = split_tree_file_list.ToString() + ' ' + height_split_tree_file_list.ToString();
                fconfig.WriteLine(sfile);

                //разделитель главный
                split_main = splitContainerMain.SplitterDistance;
                width_split_main = splitContainerMain.Width;
                sfile = split_main.ToString() + ' ' + width_split_main.ToString();
                fconfig.WriteLine(sfile);

                //разделитель список файлов - свойства
                split_file_property = splitContainerFileList_FileProp.SplitterDistance;
                height_split_file_property = splitContainerFileList_FileProp.Height;
                sfile = split_file_property.ToString() + ' ' + height_split_file_property.ToString();
                fconfig.WriteLine(sfile);

                //цвета каналов

                fconfig.Close();
            }
            catch
            { }
        }

        int old_pos=-1;

        void ClearDrawArea()
        {
            // очитка окна 
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            
            Gl.glFlush();
        }


        int my_scale = 1;

        private void plus_Click(object sender, EventArgs e)
        {
            if (my_scale < 32)
            {
                my_scale = my_scale * 2;
                cl2d.Zoom_plus();
                hScrollBarGraph.Maximum = cl2d.get_max_move();
                if (cl2d.get_current_pos() >= 0)
                    hScrollBarGraph.Value = cl2d.get_current_pos();
                else
                    hScrollBarGraph.Value = 0;

                OpenGlControlGraph.Invalidate();

            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (my_scale > 1)
            {
                my_scale = my_scale / 2;
                cl2d.Zoom_minus();
                hScrollBarGraph.Maximum = cl2d.get_max_move();
                if (cl2d.get_current_pos() >= 0)
                    hScrollBarGraph.Value = cl2d.get_current_pos();
                else
                    hScrollBarGraph.Value = 0;

                OpenGlControlGraph.Invalidate();
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            cl2d.Move_right();
            OpenGlControlGraph.Invalidate();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            cl2d.Move_left();
            OpenGlControlGraph.Invalidate();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                bool flag_right = false;
                if (e.NewValue - e.OldValue > 0)
                    flag_right = true;
                else
                    if (e.NewValue - e.OldValue < 0)
                        flag_right = false;
                int i, size;
                size = Math.Abs(e.NewValue - e.OldValue);
                if (flag_right)
                    for (i = 0; i < size; i++)
                        cl2d.Move_right();
                else
                    for (i = 0; i < size; i++)
                        cl2d.Move_left();

                OpenGlControlGraph.Invalidate();
            }
        }

        private void mnuSA_Click(object sender, EventArgs e)
        {
            //строка адреса
            explorerTreeMain.ShowAddressbar = mnuSA.Checked;
            explorerTreeMain.refreshView();
        }

        private void mnuST_Click(object sender, EventArgs e)
        {
            //панель инструментов
            explorerTreeMain.ShowToolbar = mnuST.Checked;
            explorerTreeMain.refreshView();
        }

        private void mnuSD_Click(object sender, EventArgs e)
        {
            //мои документы
            explorerTreeMain.ShowMyDocuments = mnuSD.Checked;
            home_directory=explorerTreeMain.SelectedPath;
            //explorerTreeMain.refreshFolders();
            explorerTreeMain.SelectedPath = home_directory;

            explorerTreeMain.GetDirectory();

            explorerTreeMain.setCurrentPath(home_directory);

            explorerTreeMain.btnGo_Click(this, e);

            explorerTreeMain.refreshView();
        }

        private void mnuSN_Click(object sender, EventArgs e)
        {
            //моя есть
            explorerTreeMain.ShowMyNetwork = mnuSN.Checked;
            home_directory = explorerTreeMain.SelectedPath;
            //explorerTreeMain.refreshFolders();
            explorerTreeMain.SelectedPath = home_directory;

            explorerTreeMain.GetDirectory();

            explorerTreeMain.setCurrentPath(home_directory);

            explorerTreeMain.btnGo_Click(this, e);

            explorerTreeMain.refreshView();
        }

        private void mnuSF_Click(object sender, EventArgs e)
        {
            //избранное
            explorerTreeMain.ShowMyFavorites = mnuSF.Checked;
            home_directory = explorerTreeMain.SelectedPath;
            //explorerTreeMain.refreshFolders();
            explorerTreeMain.SelectedPath = home_directory;

            explorerTreeMain.GetDirectory();

            explorerTreeMain.setCurrentPath(home_directory);

            explorerTreeMain.btnGo_Click(this, e);

            explorerTreeMain.refreshView();

        }
       
        bool fExperimentTime=true;
        bool fKadrsNumber=true;
        bool fInputTimeInSec=true;
        int fNumCol = 4;

        //коллекция записей
        List<ClassRecord> vrecords = new List<ClassRecord>();

        protected void InitFileList()
        {


            //init dataview control
            dataGridViewFiles.Columns.Clear();
            dataGridViewFiles.ColumnCount = fNumCol;

            int i = 0;

            dataGridViewFiles.Columns[i].Name = "Имя файла"; dataGridViewFiles.Columns[i].AutoSizeMode= DataGridViewAutoSizeColumnMode.None;
            dataGridViewFiles.Columns[i].Width = 180;
            i++;

            if (fExperimentTime)
            {
                dataGridViewFiles.Columns[i].Name = "Время эксперимента"; dataGridViewFiles.Columns[i].AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
                dataGridViewFiles.Columns[i].Width = 130;
                i++;
            }

            if (fKadrsNumber)
            {
                dataGridViewFiles.Columns[i].Name = "Число кадров"; dataGridViewFiles.Columns[i].AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
                dataGridViewFiles.Columns[i].Width = 80;
                i++;
            }

            if (fInputTimeInSec)
            {
                dataGridViewFiles.Columns[i].Name = "Длительность записи, сек"; dataGridViewFiles.Columns[i].AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
                dataGridViewFiles.Columns[i].Width = 90;
                i++;
            }

        }

        private void mnuSFExperimentTime_Click(object sender, EventArgs e)
        {
            fExperimentTime = mnuSFExperimentTime.Checked;
            if (fExperimentTime) fNumCol++;
            else fNumCol--;
                ShowFileList();
        }


        private void mnuSFKadrsNumber_Click(object sender, EventArgs e)
        {
            fKadrsNumber = mnuSFKadrsNumber.Checked;
            if (fKadrsNumber) fNumCol++;
            else fNumCol--;
            ShowFileList();
        }

        private void mnuSFInputTimeInSec_Click(object sender, EventArgs e)
        {
            fInputTimeInSec = mnuSFInputTimeInSec.Checked;
            if (fInputTimeInSec) fNumCol++;
            else fNumCol--;
            ShowFileList();
        }


        private void mnuSCA_Click(object sender, EventArgs e)
        {

        }

        private void mnuSCO_Click(object sender, EventArgs e)
        {

        }

        private void explorerTreeMain_PathChanged(object sender, EventArgs e)
        {
            flag_load = false;
            //отображаем файлы из дериктории
            home_directory = explorerTreeMain.SelectedPath;
            LoadFileList(explorerTreeMain.SelectedPath);
            ShowFileList();
            old_pos = -1;
            if (vrecords.Count > 0)
                ShowChannels(vrecords[dataGridViewFiles.SelectedCells[0].RowIndex].NumberOfChannels);
            flag_load = true;
            
        }

        

        protected void LoadFileList(string dir)
        {
            //загружаем файлы из дериктории
            string[] filePaths = Directory.GetFiles(dir, "*.txt");
            int i;
            flag_record = false;
            vrecords.Clear();
            for (i = 0; i < filePaths.Length; i++)
            {
                ClassRecord local_rec = new ClassRecord();
                if (local_rec.ValidateReadHead(filePaths[i]) || local_rec.ValidateReadHeadWindows7(filePaths[i]))
                {
                    vrecords.Add(local_rec);
                }
            }
            
        }

        protected void ShowFileList()
        {
            dataGridViewFiles.AllowUserToAddRows = true;
            InitFileList();
            //отображаем файлы в окне просмотра файлов

            int i, j;
            for (i = 0; i < vrecords.Count; i++)
            {
                j = 0;
                string[] lvData = new string[fNumCol];

                //имя файла
                lvData[j] = vrecords[i].file_name; j++;
                //время проведения эксперимента
                if (fExperimentTime) { lvData[j] = vrecords[i].ExperimentTime; j++; }
                //число кадров
                if (fKadrsNumber) { lvData[j] = vrecords[i].KadrsNumber.ToString(); j++; }
                //длительность эксперимента
                if (fInputTimeInSec) { lvData[j] = vrecords[i].InputTimeInSec.ToString(); j++; }

                dataGridViewFiles.Rows.Add(lvData);
            }
            dataGridViewFiles.AllowUserToAddRows = false;
            
        }

        private string[] types_ch = { "Датчик давления", "Датчик частоты вращения аналоговый" };
        object[] ch_brush = new Brush[16];
        protected void ShowChannels(int count)
        {
            if (count > 0)
            {
                int i;
                dataGridViewFileProp.Rows.Clear();
                dataGridViewFileProp.AllowUserToAddRows = true;
                dataGridViewFileProp.AllowUserToDeleteRows = true;
                dataGridViewFileProp.Rows.Add(count);
                dataGridViewFileProp.AllowUserToAddRows = false;
                for (i = 0; i < count; i++)
                {
                    dataGridViewFileProp.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dataGridViewFileProp.Rows[i].Cells[1].Value = GetBitmap(i);
                    dataGridViewFileProp.Rows[i].Cells[2].Value = types_ch[0];

                }
            }
            else
            {
                dataGridViewFileProp.AllowUserToAddRows = true;
                dataGridViewFileProp.AllowUserToDeleteRows = true;
                dataGridViewFileProp.Rows.Clear();
                dataGridViewFileProp.AllowUserToAddRows = false;
                dataGridViewFileProp.AllowUserToDeleteRows = false;
            }
            
        }

        protected Bitmap GetBitmap(int i)
        {
            Bitmap Bmp = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(Bmp);
            switch (i)
            {
                case 0:
                    g.FillRectangle(Brushes.DarkGreen, 0, 0, 200, 100);
                break;
                case 1:
                    g.FillRectangle(Brushes.Red, 0, 0, 200, 100);
                break;
                case 2:
                    g.FillRectangle(Brushes.Blue, 0, 0, 200, 100);
                break;
                case 3:
                    g.FillRectangle(Brushes.DarkOrange, 0, 0, 200, 100);
                break;
            }
            return Bmp;
        }

        protected bool DrawGraph(string path)
        {
                int res = record.ValidateRecord(path);
                int res2 = record.ValidateRecordWindows7(path);
                if (res == 1)
                {            
                    flag_record = true;
                    flag_graph = true;
                    record.ReadRecord(path);
                }
                else if (res2 == 1)
                {
                    flag_record = true;
                    flag_graph = true;
                    record.ReadRecordWindows7(path);
                }
                else
                {
                    flag_record = false;
                    return false;
                }

                string[] names = new string[4];
                names[0] = "канал 1";
                names[1] = "канал 2";
                names[2] = "канал 3";
                names[3] = "канал 4";
                int[] m = new int[4];
                m[0] = m[1] = m[2] = m[3] = record.KadrsNumber;
                int i, j;
                
                cl2d.DrawGraphick( record.time, "t, секунды",  record.ch, "U, В",  m,  names,record.NumberOfChannels , OpenGlControlGraph.Width, OpenGlControlGraph.Height);
                if(old_pos>-1)
                    dataGridViewFiles.Rows[old_pos].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                old_pos = dataGridViewFiles.CurrentRow.Index;
                dataGridViewFiles.Rows[old_pos].DefaultCellStyle.BackColor = System.Drawing.Color.Green;

                OpenGlControlGraph.Invalidate();
            return true;
        }

        string dir_file;
        string path_file;
        string name_file;

        protected bool ShowGraph()
        {

            flag_record = false;
            if (vrecords.Count > 0)
            {

                name_file = dataGridViewFiles.SelectedCells[0].Value.ToString();
                dir_file = explorerTreeMain.SelectedPath;
                path_file = dir_file + "\\" + name_file;

                if (DrawGraph(path_file))
                {
                    my_scale = 1;
                    hScrollBarGraph.Maximum = 0;
                    flag_record = true;
                }
                else
                {
                    flag_record = false;
                    MessageBox.Show("Файл повреждён или отстутсвует");
                }
            }
            else
            {
                flag_record = false;
                MessageBox.Show("Не выбрано ни одного файла");
            }
            return true;
        }

        private void menuShowGrap_Click(object sender, EventArgs e)
        {
            ShowGraph();
        }

        private void toolStripButtonShowGraph_Click(object sender, EventArgs e)
        {
            ShowGraph();
        }

        private void dataGridViewFiles_SelectionChanged(object sender, EventArgs e)
        {
            flag_record = false;
            flag_calc = false;
            if (flag_load && vrecords.Count > 0)
                ShowChannels(vrecords[dataGridViewFiles.SelectedCells[0].RowIndex].NumberOfChannels);
            else
                ShowChannels(0);
        }

        private void toolStripButtonGraphZoomIn_Click(object sender, EventArgs e)
        {
            if(flag_graph)
            if (my_scale < 512)
            {
                my_scale = my_scale * 2;
                cl2d.Zoom_plus();
                hScrollBarGraph.Maximum = cl2d.get_max_move();
                if (cl2d.get_current_pos() >= 0)
                    hScrollBarGraph.Value = cl2d.get_current_pos();
                else
                    hScrollBarGraph.Value = 0;

                OpenGlControlGraph.Invalidate();

            }
        }

        private void toolStripButtonGraphZoomOut_Click(object sender, EventArgs e)
        {
            if(flag_graph)
            if (my_scale > 1)
            {
                my_scale = my_scale / 2;
                cl2d.Zoom_minus();
                hScrollBarGraph.Maximum = cl2d.get_max_move();
                if (cl2d.get_current_pos() >= 0)
                    hScrollBarGraph.Value = cl2d.get_current_pos();
                else
                    hScrollBarGraph.Value = 0;

                OpenGlControlGraph.Invalidate();
            }
        }

        private void toolStripButtonGraphFullView_Click(object sender, EventArgs e)
        {
            if (flag_graph)
            {
                my_scale = 1;
                cl2d.Zoom_full();
                hScrollBarGraph.Value = 0;
                hScrollBarGraph.Maximum = 0;
                OpenGlControlGraph.Invalidate();
            }
        }

        string name_file_graph = "";
        void SaveGraph()
        {

            if (flag_graph)
            {
                saveFileDialogGraph.FileName = name_file_graph;
                Bitmap bmpsv = cl2d.GetBitmap();
                if (saveFileDialogGraph.ShowDialog() == DialogResult.OK)
                {
                    //name_file_graph=saveFileDialogBmp.
                    bmpsv.Save(saveFileDialogGraph.FileName);
                    name_file_graph = Path.GetFileName(saveFileDialogGraph.FileName);
                    name_file_graph = name_file_graph.Remove(name_file_graph.Length - 4);
                }
                bmpsv.Dispose();

            }
        }

        private void toolStripButtonGraphSave_Click(object sender, EventArgs e)
        {
            SaveGraph();
        }

        private void ToolStripMenuItemSaveGraph_Click(object sender, EventArgs e)
        {
            SaveGraph();
        }


        void CreateReport()
        {
        }


        private static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        void Calculate()
        {
            ShowGraph();

            if (flag_record)
            {
                
                //рассчёт 

                //вывод графиков
                CreateReport();
                flag_calc = true;
                tabControlMain.SelectedIndex = 4;

                my_scale = 1;
                cl2d.Zoom_full();
                hScrollBarGraph.Value = 0;
                hScrollBarGraph.Maximum = 0;
                OpenGlControlGraph.Invalidate();
            }
        }

        private void CreateGraph(ref ZedGraphControl zgc, ref double[] x,string label_x, ref double[] y,string label_y, int n, string name,string title)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            // Set the Titles
            myPane.Title.Text = title;
            myPane.XAxis.Title.Text = label_x;
            myPane.YAxis.Title.Text = label_y;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            myPane.CurveList.Clear();

            // Make up some data arrays based on the Sine function

            // Включаем отображение сетки напротив крупных рисок по оси Y
            myPane.YAxis.MajorGrid.IsVisible = true;


            // Включаем отображение сетки напротив мелких рисок по оси X
            myPane.YAxis.MinorGrid.IsVisible = true;

            LineItem myCurve = myPane.AddCurve(name, x, y, System.Drawing.Color.Green, SymbolType.None);

            // Tell ZedGraph to refigure the
            // axes since the data have changed

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private void CreateGraphMaxMin(ref ZedGraphControl zgc, ref double[] x, string label_x, ref double[] y, string label_y, int n, string name, string title,double[] in_tsup, double[] in_vsup, double[] in_tinf, double[] in_vinf)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            // Set the Titles
            myPane.Title.Text = title;
            myPane.XAxis.Title.Text = label_x;
            myPane.YAxis.Title.Text = label_y;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            myPane.CurveList.Clear();

            // Make up some data arrays based on the Sine function

            // Включаем отображение сетки напротив крупных рисок по оси Y
            myPane.YAxis.MajorGrid.IsVisible = true;


            // Включаем отображение сетки напротив мелких рисок по оси X
            myPane.YAxis.MinorGrid.IsVisible = true;

            LineItem myCurve = myPane.AddCurve(name, x, y, System.Drawing.Color.Green, SymbolType.None);


            // !!! Минимум
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurveInf = myPane.AddCurve("Минимум", in_tinf, in_vinf, System.Drawing.Color.Blue, SymbolType.Diamond);

            // !!!
            // У кривой линия будет невидимой
            myCurveInf.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            myCurveInf.Symbol.Fill.Color = System.Drawing.Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurveInf.Symbol.Fill.Type = FillType.None;

            // !!!
            // Размер ромбиков
            myCurveInf.Symbol.Size = 7;
            //..............................................

            // !!! Максимум
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurveSup = myPane.AddCurve("Максимум", in_tsup, in_vsup, System.Drawing.Color.Red, SymbolType.Circle);

            // !!!
            // У кривой линия будет невидимой
            myCurveSup.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            myCurveSup.Symbol.Fill.Color = System.Drawing.Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurveSup.Symbol.Fill.Type = FillType.None;

            // !!!
            // Размер ромбиков
            myCurveSup.Symbol.Size = 7;
            //..............................................


            // !!! Промежуточные точки
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurveMid = myPane.AddCurve("", calc_record.t_InEng, calc_record.InEng, System.Drawing.Color.Black, SymbolType.Square);

            // !!!
            // У кривой линия будет невидимой
            myCurveMid.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            myCurveMid.Symbol.Fill.Color = System.Drawing.Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurveMid.Symbol.Fill.Type = FillType.None;

            // !!!
            // Размер ромбиков
            myCurveMid.Symbol.Size = 7;
            //..............................................

            // Tell ZedGraph to refigure the
            // axes since the data have changed

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private void AppendEventsToGraph(ref ZedGraphControl zgc, double[] in_tsup, double[] in_vsup, double[] in_tinf, double[] in_vinf,double [] t_InEng,double[] InEng)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // !!! Минимум
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurveInf = myPane.AddCurve("Минимум", in_tinf, in_vinf, System.Drawing.Color.Blue, SymbolType.Diamond);

            // !!!
            // У кривой линия будет невидимой
            myCurveInf.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            myCurveInf.Symbol.Fill.Color = System.Drawing.Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurveInf.Symbol.Fill.Type = FillType.None;

            // !!!
            // Размер ромбиков
            myCurveInf.Symbol.Size = 7;
            //..............................................

            // !!! Максимум
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurveSup = myPane.AddCurve("Максимум", in_tsup, in_vsup, System.Drawing.Color.Red, SymbolType.Circle);

            // !!!
            // У кривой линия будет невидимой
            myCurveSup.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            myCurveSup.Symbol.Fill.Color = System.Drawing.Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurveSup.Symbol.Fill.Type = FillType.None;

            // !!!
            // Размер ромбиков
            myCurveSup.Symbol.Size = 7;
            //..............................................


            // !!! Промежуточные точки
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurveMid = myPane.AddCurve("", t_InEng, InEng, System.Drawing.Color.Black, SymbolType.Square);

            // !!!
            // У кривой линия будет невидимой
            myCurveMid.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            myCurveMid.Symbol.Fill.Color = System.Drawing.Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurveMid.Symbol.Fill.Type = FillType.None;

            // !!!
            // Размер ромбиков
            myCurveMid.Symbol.Size = 7;
            //..............................................

            // Tell ZedGraph to refigure the
            // axes since the data have changed

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private void toolStripButtonCalc_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        string namemy_file="";
        private void ToolStripMenuItemSaveReportAs_Click(object sender, EventArgs e)
        {
            if (flag_calc)
            {
            }
        }

        private void toolStripButtonSaveReport_Click(object sender, EventArgs e)
        {
            if (flag_calc)
            {
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Environment.SetEnvironmentVariable("HomeDir", explorerTreeMain.SelectedPath, EnvironmentVariableTarget.User);
            SaveParametrs();
        }


        private void OpenGlControlGraph_SizeChanged(object sender, EventArgs e)
        {
            ClearDrawArea();
            cl2d.init_XW(OpenGlControlGraph.Width);
            cl2d.init_YH(OpenGlControlGraph.Height);
            cl2d.Init();
            cl2d.UpdateZoom();
        }

        private void OpenGlControlGraph_Paint(object sender, PaintEventArgs e)
        {
            cl2d.DrawSystem();
            cl2d.DrawFunc();
            Gl.glFlush();
        }

        private void OpenGlControlGraph_Resize(object sender, EventArgs e)
        {
            ClearDrawArea();
        }

        int pos_splitX1=-1;
        int pos_splitX2 =-10;
        bool split=true;
        private void splitContainerMain_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {

            //заменяем на картинку

            if (split && (tabControlMain.SelectedIndex==0))
            {
                pictureBoxGraphData.Image = cl2d.GetBitmapDiff();
                
                pictureBoxGraphData.Show();
                OpenGlControlGraph.Hide();
                split = !split;
            }

        }

        private void splitContainerMain_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (!split && (tabControlMain.SelectedIndex == 0))
            {
                split = !split;
                OpenGlControlGraph.Show();
                pictureBoxGraphData.Hide();
                splitContainerMain.Invalidate();
            }
        }


        private void toolStripButtonReCalc_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonFindEvent_Click(object sender, EventArgs e)
        {

        }

        private void ReCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void findEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        //////////////////////////////////////////////////////////////////////
    }
}
