using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        float zMovement = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;

        transform.Translate(xMovement,0,zMovement);
    }
}
