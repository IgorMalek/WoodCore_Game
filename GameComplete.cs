using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public void Win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  1);
    }
}
