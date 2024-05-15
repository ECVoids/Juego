using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{

    [SerializeField] public GameObject botonpausa;
    [SerializeField] public GameObject menupausa;
    [SerializeField] public GameObject menumuerte;
    public void pause(){
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menupausa.SetActive(true);
        
    }   
    public void resume(){
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menupausa.SetActive(false);  
    }
    public void Quit(){
        Application.Quit();
    }
    public void die(){
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menumuerte.SetActive(true);
    }
    public void tryagain(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
