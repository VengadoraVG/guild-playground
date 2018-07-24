using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {
    void Awake () {
        Util.GetGameController().OnGameOver += Respawn;
    }

    public void Respawn (Killer killer) {
        GetComponent<Animator>().SetTrigger("spawn");
        GameObject.FindWithTag("Player").transform.position = transform.position;
    }
}
