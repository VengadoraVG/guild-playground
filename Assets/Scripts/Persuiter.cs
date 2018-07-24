using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Persuiter : MonoBehaviour {
    public float persuitSpeedFactor = 1.5f;

    private Detector _playerDetector;
    private float _originalSpeed;
    private Enemy _enemyBehaviour;

    void Start () {
        // obtener el script Enemy que está en el game object dueño de este comportamiento
        // FIX!! _enemyBehaviour = ??
        _originalSpeed = _enemyBehaviour.speed;
        // obtener el script Enemy que está en el game object dueño de este comportamiento
        // del game object que sirve de detector del jugador
        //     (encontrarlo mediante transform.Find)
        // obtener su Detector.
        // FIX!! _playerDetector = ?? . GetComponent< ?? >();
    }

    void Update () {
        if (!IsEnemyFaster() && _playerDetector.detected) {
            _enemyBehaviour.speed *= persuitSpeedFactor;
        } else if (!_playerDetector.detected) {
            _enemyBehaviour.speed = _originalSpeed;
        }
    }

    public bool IsEnemyFaster () {
        // retorna verdadero si la velocidad del _enemyBehaviour es mayor que la original
        // de lo contrario retorna falso.
        // TODO!!
        return true; // borra esta línea :P
    }
}
