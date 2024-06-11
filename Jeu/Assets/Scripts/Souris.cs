using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souris : MonoBehaviour
{
    float rotationX =0f;
    float rotationY = 0f;

    public float sensitivity = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") / sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
