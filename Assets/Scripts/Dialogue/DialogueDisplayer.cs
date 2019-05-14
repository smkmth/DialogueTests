using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDisplayer : MonoBehaviour
{
    //roughly 46 chars in a line

    public GameObject dialogueWindow;
    public GameObject dialoguePanel;
    public GameObject speakerPanel;
    public  Image speakerImage;

    private TextMeshProUGUI dialogueContent;
    private TextMeshProUGUI speakerName;


    public Sprite testSprite;

    public bool isDisplayingDialogue;

    public void Start()
    {
        dialogueContent = dialoguePanel.GetComponentInChildren<TextMeshProUGUI>();
        speakerName = speakerPanel.GetComponentInChildren<TextMeshProUGUI>();
        dialogueWindow.SetActive(false);

        dialogueContent.text = "test text";
        speakerName.text = "test speaker";
        speakerImage.sprite = testSprite;

    }

    public void DisplayDialogue(Dialogue dialogue)
    {
        if (!isDisplayingDialogue)
        {
            dialogueWindow.SetActive(true);
            dialogueContent.text = dialogue.lineToSay;
            speakerName.text = dialogue.speakerName;
            speakerImage.sprite = dialogue.speakerImage;



        }

    }
 

    public void ToggleWindow()
    {
        if (dialogueWindow.activeSelf)
        {
            dialogueWindow.SetActive(false);

        }
        else
        {
            dialogueWindow.SetActive(true);
        }
    }

}
[CreateAssetMenu()]
public class Dialogue : ScriptableObject
{
    public string speakerName;
    public string lineToSay;
    public Sprite speakerImage;

}

