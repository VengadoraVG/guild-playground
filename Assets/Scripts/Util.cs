using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Util {
    public static Vector3 Round (Vector3 floatyVector) {
        return new Vector3(Mathf.Round(floatyVector.x),
                           Mathf.Round(floatyVector.y),
                           Mathf.Round(floatyVector.z));
    }

    public static GameController GetGameController () {
        return GameObject.FindWithTag("GameController")
            .GetComponent<GameController>();
    }
}
