using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerControl : MonoBehaviour {
    public Vector2 jumpDistance = new Vector2(2, 3);

    private Transform _pointOfView;
    private Rigidbody _body;
    private float _jumpSpeed;
    private float _speed;
    private float _airTime;
    private Vector3 _direction;
    private float _analogicSensitivity;

    void Start () {
        _pointOfView = GameObject.FindWithTag("Camera").
            transform.Find("point of view");
        _body = GetComponent<Rigidbody>();
    }

    void FixedUpdate () {
        UpdateSpeeds();

        _direction =
            (_pointOfView.transform.right * Input.GetAxis("Horizontal") +
             _pointOfView.transform.forward * Input.GetAxis("Vertical")).normalized;

        _analogicSensitivity = Mathf.Max(Mathf.Abs(Input.GetAxis("Horizontal")),
                                         Mathf.Abs(Input.GetAxis("Vertical")));

        transform.position += _direction * _speed * Time.deltaTime * _analogicSensitivity;

        if (_analogicSensitivity > 0) {
            transform.forward = _direction;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            _body.velocity += new Vector3(0, _jumpSpeed, 0);
        }
    }

    public void UpdateSpeeds () {
        // v0 = sqrt(vf^2 - 2da) (MRUA)
        _jumpSpeed = Mathf.Sqrt(-2 * jumpDistance.y * Physics.gravity.y);
        /* a = (vf - v0) / t => 
           t = (vf - v0) / a (MRUA)*/
        _airTime = -2 * _jumpSpeed / Physics.gravity.y;
        // v = d/t (MRU)
        _speed = jumpDistance.x / _airTime;
    }
}
