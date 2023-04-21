using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject CompleteLevelUI;

     public void LevelComplete()
    {
        //CompleteLevelUI.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  1);
        Debug.Log("nowascena");
    }

    void Update()
    {
        
    }
}
