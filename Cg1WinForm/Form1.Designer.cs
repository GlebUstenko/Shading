using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cg1WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.crystall1Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.yNUD = new System.Windows.Forms.NumericUpDown();
            this.crystall2Btn = new System.Windows.Forms.Button();
            this.rotateCenterBtn = new System.Windows.Forms.Button();
            this.xNUD = new System.Windows.Forms.NumericUpDown();
            this.reflectBtn = new System.Windows.Forms.Button();
            this.xCheckBox = new System.Windows.Forms.CheckBox();
            this.yCheckBox = new System.Windows.Forms.CheckBox();
            this.zCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fillRb = new System.Windows.Forms.RadioButton();
            this.normalVisualizerRb = new System.Windows.Forms.RadioButton();
            this.defaultVisualizerRb = new System.Windows.Forms.RadioButton();
            this.zNUD = new System.Windows.Forms.NumericUpDown();
            this.subscribeCb = new System.Windows.Forms.CheckBox();
            this.autoAction = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNUD)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystall1Btn
            // 
            this.crystall1Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystall1Btn.Location = new System.Drawing.Point(5, 30);
            this.crystall1Btn.Margin = new System.Windows.Forms.Padding(5);
            this.crystall1Btn.Name = "crystall1Btn";
            this.crystall1Btn.Size = new System.Drawing.Size(307, 55);
            this.crystall1Btn.TabIndex = 1;
            this.crystall1Btn.Text = "crystall1Btn";
            this.crystall1Btn.UseVisualStyleBackColor = true;
            this.crystall1Btn.Click += new System.EventHandler(this.crystall1Btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.yNUD, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.crystall2Btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.crystall1Btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rotateCenterBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.xNUD, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.reflectBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.xCheckBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.yCheckBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.zCheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.zNUD, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 399);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 243);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // yNUD
            // 
            this.yNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yNUD.Location = new System.Drawing.Point(504, 107);
            this.yNUD.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.yNUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.yNUD.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.yNUD.Name = "yNUD";
            this.yNUD.Size = new System.Drawing.Size(120, 38);
            this.yNUD.TabIndex = 17;
            this.yNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // crystall2Btn
            // 
            this.crystall2Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystall2Btn.Location = new System.Drawing.Point(5, 95);
            this.crystall2Btn.Margin = new System.Windows.Forms.Padding(5);
            this.crystall2Btn.Name = "crystall2Btn";
            this.crystall2Btn.Size = new System.Drawing.Size(307, 55);
            this.crystall2Btn.TabIndex = 13;
            this.crystall2Btn.Text = "crystall2Btn";
            this.crystall2Btn.UseVisualStyleBackColor = true;
            this.crystall2Btn.Click += new System.EventHandler(this.crystall2Btn_Click);
            // 
            // rotateCenterBtn
            // 
            this.rotateCenterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateCenterBtn.Location = new System.Drawing.Point(632, 30);
            this.rotateCenterBtn.Margin = new System.Windows.Forms.Padding(5);
            this.rotateCenterBtn.Name = "rotateCenterBtn";
            this.rotateCenterBtn.Size = new System.Drawing.Size(308, 55);
            this.rotateCenterBtn.TabIndex = 6;
            this.rotateCenterBtn.Text = "rotateCenterBtn";
            this.rotateCenterBtn.UseVisualStyleBackColor = true;
            this.rotateCenterBtn.Click += new System.EventHandler(this.rotateCenterBtn_Click);
            // 
            // xNUD
            // 
            this.xNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xNUD.Location = new System.Drawing.Point(504, 42);
            this.xNUD.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.xNUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.xNUD.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.xNUD.Name = "xNUD";
            this.xNUD.Size = new System.Drawing.Size(120, 38);
            this.xNUD.TabIndex = 6;
            this.xNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // reflectBtn
            // 
            this.reflectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectBtn.Location = new System.Drawing.Point(632, 95);
            this.reflectBtn.Margin = new System.Windows.Forms.Padding(5);
            this.reflectBtn.Name = "reflectBtn";
            this.reflectBtn.Size = new System.Drawing.Size(308, 55);
            this.reflectBtn.TabIndex = 10;
            this.reflectBtn.Text = "reflectBtn";
            this.reflectBtn.UseVisualStyleBackColor = true;
            this.reflectBtn.Click += new System.EventHandler(this.reflectBtn_Click);
            // 
            // xCheckBox
            // 
            this.xCheckBox.AutoSize = true;
            this.xCheckBox.Checked = true;
            this.xCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xCheckBox.Location = new System.Drawing.Point(327, 28);
            this.xCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.xCheckBox.Name = "xCheckBox";
            this.xCheckBox.Size = new System.Drawing.Size(164, 29);
            this.xCheckBox.TabIndex = 14;
            this.xCheckBox.Text = "Координата X";
            this.xCheckBox.UseVisualStyleBackColor = true;
            // 
            // yCheckBox
            // 
            this.yCheckBox.AutoSize = true;
            this.yCheckBox.Checked = true;
            this.yCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yCheckBox.Location = new System.Drawing.Point(327, 93);
            this.yCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.yCheckBox.Name = "yCheckBox";
            this.yCheckBox.Size = new System.Drawing.Size(163, 29);
            this.yCheckBox.TabIndex = 15;
            this.yCheckBox.Text = "Координата Y";
            this.yCheckBox.UseVisualStyleBackColor = true;
            // 
            // zCheckBox
            // 
            this.zCheckBox.AutoSize = true;
            this.zCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zCheckBox.Location = new System.Drawing.Point(327, 158);
            this.zCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.zCheckBox.Name = "zCheckBox";
            this.zCheckBox.Size = new System.Drawing.Size(162, 29);
            this.zCheckBox.TabIndex = 16;
            this.zCheckBox.Text = "Координата Z";
            this.zCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(358, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Угол вращения (в градусах)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fillRb);
            this.panel1.Controls.Add(this.normalVisualizerRb);
            this.panel1.Controls.Add(this.defaultVisualizerRb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 82);
            this.panel1.TabIndex = 19;
            // 
            // fillRb
            // 
            this.fillRb.AutoSize = true;
            this.fillRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillRb.Location = new System.Drawing.Point(2, 51);
            this.fillRb.Name = "fillRb";
            this.fillRb.Size = new System.Drawing.Size(156, 29);
            this.fillRb.TabIndex = 2;
            this.fillRb.Text = "Закрашивать";
            this.fillRb.UseVisualStyleBackColor = true;
            this.fillRb.CheckedChanged += new System.EventHandler(this.fillRb_CheckedChanged);
            // 
            // normalVisualizerRb
            // 
            this.normalVisualizerRb.AutoSize = true;
            this.normalVisualizerRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalVisualizerRb.Location = new System.Drawing.Point(2, 24);
            this.normalVisualizerRb.Name = "normalVisualizerRb";
            this.normalVisualizerRb.Size = new System.Drawing.Size(246, 29);
            this.normalVisualizerRb.TabIndex = 1;
            this.normalVisualizerRb.Text = "Только видимые грани";
            this.normalVisualizerRb.UseVisualStyleBackColor = true;
            this.normalVisualizerRb.CheckedChanged += new System.EventHandler(this.normalVisualizerRb_CheckedChanged);
            // 
            // defaultVisualizerRb
            // 
            this.defaultVisualizerRb.AutoSize = true;
            this.defaultVisualizerRb.Checked = true;
            this.defaultVisualizerRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defaultVisualizerRb.Location = new System.Drawing.Point(2, -1);
            this.defaultVisualizerRb.Name = "defaultVisualizerRb";
            this.defaultVisualizerRb.Size = new System.Drawing.Size(122, 29);
            this.defaultVisualizerRb.TabIndex = 0;
            this.defaultVisualizerRb.TabStop = true;
            this.defaultVisualizerRb.Text = "Все грани";
            this.defaultVisualizerRb.UseVisualStyleBackColor = true;
            this.defaultVisualizerRb.CheckedChanged += new System.EventHandler(this.defaultVisualizerRb_CheckedChanged);
            // 
            // zNUD
            // 
            this.zNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zNUD.Location = new System.Drawing.Point(504, 158);
            this.zNUD.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.zNUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.zNUD.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.zNUD.Name = "zNUD";
            this.zNUD.Size = new System.Drawing.Size(120, 38);
            this.zNUD.TabIndex = 18;
            this.zNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // subscribeCb
            // 
            this.subscribeCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subscribeCb.AutoSize = true;
            this.subscribeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscribeCb.Location = new System.Drawing.Point(11, 346);
            this.subscribeCb.Name = "subscribeCb";
            this.subscribeCb.Size = new System.Drawing.Size(248, 29);
            this.subscribeCb.TabIndex = 8;
            this.subscribeCb.Text = "Подписывать вершины";
            this.subscribeCb.UseVisualStyleBackColor = true;
            this.subscribeCb.CheckedChanged += new System.EventHandler(this.subscribeCb_CheckedChanged);
            // 
            // autoAction
            // 
            this.autoAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoAction.AutoSize = true;
            this.autoAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoAction.Location = new System.Drawing.Point(345, 346);
            this.autoAction.Name = "autoAction";
            this.autoAction.Size = new System.Drawing.Size(287, 29);
            this.autoAction.TabIndex = 9;
            this.autoAction.Text = "Автовращение с периодом";
            this.autoAction.UseVisualStyleBackColor = true;
            this.autoAction.CheckedChanged += new System.EventHandler(this.autoAction_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(652, 343);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 325);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(968, 654);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.autoAction);
            this.Controls.Add(this.subscribeCb);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNUD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button crystall1Btn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button rotateCenterBtn;
        private NumericUpDown xNUD;
        private Label label1;
        private CheckBox subscribeCb;
        private CheckBox autoAction;
        private Timer timer1;
        private NumericUpDown numericUpDown2;
        private Button reflectBtn;
        private Button crystall2Btn;
        private PictureBox pictureBox1;
        private CheckBox xCheckBox;
        private CheckBox yCheckBox;
        private CheckBox zCheckBox;
        private NumericUpDown yNUD;
        private NumericUpDown zNUD;
        private Panel panel1;
        private RadioButton normalVisualizerRb;
        private RadioButton defaultVisualizerRb;
        private RadioButton fillRb;
    }
}

