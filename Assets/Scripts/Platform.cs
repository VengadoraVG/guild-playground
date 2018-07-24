using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class Platform : MonoBehaviour {    
    public GameObject target;
    public Vector3 size = new Vector3(2, 0.5f, 2);

    void Update () {
        UpdateSize();
    }

    public void UpdateSize () {
        size = target.transform.localScale = Util.Round(size / 1) * 1;
    }
}
