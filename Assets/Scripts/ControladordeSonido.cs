using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladordeSonido : MonoBehaviour
{
    public static ControladordeSonido instance;
    public AudioSource audioSource;
    public int parametroMusica = 2;
    private void Awake(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
    }

    public void Ejecutarsonido(AudioClip audio){
        audioSource.PlayOneShot(audio);
    }
    public void Pararsonido(){
        audioSource.Stop();
    }
    public void playear(){
        audioSource.Play();
    }
    public void Update(){
        if (parametroMusica == 0){
            playear();
            parametroMusica = 2;
        }
        if (SceneManager.GetActiveScene().buildIndex == 8){
            parametroMusica = 1;
        }
        if (parametroMusica == 1){
            Pararsonido();
        }
    } 
}
