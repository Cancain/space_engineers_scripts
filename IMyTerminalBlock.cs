IMyTerminalBlock lcd;
IMyMotorStator rotor;
IMyPistonBase piston1;
IMyPistonBase pistonHoriz;
Screen screen; 

void Main(string argument) {  
	if(rotor == null)
		rotor = GridTerminalSystem.GetBlockWithName("DrillRotor") as IMyMotorStator;
	if(lcd == null) 
		lcd = GridTerminalSystem.GetBlockWithName("DrillLcd");
	if(piston1 == null)
		piston1 = GridTerminalSystem.GetBlockWithName("Down") as IMyPistonBase;
    if(pistonHoriz == null)
		pistonHoriz = GridTerminalSystem.GetBlockWithName("horiz") as IMyPistonBase;
	if(screen == null) 
		screen = new Screen(lcd);
	screen.clear(); 
    screen.println("Rotor : " + rotor.DetailedInfo);
    screen.println("Piston Down 1: " + IsMax(piston1.DetailedInfo.Split(' ','\n')[3]));
    screen.println("Horizontal piston: " + IsMax(pistonHoriz.DetailedInfo.Split(' ','\n')[3]));
} 
  
public class Screen {  
	private IMyTextPanel scr;  
	public Screen() {}  
	public Screen(IMyTerminalBlock block) {  
		scr=(IMyTextPanel) block;  
	}  
	public void print(string str) {  
		scr.WriteText(str,true);   
	}  
	public void println(string str) {  
		scr.WriteText(str+"\n",true);  
	}  
	public void clear() {  
		scr.WriteText("",false);  
	}  
}

string IsMax(string length) {
    if(length == "10.0m"){
        return "Max";
    } else return length;
}