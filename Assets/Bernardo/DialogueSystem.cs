using TMPro;
using UnityEngine;
using System.Collections;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem _instance;
    public TextMeshProUGUI DialogueText;

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
    }
    public void ShowDialogue(Dialogue dialogue)
    {
        DialogueText.gameObject.SetActive(true);
        StartCoroutine(Dialogue(dialogue));
    }

    IEnumerator Dialogue(Dialogue dialogue)
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
        DialogueText.gameObject.SetActive(false);
    }
}
