using UnityEngine;

public class JailDoorScript : MonoBehaviour
{
   
    private Animator doorAnimator;
    private bool isOpened = false;

    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Checking the 'hasKey' variable from your JailKeyScript
            if (JailKeyScript.hasKey && !isOpened)
            {
                // This MUST match the Trigger name in your Animator Parameters tab
                doorAnimator.SetTrigger("LockedJailDoor"); 
                isOpened = true;
                Debug.Log("Success: Jail Door is rolling up!");
            }
            else if (!JailKeyScript.hasKey)
            {
                Debug.Log("Action Failed: You still need the Jail Key!");
            }
        }
    }
}

    //[SerializeField] Animator anim;
    //public void Unlock(){
       // this.gameObject.SetActive(false);
          //   anim.SetTrigger("JailDoorScript");
    //}
    

