using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spikes : MonoBehaviour {
    public float waitingTime = 2;
    public float spikyTime = 0.5f;
    private Animator _animator;
    private GameObject killer;

    void Start () {
        killer = transform.Find("letal area").gameObject;
        _animator = GetComponent<Animator>();
        StartCoroutine(Switch());
    }

    public IEnumerator Switch () {
        Hide();
        yield return new WaitForSeconds(waitingTime);
        GetSpiky();
        yield return new WaitForSeconds(spikyTime);
        StartCoroutine(Switch());
    }

    public void GetSpiky () {
        killer.SetActive(true);
        _animator.SetBool("letal", true);
    }

    public void Hide () {
        killer.SetActive(false);
        _animator.SetBool("letal", false);
    }
}
