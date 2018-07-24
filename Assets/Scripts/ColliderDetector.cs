using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColliderDetector : MonoBehaviour {
    public bool detected;

    private float _secondOfLastStayCalled = 0;

    void OnTriggerStay (Collider c) {
        if (c.CompareTag("jumpable")) {
            detected = true;
            _secondOfLastStayCalled = Time.time;
        }
    }

    void OnTriggerExit (Collider c) {
        if (_secondOfLastStayCalled != Time.time && c.CompareTag("jumpable")) {
            detected = false;
        }
    }
}
