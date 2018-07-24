using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {
    public bool randomOrientation = true;
    public float spinningAngle = 90;
    public float speed = 2;

    private Detector _floorDetector;
    private Detector _wallDetector;

    void Start () {
        _floorDetector = transform.Find("floor detector")
            .GetComponent<Detector>();
        _wallDetector = transform.Find("wall detector")
            .GetComponent<Detector>();
    }
    
    void Update () {
        if (!_floorDetector.detected || _wallDetector.detected) {
            Spin();
        }

        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    public void Spin () {
        int orientation = randomOrientation? (int) Mathf.Pow(-1, Random.Range(1, 3)): 1;
        transform.Rotate(0, orientation * spinningAngle, 0);
    }
}
