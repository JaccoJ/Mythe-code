using UnityEngine;
using System.Collections;

public class PlayerBoots : MonoBehaviour
{
    [SerializeField]
    private float _upForce;
    public float verticalSpeed;
    public float amplitude;

    public PlayerAllAttacks allAttacks;

    private Vector3 tempPosition;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if (Input.GetKeyDown("3") || Input.GetAxis("rightPad") == 1f)
        {
            StartCoroutine(floatUp());
        }
        if (Input.GetKeyDown("0") || Input.GetAxis("rightPad") == -1f)
        {
            StopCoroutine(floatUp());
        }
        if (transform.position.y > 3.5f)
        {
            tempPosition = this.transform.position;
            tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude + 5;
            transform.position = tempPosition;
        }
    }

    IEnumerator floatUp()
    {

        rb.velocity += Vector3.up * _upForce;

        yield return null;
    }
}
