import gnu.io.CommPortIdentifier;
import gnu.io.SerialPort;
import gnu.io.SerialPortEvent;
import gnu.io.SerialPortEventListener;
import java.io.InputStream;
import java.io.OutputStream;
import java.util.Enumeration;
import java.util.HashMap;

/*
Duy Anh Nguyen
May 1, 2020
UMSATS Avionics Tools
Class use RXTXcomm.jar library to establish 
serial communication.
*/

public class SerialCommunication
        implements SerialPortEventListener
{
    // Public member
    public AvionicsTools mainTools = null;
    
    // Private member
    private Enumeration allPorts = null; // Ports found when search
    private final HashMap allPorts_map;  // Map the ports' name to CommPortIdentifiers
    
    private CommPortIdentifier selectedPortIdentifier = null; // Selected Port
    private SerialPort selected_serialPort = null; // Serial Port to communicate
    
    // Sending and receiving data of serial
    private final InputStream serial_in = null;
    private final OutputStream serial_out = null;
    
    private boolean serialConnect = false; // Flag track if connected to a Serial Port or not to allow the option to send and receive data
    
    final static int TIMEOUT = 3000; // Connect to Serial Port timeout
  
    String logText = ""; // Output of text-interface of Serial Communication
    
    
    public SerialCommunication(final AvionicsTools AVIONICS_GUI)
    {
        this.mainTools = AVIONICS_GUI;
        
        // Initialize fields/members
        this.allPorts_map = new HashMap();
    }
    
    
    
    public void searchPorts()
    {
        // Search and get all ports
        this.allPorts = CommPortIdentifier.getPortIdentifiers();
        
        // Run through all ports, select the ports that are serial and send to GUI menu to display for selection
        while (this.allPorts.hasMoreElements())
        {
            // Get the port to process
            CommPortIdentifier processPort = (CommPortIdentifier)this.allPorts.nextElement();
            
            // Only send the serial ports to Avionics Tools GUI for selection
            if (processPort.getPortType() == CommPortIdentifier.PORT_SERIAL)
            {
                // Add found serial COM Port for selection
                this.mainTools.add_COM_to_Select(processPort.getName());
                
                // Track COM Port name with COM Port identifier
                this.allPorts_map.put(processPort.getName(), processPort);
            }
        }
    }

    
    /*
    Process receive data.
    */
    @Override
    public void serialEvent(SerialPortEvent spe) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    
    
    
    
}
