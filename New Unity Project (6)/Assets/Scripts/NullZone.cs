using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullZone : MonoBehaviour
{
    public GameObject DoorClose;
    
    private void OnTriggerExit(Collider other)
    {
        DoorClose.transform.Rotate(new Vector3(0, -60, 0));
        this.gameObject.SetActive(false);

    }
}
