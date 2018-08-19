using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Follower : MonoBehaviour {
    public Vector3 direction;
    private Enemy _enemy;
    private Quaternion _originalRotation;
    private bool _cachedOriginalRotation = false;

    void Start () {
        _enemy = transform.parent.GetComponent<Enemy>();
    }
    
    /* mientras el jugador esté dentro de la esfera:
       - el comportamiento Enemy debería apagarse. 
         el método TurnEnemyBehaviourOff() hace esto ;)

       - El enemigo debería perseguir al jugador

       recuerda que transform.Translate(0, 0, 1) va a mover al game object 1 unidad
       en la dirección hacia la que esté viendo.

       El método LookAtGameObject(target) hace que el enemigo vea hacia el gameObject
       target, *de tal forma, que no apunte hacia arriba o hacia abajo*.
       *: Esto nos asegura que el enemigo no "vuele" xD

       Recuerda también que debes multiplicar la velocidad por Time.deltaTime para
       que los fps bajos no afecten la experiencia de juego. */

    /* cuando el jugador salga de la esfera, el enemigo debe volver a
       su comportamiento normal... el método ReturnToNormal() hace esto ;) */

    public void TurnEnemyBehaviourOff () {
        // así se apaga un comportamiento :O
        _enemy.enabled = false;
    }

    public void LookAtGameObject (GameObject target) {
        if (!_cachedOriginalRotation) {
            _originalRotation = transform.parent.rotation;
            _cachedOriginalRotation = true;
        }

        direction = (target.transform.position - transform.position).normalized;
        transform.parent.forward = Vector3.Scale(new Vector3(1, 0, 1), direction);
    }

    public void ReturnToNormal () {
        _cachedOriginalRotation = false;
        transform.parent.rotation = _originalRotation;
        _enemy.enabled = true;
    }
}
