using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarlightRotation
{
    public partial class Form1 : Form
    {
        private StarlightDeviceApi device1 = new StarlightDeviceApi("1266");
        private StarlightDeviceApi device2 = new StarlightDeviceApi("0105");

        public Form1()
        {
            InitializeComponent();
            StartStarlightDevice();
            // 启动定时器，开始定时更新
            timer1.Enabled = true;
        }

        private void StartStarlightDevice()
        {
            device1.Connect();
            device2.Connect();

            // 以下代码保持不变，只执行一次
            device1.SetLightSourceCurrent(0, 0.1);
            device2.SetLightSourceCurrent(0, 0.2);
            labelDevice1SerialNumber.Text = device1.SerialNumber;
            labelDevice2SerialNumber.Text = device2.SerialNumber;
        }

        // 这个方法是自动生成的，你只需在里面添加代码
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 把之前 StartStarlightDevice() 中读取和更新 UI 的代码移到这里
            var d1Read = device1.ReadDetectorValue();
            var d2Read = device2.ReadDetectorValue();
            LabelLight1ReadNumber.Text = "Value: " + d1Read.Value + "Gain: " + d1Read.Gain;
            LabelLight2ReadNumber.Text = "Value: " + d2Read.Value + "Gain: " + d2Read.Gain;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 这个方法不需要改动
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}