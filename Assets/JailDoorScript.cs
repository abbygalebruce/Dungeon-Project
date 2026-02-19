using UnityEngine;

public class JailDoorScript : MonoBehaviour
{
    // 1. Keep variables at the top, outside of methods
    public Animator gateAnimator;
    private bool isPlayerNearby = false;

    // 2. The Update method handles the button press
    void Update()
    {
        // Access the static variable directly from the DungeonKey class
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E) && JailKeyScript.HasKey)
        {
            Debug.Log("Pressed E! Key status: " + JailKeyScript.HasKey); // Check this in the console
            if (JailKeyScript.HasKey)
            {
                gateAnimator.SetTrigger("OpenGate");
            }
        }
    }

    // 3. Trigger methods handle the player walking in/out of range
    private void OnTriggerEnter(Collider other) 
    { 
        if (other.CompareTag("Player")) isPlayerNearby = true; 
    }

    private void OnTriggerExit(Collider other) 
    { 
        if (other.CompareTag("Player")) isPlayerNearby = false; 
    }

    //[SerializeField] Animator anim;
    //public void Unlock(){
       // this.gameObject.SetActive(false);
          //   anim.SetTrigger("JailDoorScript");
    //}
    
}

