using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{ 
    
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            FindAnyObjectByType<Puerta>().tomadellave = true; 
            Destroy(gameObject);    
        }
    }
}
