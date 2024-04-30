using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
  private NavMeshAgent navMeshAgent;
  private Transform playerTransform; 

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
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    
        }
    } 
}
