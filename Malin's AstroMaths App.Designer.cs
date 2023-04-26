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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroMathApp));
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            resources.ApplyResources(this.menuStripMalin, "menuStripMalin");
            this.menuStripMalin.Name = "menuStripMalin";
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            resources.ApplyResources(this.selectColorToolStripMenuItem, "selectColorToolStripMenuItem");
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.selectColorToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
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
            resources.ApplyResources(this.dataViewCalculations, "dataViewCalculations");
            this.dataViewCalculations.Name = "dataViewCalculations";
            this.dataViewCalculations.RowHeadersVisible = false;
            // 
            // StarVelocityColumn
            // 
            resources.ApplyResources(this.StarVelocityColumn, "StarVelocityColumn");
            this.StarVelocityColumn.Name = "StarVelocityColumn";
            // 
            // StarDistanceColumn
            // 
            resources.ApplyResources(this.StarDistanceColumn, "StarDistanceColumn");
            this.StarDistanceColumn.Name = "StarDistanceColumn";
            // 
            // TemperatureColumn
            // 
            resources.ApplyResources(this.TemperatureColumn, "TemperatureColumn");
            this.TemperatureColumn.Name = "TemperatureColumn";
            // 
            // EventHorizonColumn
            // 
            resources.ApplyResources(this.EventHorizonColumn, "EventHorizonColumn");
            this.EventHorizonColumn.Name = "EventHorizonColumn";
            // 
            // labelObservedWaveLength
            // 
            resources.ApplyResources(this.labelObservedWaveLength, "labelObservedWaveLength");
            this.labelObservedWaveLength.Name = "labelObservedWaveLength";
            // 
            // labelWaveLength
            // 
            resources.ApplyResources(this.labelWaveLength, "labelWaveLength");
            this.labelWaveLength.Name = "labelWaveLength";
            // 
            // textBoxObsLength
            // 
            this.textBoxObsLength.BackColor = System.Drawing.Color.White;
            this.textBoxObsLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxObsLength.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxObsLength, "textBoxObsLength");
            this.textBoxObsLength.Name = "textBoxObsLength";
            this.toolTip1.SetToolTip(this.textBoxObsLength, resources.GetString("textBoxObsLength.ToolTip"));
            this.textBoxObsLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObsLength_KeyPress);
            // 
            // textBoxRestLength
            // 
            this.textBoxRestLength.BackColor = System.Drawing.Color.White;
            this.textBoxRestLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxRestLength, "textBoxRestLength");
            this.textBoxRestLength.Name = "textBoxRestLength";
            this.toolTip1.SetToolTip(this.textBoxRestLength, resources.GetString("textBoxRestLength.ToolTip"));
            this.textBoxRestLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRestLength_KeyPress);
            // 
            // buttonStarVelocity
            // 
            this.buttonStarVelocity.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStarVelocity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStarVelocity.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonStarVelocity, "buttonStarVelocity");
            this.buttonStarVelocity.Name = "buttonStarVelocity";
            this.toolTip1.SetToolTip(this.buttonStarVelocity, resources.GetString("buttonStarVelocity.ToolTip"));
            this.buttonStarVelocity.UseVisualStyleBackColor = false;
            this.buttonStarVelocity.Click += new System.EventHandler(this.buttonStarVelocity_Click);
            // 
            // labelArcsecondAngle
            // 
            resources.ApplyResources(this.labelArcsecondAngle, "labelArcsecondAngle");
            this.labelArcsecondAngle.Name = "labelArcsecondAngle";
            // 
            // textBoxArcsecondAngle
            // 
            resources.ApplyResources(this.textBoxArcsecondAngle, "textBoxArcsecondAngle");
            this.textBoxArcsecondAngle.Name = "textBoxArcsecondAngle";
            this.toolTip1.SetToolTip(this.textBoxArcsecondAngle, resources.GetString("textBoxArcsecondAngle.ToolTip"));
            this.textBoxArcsecondAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxArcsecondAngle_KeyPress);
            // 
            // buttonStarDistance
            // 
            this.buttonStarDistance.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.buttonStarDistance, "buttonStarDistance");
            this.buttonStarDistance.ForeColor = System.Drawing.Color.White;
            this.buttonStarDistance.Name = "buttonStarDistance";
            this.toolTip1.SetToolTip(this.buttonStarDistance, resources.GetString("buttonStarDistance.ToolTip"));
            this.buttonStarDistance.UseVisualStyleBackColor = false;
            this.buttonStarDistance.Click += new System.EventHandler(this.buttonStarDistance_Click);
            // 
            // labelCelsius
            // 
            resources.ApplyResources(this.labelCelsius, "labelCelsius");
            this.labelCelsius.Name = "labelCelsius";
            // 
            // textBoxCelsius
            // 
            resources.ApplyResources(this.textBoxCelsius, "textBoxCelsius");
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.toolTip1.SetToolTip(this.textBoxCelsius, resources.GetString("textBoxCelsius.ToolTip"));
            this.textBoxCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelsius_KeyPress);
            // 
            // buttonKelvinTemp
            // 
            this.buttonKelvinTemp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonKelvinTemp.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonKelvinTemp, "buttonKelvinTemp");
            this.buttonKelvinTemp.Name = "buttonKelvinTemp";
            this.toolTip1.SetToolTip(this.buttonKelvinTemp, resources.GetString("buttonKelvinTemp.ToolTip"));
            this.buttonKelvinTemp.UseVisualStyleBackColor = false;
            this.buttonKelvinTemp.Click += new System.EventHandler(this.buttonKelvinTemp_Click);
            // 
            // labelBlackholeMass
            // 
            resources.ApplyResources(this.labelBlackholeMass, "labelBlackholeMass");
            this.labelBlackholeMass.Name = "labelBlackholeMass";
            // 
            // textBoxBlackholeMass
            // 
            resources.ApplyResources(this.textBoxBlackholeMass, "textBoxBlackholeMass");
            this.textBoxBlackholeMass.Name = "textBoxBlackholeMass";
            this.toolTip1.SetToolTip(this.textBoxBlackholeMass, resources.GetString("textBoxBlackholeMass.ToolTip"));
            this.textBoxBlackholeMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBlackholeMass_KeyPress);
            // 
            // buttonEventHorizon
            // 
            this.buttonEventHorizon.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEventHorizon.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonEventHorizon, "buttonEventHorizon");
            this.buttonEventHorizon.Name = "buttonEventHorizon";
            this.toolTip1.SetToolTip(this.buttonEventHorizon, resources.GetString("buttonEventHorizon.ToolTip"));
            this.buttonEventHorizon.UseVisualStyleBackColor = false;
            this.buttonEventHorizon.Click += new System.EventHandler(this.buttonEventHorizon_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            resources.ApplyResources(this.StatusBar, "StatusBar");
            // 
            // groupBoxStarVelocity
            // 
            this.groupBoxStarVelocity.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObsLength);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRestLength);
            this.groupBoxStarVelocity.Controls.Add(this.labelObservedWaveLength);
            this.groupBoxStarVelocity.Controls.Add(this.labelWaveLength);
            this.groupBoxStarVelocity.Controls.Add(this.buttonStarVelocity);
            resources.ApplyResources(this.groupBoxStarVelocity, "groupBoxStarVelocity");
            this.groupBoxStarVelocity.ForeColor = System.Drawing.Color.Black;
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.TabStop = false;
            // 
            // buttonFrench
            // 
            this.buttonFrench.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.france;
            resources.ApplyResources(this.buttonFrench, "buttonFrench");
            this.buttonFrench.Name = "buttonFrench";
            this.toolTip1.SetToolTip(this.buttonFrench, resources.GetString("buttonFrench.ToolTip"));
            this.buttonFrench.UseVisualStyleBackColor = true;
            this.buttonFrench.Click += new System.EventHandler(this.buttonFrench_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.buttonEnglish.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.Flag_of_the_United_Kingdom_svg;
            resources.ApplyResources(this.buttonEnglish, "buttonEnglish");
            this.buttonEnglish.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEnglish.Name = "buttonEnglish";
            this.toolTip1.SetToolTip(this.buttonEnglish, resources.GetString("buttonEnglish.ToolTip"));
            this.buttonEnglish.UseVisualStyleBackColor = false;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // buttonGerman
            // 
            this.buttonGerman.BackColor = System.Drawing.Color.Silver;
            this.buttonGerman.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.Flag_of_Germany_svg;
            resources.ApplyResources(this.buttonGerman, "buttonGerman");
            this.buttonGerman.ForeColor = System.Drawing.Color.White;
            this.buttonGerman.Name = "buttonGerman";
            this.toolTip1.SetToolTip(this.buttonGerman, resources.GetString("buttonGerman.ToolTip"));
            this.buttonGerman.UseVisualStyleBackColor = false;
            this.buttonGerman.Click += new System.EventHandler(this.buttonGerman_Click);
            // 
            // groupBoxStarDistance
            // 
            resources.ApplyResources(this.groupBoxStarDistance, "groupBoxStarDistance");
            this.groupBoxStarDistance.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStarDistance.Controls.Add(this.labelArcsecondAngle);
            this.groupBoxStarDistance.Controls.Add(this.textBoxArcsecondAngle);
            this.groupBoxStarDistance.Controls.Add(this.buttonStarDistance);
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.TabStop = false;
            // 
            // groupBoxKelvin
            // 
            resources.ApplyResources(this.groupBoxKelvin, "groupBoxKelvin");
            this.groupBoxKelvin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxKelvin.Controls.Add(this.labelCelsius);
            this.groupBoxKelvin.Controls.Add(this.textBoxCelsius);
            this.groupBoxKelvin.Controls.Add(this.buttonKelvinTemp);
            this.groupBoxKelvin.Name = "groupBoxKelvin";
            this.groupBoxKelvin.TabStop = false;
            // 
            // groupBoxEventHorizon
            // 
            resources.ApplyResources(this.groupBoxEventHorizon, "groupBoxEventHorizon");
            this.groupBoxEventHorizon.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEventHorizon.Controls.Add(this.textBoxUnits);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxPower);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxExpo);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxMultiply);
            this.groupBoxEventHorizon.Controls.Add(this.labelBlackholeMass);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxBlackholeMass);
            this.groupBoxEventHorizon.Controls.Add(this.buttonEventHorizon);
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.TabStop = false;
            // 
            // textBoxUnits
            // 
            resources.ApplyResources(this.textBoxUnits, "textBoxUnits");
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.ReadOnly = true;
            // 
            // textBoxPower
            // 
            resources.ApplyResources(this.textBoxPower, "textBoxPower");
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPower_KeyPress);
            // 
            // textBoxExpo
            // 
            resources.ApplyResources(this.textBoxExpo, "textBoxExpo");
            this.textBoxExpo.Name = "textBoxExpo";
            this.textBoxExpo.ReadOnly = true;
            // 
            // textBoxMultiply
            // 
            resources.ApplyResources(this.textBoxMultiply, "textBoxMultiply");
            this.textBoxMultiply.Name = "textBoxMultiply";
            this.textBoxMultiply.ReadOnly = true;
            // 
            // checkBoxMode
            // 
            resources.ApplyResources(this.checkBoxMode, "checkBoxMode");
            this.checkBoxMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxMode.Name = "checkBoxMode";
            this.toolTip1.SetToolTip(this.checkBoxMode, resources.GetString("checkBoxMode.ToolTip"));
            this.checkBoxMode.UseVisualStyleBackColor = false;
            this.checkBoxMode.CheckedChanged += new System.EventHandler(this.checkBoxMode_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // AstroMathApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.happy_face;
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
            this.Load += new System.EventHandler(this.AstroMathApp_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AstroMathApp_MouseMove);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn StarVelocityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarDistanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperatureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventHorizonColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

