﻿namespace AgOpenGPS
{
    partial class FormABLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFixHeading = new System.Windows.Forms.Label();
            this.lblKeepGoing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBasedOnPass = new System.Windows.Forms.NumericUpDown();
            this.nudTramRepeats = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTurnOffAB = new System.Windows.Forms.Button();
            this.btnBPoint = new System.Windows.Forms.Button();
            this.btnAPoint = new System.Windows.Forms.Button();
            this.btnABLineOk = new System.Windows.Forms.Button();
            this.btnAddToFile = new System.Windows.Forms.Button();
            this.tboxHeading = new System.Windows.Forms.TextBox();
            this.lvLines = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAngle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEasting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNorthing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListDelete = new System.Windows.Forms.Button();
            this.btnListUse = new System.Windows.Forms.Button();
            this.btnPlus90 = new System.Windows.Forms.Button();
            this.btnDnABHeadingBy1 = new System.Windows.Forms.Button();
            this.btnUpABHeadingBy1 = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnNewABLine = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.tboxABLineName = new System.Windows.Forms.TextBox();
            this.btnGetABForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasedOnPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRepeats)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFixHeading
            // 
            this.lblFixHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFixHeading.AutoSize = true;
            this.lblFixHeading.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblFixHeading.Location = new System.Drawing.Point(541, 6);
            this.lblFixHeading.Name = "lblFixHeading";
            this.lblFixHeading.Size = new System.Drawing.Size(32, 33);
            this.lblFixHeading.TabIndex = 64;
            this.lblFixHeading.Text = "0";
            // 
            // lblKeepGoing
            // 
            this.lblKeepGoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeepGoing.AutoSize = true;
            this.lblKeepGoing.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblKeepGoing.Location = new System.Drawing.Point(711, 6);
            this.lblKeepGoing.Name = "lblKeepGoing";
            this.lblKeepGoing.Size = new System.Drawing.Size(22, 25);
            this.lblKeepGoing.TabIndex = 74;
            this.lblKeepGoing.Text = "?";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(162, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 76;
            this.label2.Text = "Repeats";
            // 
            // nudBasedOnPass
            // 
            this.nudBasedOnPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudBasedOnPass.BackColor = System.Drawing.Color.MediumOrchid;
            this.nudBasedOnPass.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBasedOnPass.Location = new System.Drawing.Point(69, 410);
            this.nudBasedOnPass.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudBasedOnPass.Name = "nudBasedOnPass";
            this.nudBasedOnPass.Size = new System.Drawing.Size(67, 52);
            this.nudBasedOnPass.TabIndex = 77;
            this.nudBasedOnPass.ValueChanged += new System.EventHandler(this.nudBasedOnPass_ValueChanged);
            // 
            // nudTramRepeats
            // 
            this.nudTramRepeats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudTramRepeats.BackColor = System.Drawing.Color.Lime;
            this.nudTramRepeats.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTramRepeats.Location = new System.Drawing.Point(232, 410);
            this.nudTramRepeats.Name = "nudTramRepeats";
            this.nudTramRepeats.Size = new System.Drawing.Size(67, 52);
            this.nudTramRepeats.TabIndex = 75;
            this.nudTramRepeats.ValueChanged += new System.EventHandler(this.nudTramRepeats_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(21, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 78;
            this.label3.Text = "Start";
            // 
            // btnTurnOffAB
            // 
            this.btnTurnOffAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTurnOffAB.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnOffAB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTurnOffAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTurnOffAB.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnTurnOffAB.Location = new System.Drawing.Point(509, 383);
            this.btnTurnOffAB.Name = "btnTurnOffAB";
            this.btnTurnOffAB.Size = new System.Drawing.Size(100, 80);
            this.btnTurnOffAB.TabIndex = 0;
            this.btnTurnOffAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTurnOffAB.UseVisualStyleBackColor = false;
            this.btnTurnOffAB.Click += new System.EventHandler(this.btnTurnOffAB_Click);
            // 
            // btnBPoint
            // 
            this.btnBPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBPoint.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnBPoint.Image = global::AgOpenGPS.Properties.Resources.LetterBBlue;
            this.btnBPoint.Location = new System.Drawing.Point(664, 38);
            this.btnBPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBPoint.Name = "btnBPoint";
            this.btnBPoint.Size = new System.Drawing.Size(100, 80);
            this.btnBPoint.TabIndex = 58;
            this.btnBPoint.UseVisualStyleBackColor = true;
            this.btnBPoint.Click += new System.EventHandler(this.btnBPoint_Click);
            // 
            // btnAPoint
            // 
            this.btnAPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAPoint.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnAPoint.Image = global::AgOpenGPS.Properties.Resources.LetterABlue;
            this.btnAPoint.Location = new System.Drawing.Point(506, 38);
            this.btnAPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAPoint.Name = "btnAPoint";
            this.btnAPoint.Size = new System.Drawing.Size(100, 80);
            this.btnAPoint.TabIndex = 57;
            this.btnAPoint.UseVisualStyleBackColor = true;
            this.btnAPoint.Click += new System.EventHandler(this.btnAPoint_Click);
            // 
            // btnABLineOk
            // 
            this.btnABLineOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnABLineOk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnABLineOk.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnABLineOk.Location = new System.Drawing.Point(642, 382);
            this.btnABLineOk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnABLineOk.Name = "btnABLineOk";
            this.btnABLineOk.Size = new System.Drawing.Size(125, 80);
            this.btnABLineOk.TabIndex = 62;
            this.btnABLineOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnABLineOk.UseVisualStyleBackColor = true;
            this.btnABLineOk.Click += new System.EventHandler(this.btnABLineOk_Click);
            // 
            // btnAddToFile
            // 
            this.btnAddToFile.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToFile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddToFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddToFile.Image = global::AgOpenGPS.Properties.Resources.FileNew;
            this.btnAddToFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddToFile.Location = new System.Drawing.Point(7, 17);
            this.btnAddToFile.Name = "btnAddToFile";
            this.btnAddToFile.Size = new System.Drawing.Size(95, 88);
            this.btnAddToFile.TabIndex = 82;
            this.btnAddToFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddToFile.UseVisualStyleBackColor = false;
            this.btnAddToFile.Click += new System.EventHandler(this.btnAddToFile_Click);
            // 
            // tboxHeading
            // 
            this.tboxHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxHeading.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxHeading.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.tboxHeading.Location = new System.Drawing.Point(547, 135);
            this.tboxHeading.MaxLength = 10;
            this.tboxHeading.Name = "tboxHeading";
            this.tboxHeading.Size = new System.Drawing.Size(176, 43);
            this.tboxHeading.TabIndex = 83;
            this.tboxHeading.Text = "359.123456";
            this.tboxHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxHeading.TextChanged += new System.EventHandler(this.tboxHeading_TextChanged);
            this.tboxHeading.Enter += new System.EventHandler(this.TboxHeading_Enter);
            // 
            // lvLines
            // 
            this.lvLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAngle,
            this.chEasting,
            this.chNorthing});
            this.lvLines.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lvLines.FullRowSelect = true;
            this.lvLines.GridLines = true;
            this.lvLines.HideSelection = false;
            this.lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lvLines.Location = new System.Drawing.Point(113, 93);
            this.lvLines.MultiSelect = false;
            this.lvLines.Name = "lvLines";
            this.lvLines.Size = new System.Drawing.Size(359, 264);
            this.lvLines.TabIndex = 84;
            this.lvLines.UseCompatibleStateImageBehavior = false;
            this.lvLines.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 260;
            // 
            // chAngle
            // 
            this.chAngle.Text = "Angle";
            this.chAngle.Width = 100;
            // 
            // chEasting
            // 
            this.chEasting.Text = "X";
            this.chEasting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEasting.Width = 100;
            // 
            // chNorthing
            // 
            this.chNorthing.Text = "Y";
            this.chNorthing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNorthing.Width = 100;
            // 
            // btnListDelete
            // 
            this.btnListDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnListDelete.Image = global::AgOpenGPS.Properties.Resources.FileDelete;
            this.btnListDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListDelete.Location = new System.Drawing.Point(7, 156);
            this.btnListDelete.Name = "btnListDelete";
            this.btnListDelete.Size = new System.Drawing.Size(95, 93);
            this.btnListDelete.TabIndex = 85;
            this.btnListDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListDelete.UseVisualStyleBackColor = true;
            this.btnListDelete.Click += new System.EventHandler(this.btnListDelete_Click);
            // 
            // btnListUse
            // 
            this.btnListUse.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnListUse.Image = global::AgOpenGPS.Properties.Resources.FileUse;
            this.btnListUse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListUse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListUse.Location = new System.Drawing.Point(7, 281);
            this.btnListUse.Name = "btnListUse";
            this.btnListUse.Size = new System.Drawing.Size(95, 88);
            this.btnListUse.TabIndex = 86;
            this.btnListUse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListUse.UseVisualStyleBackColor = true;
            this.btnListUse.Click += new System.EventHandler(this.btnListUse_Click);
            // 
            // btnPlus90
            // 
            this.btnPlus90.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlus90.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus90.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlus90.Location = new System.Drawing.Point(693, 198);
            this.btnPlus90.Name = "btnPlus90";
            this.btnPlus90.Size = new System.Drawing.Size(70, 51);
            this.btnPlus90.TabIndex = 87;
            this.btnPlus90.Text = "+90";
            this.btnPlus90.UseVisualStyleBackColor = true;
            this.btnPlus90.Click += new System.EventHandler(this.btnPlus90_Click);
            // 
            // btnDnABHeadingBy1
            // 
            this.btnDnABHeadingBy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDnABHeadingBy1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnABHeadingBy1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDnABHeadingBy1.Location = new System.Drawing.Point(601, 198);
            this.btnDnABHeadingBy1.Name = "btnDnABHeadingBy1";
            this.btnDnABHeadingBy1.Size = new System.Drawing.Size(70, 51);
            this.btnDnABHeadingBy1.TabIndex = 73;
            this.btnDnABHeadingBy1.Text = "+0.1";
            this.btnDnABHeadingBy1.UseVisualStyleBackColor = true;
            this.btnDnABHeadingBy1.Click += new System.EventHandler(this.BtnDnABHeadingBy1_Click);
            // 
            // btnUpABHeadingBy1
            // 
            this.btnUpABHeadingBy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpABHeadingBy1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpABHeadingBy1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpABHeadingBy1.Location = new System.Drawing.Point(509, 198);
            this.btnUpABHeadingBy1.Name = "btnUpABHeadingBy1";
            this.btnUpABHeadingBy1.Size = new System.Drawing.Size(70, 51);
            this.btnUpABHeadingBy1.TabIndex = 72;
            this.btnUpABHeadingBy1.Text = "-0.1";
            this.btnUpABHeadingBy1.UseVisualStyleBackColor = true;
            this.btnUpABHeadingBy1.Click += new System.EventHandler(this.BtnUpABHeadingBy1_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Image = global::AgOpenGPS.Properties.Resources.ArrowRight;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShow.Location = new System.Drawing.Point(509, 276);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 80);
            this.btnShow.TabIndex = 148;
            this.btnShow.Text = "Show";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnNewABLine
            // 
            this.btnNewABLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewABLine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewABLine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewABLine.Image = global::AgOpenGPS.Properties.Resources.back_button;
            this.btnNewABLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewABLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewABLine.Location = new System.Drawing.Point(664, 276);
            this.btnNewABLine.Name = "btnNewABLine";
            this.btnNewABLine.Size = new System.Drawing.Size(100, 80);
            this.btnNewABLine.TabIndex = 149;
            this.btnNewABLine.Text = "New";
            this.btnNewABLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewABLine.UseVisualStyleBackColor = false;
            this.btnNewABLine.Click += new System.EventHandler(this.BtnNewABLine_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(146, 8);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(246, 39);
            this.lblEnterName.TabIndex = 151;
            this.lblEnterName.Text = "Enter Line Name";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnterName.Visible = false;
            // 
            // tboxABLineName
            // 
            this.tboxABLineName.Location = new System.Drawing.Point(151, 52);
            this.tboxABLineName.Name = "tboxABLineName";
            this.tboxABLineName.Size = new System.Drawing.Size(228, 30);
            this.tboxABLineName.TabIndex = 152;
            this.tboxABLineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetABForm
            // 
            this.btnGetABForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetABForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGetABForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetABForm.Image = global::AgOpenGPS.Properties.Resources.PointStart;
            this.btnGetABForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGetABForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetABForm.Location = new System.Drawing.Point(379, 387);
            this.btnGetABForm.Name = "btnGetABForm";
            this.btnGetABForm.Size = new System.Drawing.Size(80, 69);
            this.btnGetABForm.TabIndex = 149;
            this.btnGetABForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGetABForm.UseVisualStyleBackColor = false;
            this.btnGetABForm.Click += new System.EventHandler(this.BtnGetABForm_Click);
            // 
            // FormABLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(768, 462);
            this.ControlBox = false;
            this.Controls.Add(this.tboxABLineName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.btnGetABForm);
            this.Controls.Add(this.btnNewABLine);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblFixHeading);
            this.Controls.Add(this.btnPlus90);
            this.Controls.Add(this.btnListUse);
            this.Controls.Add(this.btnListDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvLines);
            this.Controls.Add(this.nudTramRepeats);
            this.Controls.Add(this.tboxHeading);
            this.Controls.Add(this.nudBasedOnPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddToFile);
            this.Controls.Add(this.lblKeepGoing);
            this.Controls.Add(this.btnDnABHeadingBy1);
            this.Controls.Add(this.btnUpABHeadingBy1);
            this.Controls.Add(this.btnTurnOffAB);
            this.Controls.Add(this.btnBPoint);
            this.Controls.Add(this.btnAPoint);
            this.Controls.Add(this.btnABLineOk);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormABLine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AB Line";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormABLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBasedOnPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRepeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurnOffAB;
        private System.Windows.Forms.Button btnBPoint;
        private System.Windows.Forms.Button btnAPoint;
        private System.Windows.Forms.Button btnABLineOk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFixHeading;
        private System.Windows.Forms.Label lblKeepGoing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBasedOnPass;
        private System.Windows.Forms.NumericUpDown nudTramRepeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddToFile;
        private System.Windows.Forms.TextBox tboxHeading;
        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAngle;
        private System.Windows.Forms.Button btnListDelete;
        private System.Windows.Forms.Button btnListUse;
        private System.Windows.Forms.ColumnHeader chEasting;
        private System.Windows.Forms.ColumnHeader chNorthing;
        private System.Windows.Forms.Button btnPlus90;
        private System.Windows.Forms.Button btnDnABHeadingBy1;
        private System.Windows.Forms.Button btnUpABHeadingBy1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnNewABLine;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox tboxABLineName;
        private System.Windows.Forms.Button btnGetABForm;
    }
}