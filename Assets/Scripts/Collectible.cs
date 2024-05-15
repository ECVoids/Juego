using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] public AudioClip soundcollect;
private void OnCollisionEnter (Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            ControladordeSonido.instance.Ejecutarsonido(soundcollect);
            FindAnyObjectByType<GameManager>().AddCollectible();
            Destroy(gameObject);    
        }
    } 
}
