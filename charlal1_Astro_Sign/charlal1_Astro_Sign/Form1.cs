using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace charlal1_Astro_Sign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string ZodiacSign(DateTime date, out string element)
        {
            switch (date.Month)
            {
                case 1: if (date.Day <= 20)
                    { element = "Earth"; return "Capricorn"; }
                    else
                    { element = "Air"; return "Aquarius"; }
                case 2: if (date.Day <= 19)
                    { element = "Air"; return "Aquarius"; }
                    else
                    { element = "Water"; return "Pisces"; }
                case 3: if (date.Day <= 20)
                    { element = "Water"; return "Pisces"; }
                    else
                    { element = "Fire"; return "Aries"; }
                case 4: if (date.Day <= 20)
                    { element = "Fire"; return "Aries"; }
                    else
                    { element = "Earth"; return "Taurus"; }
                case 5: if (date.Day <= 21)
                    { element = "Earth"; return "Taurus"; }
                    else
                    { element = "Air"; return "Gemini"; }
                case 6: if (date.Day <= 22)
                    { element = "Air"; return "Gemini"; }
                    else
                    { element = "Water"; return "Cancer"; }
                case 7: if (date.Day <= 22)
                    { element = "Water"; return "Cancer"; }
                    else
                    { element = "Fire"; return "Leo"; }
                case 8: if (date.Day <= 23)
                    { element = "Fire"; return "Leo"; }
                    else
                    { element = "Earth"; return "Virgo"; }
                case 9: if (date.Day <= 23)
                    { element = "Earth"; return "Virgo"; }
                    else
                    { element = "Air"; return "Libra"; }
                case 10: if (date.Day <= 23)
                    { element = "Air"; return "Libra"; }
                    else
                    { element = "Water"; return "Scorpio"; }
                case 11: if (date.Day <= 22)
                    { element = "Water"; return "Scorpio"; }
                    else
                    { element = "Fire"; return "Sagittarius"; }
                case 12: if (date.Day <= 21)
                    { element = "Fire"; return "Sagittarius"; }
                    else
                    { element = "Earth"; return "Capricorn"; }
                default:
                    element = ""; return "";
            }
        }

        public string ChineseSign(DateTime date) 
        {            
            switch ((date.Year - 4) % 12)
            {
                case  0: return "Rat";
                case  1: return "Ox";
                case  2: return "Tiger";
                case  3: return "Rabbit";
                case  4: return "Dragon";
                case  5: return "Snake";
                case  6: return "Horse";
                case  7: return "Goat";
                case  8: return "Monkey";
                case  9: return "Rooster";
                case 10: return "Dog";
                case 11: return "Pig";
                default: return "";
            }
        }

        private void bGetSign_Click(object sender, EventArgs e)
        {
            string sign = "";
            string element = "";

            if (rbWestern.Checked)
            {
                sign = ZodiacSign(dtpBirthDate.Value, out element);
            }
            else 
            {
                sign = ChineseSign(dtpBirthDate.Value);
            }

            lResult.Text = sign;
        }
    }

    
}
