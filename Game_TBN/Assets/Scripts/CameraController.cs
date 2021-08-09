using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerCamera;
    public float cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 actualPosition = this.transform.position;
        Vector3 currentPosition = playerCamera.transform.position;

        playerCamera.transform.position = Vector3.Lerp(currentPosition, actualPosition, cameraSpeed  * Time.deltaTime);

    }
}
