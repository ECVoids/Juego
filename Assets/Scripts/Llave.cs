using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{ 
    [SerializeField] public AudioClip soundcollect;
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            ControladordeSonido.instance.Ejecutarsonido(soundcollect);
            FindAnyObjectByType<Puerta>().tomadellave = true; 
            Destroy(gameObject);   
        }
    }
}
