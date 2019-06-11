using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06上位机编程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
        /// <summary>
        /// 串口初始化函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openSerial_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)    //如果串口是关
            {
                //设置串口的初始属性

                //设置端口号
                serialPort1.PortName = portName.SelectedText.ToString().Trim();
                //设置波特率
                serialPort1.BaudRate = Convert.ToInt32(baudRate.SelectedText.ToString());
                //设置数据位
                serialPort1.DataBits = Convert.ToInt32(dataBits.SelectedText.ToString());
                //设置停止位
                float f = Convert.ToSingle(stopBits.SelectedText.ToString());
                if (f == 0)
                {
                    serialPort1.StopBits = StopBits.None;
                }
                else if (f == 1)
                {
                    serialPort1.StopBits = StopBits.One;
                }
                else if (f == 1.5)
                {
                    serialPort1.StopBits = StopBits.OnePointFive;
                }
                else if (f == 2)
                {
                    serialPort1.StopBits = StopBits.Two;
                }
                //设置奇偶校验




            }
        }
    }
}
