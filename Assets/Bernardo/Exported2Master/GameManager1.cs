using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 _instance;

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

    public void YouLose()
    {
        if(!stage1EndScreen.activeInHierarchy)
        stage1EndScreen.SetActive(true);
    }

}
