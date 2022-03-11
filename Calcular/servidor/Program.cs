using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importamos las librerias
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using ClsCalcular;

namespace servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ClsCalcular.Calculadora),"Calculadora",WellKnownObjectMode.SingleCall);

            TcpChannel chnl = new TcpChannel(1235);
            Console.WriteLine("Servidor remoto activado");
            Console.ReadKey();
        }
    }
}
