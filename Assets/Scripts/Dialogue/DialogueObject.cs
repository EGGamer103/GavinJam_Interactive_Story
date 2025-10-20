using UnityEngine;

public class DialogueObject : Interactable
{
    public string Name;
    public DialogueScriptable diaScriptable;

    // Trigger dialogue for this actor
    public void SpeakTo()
    {
        Dialogue.Instance.StartDialogue(Name, diaScriptable.DiaNode);
    }

    public override void OnInteract()
    {
        SpeakTo();
        Debug.Log("looked at");
        Cursor.lockState = CursorLockMode.None;
    }

    public override void OnFocus()
    {
        
    }

    public override void OnLoseFocus()
    {
        
    }
}
