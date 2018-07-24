using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
    public delegate void GameOverDelegate (Killer killer);
    public event GameOverDelegate OnGameOver;

    public void TriggerGameOver (Killer killer) {
        if (OnGameOver != null) {
            OnGameOver(killer);
        }
    }
}
