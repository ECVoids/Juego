using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
   public bool tomadellave = false;

    public void apertura ()
    {
        if (tomadellave == true){
            FindAnyObjectByType<GameManager>().parametroPuerta = true;
            Destroy(gameObject);
        }
    }
}
