using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class SnapPosition : MonoBehaviour {
    void Update () {
        transform.position = Util.Round(transform.position / 0.5f) * 0.5f;
    }
}
