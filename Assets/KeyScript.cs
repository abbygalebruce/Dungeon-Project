using UnityEngine;

public class KeyScript : PickupBase
{
    [Header("Key")]
    [SerializeField] DoorScript door;
    [SerializeField] Animator anim;
    public override void PickupEffect(){
        base.PickupEffect();
        if(anim != null){
            anim.SetTrigger("OpenGate");
        }
        else{
            door.Unlock();
        }
    }
}
