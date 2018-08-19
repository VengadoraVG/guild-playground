using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Expirable : MonoBehaviour {
    public float lifeTime;

    void Start () {
        StartCoroutine(EventuallyDie());
    }

    public IEnumerator EventuallyDie () {
        yield return new WaitForSeconds(lifeTime);
        Destroy(this.gameObject);
    }
}
