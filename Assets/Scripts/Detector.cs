using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Detector : MonoBehaviour {
    public bool detected;
    public LayerMask layersDetected;

    public RaycastHit hit;

    public Transform begin;
    public Transform ending;

    private Vector3 _direction;
    private float _maxDistance;

    void Start () {
        Update();
    }

    void Update () {
        _direction = (ending.position - begin.position).normalized;
        _maxDistance = (begin.position - ending.position).magnitude;

        if (Physics.Raycast(begin.position, _direction, out hit, _maxDistance,
                            layersDetected)) {
            detected = true;
        } else {
            detected = false;
        }
    }
}
