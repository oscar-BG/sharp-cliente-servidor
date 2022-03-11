using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClsCalcular;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TcpChannel chanel = new TcpChannel();
            ChannelServices.RegisterChannel(chanel, false);

            RemotingConfiguration.RegisterWellKnownClientType(typeof(Calculadora), "tcp://localhost:1235/Calculadora");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculadora Opera = new Calculadora();
            int n1, n2;
            n1 = Int16.Parse(this.textnum1.Text);
            n2 = Int16.Parse(this.textnum2.Text);
            this.textcalcular.Text = Opera.suma(n1, n2).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Calculadora OperaR = new Calculadora();
            int n1, n2;
            n1 = Int16.Parse(this.textnum1.Text);
            n2 = Int16.Parse(this.textnum2.Text);
            this.textcalcular.Text = OperaR.resta(n1, n2).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Calculadora OperaR = new Calculadora();
            int n1, n2;
            n1 = Int16.Parse(this.textnum1.Text);
            n2 = Int16.Parse(this.textnum2.Text);
            this.textcalcular.Text = OperaR.multiplicacion(n1, n2).ToString();
        }
    }
}
