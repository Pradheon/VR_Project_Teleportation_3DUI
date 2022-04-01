using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Container")
        {
            Debug.Log("Do something here");
        }

        if (collision.gameObject.tag == "Sphere")
        {
            Debug.Log("Do something else here.");
        }
    }
}
