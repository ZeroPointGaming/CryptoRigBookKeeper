using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookKeeping
{
    public partial class Main : Form
    {
        public Dictionary<string, MachineConfig> ConfigList = new Dictionary<string, MachineConfig>();

        public Main()
        {
            InitializeComponent();
        }

        public void ReloadMachienConfigs()
        {
            listBox1.Items.Clear();
            
            foreach (var Block in ConfigList)
            {
                listBox1.Items.Add(Block.Key.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { checkBox1.Checked = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { checkBox2.Checked = false; }
        }

        private void SaveCfgBtn_Click(object sender, EventArgs e)
        {
            ConfigList.Add(NewCFGNameTxtBox.Text, new MachineConfig(NewCFGNameTxtBox.Text, NewGPUModelTxtBox.Text, int.Parse(NewGpuCountTxt.Text), double.Parse(NewGpuValueTxt.Text), NewCpuModelTxt.Text, int.Parse(NewCpuCountTxt.Text), double.Parse(NewCpuValueTxt.Text), NewPSUModelTxt.Text, int.Parse(NewPSUCountTxt.Text), double.Parse(NewPSUValueTxt.Text), NewRamModelTxt.Text, int.Parse(NewRamCountTxt.Text), double.Parse(NewRamValueTxt.Text), NewRiserModelTxt.Text, int.Parse(NewRiserCountTxt.Text), double.Parse(NewRiserValueTxt.Text), NewSSDModelTxt.Text, int.Parse(NewSSDCountTxt.Text), double.Parse(NewSSDValueTxt.Text)));

            ReloadMachienConfigs();
        }
    }

    public class MachineConfig
    {
        string MachineName = "";
        string GPUModel = "";
        int GPUCount = 0;
        double GPUValue = 0;
        string CPUModel = "";
        int CPUCount = 0;
        double CPUValue = 0;
        string PSUModel = "";
        int PSUCount = 0;
        double PSUValue = 0;
        string RAMModel = "";
        int RAMCount = 0;
        double RAMValue = 0;
        string RiserModel = "";
        int RiserCount = 0;
        double RiserValue = 0;
        string SSDModel = "";
        int SSDCount = 0;
        double SSDValue = 0;

        public MachineConfig(string machineName, string gPUModel, int gPUCount, double gPUValue, string cPUModel, int cPUCount, double cPUValue, string pSUModel, int pSUCount, double pSUValue, string rAMModel, int rAMCount, double rAMValue, string riserModel, int riserCount, double riserValue, string sSDModel, int sSDCount, double sSDValue)
        {
            MachineName = machineName;
            GPUModel = gPUModel;
            GPUCount = gPUCount;
            GPUValue = gPUValue;
            CPUModel = cPUModel;
            CPUCount = cPUCount;
            CPUValue = cPUValue;
            PSUModel = pSUModel;
            PSUCount = pSUCount;
            PSUValue = pSUValue;
            RAMModel = rAMModel;
            RAMCount = rAMCount;
            RAMValue = rAMValue;
            RiserModel = riserModel;
            RiserCount = riserCount;
            RiserValue = riserValue;
            SSDModel = sSDModel;
            SSDCount = sSDCount;
            SSDValue = sSDValue;
        }
    }
}
