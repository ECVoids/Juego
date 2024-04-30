using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene(0);  
    }
    public void Quit()
    {
        Application.Quit();
    }
}
