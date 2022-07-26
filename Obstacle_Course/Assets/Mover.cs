using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float xPosition = 0;
    //[SerializeField] float yPosition = 0.01f;
    //[SerializeField] float zPosition = 0;

    [SerializeField] float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Move with WASD and dodge stuff.");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xPosition = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zPosition = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        this.transform.Translate(xPosition, 0, zPosition);
    }
}
