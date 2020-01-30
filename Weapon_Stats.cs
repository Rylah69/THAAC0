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
    public partial class Weapon_Stats : Form
    {
        Weapon weapon = new Weapon();
        string message = "Please use a whole number.";

        public Weapon_Stats()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WType_Normal_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (WType_Normal_rb.Checked)
            {
                WType_CritP_tb.Text = "0";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Weapon Dice
            if (int.TryParse(WDice_TextBox.Text, out int x))
            {
                weapon.Dice = x;
            }
            else
            {
                MessageBox.Show("Weapon Dice: " + message);
            }
            //Weapon Damage
            if (int.TryParse(WDamage_TextBox.Text, out x))
            {
                weapon.Damage_Bonus = x;
            }
            else
            {
                MessageBox.Show("Weapon Damage: " + message);
            }
            //Weapon Hit
            if (int.TryParse(WHit_TextBox.Text, out x))
            {
                weapon.Hit_Bonus = x;
            }
            else
            {
                MessageBox.Show("Weapon Hit: " + message);
            }
            //Weapon Enchant
            if (int.TryParse(WEnchant_TextBox.Text, out x))
            {
                weapon.Enchant = x;
                weapon.Damage_Bonus += x;
                weapon.Hit_Bonus += (x / 2);
            }
            else
            {
                MessageBox.Show("Weapon Enchant: " + message);
            }


        }
    }
}
