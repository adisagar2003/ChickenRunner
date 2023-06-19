using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    HealthManager _healthManager;
    public static GameManager instance;
    [SerializeField] private GameObject gameOverUI;
    // Start is called before the first frame update
    public float points;
    public bool isGameRunning = false;
    private void Awake()
    {
        isGameRunning = true;
        if (instance!=null && instance !=this)
        {
            Destroy(this);
            return;
        }
        instance = this;
    }
    
    public void QuitGame(){
        Application.Quit();
    }
    
    public void ResetGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name );
    }
    public void ReturnToMainMenu(){
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
