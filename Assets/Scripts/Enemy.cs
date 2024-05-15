using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
  private NavMeshAgent navMeshAgent;
  private Transform playerTransform; 
  [SerializeField] public AudioClip soundkill;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        playerTransform = FindAnyObjectByType<Player>().transform;
    }

    void Update()
    {
        navMeshAgent.destination = playerTransform.position;
    }

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
