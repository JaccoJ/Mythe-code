using UnityEngine;
using System.Collections;

public class PegasusMove : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]
    private float turnSpeed = 25f;
    private float moveSpeed = 5f;
    private bool movePegasus = false;

    [SerializeField]
    private Transform resetPoint;

    public float verticalSpeed;
    public float amplitude;

    private Vector3 tempPosition;

    [Header("Time")]
    [SerializeField]
    private float time;
    Time timer;

    [Header("Attack")]
    public bool attackPegasus = false;

    [Header("EnemyInfo")]
    [SerializeField]
    private Transform medusa;

    void Update()
    {
        //Movement Pegasus
        tempPosition = this.transform.position;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude + 5;
        transform.position = tempPosition;

        Vector3 movement = new Vector3();

        movement -= transform.forward;
        this.transform.position += (movement * Time.deltaTime * moveSpeed);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}