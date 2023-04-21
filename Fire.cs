using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameManager gameManager;
    
    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;

    void OnTriggerEnter()
    {
        
        fire1.SetActive(true);
        fire2.SetActive(true);
        fire3.SetActive(true);
        Debug.Log("Dotkniete");
        gameManager.LevelComplete();
        Debug.Log("napis");
    }
}