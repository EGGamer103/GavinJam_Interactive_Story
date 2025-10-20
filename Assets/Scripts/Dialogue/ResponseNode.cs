
using NUnit.Framework;
using UnityEngine;

[System.Serializable]
public class ResponseNode
{
    public string responseText;
    public DialogueNode nextNode;
    [Header("Karma value")]
    [UnityEngine.Range(-1, 1)]
    public int ending = 0;
}
