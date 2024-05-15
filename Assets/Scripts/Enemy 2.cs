using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] public AudioClip soundkill;

private void OnCollisionEnter (Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            ControladordeSonido.instance.Ejecutarsonido(soundkill);
            Destroy(FindAnyObjectByType<Player>());
            FindAnyObjectByType<Pause>().die();   
        }
    } 
}