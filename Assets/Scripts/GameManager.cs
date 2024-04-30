using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public TMP_Text collectiblesNumbresText;
    private int collectiblesNumber;
    public TMP_Text totalCollectiblesNumbersText;
    private int totalcollectiblesNumber;

    public bool controladorpuerta = false;
    void Start()
    {
        totalcollectiblesNumber = transform.childCount;
        totalCollectiblesNumbersText.text = totalcollectiblesNumber.ToString(); 
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3 && controladorpuerta == false){
            FindAnyObjectByType<Puerta>().apertura();
        }
        NextLevel();
    }

    public void AddCollectible(){
        collectiblesNumber++;
        collectiblesNumbresText.text = collectiblesNumber.ToString();
    }

    public void NextLevel(){
        if (transform.childCount <= 0){
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);     
        }
        
    }
}
