using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMSATS_Tool
{
    public partial class AvionicsTools : Form
    {
        public AvionicsTools()
        {
            InitializeComponent();

            // Tab buttons, using Panel Panel_TabButton
            this.tabButtons = new LinkedList<Button>();
            foreach (Control control in Panel_TabButton.Controls)
            {
                // Add to tabButtons when found button in tab panel
                if (control.GetType() == typeof(Button))
                    this.tabButtons.AddLast(control as Button);
            }

            // Setup serial communication line
            this.serialComm = new SerialCommunication(this);

            // Default open configuration tab at start
            ConfigurationTab_Click(null, null);

            
            
        }

       

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerialTab_Click(object sender, EventArgs e)
        {
            // Visual focus on the button
            this.focus_tabButton(SerialTab_Button);

            // Make the right panel visible and other tab invisible
            SerialPanel.Visible = true;
            ConfigPanel.Visible = false;
            DataPanel.Visible = false;
        }

        private void ConfigurationTab_Click(object sender, EventArgs e)
        {
            // Visual focus on the button
            this.focus_tabButton(ConfigurationTab_Button);

            // Bring the panel to the front
            SerialPanel.Visible = false;
            ConfigPanel.Visible = true;
            DataPanel.Visible = false;

            // If not connected, show the option. Else, connected then nothing to change.
            if (!this.serialComm.connected())
            {
                // Deselect port
                this.PortSelect_comboBox.SelectedItem = null;

                // Get the ports to connect
                this.PortSelect_comboBox.Items.Clear();
                this.serialComm.searchForPorts();

                // Set default first port
                this.PortSelect_comboBox.SelectedIndex = this.PortSelect_comboBox.Items.Count - 1; // Select the first index

                // Set default baud rate
                this.BaudRate_TextBox.Text = "9800";

                // Set connect and disconnect buttons
                this.SerialConnect_Button.Enabled = true;
                this.SerialDisconnect_Button.Enabled = false;
            }
            
        }

        private void DataTab_Button_Click(object sender, EventArgs e)
        {
            // Visual focus on the button
            this.focus_tabButton(DataTab_Button);

            // Bring the panel to the front
            SerialPanel.Visible = false;
            ConfigPanel.Visible = false;
            DataPanel.Visible = true;
        }

        private void SerialConnect_Button_Click(object sender, EventArgs e)
        {
            bool connected = false;

            // Connect port
            try
            {
                // Get port's information to connect
                string portName = Convert.ToString(this.PortSelect_comboBox.SelectedItem); // Port name to connect to
                int baudRate = Convert.ToInt32(this.BaudRate_TextBox.Text);   // Baud rate

                // Connect serial port
                connected = this.serialComm.serialConnect((string)this.PortSelect_comboBox.SelectedItem, baudRate);
            }
            catch (FormatException)
            {
                // Message box error
                string errorMessage = "Please check the baud rate number format";
                MessageBox.Show(errorMessage, "Error");
            }
            catch (OverflowException)
            {
                // Message box error
                string errorMessage = "Baud rate number is too big for 32bits int";
                MessageBox.Show(errorMessage, "Error");
            }

            // Set connect and disconnect buttons
            if (connected)
            {
                // Only disconnect button can be use
                this.SerialConnect_Button.Enabled = false;
                this.SerialDisconnect_Button.Enabled = true;

                this.PortSelect_comboBox.Enabled = false;
                this.BaudRate_TextBox.Enabled = false;
            }

        }

        private void SerialDisconnect_Button_Click(object sender, EventArgs e)
        {
            // Stop serial communication line
            this.serialComm.serialDisconnect();

            // Enable buttons to connect to a serial line
            this.SerialConnect_Button.Enabled = true;
            this.SerialDisconnect_Button.Enabled = false;

            this.PortSelect_comboBox.Enabled = true;
            this.BaudRate_TextBox.Enabled = true;
        }


        // Private member
        LinkedList<Button> tabButtons = null; // List of buttons to access different tabs
        SerialCommunication serialComm = null;



        /* focus_tabButton()
        Make all tab buttons neutral.
        Not focus or clicked.
        */
        private void focus_tabButton(Button FOCUS)
        {
            // Run through all the buttons, focus on given button and neutral on others
            for (int counter = 0; counter < this.tabButtons.Count(); counter++)
            {
                // Get the button to process
                Button currButton = this.tabButtons.ElementAt(counter);

                // Focus if it is the button need to focus or neutralize. Using "UseVisualStyleBackColor"
                if (currButton.Equals(FOCUS))
                {
                    currButton.UseVisualStyleBackColor = true;
                }
                else
                    currButton.UseVisualStyleBackColor = false;
            }
        }

        public void addPortName(String portName)
        {
            this.PortSelect_comboBox.Items.Add(portName);
        }

        
        
    }
}
