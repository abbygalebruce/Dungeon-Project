using UnityEngine;

public class JailKeyScript : MonoBehaviour
{
    // MUST be 'public static' and spelled exactly this way
    public static bool hasKey = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasKey = true;
            Debug.Log("Collected Jail Key!");
            Destroy(gameObject);
        }
    }
}



   // [Header("Key")]
   // [SerializeField] JailDoorScript JailDoor;
   // public override void PickupEffect(){
   //     base.PickupEffect();
   //     JailDoor.Unlock();
  //  }
