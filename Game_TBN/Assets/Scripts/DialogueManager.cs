using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UI;

// keep in mind i was not in a right state of mind when i made this so it might be janky as hell

public class DialogueManager : MonoBehaviour
{

    public Dialogue dialogue;

    bool isSpeaking = false;

    //public GameObject dialogueUI;
    public GameObject player;

    //TODO: Go back and rename all this character crap it's too confusing
    public Text characterText;
    public Text characterNameText; 
    public Text character2Text;
    public Text character2NameText;

    int dialogueIndex = 0;



    // Start is called before the first frame update
    void Start()
    {
        //dialogueUI.SetActive(false);
        return;
    }

    public void onClicked()
    {
        //capsule.GetComponent<Dialogue>();
        if (dialogueIndex == 0)
        {
            startConversation();
        }
        if (dialogueIndex < dialogue.lineOfDialogue.Length )
        {
            characterText.text = dialogue.lineOfDialogue[dialogueIndex];
            character2Text.text = dialogue.otherLineOfDialogue[dialogueIndex];
            dialogueIndex++;
        }
    }

    void startConversation()
    {
        //set up dynamic Convo - 1+ people, pass people in convo int or something idk
        isSpeaking = true;
        //dialogueUI.SetActive(true);
        characterNameText.text = dialogue.name;
        characterText.text = dialogue.lineOfDialogue[0];
        character2NameText.text = dialogue.name2;
        character2Text.text = dialogue.otherLineOfDialogue[0];
    }
    void endDialogue()
    {
        isSpeaking = false;
        //dialogueUI.SetActive(false);
    }

    //float distance;


    /* 
     * If we want to enable multiple options could use this script i found for selecting options
     * will definetly have to mess around with
     * 
     * void OnMouseOver()
      {
          distance = Vector3.Distance(player.transform.position, this.transform.position);
          if (distance <= 2.5f)
          {
              if (Input.GetAxis("Mouse ScrollWheel") < 0f)
              {
                  curResponseTracker++;
                  if (curResponseTracker >= npc.playerDialogue.Length - 1)
                  {
                      curResponseTracker = npc.playerDialogue.Length - 1;
                  }
              }
              else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
              {
                  curResponseTracker--;
                  if (curResponseTracker < 0)
                  {
                      curResponseTracker = 0;
                  }
              }
              //trigger dialogue
              if (Input.GetKeyDown(KeyCode.E) && isTalking == false)
              {
                  StartConversation();
              }
              else if (Input.GetKeyDown(KeyCode.E) && isTalking == true)
              {
                  EndDialogue();
              }

              if (curResponseTracker == 0 && npc.playerDialogue.Length >= 0)
              {
                  playerResponse.text = npc.playerDialogue[0];
                  if (Input.GetKeyDown(KeyCode.Return))
                  {
                      npcDialogueBox.text = npc.dialogue[1];
                  }
              }
              else if (curResponseTracker == 1 && npc.playerDialogue.Length >= 1)
              {
                  playerResponse.text = npc.playerDialogue[1];
                  if (Input.GetKeyDown(KeyCode.Return))
                  {
                      npcDialogueBox.text = npc.dialogue[2];
                  }
              }
              else if (curResponseTracker == 2 && npc.playerDialogue.Length >= 2)
              {
                  playerResponse.text = npc.playerDialogue[2];
                  if (Input.GetKeyDown(KeyCode.Return))
                  {
                      npcDialogueBox.text = npc.dialogue[3];
                  }
              }

          }
      } */
}
