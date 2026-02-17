using UnityEngine;

public class DoorOpener : MonoBehaviour, IInteractable
{
    [SerializeField] Animator anim;
    public void Interacted(){
        anim.SetTrigger("doorOpen");
    }
}
