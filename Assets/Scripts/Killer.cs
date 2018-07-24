using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Killer : MonoBehaviour {
    void OnTriggerEnter (Collider c) {
        Util.GetGameController().TriggerGameOver(this);
    }
}
