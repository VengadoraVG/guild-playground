using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour {
    public GameObject enemyPrefab;
    public float spawnCooldown = 1;

    public bool isDestroyed;

    private Transform _spawnTransform;
    private bool _startedCoroutine = false;

    void Start () {
        StartCoroutine(PeriodicallySpawn());
        _startedCoroutine = true;
        _spawnTransform = transform.Find("spawning transform");
    }

    void Update () {
        if (isDestroyed && _startedCoroutine) {
            _startedCoroutine = false;
            StopAllCoroutines();
            GetComponent<Animator>().SetBool("is destroyed", true);
        } else if (!_startedCoroutine && !isDestroyed) {
            GetComponent<Animator>().SetBool("is destroyed", false);
            _startedCoroutine = true;
            StartCoroutine(PeriodicallySpawn());
        }
    }

    public IEnumerator PeriodicallySpawn () {
        yield return new WaitForSeconds(spawnCooldown);
        GetComponent<Animator>().SetTrigger("spawn");
        GameObject instantiated = Instantiate(enemyPrefab);
        instantiated.transform.position = _spawnTransform.position;
        instantiated.transform.rotation = _spawnTransform.rotation;
        StartCoroutine(PeriodicallySpawn());
    }
}
