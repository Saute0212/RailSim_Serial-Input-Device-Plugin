﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialDevicePlugin
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            ReadingComPorts();
        }

        //接続されているCOMポートの読み込み
        public void ReadingComPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ComPorts.Items.Add(port);
            }
        }

        //"更新"が押された際にCOMポートを再度読み込み
        private void Reloading_Click(object sender, EventArgs e)
        {
            ReadingComPorts();
        }
    }
}
