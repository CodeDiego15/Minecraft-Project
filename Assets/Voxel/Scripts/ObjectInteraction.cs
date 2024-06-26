using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
   public GameObject handPoint;
   private GameObject pickedObject = null;


    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Object"))
        {
            if(Input.GetKey("e") && pickedObject == null)
            {
                
                other.GetComponent<Rigidbody>().useGravity = false;

                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = handPoint.transform.position;
                
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);

                pickedObject = other.gameObject;
            }
        }
    }
}
