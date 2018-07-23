using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Killer : MonoBehaviour {
    void OnTriggerEnter (Collider c) {
        Debug.Log("x__x" + Time.time);
        // Destroy(c.gameObject);
    }
}
