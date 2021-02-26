IMyTerminalBlock lcd;
IMyMotorStator rotor;
IMyPistonBase piston1;
IMyPistonBase piston2;
IMyPistonBase piston3;
IMyPistonBase piston4;
IMyPistonBase piston5;
IMyPistonBase pistonHoriz1;
IMyPistonBase pistonHoriz2;

Screen screen; 

void Main(string argument) {  
	if(rotor == null)
		rotor = GridTerminalSystem.GetBlockWithName("DrillRotor") as IMyMotorStator;

	if(lcd == null) 
		lcd = GridTerminalSystem.GetBlockWithName("DrillLcd");

	if(piston1 == null)
		piston1 = GridTerminalSystem.GetBlockWithName("PDown1") as IMyPistonBase;
	if(piston2 == null)
		piston2 = GridTerminalSystem.GetBlockWithName("PDown2") as IMyPistonBase;
	if(piston3 == null)
		piston3 = GridTerminalSystem.GetBlockWithName("PDown3") as IMyPistonBase;
	if(piston4 == null)
		piston4 = GridTerminalSystem.GetBlockWithName("PDown4") as IMyPistonBase;
	if(piston5 == null)
		piston5 = GridTerminalSystem.GetBlockWithName("up") as IMyPistonBase;
		
    if(pistonHoriz1 == null)
		pistonHoriz1 = GridTerminalSystem.GetBlockWithName("horiz") as IMyPistonBase;
    if(pistonHoriz2 == null)
		pistonHoriz2 = GridTerminalSystem.GetBlockWithName("horiz2") as IMyPistonBase;

	if(screen == null) 
		screen = new Screen(lcd);

	screen.clear(); 
    screen.println("Rotor : " + rotor.DetailedInfo);
    screen.println("Piston Down 1: " + IsMax(piston1.DetailedInfo.Split(' ','\n')[3]));
	screen.println("Piston Down 2: " + IsMax(piston2.DetailedInfo.Split(' ','\n')[3]));
	screen.println("Piston Down 3: " + IsMax(piston3.DetailedInfo.Split(' ','\n')[3]));
	screen.println("Piston Down 4: " + IsMax(piston4.DetailedInfo.Split(' ','\n')[3]));
	screen.println("Piston up: " + piston5.DetailedInfo.Split(' ','\n')[3]);
    screen.println("Horizontal piston1: " + IsMax(pistonHoriz1.DetailedInfo.Split(' ','\n')[3]));
    screen.println("Horizontal piston2: " + IsMax(pistonHoriz2.DetailedInfo.Split(' ','\n')[3]));

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