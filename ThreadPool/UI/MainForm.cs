using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        private IMyThreadPool threadPool;

        private string filename;
        private string pathTo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreatePool_Click(object sender, EventArgs e)
        {
            int min = 0, max = 0;

            try
            {
                min = Int32.Parse(textBoxMin.Text);
                max = Int32.Parse(textBoxMax.Text);

                if (min > max || min <= 0)
                    throw new Exception("Значения введены неверно");

                ShowTasksMenu();

                threadPool = new MyThreadPool(min, max);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowTasksMenu()
        {
            labelCopy.Visible = true;

            buttonEmptyTask.Visible = true;
            buttonDivideByZeroTask.Visible = true;
            buttonFile.Visible = true;
            buttonCopyTo.Visible = true;
            buttonCopy.Visible = true;
        }

        private void buttonEmptyTask_Click(object sender, EventArgs e)
        {
            MyTask testTask = new MyTask(AllTasks.EmptyTask, null);
            threadPool.AddTaskInQueue(testTask);
        }

        private void buttonDivideByZeroTask_Click(object sender, EventArgs e)
        {
            MyTask testTask = new MyTask(AllTasks.DivideByZeroTask, null);
            threadPool.AddTaskInQueue(testTask);
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
        }

        private void buttonCopyTo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            pathTo = folderBrowserDialog1.SelectedPath;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (filename != "" && pathTo != "")
            {
                string newFilename = pathTo + '\\' + filename.Substring(filename.LastIndexOf('\\') + 1);
                FileCopyData state = new FileCopyData(filename, newFilename);

                MyTask copyFileTask = new MyTask(AllTasks.CopyFileTask, state);
                threadPool.AddTaskInQueue(copyFileTask);
            }
            else
                MessageBox.Show("Введите верные пути");
        }
    }
}
