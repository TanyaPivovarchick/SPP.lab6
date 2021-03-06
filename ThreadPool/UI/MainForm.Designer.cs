﻿namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreatePool = new System.Windows.Forms.Button();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.buttonEmptyTask = new System.Windows.Forms.Button();
            this.buttonDivideByZeroTask = new System.Windows.Forms.Button();
            this.labelCopy = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonCopyTo = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мин кол-во потоков:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Макс кол-во потоков:";
            // 
            // buttonCreatePool
            // 
            this.buttonCreatePool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreatePool.Location = new System.Drawing.Point(313, 9);
            this.buttonCreatePool.Name = "buttonCreatePool";
            this.buttonCreatePool.Size = new System.Drawing.Size(190, 44);
            this.buttonCreatePool.TabIndex = 2;
            this.buttonCreatePool.Text = "Создать пул потоков";
            this.buttonCreatePool.UseVisualStyleBackColor = true;
            this.buttonCreatePool.Click += new System.EventHandler(this.buttonCreatePool_Click);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMin.Location = new System.Drawing.Point(182, 6);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(57, 26);
            this.textBoxMin.TabIndex = 3;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMax.Location = new System.Drawing.Point(182, 33);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(57, 26);
            this.textBoxMax.TabIndex = 4;
            // 
            // buttonEmptyTask
            // 
            this.buttonEmptyTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmptyTask.Location = new System.Drawing.Point(240, 94);
            this.buttonEmptyTask.Name = "buttonEmptyTask";
            this.buttonEmptyTask.Size = new System.Drawing.Size(132, 33);
            this.buttonEmptyTask.TabIndex = 5;
            this.buttonEmptyTask.Text = "Пустая задача";
            this.buttonEmptyTask.UseVisualStyleBackColor = true;
            this.buttonEmptyTask.Visible = false;
            this.buttonEmptyTask.Click += new System.EventHandler(this.buttonEmptyTask_Click);
            // 
            // buttonDivideByZeroTask
            // 
            this.buttonDivideByZeroTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivideByZeroTask.Location = new System.Drawing.Point(378, 94);
            this.buttonDivideByZeroTask.Name = "buttonDivideByZeroTask";
            this.buttonDivideByZeroTask.Size = new System.Drawing.Size(125, 33);
            this.buttonDivideByZeroTask.TabIndex = 6;
            this.buttonDivideByZeroTask.Text = "Деление на 0";
            this.buttonDivideByZeroTask.UseVisualStyleBackColor = true;
            this.buttonDivideByZeroTask.Visible = false;
            this.buttonDivideByZeroTask.Click += new System.EventHandler(this.buttonDivideByZeroTask_Click);
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopy.Location = new System.Drawing.Point(12, 144);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(169, 20);
            this.labelCopy.TabIndex = 7;
            this.labelCopy.Text = "Копирование файла:";
            this.labelCopy.Visible = false;
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFile.Location = new System.Drawing.Point(203, 139);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(74, 31);
            this.buttonFile.TabIndex = 8;
            this.buttonFile.Text = "Файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Visible = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonCopyTo
            // 
            this.buttonCopyTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopyTo.Location = new System.Drawing.Point(283, 139);
            this.buttonCopyTo.Name = "buttonCopyTo";
            this.buttonCopyTo.Size = new System.Drawing.Size(82, 31);
            this.buttonCopyTo.TabIndex = 9;
            this.buttonCopyTo.Text = "Куда";
            this.buttonCopyTo.UseVisualStyleBackColor = true;
            this.buttonCopyTo.Visible = false;
            this.buttonCopyTo.Click += new System.EventHandler(this.buttonCopyTo_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopy.Location = new System.Drawing.Point(371, 139);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(132, 31);
            this.buttonCopy.TabIndex = 10;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Visible = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 173);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonCopyTo);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.buttonDivideByZeroTask);
            this.Controls.Add(this.buttonEmptyTask);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.buttonCreatePool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Пул потоков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreatePool;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Button buttonEmptyTask;
        private System.Windows.Forms.Button buttonDivideByZeroTask;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonCopyTo;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

