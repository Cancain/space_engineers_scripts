IMyPistonBase piston1;
IMyPistonBase piston2;
IMyPistonBase piston3;
IMyPistonBase piston4;
IMyPistonBase piston5;

void Main(string arg){
    if(piston1 == null){
        piston1 = GridTerminalSystem.GetBlockWithName("PDown1") as IMyPistonBase;
    }
    if(piston2 == null){
        piston2 = GridTerminalSystem.GetBlockWithName("PDown2") as IMyPistonBase;
    }
    if(piston3 == null){
        piston3 = GridTerminalSystem.GetBlockWithName("PDown3") as IMyPistonBase;
    }
    if(piston4 == null){
        piston4 = GridTerminalSystem.GetBlockWithName("PDown4") as IMyPistonBase;
    }
    if(piston5 == null){
        piston5 = GridTerminalSystem.GetBlockWithName("up") as IMyPistonBase;
    }

    piston1.ApplyAction("Reverse");
    piston2.ApplyAction("Reverse");
    piston3.ApplyAction("Reverse");
    piston4.ApplyAction("Reverse");
    piston5.ApplyAction("Reverse");
}