using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private Transform _player;

	void Update () {
        transform.LookAt(new Vector3(_player.position.x, this.transform.position.y, _player.position.z));
    }
}
