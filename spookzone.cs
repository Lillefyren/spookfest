using system.collections;
using Unity;
using system.generic;

public class spookzone : Monobehaviour{

public int spooks;

void Start(){
  InvokeRepeatable(1, 1, "GetSpooks()")
}

void GetSpooks(){
if(spooks < bonezone.bones){
spooks += 1;
}
}
}
