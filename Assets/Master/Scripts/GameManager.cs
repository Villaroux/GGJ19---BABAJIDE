using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public GameObject stage1EndScreen;


    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;

            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void YouLose()
    {
        if(!stage1EndScreen.activeInHierarchy)
        stage1EndScreen.SetActive(true);
    }

    
}
