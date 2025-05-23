﻿namespace LaserGRBL
{
	partial class JogForm
	{
		/// <summary> 
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Liberare le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione componenti

		/// <summary> 
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.BtnHome = new LaserGRBL.DirectionButton();
            this.BtnW = new LaserGRBL.DirectionButton();
            this.BtnN = new LaserGRBL.DirectionButton();
            this.BtnE = new LaserGRBL.DirectionButton();
            this.BtnNW = new LaserGRBL.DirectionButton();
            this.BtnNE = new LaserGRBL.DirectionButton();
            this.BtnS = new LaserGRBL.DirectionButton();
            this.BtnSW = new LaserGRBL.DirectionButton();
            this.BtnSE = new LaserGRBL.DirectionButton();
            this.TlpSpeedControl = new System.Windows.Forms.TableLayoutPanel();
            this.TbSpeed = new System.Windows.Forms.TrackBar();
            this.LblSpeed = new System.Windows.Forms.Label();
            this.TlpStepControl = new System.Windows.Forms.TableLayoutPanel();
            this.TbStep = new LaserGRBL.StepBar();
            this.LblStep = new System.Windows.Forms.Label();
            this.TlpZControl = new System.Windows.Forms.TableLayoutPanel();
            this.BtnZup01 = new LaserGRBL.DirectionStepButton();
            this.BtnZup1 = new LaserGRBL.DirectionStepButton();
            this.BtnZup10 = new LaserGRBL.DirectionStepButton();
            this.BtnZdown10 = new LaserGRBL.DirectionStepButton();
            this.BtnZdown1 = new LaserGRBL.DirectionStepButton();
            this.BtnZdown01 = new LaserGRBL.DirectionStepButton();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.UpdateFMax = new System.Windows.Forms.Timer(this.components);
            this.tlp.SuspendLayout();
            this.TlpSpeedControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbSpeed)).BeginInit();
            this.TlpStepControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbStep)).BeginInit();
            this.TlpZControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.AutoSize = true;
            this.tlp.ColumnCount = 8;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Controls.Add(this.BtnHome, 3, 2);
            this.tlp.Controls.Add(this.BtnW, 2, 2);
            this.tlp.Controls.Add(this.BtnN, 3, 1);
            this.tlp.Controls.Add(this.BtnE, 4, 2);
            this.tlp.Controls.Add(this.BtnNW, 2, 1);
            this.tlp.Controls.Add(this.BtnNE, 4, 1);
            this.tlp.Controls.Add(this.BtnS, 3, 3);
            this.tlp.Controls.Add(this.BtnSW, 2, 3);
            this.tlp.Controls.Add(this.BtnSE, 4, 3);
            this.tlp.Controls.Add(this.TlpSpeedControl, 1, 1);
            this.tlp.Controls.Add(this.TlpStepControl, 6, 1);
            this.tlp.Controls.Add(this.TlpZControl, 5, 1);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 5;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(267, 125);
            this.tlp.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.AltImage = null;
            this.BtnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnHome.Caption = null;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.Image = null;
            this.BtnHome.JogDirection = LaserGRBL.GrblCore.JogDirection.Home;
            this.BtnHome.Location = new System.Drawing.Point(107, 42);
            this.BtnHome.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.RoundedBorders = false;
            this.BtnHome.Size = new System.Drawing.Size(33, 33);
            this.BtnHome.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnHome.TabIndex = 7;
            this.BtnHome.TabStop = false;
            this.BtnHome.UseAltImage = false;
            this.BtnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // BtnW
            // 
            this.BtnW.AltImage = null;
            this.BtnW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnW.Caption = null;
            this.BtnW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnW.Image = null;
            this.BtnW.JogDirection = LaserGRBL.GrblCore.JogDirection.W;
            this.BtnW.Location = new System.Drawing.Point(67, 42);
            this.BtnW.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnW.Name = "BtnW";
            this.BtnW.RoundedBorders = false;
            this.BtnW.Size = new System.Drawing.Size(33, 33);
            this.BtnW.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnW.TabIndex = 8;
            this.BtnW.TabStop = false;
            this.BtnW.UseAltImage = false;
            this.BtnW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // BtnN
            // 
            this.BtnN.AltImage = null;
            this.BtnN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnN.Caption = null;
            this.BtnN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnN.Image = null;
            this.BtnN.JogDirection = LaserGRBL.GrblCore.JogDirection.N;
            this.BtnN.Location = new System.Drawing.Point(107, 3);
            this.BtnN.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnN.Name = "BtnN";
            this.BtnN.RoundedBorders = false;
            this.BtnN.Size = new System.Drawing.Size(33, 33);
            this.BtnN.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnN.TabIndex = 9;
            this.BtnN.TabStop = false;
            this.BtnN.UseAltImage = false;
            this.BtnN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // BtnE
            // 
            this.BtnE.AltImage = null;
            this.BtnE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnE.Caption = null;
            this.BtnE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnE.Image = null;
            this.BtnE.JogDirection = LaserGRBL.GrblCore.JogDirection.E;
            this.BtnE.Location = new System.Drawing.Point(147, 42);
            this.BtnE.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnE.Name = "BtnE";
            this.BtnE.RoundedBorders = false;
            this.BtnE.Size = new System.Drawing.Size(33, 33);
            this.BtnE.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnE.TabIndex = 11;
            this.BtnE.TabStop = false;
            this.BtnE.UseAltImage = false;
            this.BtnE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // BtnNW
            // 
            this.BtnNW.AltImage = null;
            this.BtnNW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNW.Caption = null;
            this.BtnNW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNW.Image = null;
            this.BtnNW.JogDirection = LaserGRBL.GrblCore.JogDirection.NW;
            this.BtnNW.Location = new System.Drawing.Point(67, 3);
            this.BtnNW.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnNW.Name = "BtnNW";
            this.BtnNW.RoundedBorders = false;
            this.BtnNW.Size = new System.Drawing.Size(33, 33);
            this.BtnNW.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnNW.TabIndex = 13;
            this.BtnNW.TabStop = false;
            this.BtnNW.UseAltImage = false;
            this.BtnNW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnNW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // BtnNE
            // 
            this.BtnNE.AltImage = null;
            this.BtnNE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNE.Caption = null;
            this.BtnNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNE.Image = null;
            this.BtnNE.JogDirection = LaserGRBL.GrblCore.JogDirection.NE;
            this.BtnNE.Location = new System.Drawing.Point(147, 3);
            this.BtnNE.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnNE.Name = "BtnNE";
            this.BtnNE.RoundedBorders = false;
            this.BtnNE.Size = new System.Drawing.Size(33, 33);
            this.BtnNE.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnNE.TabIndex = 12;
            this.BtnNE.TabStop = false;
            this.BtnNE.UseAltImage = false;
            this.BtnNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnNE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // BtnS
            // 
            this.BtnS.AltImage = null;
            this.BtnS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnS.Caption = null;
            this.BtnS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnS.Image = null;
            this.BtnS.JogDirection = LaserGRBL.GrblCore.JogDirection.S;
            this.BtnS.Location = new System.Drawing.Point(107, 85);
            this.BtnS.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnS.Name = "BtnS";
            this.BtnS.RoundedBorders = false;
            this.BtnS.Size = new System.Drawing.Size(34, 34);
            this.BtnS.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnS.TabIndex = 15;
            this.BtnS.TabStop = false;
            this.BtnS.UseAltImage = false;
            this.BtnS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // BtnSW
            // 
            this.BtnSW.AltImage = null;
            this.BtnSW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSW.Caption = null;
            this.BtnSW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSW.Image = null;
            this.BtnSW.JogDirection = LaserGRBL.GrblCore.JogDirection.SW;
            this.BtnSW.Location = new System.Drawing.Point(67, 85);
            this.BtnSW.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnSW.Name = "BtnSW";
            this.BtnSW.RoundedBorders = false;
            this.BtnSW.Size = new System.Drawing.Size(34, 34);
            this.BtnSW.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnSW.TabIndex = 14;
            this.BtnSW.TabStop = false;
            this.BtnSW.UseAltImage = false;
            this.BtnSW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnSW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // BtnSE
            // 
            this.BtnSE.AltImage = null;
            this.BtnSE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSE.Caption = null;
            this.BtnSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSE.Image = null;
            this.BtnSE.JogDirection = LaserGRBL.GrblCore.JogDirection.SE;
            this.BtnSE.Location = new System.Drawing.Point(147, 85);
            this.BtnSE.MaximumSize = new System.Drawing.Size(48, 48);
            this.BtnSE.Name = "BtnSE";
            this.BtnSE.RoundedBorders = false;
            this.BtnSE.Size = new System.Drawing.Size(34, 34);
            this.BtnSE.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.StretchImage;
            this.BtnSE.TabIndex = 10;
            this.BtnSE.TabStop = false;
            this.BtnSE.UseAltImage = false;
            this.BtnSE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseDown);
            this.BtnSE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnJogButtonMouseUp);
            // 
            // TlpSpeedControl
            // 
            this.TlpSpeedControl.AutoSize = true;
            this.TlpSpeedControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TlpSpeedControl.ColumnCount = 1;
            this.TlpSpeedControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpSpeedControl.Controls.Add(this.TbSpeed, 0, 0);
            this.TlpSpeedControl.Controls.Add(this.LblSpeed, 0, 1);
            this.TlpSpeedControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSpeedControl.Location = new System.Drawing.Point(-11, 0);
            this.TlpSpeedControl.Margin = new System.Windows.Forms.Padding(0);
            this.TlpSpeedControl.Name = "TlpSpeedControl";
            this.TlpSpeedControl.RowCount = 2;
            this.tlp.SetRowSpan(this.TlpSpeedControl, 3);
            this.TlpSpeedControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSpeedControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpSpeedControl.Size = new System.Drawing.Size(75, 126);
            this.TlpSpeedControl.TabIndex = 18;
            // 
            // TbSpeed
            // 
            this.TbSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbSpeed.LargeChange = 100;
            this.TbSpeed.Location = new System.Drawing.Point(3, 3);
            this.TbSpeed.Maximum = 4000;
            this.TbSpeed.Minimum = 10;
            this.TbSpeed.Name = "TbSpeed";
            this.TbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TbSpeed.Size = new System.Drawing.Size(69, 100);
            this.TbSpeed.SmallChange = 50;
            this.TbSpeed.TabIndex = 16;
            this.TbSpeed.TickFrequency = 200;
            this.TbSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TbSpeed.Value = 1000;
            this.TbSpeed.ValueChanged += new System.EventHandler(this.TbSpeed_ValueChanged);
            // 
            // LblSpeed
            // 
            this.LblSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSpeed.AutoSize = true;
            this.LblSpeed.Location = new System.Drawing.Point(10, 106);
            this.LblSpeed.Name = "LblSpeed";
            this.LblSpeed.Size = new System.Drawing.Size(55, 20);
            this.LblSpeed.TabIndex = 17;
            this.LblSpeed.Text = "F1000";
            // 
            // TlpStepControl
            // 
            this.TlpStepControl.AutoSize = true;
            this.TlpStepControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TlpStepControl.ColumnCount = 1;
            this.TlpStepControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpStepControl.Controls.Add(this.TbStep, 0, 0);
            this.TlpStepControl.Controls.Add(this.LblStep, 0, 1);
            this.TlpStepControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpStepControl.Location = new System.Drawing.Point(204, 0);
            this.TlpStepControl.Margin = new System.Windows.Forms.Padding(0);
            this.TlpStepControl.Name = "TlpStepControl";
            this.TlpStepControl.RowCount = 2;
            this.tlp.SetRowSpan(this.TlpStepControl, 3);
            this.TlpStepControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpStepControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpStepControl.Size = new System.Drawing.Size(75, 126);
            this.TlpStepControl.TabIndex = 19;
            // 
            // TbStep
            // 
            this.TbStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbStep.LargeChange = 1;
            this.TbStep.Location = new System.Drawing.Point(3, 3);
            this.TbStep.Name = "TbStep";
            this.TbStep.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TbStep.Size = new System.Drawing.Size(69, 100);
            this.TbStep.TabIndex = 17;
            this.TbStep.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TbStep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TbStep.ValueChanged += new System.EventHandler(this.TbStep_ValueChanged);
            // 
            // LblStep
            // 
            this.LblStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblStep.AutoSize = true;
            this.LblStep.Location = new System.Drawing.Point(24, 106);
            this.LblStep.Name = "LblStep";
            this.LblStep.Size = new System.Drawing.Size(27, 20);
            this.LblStep.TabIndex = 18;
            this.LblStep.Text = "10";
            // 
            // TlpZControl
            // 
            this.TlpZControl.ColumnCount = 1;
            this.TlpZControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpZControl.Controls.Add(this.BtnZup01, 0, 3);
            this.TlpZControl.Controls.Add(this.BtnZup1, 0, 2);
            this.TlpZControl.Controls.Add(this.BtnZup10, 0, 1);
            this.TlpZControl.Controls.Add(this.BtnZdown10, 0, 6);
            this.TlpZControl.Controls.Add(this.BtnZdown1, 0, 5);
            this.TlpZControl.Controls.Add(this.BtnZdown01, 0, 5);
            this.TlpZControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpZControl.Location = new System.Drawing.Point(184, 0);
            this.TlpZControl.Margin = new System.Windows.Forms.Padding(0);
            this.TlpZControl.Name = "TlpZControl";
            this.TlpZControl.RowCount = 9;
            this.tlp.SetRowSpan(this.TlpZControl, 3);
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpZControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpZControl.Size = new System.Drawing.Size(20, 126);
            this.TlpZControl.TabIndex = 20;
            this.TlpZControl.Visible = false;
            // 
            // BtnZup01
            // 
            this.BtnZup01.AltImage = null;
            this.BtnZup01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnZup01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnZup01.Caption = null;
            this.BtnZup01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZup01.Image = null;
            this.BtnZup01.JogDirection = LaserGRBL.GrblCore.JogDirection.Zup;
            this.BtnZup01.JogStep = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.BtnZup01.Location = new System.Drawing.Point(2, 47);
            this.BtnZup01.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZup01.MaximumSize = new System.Drawing.Size(16, 16);
            this.BtnZup01.MinimumSize = new System.Drawing.Size(16, 16);
            this.BtnZup01.Name = "BtnZup01";
            this.BtnZup01.RoundedBorders = false;
            this.BtnZup01.Size = new System.Drawing.Size(16, 16);
            this.BtnZup01.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnZup01.TabIndex = 19;
            this.BtnZup01.TabStop = false;
            this.TT.SetToolTip(this.BtnZup01, "0.1mm");
            this.BtnZup01.UseAltImage = false;
            this.BtnZup01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnZJogButtonMouseDown);
            // 
            // BtnZup1
            // 
            this.BtnZup1.AltImage = null;
            this.BtnZup1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnZup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnZup1.Caption = null;
            this.BtnZup1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZup1.Image = null;
            this.BtnZup1.JogDirection = LaserGRBL.GrblCore.JogDirection.Zup;
            this.BtnZup1.JogStep = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.BtnZup1.Location = new System.Drawing.Point(2, 31);
            this.BtnZup1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZup1.MaximumSize = new System.Drawing.Size(16, 16);
            this.BtnZup1.MinimumSize = new System.Drawing.Size(16, 16);
            this.BtnZup1.Name = "BtnZup1";
            this.BtnZup1.RoundedBorders = false;
            this.BtnZup1.Size = new System.Drawing.Size(16, 16);
            this.BtnZup1.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnZup1.TabIndex = 18;
            this.BtnZup1.TabStop = false;
            this.TT.SetToolTip(this.BtnZup1, "1mm");
            this.BtnZup1.UseAltImage = false;
            this.BtnZup1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnZJogButtonMouseDown);
            // 
            // BtnZup10
            // 
            this.BtnZup10.AltImage = null;
            this.BtnZup10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnZup10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnZup10.Caption = null;
            this.BtnZup10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZup10.Image = null;
            this.BtnZup10.JogDirection = LaserGRBL.GrblCore.JogDirection.Zup;
            this.BtnZup10.JogStep = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.BtnZup10.Location = new System.Drawing.Point(2, 15);
            this.BtnZup10.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZup10.MaximumSize = new System.Drawing.Size(16, 16);
            this.BtnZup10.MinimumSize = new System.Drawing.Size(16, 16);
            this.BtnZup10.Name = "BtnZup10";
            this.BtnZup10.RoundedBorders = false;
            this.BtnZup10.Size = new System.Drawing.Size(16, 16);
            this.BtnZup10.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnZup10.TabIndex = 17;
            this.BtnZup10.TabStop = false;
            this.TT.SetToolTip(this.BtnZup10, "10mm");
            this.BtnZup10.UseAltImage = false;
            this.BtnZup10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnZJogButtonMouseDown);
            // 
            // BtnZdown10
            // 
            this.BtnZdown10.AltImage = null;
            this.BtnZdown10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnZdown10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnZdown10.Caption = null;
            this.BtnZdown10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZdown10.Image = null;
            this.BtnZdown10.JogDirection = LaserGRBL.GrblCore.JogDirection.Zdown;
            this.BtnZdown10.JogStep = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.BtnZdown10.Location = new System.Drawing.Point(2, 95);
            this.BtnZdown10.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZdown10.MaximumSize = new System.Drawing.Size(16, 16);
            this.BtnZdown10.MinimumSize = new System.Drawing.Size(16, 16);
            this.BtnZdown10.Name = "BtnZdown10";
            this.BtnZdown10.RoundedBorders = false;
            this.BtnZdown10.Size = new System.Drawing.Size(16, 16);
            this.BtnZdown10.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnZdown10.TabIndex = 16;
            this.BtnZdown10.TabStop = false;
            this.TT.SetToolTip(this.BtnZdown10, "10mm");
            this.BtnZdown10.UseAltImage = false;
            this.BtnZdown10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnZJogButtonMouseDown);
            // 
            // BtnZdown1
            // 
            this.BtnZdown1.AltImage = null;
            this.BtnZdown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnZdown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnZdown1.Caption = null;
            this.BtnZdown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZdown1.Image = null;
            this.BtnZdown1.JogDirection = LaserGRBL.GrblCore.JogDirection.Zdown;
            this.BtnZdown1.JogStep = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.BtnZdown1.Location = new System.Drawing.Point(2, 79);
            this.BtnZdown1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZdown1.MaximumSize = new System.Drawing.Size(16, 16);
            this.BtnZdown1.MinimumSize = new System.Drawing.Size(16, 16);
            this.BtnZdown1.Name = "BtnZdown1";
            this.BtnZdown1.RoundedBorders = false;
            this.BtnZdown1.Size = new System.Drawing.Size(16, 16);
            this.BtnZdown1.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnZdown1.TabIndex = 15;
            this.BtnZdown1.TabStop = false;
            this.TT.SetToolTip(this.BtnZdown1, "1mm");
            this.BtnZdown1.UseAltImage = false;
            this.BtnZdown1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnZJogButtonMouseDown);
            // 
            // BtnZdown01
            // 
            this.BtnZdown01.AltImage = null;
            this.BtnZdown01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnZdown01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnZdown01.Caption = null;
            this.BtnZdown01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZdown01.Image = null;
            this.BtnZdown01.JogDirection = LaserGRBL.GrblCore.JogDirection.Zdown;
            this.BtnZdown01.JogStep = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.BtnZdown01.Location = new System.Drawing.Point(2, 63);
            this.BtnZdown01.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZdown01.MaximumSize = new System.Drawing.Size(16, 16);
            this.BtnZdown01.MinimumSize = new System.Drawing.Size(16, 16);
            this.BtnZdown01.Name = "BtnZdown01";
            this.BtnZdown01.RoundedBorders = false;
            this.BtnZdown01.Size = new System.Drawing.Size(16, 16);
            this.BtnZdown01.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.BtnZdown01.TabIndex = 14;
            this.BtnZdown01.TabStop = false;
            this.TT.SetToolTip(this.BtnZdown01, "0.1mm");
            this.BtnZdown01.UseAltImage = false;
            this.BtnZdown01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnZJogButtonMouseDown);
            // 
            // UpdateFMax
            // 
            this.UpdateFMax.Interval = 1000;
            this.UpdateFMax.Tick += new System.EventHandler(this.UpdateFMax_Tick);
            // 
            // JogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JogForm";
            this.Size = new System.Drawing.Size(267, 125);
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.TlpSpeedControl.ResumeLayout(false);
            this.TlpSpeedControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbSpeed)).EndInit();
            this.TlpStepControl.ResumeLayout(false);
            this.TlpStepControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbStep)).EndInit();
            this.TlpZControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlp;
		private DirectionButton BtnS;
		private DirectionButton BtnSW;
		private DirectionButton BtnHome;
		private DirectionButton BtnW;
		private DirectionButton BtnN;
		private DirectionButton BtnSE;
		private DirectionButton BtnE;
		private DirectionButton BtnNW;
		private DirectionButton BtnNE;
		private System.Windows.Forms.TrackBar TbSpeed;
		private StepBar TbStep;
		private System.Windows.Forms.ToolTip TT;
		private System.Windows.Forms.TableLayoutPanel TlpSpeedControl;
		private System.Windows.Forms.Label LblSpeed;
		private System.Windows.Forms.TableLayoutPanel TlpStepControl;
		private System.Windows.Forms.Label LblStep;
		private System.Windows.Forms.Timer UpdateFMax;
        private System.Windows.Forms.TableLayoutPanel TlpZControl;
        private DirectionStepButton BtnZdown10;
        private DirectionStepButton BtnZdown1;
        private DirectionStepButton BtnZdown01;
        private DirectionStepButton BtnZup01;
        private DirectionStepButton BtnZup1;
        private DirectionStepButton BtnZup10;
    }
}
