!!! look inside lib_install of AvionicsTools
There are Windows 32 bits and 64 bits.
Linux 32/64 bits.
Install accordingly to your computer or it will not run.




import gnu.io.*; // Need to install this library
    RXTXcomm.jar handle the serial communication. It contains gnu.io.*
    rxtxserial.dll binary code for RXTXcomm.jar to run.




!!! How to install the required libarary
1) In IDE, need to access Build Path -> Library. (Something simmilar)
    Right click on main/root project folder -> Properties -> Java Build Path -> Libraries
2) Unzipped the right library according to your computer and add the external JARs.
    From previous step (1), navigate to the folder just unzipped and select "RXTXcomm.jar" to add the external library.
    !!!!!Put it under "Class Path"



C:\Users\Duy Anh\AppData\Local\Programs\AdoptOpenJDK\bin, C:\WINDOWS\Sun\Java\bin


win32com.dll - jre/bin
comm.jar - jre/lib/ext