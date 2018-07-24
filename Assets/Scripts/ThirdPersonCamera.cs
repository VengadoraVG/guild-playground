using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ThirdPersonCamera : MonoBehaviour {
    public GameObject target;
    public float mouseSensitivity;
    
    private GameObject pitch;

    void Start () {
        if (target == null) {
            target = GameObject.FindWithTag("Player");
        }
        pitch = transform.Find("pitch").gameObject;
        transform.rotation = target.transform.rotation;
    }

    void Update () {
        transform.position = target.transform.position;
        pitch.transform.
            Rotate(-Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime, 0, 0);
        transform.
            Rotate(0, Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime, 0);
    }
}
