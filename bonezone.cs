using Unity;
using Photon;
using Linq;

public class bonezone : Photon.Monobehaviour{

public static int bones;
public int varBones;

void Start()
{
varBones = gameObject.FindObjectsWithTag("Calcium").length;
bones = varBones;
}
}
