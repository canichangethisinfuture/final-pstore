using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet") 
        {
            Destroy(other.gameObject);
        }
    }
}
