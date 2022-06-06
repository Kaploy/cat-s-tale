using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    

    float xRotation = 0f;

    public Transform startingTarget;
    private Vector2 turn;

    [Range(0f,1000f)] public float sensitivity;

    private Vector3 deltaMove;

    void Start()
    {
        transform.LookAt(startingTarget);
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void ControlUpdate()

    {

        turn.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        turn.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= turn.y;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, turn.x, 0);

    }

}

