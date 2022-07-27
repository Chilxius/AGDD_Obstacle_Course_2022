using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float xPosition = 0;
    //[SerializeField] float yPosition = 0.01f;
    //[SerializeField] float zPosition = 0;

    [SerializeField] float moveSpeed = 10f;

    Rigidbody rb = null;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Move with WASD and dodge stuff.");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xMagnitude = Input.GetAxis("Horizontal") * moveSpeed;
        float zMagnitude = Input.GetAxis("Vertical") * moveSpeed;
        //this.transform.Translate(xPosition, 0, zPosition);
        rb.velocity = new Vector3(xMagnitude, 0, zMagnitude);
    }
}
