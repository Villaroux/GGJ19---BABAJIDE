using TMPro;
using UnityEngine;
using System.Collections;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem _instance;
    TextMeshProUGUI DialogueText;
    GameObject DialogueTextBox;
    public float textSpeed = 0.1f;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        DialogueTextBox = gameObject.transform.GetChild(0).gameObject;
        DialogueText = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void Dialogue(Dialogue dialogue)
    {
        DialogueTextBox.SetActive(true);
        
        StartCoroutine(ShowDialogue(dialogue));
    }

    IEnumerator ShowDialogue(Dialogue dialogue)
    {
        DialogueText.text ="";

        yield return new WaitForEndOfFrame();

        foreach(var dialog in dialogue.dialogues)
        {
            DialogueText.text = "";
            foreach (var chars in dialog)
            {
                DialogueText.text += chars;
                yield return new WaitForSeconds(textSpeed);
            }

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        }
        
        
        DialogueTextBox.SetActive(false);
    }
}
