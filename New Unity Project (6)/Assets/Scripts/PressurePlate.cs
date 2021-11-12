using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject DoorOpen;
    private void OnTriggerStay(Collider other)
    {
        DoorOpen.transform.Rotate(new Vector3(0, 60, 0));
    }
    private void OnTriggerExit(Collider other)
    {
        DoorOpen.transform.Rotate(new Vector3(0, 0, 0));
    }

}
