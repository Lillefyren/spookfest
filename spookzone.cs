using system.collections;
using Unity;
using system.generic;

public class spookzone : Monobehaviour{

private int spooks;

void Start(){
  InvokeRepeatable(1, 1, "GetSpooks()");
}

void GetSpooks(){
if(spooks <= bonezone.bones){
spooks += 1;
}
if (spooks >= boneZone.bones){
  Destroy(this.gameObject);
}
}
}
