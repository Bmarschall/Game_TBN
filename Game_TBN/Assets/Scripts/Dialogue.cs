using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDialogue", menuName = "CharacterTextMenu")]
public class Dialogue : ScriptableObject{

    public string name;
    [TextArea(3, 15)]
    public string name2;
    [TextArea(3, 15)]
    public string[] lineOfDialogue;
    [TextArea(3, 15)]
    public string[] otherLineOfDialogue;
}
