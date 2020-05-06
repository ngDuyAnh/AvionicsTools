using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace UMSATS_Tool
{
    class SerialCommunication
    {
        // Private member
        private AvionicsTools mainTools = null; // Avionics Tools
        private string[] namePorts = null; // Name of ports
        private SerialPort connect = null; // Serial connect communication




        public SerialCommunication(AvionicsTools MAIN_TOOLS)
        {
            this.mainTools = MAIN_TOOLS; // Avionics Tools GUI Application
        }

        public void searchForPorts()
        {
            // Get all the ports' name
            this.namePorts = SerialPort.GetPortNames();

            // Add ports' name to available list
            for (int counter = 0; counter < this.namePorts.Length; counter++)
            {
                this.mainTools.addPortName(this.namePorts[counter]);
            }
        }

        public bool serialConnect(string portName, int baudRate)
        {
            bool connected = false;

            // Serial connect
            try
            {
                if (portName == null)
                    throw new IOException();

                this.connect = new SerialPort(portName, baudRate);
                connected = true;
            }
            catch (IOException)
            {
                // Message box error
                string errorMessage = "Failed to connect to serial port.\n" +
                        "Maybe refresh serial ports search and try again.";
                MessageBox.Show(errorMessage, "Error");
            }

            return connected;
        }

        public void serialDisconnect()
        {
            this.connect = null; // Stop the communication line
        }

        public bool serialSend()
        {
            return true;
        }




        // Ultility methods

        public bool connected()
        {
            bool connection = false;

            if (this.connect != null)
                connection = true;

            return connection;
        }


    }
}
