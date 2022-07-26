using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCycle : MonoBehaviour
{
    [SerializeField] float amount = 150;
    private Vector3 targetRotation;
    private Vector3 rotateValue;
    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        amount -= 0.01f;

        rotateValue = new Vector3(amount, 45, 90);
        targetRotation = transform.position + rotateValue;
        rotation = Quaternion.Euler(amount, 45, 90);
        transform.rotation = rotation;
    }
}
