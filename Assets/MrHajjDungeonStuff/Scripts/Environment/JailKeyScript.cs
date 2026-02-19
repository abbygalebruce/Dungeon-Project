using UnityEngine;

public class JailKeyScript : PickupBase
{
    public static bool HasKey = false;

    protected new void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HasKey = true; // Set the global variable
            Debug.Log("Key Collected!");
            Destroy(gameObject);
        }
    }







   // [Header("Key")]
   // [SerializeField] JailDoorScript JailDoor;
   // public override void PickupEffect(){
   //     base.PickupEffect();
   //     JailDoor.Unlock();
  //  }
}
