using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour{

    public TextMeshProUGUI textDisplay
    public string[] lineOfDialogue;
    private int dialogueIndex;
    public float charSpeed;

    IEnumerator Type(){

      foreach(char letter in lineOfDialogue[dialogueIndex].ToCharArray()){
        textDisplay.text +=letter; 
        yeild return new WaitForSeconds(charSpeed);
      }

    }
}
