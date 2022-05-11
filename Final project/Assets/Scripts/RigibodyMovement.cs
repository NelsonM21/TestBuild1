using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibodyMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed;
    private Rigidbody rigibody;
    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Currently detecting" + rigibody);
        rigibody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigibody.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
    }
}

