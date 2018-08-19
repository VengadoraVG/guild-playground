using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Look : MonoBehaviour {
    public GameObject cam;
    void Start () {
        
    }
    
    void Update () {
        transform.forward = -cam.transform.forward;
    }
}
