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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroMathApp));
            this.menuStripMalin = new System.Windows.Forms.MenuStrip();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.checkBoxMode = new System.Windows.Forms.CheckBox();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // textBoxRestLength
            // 
            this.textBoxRestLength.BackColor = System.Drawing.Color.White;
            this.textBoxRestLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxRestLength, "textBoxRestLength");
            this.textBoxRestLength.Name = "textBoxRestLength";
            // 
            // buttonStarVelocity
            // 
            this.buttonStarVelocity.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStarVelocity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStarVelocity.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonStarVelocity, "buttonStarVelocity");
            this.buttonStarVelocity.Name = "buttonStarVelocity";
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
            // 
            // buttonStarDistance
            // 
            this.buttonStarDistance.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.buttonStarDistance, "buttonStarDistance");
            this.buttonStarDistance.ForeColor = System.Drawing.Color.White;
            this.buttonStarDistance.Name = "buttonStarDistance";
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
            // 
            // buttonKelvinTemp
            // 
            this.buttonKelvinTemp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonKelvinTemp.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonKelvinTemp, "buttonKelvinTemp");
            this.buttonKelvinTemp.Name = "buttonKelvinTemp";
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
            // 
            // buttonEventHorizon
            // 
            this.buttonEventHorizon.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEventHorizon.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonEventHorizon, "buttonEventHorizon");
            this.buttonEventHorizon.Name = "buttonEventHorizon";
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
            this.buttonFrench.UseVisualStyleBackColor = true;
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.buttonEnglish.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.Flag_of_the_United_Kingdom_svg;
            resources.ApplyResources(this.buttonEnglish, "buttonEnglish");
            this.buttonEnglish.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.UseVisualStyleBackColor = false;
            // 
            // buttonGerman
            // 
            this.buttonGerman.BackColor = System.Drawing.Color.Silver;
            this.buttonGerman.BackgroundImage = global::Malin_s_AstroMath_App.Properties.Resources.Flag_of_Germany_svg;
            resources.ApplyResources(this.buttonGerman, "buttonGerman");
            this.buttonGerman.ForeColor = System.Drawing.Color.White;
            this.buttonGerman.Name = "buttonGerman";
            this.buttonGerman.UseVisualStyleBackColor = false;
            // 
            // groupBoxStarDistance
            // 
            this.groupBoxStarDistance.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStarDistance.Controls.Add(this.labelArcsecondAngle);
            this.groupBoxStarDistance.Controls.Add(this.textBoxArcsecondAngle);
            this.groupBoxStarDistance.Controls.Add(this.buttonStarDistance);
            resources.ApplyResources(this.groupBoxStarDistance, "groupBoxStarDistance");
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.TabStop = false;
            // 
            // groupBoxKelvin
            // 
            this.groupBoxKelvin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxKelvin.Controls.Add(this.labelCelsius);
            this.groupBoxKelvin.Controls.Add(this.textBoxCelsius);
            this.groupBoxKelvin.Controls.Add(this.buttonKelvinTemp);
            resources.ApplyResources(this.groupBoxKelvin, "groupBoxKelvin");
            this.groupBoxKelvin.Name = "groupBoxKelvin";
            this.groupBoxKelvin.TabStop = false;
            // 
            // groupBoxEventHorizon
            // 
            this.groupBoxEventHorizon.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEventHorizon.Controls.Add(this.labelBlackholeMass);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxBlackholeMass);
            this.groupBoxEventHorizon.Controls.Add(this.buttonEventHorizon);
            resources.ApplyResources(this.groupBoxEventHorizon, "groupBoxEventHorizon");
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.TabStop = false;
            // 
            // checkBoxMode
            // 
            resources.ApplyResources(this.checkBoxMode, "checkBoxMode");
            this.checkBoxMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxMode.Name = "checkBoxMode";
            this.checkBoxMode.UseVisualStyleBackColor = false;
            this.checkBoxMode.CheckedChanged += new System.EventHandler(this.checkBoxMode_CheckedChanged);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
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
    }
}

