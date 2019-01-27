using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [TextArea]
    public string[] dialogues;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        DialogueSystem._instance.ShowDialogue(this);
        
    }
}
