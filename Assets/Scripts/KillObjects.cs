using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillObjects : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D CollidedObject)
    {
        if(CollidedObject.gameObject.name.StartsWith("Cactus")){
            Destroy(CollidedObject.gameObject);
            Debug.Log("Cactus removed.");
        }
    }
}
