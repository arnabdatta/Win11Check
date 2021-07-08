
namespace Win11Check
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelStorage = new System.Windows.Forms.Label();
            this.labelFirm = new System.Windows.Forms.Label();
            this.labelTpm = new System.Windows.Forms.Label();
            this.labelGpu = new System.Windows.Forms.Label();
            this.labelScreen = new System.Windows.Forms.Label();
            this.pictureBoxCPU = new System.Windows.Forms.PictureBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.pictureBoxRam = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Windows 11 Requirement Check";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelCPU, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStorage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFirm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTpm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelGpu, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelScreen, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxCPU, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxRam, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 332);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Display :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Processor :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 47);
            this.label3.TabIndex = 1;
            this.label3.Text = "RAM :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 47);
            this.label4.TabIndex = 2;
            this.label4.Text = "Storage (OS Drive) :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 51);
            this.label5.TabIndex = 3;
            this.label5.Text = "System Firmware :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 42);
            this.label6.TabIndex = 4;
            this.label6.Text = "TPM :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 48);
            this.label7.TabIndex = 5;
            this.label7.Text = "Graphics card :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPU
            // 
            this.labelCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPU.Location = new System.Drawing.Point(166, 3);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(396, 46);
            this.labelCPU.TabIndex = 7;
            this.labelCPU.Text = "CPU";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRam
            // 
            this.labelRam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRam.AutoSize = true;
            this.labelRam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRam.Location = new System.Drawing.Point(166, 50);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(396, 47);
            this.labelRam.TabIndex = 8;
            this.labelRam.Text = "RAM";
            this.labelRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStorage
            // 
            this.labelStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStorage.AutoSize = true;
            this.labelStorage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStorage.Location = new System.Drawing.Point(166, 98);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(396, 47);
            this.labelStorage.TabIndex = 9;
            this.labelStorage.Text = "Storage";
            this.labelStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirm
            // 
            this.labelFirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirm.AutoSize = true;
            this.labelFirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirm.Location = new System.Drawing.Point(166, 146);
            this.labelFirm.Name = "labelFirm";
            this.labelFirm.Size = new System.Drawing.Size(396, 51);
            this.labelFirm.TabIndex = 10;
            this.labelFirm.Text = "Firmware";
            this.labelFirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTpm
            // 
            this.labelTpm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTpm.AutoSize = true;
            this.labelTpm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTpm.Location = new System.Drawing.Point(166, 198);
            this.labelTpm.Name = "labelTpm";
            this.labelTpm.Size = new System.Drawing.Size(396, 42);
            this.labelTpm.TabIndex = 11;
            this.labelTpm.Text = "TPM";
            this.labelTpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGpu
            // 
            this.labelGpu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGpu.AutoSize = true;
            this.labelGpu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGpu.Location = new System.Drawing.Point(166, 241);
            this.labelGpu.Name = "labelGpu";
            this.labelGpu.Size = new System.Drawing.Size(396, 48);
            this.labelGpu.TabIndex = 12;
            this.labelGpu.Text = "GPU";
            this.labelGpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScreen
            // 
            this.labelScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScreen.AutoSize = true;
            this.labelScreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScreen.Location = new System.Drawing.Point(166, 290);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(396, 39);
            this.labelScreen.TabIndex = 13;
            this.labelScreen.Text = "Screen";
            this.labelScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCPU
            // 
            this.pictureBoxCPU.Location = new System.Drawing.Point(569, 6);
            this.pictureBoxCPU.Name = "pictureBoxCPU";
            this.pictureBoxCPU.Size = new System.Drawing.Size(47, 32);
            this.pictureBoxCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCPU.TabIndex = 14;
            this.pictureBoxCPU.TabStop = false;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCheck.Location = new System.Drawing.Point(323, 77);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(152, 42);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check Now";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // pictureBoxRam
            // 
            this.pictureBoxRam.Location = new System.Drawing.Point(569, 53);
            this.pictureBoxRam.Name = "pictureBoxRam";
            this.pictureBoxRam.Size = new System.Drawing.Size(47, 32);
            this.pictureBoxRam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRam.TabIndex = 15;
            this.pictureBoxRam.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Windows 11 Check";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.Label labelFirm;
        private System.Windows.Forms.Label labelTpm;
        private System.Windows.Forms.Label labelGpu;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.PictureBox pictureBoxCPU;
        private System.Windows.Forms.PictureBox pictureBoxRam;
    }
}

