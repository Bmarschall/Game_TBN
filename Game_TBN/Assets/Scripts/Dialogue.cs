using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
public TextMeshProUGUI textDisplay
public string[] lineOfDialogue;
private int dialogueIndex;
public float charSpeed;

    // Start is called before the first frame update
    void start()
    {

    }

    // Update is called once per frame
    void update()
    {

    }

    IEnumerator Type(){

      foreach(char letter in lineOfDialogue[dialogueIndex].ToCharArray()){
        textDisplay.text +=letter;
        yeild return new WaitForSeconds(charSpeed)
      }

    }
}
