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
        private StarlightDeviceApi device0105 = new StarlightDeviceApi();
        private StarlightDeviceApi device1266 = new StarlightDeviceApi();
        

        public Form1()
        {
            InitializeComponent();
            StartStarlightDevice();
            // 启动定时器，开始定时更新
            timer1.Enabled = true;
            timer1.Start();
        }

        private void StartStarlightDevice()
        {
            device0105.Connect();
            device1266.Connect();
            if(device0105.SerialNumber == "1266" && device1266.SerialNumber == "0105")
            {
                (device0105, device1266) = (device1266, device0105);
            }
            if(device0105.SerialNumber != "0105" || device1266.SerialNumber != "1266")
            {
                Console.WriteLine("无法连接到星光模拟器！");
                return;
            }

            // 以下代码保持不变，只执行一次
//            device1266.SetLightSourceCurrent(0, 0.1);
            device1266.SetLightSourceCurrent(1, 0.1);
            labelDevice1SerialNumber.Text = device0105.SerialNumber;
            labelDevice2SerialNumber.Text = device1266.SerialNumber;


            var d1Read = device0105.ReadDetectorValue();
            var d2Read = device1266.ReadDetectorValue();
            LabelLight1ReadNumber.Text = "Value: " + d1Read.Value + "Gain: " + d1Read.Gain;
            LabelLight2ReadNumber.Text = "Value: " + d2Read.Value + "Gain: " + d2Read.Gain;
        }

        // 这个方法是自动生成的，你只需在里面添加代码
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 把之前 StartStarlightDevice() 中读取和更新 UI 的代码移到这里
            var d1Read = device0105.ReadDetectorValue();
            var d2Read = device1266.ReadDetectorValue();
            LabelLight1ReadNumber.Text = "Value: " + d1Read.Value + "Gain: " + d1Read.Gain;
            LabelLight2ReadNumber.Text = "Value: " + d2Read.Value + "Gain: " + d2Read.Gain;
        }

    }
}