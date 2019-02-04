using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 _instance;

    public GameObject stage1EndScreen;
    public GameObject Totem1, Totem2, Totem3, Totem4, Totem5, Totem6;

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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            stage1EndScreen.SetActive(true);
        }


       
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }


        }


    }
    public void YouLose()
    {
        if(Totem1.activeInHierarchy && Totem2.activeInHierarchy && Totem3.activeInHierarchy && Totem4.activeInHierarchy && Totem5.activeInHierarchy && Totem6.activeInHierarchy)
        {
                stage1EndScreen.SetActive(true);
        }
    }


}
