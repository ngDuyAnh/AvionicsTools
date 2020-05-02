import javax.swing.ImageIcon;

/*
Duy Anh Nguyen
May 1, 2020
UMSATS Avionics Tools
Main.java
The starting-point to run Avionics Tools application.
*/
//Toolkit.getDafaultToolkit().getImage(getClass().getResource("./icon/UMSATS_Rocket_Icon.png"))
public class Main
{
    
    public static void main(String[] args)
    {
       AvionicsTools tools = new AvionicsTools();
       
       // Setup Avionics Tools
       tools.setIconImage((new ImageIcon("icon/UMSATS_Rocket_Icon.png")).getImage());
       tools.setVisible(true);
    }
    
}
