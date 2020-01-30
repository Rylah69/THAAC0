namespace THAACO
{
    partial class Attacker
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
            this.levelLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.strTextBox = new System.Windows.Forms.TextBox();
            this.dexTextBox = new System.Windows.Forms.TextBox();
            this.classGroupBox = new System.Windows.Forms.GroupBox();
            this.wizard_radioButton = new System.Windows.Forms.RadioButton();
            this.elf_radioButton = new System.Windows.Forms.RadioButton();
            this.royal_radioButton = new System.Windows.Forms.RadioButton();
            this.k_de_dk_radioButton = new System.Windows.Forms.RadioButton();
            this.hard_code_stats_groupBox = new System.Windows.Forms.GroupBox();
            this.advanced_stats_checkBox = new System.Windows.Forms.CheckBox();
            this.advanced_description_label = new System.Windows.Forms.Label();
            this.hard_code_dmg_textBox = new System.Windows.Forms.TextBox();
            this.hard_code_hit_textBox = new System.Windows.Forms.TextBox();
            this.hard_code_dmg_label = new System.Windows.Forms.Label();
            this.hard_code_hit_label = new System.Windows.Forms.Label();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.startHitBonus_textBox = new System.Windows.Forms.TextBox();
            this.startDmgBonus_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearStats_button = new System.Windows.Forms.Button();
            this.compileStats_button = new System.Windows.Forms.Button();
            this.statSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.HitfDEXSummaryLabel = new System.Windows.Forms.Label();
            this.HitfLVLSummaryLabel = new System.Windows.Forms.Label();
            this.HitfSTRSummaryLabel = new System.Windows.Forms.Label();
            this.HitDiceSummaryLabel = new System.Windows.Forms.Label();
            this.LvDamSummaryLabel = new System.Windows.Forms.Label();
            this.StrDamSummaryLabel = new System.Windows.Forms.Label();
            this.DamSummaryLabel = new System.Windows.Forms.Label();
            this.DSummaryLabel = new System.Windows.Forms.Label();
            this.SSummaryLabel = new System.Windows.Forms.Label();
            this.LSummaryLabel = new System.Windows.Forms.Label();
            this.classGroupBox.SuspendLayout();
            this.hard_code_stats_groupBox.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.statSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(26, 39);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(46, 17);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "Level:";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(25, 65);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(66, 17);
            this.strengthLabel.TabIndex = 1;
            this.strengthLabel.Text = "Strength:";
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Location = new System.Drawing.Point(26, 93);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(67, 17);
            this.dexLabel.TabIndex = 2;
            this.dexLabel.Text = "Dexterity:";
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(120, 34);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(100, 22);
            this.levelTextBox.TabIndex = 4;
            // 
            // strTextBox
            // 
            this.strTextBox.Location = new System.Drawing.Point(120, 62);
            this.strTextBox.Name = "strTextBox";
            this.strTextBox.Size = new System.Drawing.Size(100, 22);
            this.strTextBox.TabIndex = 5;
            // 
            // dexTextBox
            // 
            this.dexTextBox.Location = new System.Drawing.Point(121, 90);
            this.dexTextBox.Name = "dexTextBox";
            this.dexTextBox.Size = new System.Drawing.Size(100, 22);
            this.dexTextBox.TabIndex = 6;
            // 
            // classGroupBox
            // 
            this.classGroupBox.Controls.Add(this.wizard_radioButton);
            this.classGroupBox.Controls.Add(this.elf_radioButton);
            this.classGroupBox.Controls.Add(this.royal_radioButton);
            this.classGroupBox.Controls.Add(this.k_de_dk_radioButton);
            this.classGroupBox.Location = new System.Drawing.Point(310, 19);
            this.classGroupBox.Name = "classGroupBox";
            this.classGroupBox.Size = new System.Drawing.Size(263, 231);
            this.classGroupBox.TabIndex = 7;
            this.classGroupBox.TabStop = false;
            this.classGroupBox.Text = "Class Bonus";
            // 
            // wizard_radioButton
            // 
            this.wizard_radioButton.AutoSize = true;
            this.wizard_radioButton.Location = new System.Drawing.Point(11, 177);
            this.wizard_radioButton.Name = "wizard_radioButton";
            this.wizard_radioButton.Size = new System.Drawing.Size(142, 21);
            this.wizard_radioButton.TabIndex = 3;
            this.wizard_radioButton.TabStop = true;
            this.wizard_radioButton.Text = "Wizard / Illusionist";
            this.wizard_radioButton.UseVisualStyleBackColor = true;
            // 
            // elf_radioButton
            // 
            this.elf_radioButton.AutoSize = true;
            this.elf_radioButton.Location = new System.Drawing.Point(11, 128);
            this.elf_radioButton.Name = "elf_radioButton";
            this.elf_radioButton.Size = new System.Drawing.Size(45, 21);
            this.elf_radioButton.TabIndex = 2;
            this.elf_radioButton.TabStop = true;
            this.elf_radioButton.Text = "Elf";
            this.elf_radioButton.UseVisualStyleBackColor = true;
            // 
            // royal_radioButton
            // 
            this.royal_radioButton.AutoSize = true;
            this.royal_radioButton.Location = new System.Drawing.Point(11, 79);
            this.royal_radioButton.Name = "royal_radioButton";
            this.royal_radioButton.Size = new System.Drawing.Size(65, 21);
            this.royal_radioButton.TabIndex = 1;
            this.royal_radioButton.TabStop = true;
            this.royal_radioButton.Text = "Royal";
            this.royal_radioButton.UseVisualStyleBackColor = true;
            // 
            // k_de_dk_radioButton
            // 
            this.k_de_dk_radioButton.AutoSize = true;
            this.k_de_dk_radioButton.Location = new System.Drawing.Point(11, 32);
            this.k_de_dk_radioButton.Name = "k_de_dk_radioButton";
            this.k_de_dk_radioButton.Size = new System.Drawing.Size(236, 21);
            this.k_de_dk_radioButton.TabIndex = 0;
            this.k_de_dk_radioButton.TabStop = true;
            this.k_de_dk_radioButton.Text = "Knight / Dark-Elf / Dragon-Knight";
            this.k_de_dk_radioButton.UseVisualStyleBackColor = true;
            this.k_de_dk_radioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // hard_code_stats_groupBox
            // 
            this.hard_code_stats_groupBox.Controls.Add(this.advanced_stats_checkBox);
            this.hard_code_stats_groupBox.Controls.Add(this.advanced_description_label);
            this.hard_code_stats_groupBox.Controls.Add(this.hard_code_dmg_textBox);
            this.hard_code_stats_groupBox.Controls.Add(this.hard_code_hit_textBox);
            this.hard_code_stats_groupBox.Controls.Add(this.hard_code_dmg_label);
            this.hard_code_stats_groupBox.Controls.Add(this.hard_code_hit_label);
            this.hard_code_stats_groupBox.Location = new System.Drawing.Point(591, 19);
            this.hard_code_stats_groupBox.Name = "hard_code_stats_groupBox";
            this.hard_code_stats_groupBox.Size = new System.Drawing.Size(278, 231);
            this.hard_code_stats_groupBox.TabIndex = 8;
            this.hard_code_stats_groupBox.TabStop = false;
            this.hard_code_stats_groupBox.Text = "Advanced";
            // 
            // advanced_stats_checkBox
            // 
            this.advanced_stats_checkBox.AutoSize = true;
            this.advanced_stats_checkBox.Location = new System.Drawing.Point(38, 165);
            this.advanced_stats_checkBox.Name = "advanced_stats_checkBox";
            this.advanced_stats_checkBox.Size = new System.Drawing.Size(182, 21);
            this.advanced_stats_checkBox.TabIndex = 5;
            this.advanced_stats_checkBox.Text = "Use these stats instead.";
            this.advanced_stats_checkBox.UseVisualStyleBackColor = true;
            // 
            // advanced_description_label
            // 
            this.advanced_description_label.Location = new System.Drawing.Point(3, 18);
            this.advanced_description_label.Name = "advanced_description_label";
            this.advanced_description_label.Size = new System.Drawing.Size(233, 64);
            this.advanced_description_label.TabIndex = 4;
            this.advanced_description_label.Text = "These fields override the stats entered. Leave blank";
            this.advanced_description_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hard_code_dmg_textBox
            // 
            this.hard_code_dmg_textBox.Location = new System.Drawing.Point(136, 118);
            this.hard_code_dmg_textBox.Name = "hard_code_dmg_textBox";
            this.hard_code_dmg_textBox.Size = new System.Drawing.Size(100, 22);
            this.hard_code_dmg_textBox.TabIndex = 3;
            // 
            // hard_code_hit_textBox
            // 
            this.hard_code_hit_textBox.Location = new System.Drawing.Point(136, 90);
            this.hard_code_hit_textBox.Name = "hard_code_hit_textBox";
            this.hard_code_hit_textBox.Size = new System.Drawing.Size(100, 22);
            this.hard_code_hit_textBox.TabIndex = 2;
            // 
            // hard_code_dmg_label
            // 
            this.hard_code_dmg_label.AutoSize = true;
            this.hard_code_dmg_label.Location = new System.Drawing.Point(7, 118);
            this.hard_code_dmg_label.Name = "hard_code_dmg_label";
            this.hard_code_dmg_label.Size = new System.Drawing.Size(65, 17);
            this.hard_code_dmg_label.TabIndex = 1;
            this.hard_code_dmg_label.Text = "Damage:";
            // 
            // hard_code_hit_label
            // 
            this.hard_code_hit_label.AutoSize = true;
            this.hard_code_hit_label.Location = new System.Drawing.Point(6, 93);
            this.hard_code_hit_label.Name = "hard_code_hit_label";
            this.hard_code_hit_label.Size = new System.Drawing.Size(29, 17);
            this.hard_code_hit_label.TabIndex = 0;
            this.hard_code_hit_label.Text = "Hit:";
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.startHitBonus_textBox);
            this.statsGroupBox.Controls.Add(this.startDmgBonus_textBox);
            this.statsGroupBox.Controls.Add(this.label3);
            this.statsGroupBox.Controls.Add(this.label2);
            this.statsGroupBox.Controls.Add(this.label1);
            this.statsGroupBox.Controls.Add(this.levelLabel);
            this.statsGroupBox.Controls.Add(this.strengthLabel);
            this.statsGroupBox.Controls.Add(this.dexLabel);
            this.statsGroupBox.Controls.Add(this.dexTextBox);
            this.statsGroupBox.Controls.Add(this.levelTextBox);
            this.statsGroupBox.Controls.Add(this.strTextBox);
            this.statsGroupBox.Location = new System.Drawing.Point(29, 19);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(263, 231);
            this.statsGroupBox.TabIndex = 9;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Enter your stats";
            // 
            // startHitBonus_textBox
            // 
            this.startHitBonus_textBox.Location = new System.Drawing.Point(120, 192);
            this.startHitBonus_textBox.Name = "startHitBonus_textBox";
            this.startHitBonus_textBox.Size = new System.Drawing.Size(100, 22);
            this.startHitBonus_textBox.TabIndex = 11;
            // 
            // startDmgBonus_textBox
            // 
            this.startDmgBonus_textBox.Location = new System.Drawing.Point(121, 162);
            this.startDmgBonus_textBox.Name = "startDmgBonus_textBox";
            this.startDmgBonus_textBox.Size = new System.Drawing.Size(100, 22);
            this.startDmgBonus_textBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Damage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Starting stat bonus:";
            // 
            // clearStats_button
            // 
            this.clearStats_button.Location = new System.Drawing.Point(908, 157);
            this.clearStats_button.Name = "clearStats_button";
            this.clearStats_button.Size = new System.Drawing.Size(115, 48);
            this.clearStats_button.TabIndex = 10;
            this.clearStats_button.Text = "Clear Stats";
            this.clearStats_button.UseVisualStyleBackColor = true;
            this.clearStats_button.Click += new System.EventHandler(this.clearStats_button_Click);
            // 
            // compileStats_button
            // 
            this.compileStats_button.Location = new System.Drawing.Point(908, 81);
            this.compileStats_button.Name = "compileStats_button";
            this.compileStats_button.Size = new System.Drawing.Size(115, 48);
            this.compileStats_button.TabIndex = 11;
            this.compileStats_button.Text = "Compile Stats";
            this.compileStats_button.UseVisualStyleBackColor = true;
            this.compileStats_button.Click += new System.EventHandler(this.compileStats_button_Click);
            // 
            // statSummaryGroupBox
            // 
            this.statSummaryGroupBox.Controls.Add(this.HitfDEXSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.HitfLVLSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.HitfSTRSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.HitDiceSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.LvDamSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.StrDamSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.DamSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.DSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.SSummaryLabel);
            this.statSummaryGroupBox.Controls.Add(this.LSummaryLabel);
            this.statSummaryGroupBox.Location = new System.Drawing.Point(29, 271);
            this.statSummaryGroupBox.Name = "statSummaryGroupBox";
            this.statSummaryGroupBox.Size = new System.Drawing.Size(840, 225);
            this.statSummaryGroupBox.TabIndex = 12;
            this.statSummaryGroupBox.TabStop = false;
            this.statSummaryGroupBox.Text = "Summary";
            // 
            // HitfDEXSummaryLabel
            // 
            this.HitfDEXSummaryLabel.AutoSize = true;
            this.HitfDEXSummaryLabel.Location = new System.Drawing.Point(482, 188);
            this.HitfDEXSummaryLabel.Name = "HitfDEXSummaryLabel";
            this.HitfDEXSummaryLabel.Size = new System.Drawing.Size(99, 17);
            this.HitfDEXSummaryLabel.TabIndex = 9;
            this.HitfDEXSummaryLabel.Text = "from Dexterity:";
            // 
            // HitfLVLSummaryLabel
            // 
            this.HitfLVLSummaryLabel.AutoSize = true;
            this.HitfLVLSummaryLabel.Location = new System.Drawing.Point(482, 88);
            this.HitfLVLSummaryLabel.Name = "HitfLVLSummaryLabel";
            this.HitfLVLSummaryLabel.Size = new System.Drawing.Size(78, 17);
            this.HitfLVLSummaryLabel.TabIndex = 8;
            this.HitfLVLSummaryLabel.Text = "from Level:";
            // 
            // HitfSTRSummaryLabel
            // 
            this.HitfSTRSummaryLabel.AutoSize = true;
            this.HitfSTRSummaryLabel.Location = new System.Drawing.Point(482, 137);
            this.HitfSTRSummaryLabel.Name = "HitfSTRSummaryLabel";
            this.HitfSTRSummaryLabel.Size = new System.Drawing.Size(98, 17);
            this.HitfSTRSummaryLabel.TabIndex = 7;
            this.HitfSTRSummaryLabel.Text = "from Strength:";
            // 
            // HitDiceSummaryLabel
            // 
            this.HitDiceSummaryLabel.AutoSize = true;
            this.HitDiceSummaryLabel.Location = new System.Drawing.Point(482, 35);
            this.HitDiceSummaryLabel.Name = "HitDiceSummaryLabel";
            this.HitDiceSummaryLabel.Size = new System.Drawing.Size(61, 17);
            this.HitDiceSummaryLabel.TabIndex = 6;
            this.HitDiceSummaryLabel.Text = "Hit Dice:";
            // 
            // LvDamSummaryLabel
            // 
            this.LvDamSummaryLabel.AutoSize = true;
            this.LvDamSummaryLabel.Location = new System.Drawing.Point(259, 88);
            this.LvDamSummaryLabel.Name = "LvDamSummaryLabel";
            this.LvDamSummaryLabel.Size = new System.Drawing.Size(78, 17);
            this.LvDamSummaryLabel.TabIndex = 5;
            this.LvDamSummaryLabel.Text = "from Level:";
            // 
            // StrDamSummaryLabel
            // 
            this.StrDamSummaryLabel.AutoSize = true;
            this.StrDamSummaryLabel.Location = new System.Drawing.Point(260, 137);
            this.StrDamSummaryLabel.Name = "StrDamSummaryLabel";
            this.StrDamSummaryLabel.Size = new System.Drawing.Size(98, 17);
            this.StrDamSummaryLabel.TabIndex = 4;
            this.StrDamSummaryLabel.Text = "from Strength:";
            // 
            // DamSummaryLabel
            // 
            this.DamSummaryLabel.AutoSize = true;
            this.DamSummaryLabel.Location = new System.Drawing.Point(260, 35);
            this.DamSummaryLabel.Name = "DamSummaryLabel";
            this.DamSummaryLabel.Size = new System.Drawing.Size(101, 17);
            this.DamSummaryLabel.TabIndex = 3;
            this.DamSummaryLabel.Text = "Damage Total:";
            // 
            // DSummaryLabel
            // 
            this.DSummaryLabel.AutoSize = true;
            this.DSummaryLabel.Location = new System.Drawing.Point(45, 137);
            this.DSummaryLabel.Name = "DSummaryLabel";
            this.DSummaryLabel.Size = new System.Drawing.Size(67, 17);
            this.DSummaryLabel.TabIndex = 2;
            this.DSummaryLabel.Text = "Dexterity:";
            // 
            // SSummaryLabel
            // 
            this.SSummaryLabel.AutoSize = true;
            this.SSummaryLabel.Location = new System.Drawing.Point(46, 88);
            this.SSummaryLabel.Name = "SSummaryLabel";
            this.SSummaryLabel.Size = new System.Drawing.Size(66, 17);
            this.SSummaryLabel.TabIndex = 1;
            this.SSummaryLabel.Text = "Strength:";
            // 
            // LSummaryLabel
            // 
            this.LSummaryLabel.AutoSize = true;
            this.LSummaryLabel.Location = new System.Drawing.Point(66, 35);
            this.LSummaryLabel.Name = "LSummaryLabel";
            this.LSummaryLabel.Size = new System.Drawing.Size(46, 17);
            this.LSummaryLabel.TabIndex = 0;
            this.LSummaryLabel.Text = "Level:";
            // 
            // Attacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 603);
            this.Controls.Add(this.statSummaryGroupBox);
            this.Controls.Add(this.compileStats_button);
            this.Controls.Add(this.clearStats_button);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.hard_code_stats_groupBox);
            this.Controls.Add(this.classGroupBox);
            this.Name = "Attacker";
            this.Text = "Attacker";
            this.Load += new System.EventHandler(this.THAAC0_Load);
            this.classGroupBox.ResumeLayout(false);
            this.classGroupBox.PerformLayout();
            this.hard_code_stats_groupBox.ResumeLayout(false);
            this.hard_code_stats_groupBox.PerformLayout();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.statSummaryGroupBox.ResumeLayout(false);
            this.statSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox strTextBox;
        private System.Windows.Forms.TextBox dexTextBox;
        private System.Windows.Forms.GroupBox classGroupBox;
        private System.Windows.Forms.RadioButton wizard_radioButton;
        private System.Windows.Forms.RadioButton elf_radioButton;
        private System.Windows.Forms.RadioButton royal_radioButton;
        private System.Windows.Forms.RadioButton k_de_dk_radioButton;
        private System.Windows.Forms.GroupBox hard_code_stats_groupBox;
        private System.Windows.Forms.TextBox hard_code_dmg_textBox;
        private System.Windows.Forms.TextBox hard_code_hit_textBox;
        private System.Windows.Forms.Label hard_code_dmg_label;
        private System.Windows.Forms.Label hard_code_hit_label;
        private System.Windows.Forms.Label advanced_description_label;
        private System.Windows.Forms.CheckBox advanced_stats_checkBox;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.Button clearStats_button;
        private System.Windows.Forms.Button compileStats_button;
        private System.Windows.Forms.GroupBox statSummaryGroupBox;
        private System.Windows.Forms.TextBox startHitBonus_textBox;
        private System.Windows.Forms.TextBox startDmgBonus_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DSummaryLabel;
        private System.Windows.Forms.Label SSummaryLabel;
        private System.Windows.Forms.Label LSummaryLabel;
        private System.Windows.Forms.Label LvDamSummaryLabel;
        private System.Windows.Forms.Label StrDamSummaryLabel;
        private System.Windows.Forms.Label DamSummaryLabel;
        private System.Windows.Forms.Label HitfDEXSummaryLabel;
        private System.Windows.Forms.Label HitfLVLSummaryLabel;
        private System.Windows.Forms.Label HitfSTRSummaryLabel;
        private System.Windows.Forms.Label HitDiceSummaryLabel;
    }
}

