namespace Malin_s_AstroMath_App
{
    partial class AstroMathApp
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
            this.menuStripMalin = new System.Windows.Forms.MenuStrip();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataViewCalculations = new System.Windows.Forms.DataGridView();
            this.StarVelocityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarDistanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventHorizonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelObservedWaveLength = new System.Windows.Forms.Label();
            this.labelWaveLength = new System.Windows.Forms.Label();
            this.textBoxObsLength = new System.Windows.Forms.TextBox();
            this.textBoxRestLength = new System.Windows.Forms.TextBox();
            this.buttonStarVelocity = new System.Windows.Forms.Button();
            this.labelArcsecondAngle = new System.Windows.Forms.Label();
            this.textBoxArcsecondAngle = new System.Windows.Forms.TextBox();
            this.buttonStarDistance = new System.Windows.Forms.Button();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.buttonKelvinTemp = new System.Windows.Forms.Button();
            this.labelBlackholeMass = new System.Windows.Forms.Label();
            this.textBoxBlackholeMass = new System.Windows.Forms.TextBox();
            this.buttonEventHorizon = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxStarVelocity = new System.Windows.Forms.GroupBox();
            this.buttonFrench = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.buttonGerman = new System.Windows.Forms.Button();
            this.groupBoxStarDistance = new System.Windows.Forms.GroupBox();
            this.groupBoxKelvin = new System.Windows.Forms.GroupBox();
            this.groupBoxEventHorizon = new System.Windows.Forms.GroupBox();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.textBoxExpo = new System.Windows.Forms.TextBox();
            this.textBoxMultiply = new System.Windows.Forms.TextBox();
            this.checkBoxMode = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripMalin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCalculations)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBoxStarVelocity.SuspendLayout();
            this.groupBoxStarDistance.SuspendLayout();
            this.groupBoxKelvin.SuspendLayout();
            this.groupBoxEventHorizon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMalin
            // 
            this.menuStripMalin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectColorToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStripMalin.Location = new System.Drawing.Point(0, 0);
            this.menuStripMalin.Name = "menuStripMalin";
            this.menuStripMalin.Size = new System.Drawing.Size(800, 24);
            this.menuStripMalin.TabIndex = 0;
            this.menuStripMalin.Text = "menuStripMalin";
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.selectColorToolStripMenuItem.Text = "Select Color";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.selectColorToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.resetToolStripMenuItem.Text = "Reset Format";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // dataViewCalculations
            // 
            this.dataViewCalculations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewCalculations.BackgroundColor = System.Drawing.Color.Silver;
            this.dataViewCalculations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCalculations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StarVelocityColumn,
            this.StarDistanceColumn,
            this.TemperatureColumn,
            this.EventHorizonColumn});
            this.dataViewCalculations.Location = new System.Drawing.Point(202, 158);
            this.dataViewCalculations.Name = "dataViewCalculations";
            this.dataViewCalculations.RowHeadersVisible = false;
            this.dataViewCalculations.Size = new System.Drawing.Size(586, 301);
            this.dataViewCalculations.TabIndex = 1;
            // 
            // StarVelocityColumn
            // 
            this.StarVelocityColumn.HeaderText = "Star Velocity";
            this.StarVelocityColumn.Name = "StarVelocityColumn";
            // 
            // StarDistanceColumn
            // 
            this.StarDistanceColumn.HeaderText = "Star Distance";
            this.StarDistanceColumn.Name = "StarDistanceColumn";
            // 
            // TemperatureColumn
            // 
            this.TemperatureColumn.HeaderText = "Temperature Coversion";
            this.TemperatureColumn.Name = "TemperatureColumn";
            // 
            // EventHorizonColumn
            // 
            this.EventHorizonColumn.HeaderText = "Event Horizon";
            this.EventHorizonColumn.Name = "EventHorizonColumn";
            // 
            // labelObservedWaveLength
            // 
            this.labelObservedWaveLength.AutoSize = true;
            this.labelObservedWaveLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelObservedWaveLength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelObservedWaveLength.Location = new System.Drawing.Point(3, 26);
            this.labelObservedWaveLength.Name = "labelObservedWaveLength";
            this.labelObservedWaveLength.Size = new System.Drawing.Size(114, 13);
            this.labelObservedWaveLength.TabIndex = 6;
            this.labelObservedWaveLength.Text = "Observed Wavelength";
            // 
            // labelWaveLength
            // 
            this.labelWaveLength.AutoSize = true;
            this.labelWaveLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelWaveLength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelWaveLength.Location = new System.Drawing.Point(142, 26);
            this.labelWaveLength.Name = "labelWaveLength";
            this.labelWaveLength.Size = new System.Drawing.Size(90, 13);
            this.labelWaveLength.TabIndex = 7;
            this.labelWaveLength.Text = "Rest Wavelength";
            // 
            // textBoxObsLength
            // 
            this.textBoxObsLength.BackColor = System.Drawing.Color.White;
            this.textBoxObsLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxObsLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxObsLength.Location = new System.Drawing.Point(6, 42);
            this.textBoxObsLength.Name = "textBoxObsLength";
            this.textBoxObsLength.Size = new System.Drawing.Size(111, 20);
            this.textBoxObsLength.TabIndex = 8;
            this.textBoxObsLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObsLength_KeyPress);
            // 
            // textBoxRestLength
            // 
            this.textBoxRestLength.BackColor = System.Drawing.Color.White;
            this.textBoxRestLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRestLength.Location = new System.Drawing.Point(123, 42);
            this.textBoxRestLength.Name = "textBoxRestLength";
            this.textBoxRestLength.Size = new System.Drawing.Size(111, 20);
            this.textBoxRestLength.TabIndex = 9;
            this.textBoxRestLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRestLength_KeyPress);
            // 
            // buttonStarVelocity
            // 
            this.buttonStarVelocity.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStarVelocity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStarVelocity.ForeColor = System.Drawing.Color.White;
            this.buttonStarVelocity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonStarVelocity.Location = new System.Drawing.Point(124, 68);
            this.buttonStarVelocity.Name = "buttonStarVelocity";
            this.buttonStarVelocity.Size = new System.Drawing.Size(110, 32);
            this.buttonStarVelocity.TabIndex = 10;
            this.buttonStarVelocity.Text = "Star Velocity";
            this.buttonStarVelocity.UseVisualStyleBackColor = false;
            this.buttonStarVelocity.Click += new System.EventHandler(this.buttonStarVelocity_Click);
            // 
            // labelArcsecondAngle
            // 
            this.labelArcsecondAngle.AutoSize = true;
            this.labelArcsecondAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelArcsecondAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelArcsecondAngle.Location = new System.Drawing.Point(6, 19);
            this.labelArcsecondAngle.Name = "labelArcsecondAngle";
            this.labelArcsecondAngle.Size = new System.Drawing.Size(93, 13);
            this.labelArcsecondAngle.TabIndex = 12;
            this.labelArcsecondAngle.Text = "Arcseconds Angle";
            // 
            // textBoxArcsecondAngle
            // 
            this.textBoxArcsecondAngle.Location = new System.Drawing.Point(9, 35);
            this.textBoxArcsecondAngle.Name = "textBoxArcsecondAngle";
            this.textBoxArcsecondAngle.Size = new System.Drawing.Size(141, 20);
            this.textBoxArcsecondAngle.TabIndex = 13;
            this.textBoxArcsecondAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxArcsecondAngle_KeyPress);
            // 
            // buttonStarDistance
            // 
            this.buttonStarDistance.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonStarDistance.ForeColor = System.Drawing.Color.White;
            this.buttonStarDistance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonStarDistance.Location = new System.Drawing.Point(40, 61);
            this.buttonStarDistance.Name = "buttonStarDistance";
            this.buttonStarDistance.Size = new System.Drawing.Size(110, 32);
            this.buttonStarDistance.TabIndex = 14;
            this.buttonStarDistance.Text = "Star Distance";
            this.buttonStarDistance.UseVisualStyleBackColor = false;
            this.buttonStarDistance.Click += new System.EventHandler(this.buttonStarDistance_Click);
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCelsius.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCelsius.Location = new System.Drawing.Point(6, 16);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(103, 13);
            this.labelCelsius.TabIndex = 16;
            this.labelCelsius.Text = "Celsius Temperature";
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Location = new System.Drawing.Point(9, 32);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(141, 20);
            this.textBoxCelsius.TabIndex = 17;
            this.textBoxCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelsius_KeyPress);
            // 
            // buttonKelvinTemp
            // 
            this.buttonKelvinTemp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonKelvinTemp.ForeColor = System.Drawing.Color.White;
            this.buttonKelvinTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKelvinTemp.Location = new System.Drawing.Point(20, 58);
            this.buttonKelvinTemp.Name = "buttonKelvinTemp";
            this.buttonKelvinTemp.Size = new System.Drawing.Size(130, 32);
            this.buttonKelvinTemp.TabIndex = 18;
            this.buttonKelvinTemp.Text = "Kelvin Temperature";
            this.buttonKelvinTemp.UseVisualStyleBackColor = false;
            this.buttonKelvinTemp.Click += new System.EventHandler(this.buttonKelvinTemp_Click);
            // 
            // labelBlackholeMass
            // 
            this.labelBlackholeMass.AutoSize = true;
            this.labelBlackholeMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelBlackholeMass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBlackholeMass.Location = new System.Drawing.Point(6, 16);
            this.labelBlackholeMass.Name = "labelBlackholeMass";
            this.labelBlackholeMass.Size = new System.Drawing.Size(82, 13);
            this.labelBlackholeMass.TabIndex = 20;
            this.labelBlackholeMass.Text = "Blackhole Mass";
            // 
            // textBoxBlackholeMass
            // 
            this.textBoxBlackholeMass.Location = new System.Drawing.Point(9, 32);
            this.textBoxBlackholeMass.Name = "textBoxBlackholeMass";
            this.textBoxBlackholeMass.Size = new System.Drawing.Size(50, 20);
            this.textBoxBlackholeMass.TabIndex = 21;
            this.textBoxBlackholeMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBlackholeMass_KeyPress);
            // 
            // buttonEventHorizon
            // 
            this.buttonEventHorizon.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEventHorizon.ForeColor = System.Drawing.Color.White;
            this.buttonEventHorizon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEventHorizon.Location = new System.Drawing.Point(40, 58);
            this.buttonEventHorizon.Name = "buttonEventHorizon";
            this.buttonEventHorizon.Size = new System.Drawing.Size(110, 32);
            this.buttonEventHorizon.TabIndex = 22;
            this.buttonEventHorizon.Text = "Event Horizon";
            this.buttonEventHorizon.UseVisualStyleBackColor = false;
            this.buttonEventHorizon.Click += new System.EventHandler(this.buttonEventHorizon_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(56, 17);
            this.StatusBar.Text = "Message:";
            // 
            // groupBoxStarVelocity
            // 
            this.groupBoxStarVelocity.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObsLength);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRestLength);
            this.groupBoxStarVelocity.Controls.Add(this.labelObservedWaveLength);
            this.groupBoxStarVelocity.Controls.Add(this.labelWaveLength);
            this.groupBoxStarVelocity.Controls.Add(this.buttonStarVelocity);
            this.groupBoxStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxStarVelocity.ForeColor = System.Drawing.Color.Black;
            this.groupBoxStarVelocity.Location = new System.Drawing.Point(12, 27);
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.Size = new System.Drawing.Size(238, 106);
            this.groupBoxStarVelocity.TabIndex = 24;
            this.groupBoxStarVelocity.TabStop = false;
            this.groupBoxStarVelocity.Text = "Star Velocity";
            // 
            // buttonFrench
            // 
            this.buttonFrench.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.france;
            this.buttonFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonFrench.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFrench.Location = new System.Drawing.Point(440, 35);
            this.buttonFrench.Name = "buttonFrench";
            this.buttonFrench.Size = new System.Drawing.Size(171, 85);
            this.buttonFrench.TabIndex = 4;
            this.buttonFrench.Text = "French";
            this.buttonFrench.UseVisualStyleBackColor = true;
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.buttonEnglish.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.Flag_of_the_United_Kingdom_svg;
            this.buttonEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonEnglish.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEnglish.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEnglish.Location = new System.Drawing.Point(263, 35);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(171, 85);
            this.buttonEnglish.TabIndex = 3;
            this.buttonEnglish.Text = "English (UK)";
            this.buttonEnglish.UseVisualStyleBackColor = false;
            // 
            // buttonGerman
            // 
            this.buttonGerman.BackColor = System.Drawing.Color.Silver;
            this.buttonGerman.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.Flag_of_Germany_svg;
            this.buttonGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonGerman.ForeColor = System.Drawing.Color.White;
            this.buttonGerman.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGerman.Location = new System.Drawing.Point(617, 35);
            this.buttonGerman.Name = "buttonGerman";
            this.buttonGerman.Size = new System.Drawing.Size(171, 85);
            this.buttonGerman.TabIndex = 2;
            this.buttonGerman.Text = "German";
            this.buttonGerman.UseVisualStyleBackColor = false;
            // 
            // groupBoxStarDistance
            // 
            this.groupBoxStarDistance.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStarDistance.Controls.Add(this.labelArcsecondAngle);
            this.groupBoxStarDistance.Controls.Add(this.textBoxArcsecondAngle);
            this.groupBoxStarDistance.Controls.Add(this.buttonStarDistance);
            this.groupBoxStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxStarDistance.Location = new System.Drawing.Point(12, 139);
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.Size = new System.Drawing.Size(161, 100);
            this.groupBoxStarDistance.TabIndex = 25;
            this.groupBoxStarDistance.TabStop = false;
            this.groupBoxStarDistance.Text = "Star Distance";
            // 
            // groupBoxKelvin
            // 
            this.groupBoxKelvin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxKelvin.Controls.Add(this.labelCelsius);
            this.groupBoxKelvin.Controls.Add(this.textBoxCelsius);
            this.groupBoxKelvin.Controls.Add(this.buttonKelvinTemp);
            this.groupBoxKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxKelvin.Location = new System.Drawing.Point(12, 245);
            this.groupBoxKelvin.Name = "groupBoxKelvin";
            this.groupBoxKelvin.Size = new System.Drawing.Size(161, 100);
            this.groupBoxKelvin.TabIndex = 26;
            this.groupBoxKelvin.TabStop = false;
            this.groupBoxKelvin.Text = "Kelvin Calculator";
            // 
            // groupBoxEventHorizon
            // 
            this.groupBoxEventHorizon.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEventHorizon.Controls.Add(this.textBoxUnits);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxPower);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxExpo);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxMultiply);
            this.groupBoxEventHorizon.Controls.Add(this.labelBlackholeMass);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxBlackholeMass);
            this.groupBoxEventHorizon.Controls.Add(this.buttonEventHorizon);
            this.groupBoxEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxEventHorizon.Location = new System.Drawing.Point(12, 359);
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.Size = new System.Drawing.Size(161, 100);
            this.groupBoxEventHorizon.TabIndex = 27;
            this.groupBoxEventHorizon.TabStop = false;
            this.groupBoxEventHorizon.Text = "Event Horizon";
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Enabled = false;
            this.textBoxUnits.Location = new System.Drawing.Point(123, 32);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.ReadOnly = true;
            this.textBoxUnits.Size = new System.Drawing.Size(27, 20);
            this.textBoxUnits.TabIndex = 32;
            this.textBoxUnits.Text = "KG";
            this.textBoxUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(86, 32);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(37, 20);
            this.textBoxPower.TabIndex = 31;
            this.textBoxPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExpo
            // 
            this.textBoxExpo.Location = new System.Drawing.Point(76, 32);
            this.textBoxExpo.Name = "textBoxExpo";
            this.textBoxExpo.ReadOnly = true;
            this.textBoxExpo.Size = new System.Drawing.Size(12, 20);
            this.textBoxExpo.TabIndex = 30;
            this.textBoxExpo.Text = "E";
            this.textBoxExpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMultiply
            // 
            this.textBoxMultiply.Location = new System.Drawing.Point(57, 32);
            this.textBoxMultiply.Name = "textBoxMultiply";
            this.textBoxMultiply.ReadOnly = true;
            this.textBoxMultiply.Size = new System.Drawing.Size(23, 20);
            this.textBoxMultiply.TabIndex = 29;
            this.textBoxMultiply.Text = "x";
            this.textBoxMultiply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxMode
            // 
            this.checkBoxMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMode.AutoSize = true;
            this.checkBoxMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkBoxMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxMode.Location = new System.Drawing.Point(685, 129);
            this.checkBoxMode.Name = "checkBoxMode";
            this.checkBoxMode.Size = new System.Drawing.Size(103, 23);
            this.checkBoxMode.TabIndex = 28;
            this.checkBoxMode.Text = "Night Mode Off";
            this.checkBoxMode.UseVisualStyleBackColor = false;
            this.checkBoxMode.CheckedChanged += new System.EventHandler(this.checkBoxMode_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // AstroMathApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.happy_face;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.checkBoxMode);
            this.Controls.Add(this.groupBoxEventHorizon);
            this.Controls.Add(this.groupBoxKelvin);
            this.Controls.Add(this.groupBoxStarDistance);
            this.Controls.Add(this.groupBoxStarVelocity);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonFrench);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.buttonGerman);
            this.Controls.Add(this.dataViewCalculations);
            this.Controls.Add(this.menuStripMalin);
            this.MainMenuStrip = this.menuStripMalin;
            this.Name = "AstroMathApp";
            this.Text = "Malin\'s Astro Math App";
            this.Load += new System.EventHandler(this.AstroMathApp_Load);
            this.menuStripMalin.ResumeLayout(false);
            this.menuStripMalin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCalculations)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxStarVelocity.ResumeLayout(false);
            this.groupBoxStarVelocity.PerformLayout();
            this.groupBoxStarDistance.ResumeLayout(false);
            this.groupBoxStarDistance.PerformLayout();
            this.groupBoxKelvin.ResumeLayout(false);
            this.groupBoxKelvin.PerformLayout();
            this.groupBoxEventHorizon.ResumeLayout(false);
            this.groupBoxEventHorizon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMalin;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataViewCalculations;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarVelocityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarDistanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperatureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventHorizonColumn;
        private System.Windows.Forms.Button buttonGerman;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Button buttonFrench;
        private System.Windows.Forms.Label labelObservedWaveLength;
        private System.Windows.Forms.Label labelWaveLength;
        private System.Windows.Forms.TextBox textBoxObsLength;
        private System.Windows.Forms.TextBox textBoxRestLength;
        private System.Windows.Forms.Button buttonStarVelocity;
        private System.Windows.Forms.Label labelArcsecondAngle;
        private System.Windows.Forms.TextBox textBoxArcsecondAngle;
        private System.Windows.Forms.Button buttonStarDistance;
        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.Button buttonKelvinTemp;
        private System.Windows.Forms.Label labelBlackholeMass;
        private System.Windows.Forms.TextBox textBoxBlackholeMass;
        private System.Windows.Forms.Button buttonEventHorizon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.GroupBox groupBoxStarVelocity;
        private System.Windows.Forms.GroupBox groupBoxStarDistance;
        private System.Windows.Forms.GroupBox groupBoxKelvin;
        private System.Windows.Forms.GroupBox groupBoxEventHorizon;
        private System.Windows.Forms.CheckBox checkBoxMode;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxMultiply;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.TextBox textBoxExpo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBoxUnits;
    }
}

