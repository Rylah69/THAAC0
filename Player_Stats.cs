using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THAACO
{
    public partial class Attacker : Form
    {
        Player player = new Player();
        //Weapon weapon = new Weapon();

        private static int[] strDmg = { -2, -2, -2, -2, -2, -2, -2, -2, -1, -1, 0, 0, 1, 1, 2, 2, 3, 3,
            4, 4, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 9, 9, 10, 11, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14, 14, 14,
            15, 15, 15, 15, 16, 16, 16, 16, 17, 17, 17, 17, 18, 18};

        private static int[] strHit = { -2, -2, -2, -2, -2, -2, -2, -2, -1, -1, 0, 0, 1, 1, 2, 2, 3, 3,
            4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10, 11, 11, 11, 12, 12, 12, 13, 13,
            13, 14, 14, 14, 15, 15, 15, 16, 16, 16, 17, 17, 17 , 17};

        private static int[] dexHit = { -2, -2, -2, -2, -2, -2, -1, -1, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 6,
            7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 19, 19, 20, 20, 20, 21, 21, 21, 22, 22, 22, 23, 23,
            23, 24, 24, 24, 25, 25, 25, 26, 26, 26, 27, 27, 27, 28 };

        public Attacker()
        {
            InitializeComponent();
            //TODO
        }

        private void THAAC0_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void compileStats_button_Click(object sender, EventArgs e)
        {
            //Input Level with input validation
            if (int.Parse(levelTextBox.Text) > 0 && int.Parse(levelTextBox.Text) < 100)
            {
                player.Level = int.Parse(levelTextBox.Text);
                player.Damage = (player.Level / 10);
                player.Hit_Dice = player.Level;
            }
            else
            {
                MessageBox.Show("Player Level must be between 1 and 99.");
            }
            //Input STR with input validation
            if (int.Parse(strTextBox.Text) > 0 && int.Parse(strTextBox.Text) < 51)
            {
                player.STR = int.Parse(strTextBox.Text);
            }
            else
            {
                MessageBox.Show("Strength attribute must be between 1 and 50.");
            }
            //Input DEX with input validation
            if (int.Parse(dexTextBox.Text) > 0 && int.Parse(dexTextBox.Text) < 51)
            {
                player.DEX = int.Parse(dexTextBox.Text);
            }
            else
            {
                MessageBox.Show("Dexterity attribute must be between 1 and 50.");
            }

            //Hit bonus by class using radio button in hitclass group box
            if (k_de_dk_radioButton.Checked)
            {
                player.Level_bonus = player.Level / 3;
            }
            else if (royal_radioButton.Checked)
            {
                player.Level_bonus = player.Level / 4;
            }
            else if (elf_radioButton.Checked)
            {
                player.Level_bonus = player.Level / 5;
            }
            else if (wizard_radioButton.Checked)
            {
                player.Level_bonus = player.Level / 8;
            }
            else
            {
                MessageBox.Show("Please select a hit class.");
            }

            player.Hit_Dice += player.Level_bonus;

            //Starting stat bonus with input validation
            if (int.TryParse(startDmgBonus_textBox.Text, out int x))
            {
                player.Damage += x;
            }
            else
            {
                MessageBox.Show("Enter a whole number for Starting Stat Bonuses.");
            }
            if (int.TryParse(startHitBonus_textBox.Text, out int y))
            {
                player.Hit_Dice += y;
            }
            else
            {
                MessageBox.Show("Enter a whole number for Starting Stat Bonuses.");
            }


            //Begin compiling stats. STR
            if (int.Parse(strTextBox.Text) > 0 && int.Parse(strTextBox.Text) < 51)
            {
                player.Damage += strDmg[player.STR - 1];
                player.Hit_Dice += strHit[player.STR - 1];
            }
            else
            {
                MessageBox.Show("Strength attribute must be between 1 and 50");
            }
            //Begin compiling stats. DEX
            if (int.Parse(dexTextBox.Text) > 0 && int.Parse(dexTextBox.Text) < 51)
            {
                player.Hit_Dice += dexHit[player.DEX - 1];
            }
            else
            {
                MessageBox.Show("Dexterity attribute must be between 1 and 50");
            }

            //Stats using Harcode Checkbox
            if (advanced_stats_checkBox.Checked && int.TryParse(hard_code_dmg_textBox.Text, out int z)
                && int.TryParse(hard_code_hit_textBox.Text, out int v))
            {
                player.Damage = z;
                player.Hit_Dice = v;

                //clear other text fields for clarity
                levelTextBox.Text = "0";
                strTextBox.Text = "0";
                dexTextBox.Text = "0";
                startDmgBonus_textBox.Text = "0";
                startHitBonus_textBox.Text = "0";
            }

            LSummaryLabel.Text = "Level: " + player.Level.ToString();
            SSummaryLabel.Text = "Strength: " + player.STR.ToString();
            DSummaryLabel.Text = "Dexterity: " + player.DEX.ToString();

            DamSummaryLabel.Text = "Damage Total: " + player.Damage.ToString();
            StrDamSummaryLabel.Text = "from Strength: " + strDmg[player.STR - 1].ToString();
            LvDamSummaryLabel.Text = "from Level: " + (player.Level / 10).ToString();

            HitDiceSummaryLabel.Text = "Hit Dice: " + player.Hit_Dice.ToString();
            HitfLVLSummaryLabel.Text = "from Level: " + player.Level_bonus.ToString();
            HitfSTRSummaryLabel.Text = "from Strength: " + strHit[player.STR - 1].ToString();
            HitfDEXSummaryLabel.Text = "from Dexterity: " + dexHit[player.DEX - 1].ToString() ;
        }

        private void clearStats_button_Click(object sender, EventArgs e)
        {
            LSummaryLabel.Text = "Level: ";
            SSummaryLabel.Text = "Strength: ";
            DSummaryLabel.Text = "Dexterity: ";

            player.Level = 0;
            player.STR = 0;
            player.DEX = 0;
            player.Level_bonus = 0;
            player.Hit_Dice = 0;
            player.Damage = 0;

            levelTextBox.Text = "0";
            strTextBox.Text = "0";
            dexTextBox.Text = "0";
            startDmgBonus_textBox.Text = "0";
            startHitBonus_textBox.Text = "0";

            hard_code_dmg_textBox.Text = "";
            hard_code_hit_textBox.Text = "";
            advanced_stats_checkBox.Checked = false;

            DamSummaryLabel.Text = "Damage Total: ";
            StrDamSummaryLabel.Text = "from Strength: ";
            LvDamSummaryLabel.Text = "from Level: ";

            HitDiceSummaryLabel.Text = "Hit Dice: ";
            HitfLVLSummaryLabel.Text = "from Level: ";
            HitfSTRSummaryLabel.Text = "from Strength: ";
            HitfDEXSummaryLabel.Text = "from Dexterity: ";
        }
    }
}
