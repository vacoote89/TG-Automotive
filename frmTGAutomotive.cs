using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TG_Automotive
{
    public partial class frmTGAutomative : Form
    {
        public frmTGAutomative()
        {
            InitializeComponent();
        }

        /**
         * Verify that the two input valuesa re valid number and neither is less that zero
         */ 
        private bool validateInputs()
        {
            return true;
        }

        /**
         * Calculate all oil and lubrication charges
         */ 
        private decimal calcFlushCharges()
        {
            return 0.0m;
        }

        /**
         * Calculate inspection, muffler, and tire rotation charges
         */ 
        private decimal calcMiscCharges()
        {
            return 0.0m;
        }

        /**
         * Calculate and display the total of all charges, including labor, parts, and services
         */ 
        private void calculateTotalCharges()
        {

        }

        /**
         * Reset the oil change and lube job check boxes
         */ 
        private void clearOilLube()
        {

        }
        /**
         * Clear the radiator and transmission flush check boxes
         */ 
        private void clearFlushes()
        {

        }

        /**
         * Clear the inspection, muffler replacement, and tire rotation check boxes
         */ 
        private void clearMisc()
        {

        }

        /**
         * Clear the parts and labor check boxes
         */ 
        private void clearOther()
        {

        }

    }
}
