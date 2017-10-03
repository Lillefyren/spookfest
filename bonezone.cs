using Unity;
using Photon;
using Linq;
using system.collections;

public class bonezone : Photon.Monobehaviour{

public static int bones;
public int varBones;

void Start()
{
varBones = Transform.FindObjectsWithTag("Calcium").length;
bones = varBones;
}
}
