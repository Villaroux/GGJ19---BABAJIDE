using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    TextMeshProUGUI timerText;

    float timer;
    [SerializeField]
    [Tooltip("In minutes")]
    float levelTimer = 0.0f;

    private void Awake()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        timer = levelTimer * 60.0f;
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime * 100;

        float minutes = Mathf.Floor(timer / 60.0f);

        float seconds = Mathf.RoundToInt(timer % 60);

        if (timer < 0.0f)
        {
            minutes = 0.0f;
            seconds = 0.0f;

            if (!GameManager._instance.stage1EndScreen.activeInHierarchy)
            {
                GameManager._instance.YouLose();
            }
        }
        if (timerText != null)
        {
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }
}
