using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RomanNumberParser;


namespace RomanNumberParser
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            string RomanNumer = txtRoman.Text;
            int calcResult = -1;
            NumberParser parser = new NumberParser();

            calcResult = parser.parseRomanNumer(RomanNumer);

            if (calcResult > 0)
            {
                txtResult.Text = calcResult.ToString();
            }
            else
            {
                txtResult.Text = "Invalid Number";
            }
        }
    }
}