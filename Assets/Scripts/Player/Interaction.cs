using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    private DialogueDisplayer dialogueDisplay;
    public float interactDistance;

    private void Start()
    {
        dialogueDisplay = GetComponent<DialogueDisplayer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100.0f, Color.yellow);
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, interactDistance))
            {
              
                if (hit.transform.gameObject.tag == "NPC")
                {
                    DialogueContainer dialogue = hit.transform.gameObject.GetComponent<DialogueContainer>();
                    dialogueDisplay.DisplayDialogue(dialogue.dialogue);
                                       

                }
            }
        }
    }
}
