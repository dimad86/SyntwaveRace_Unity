using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;

    public void Play()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehavior>().StartGame();
       
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        CoinManager._coinCount = 0;
        BarrierManager._barrierCount = 0;
    }

    public void NewGame()
    {
        SceneManager.LoadScene("level_1");
        
    }

    public void ToMain()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
