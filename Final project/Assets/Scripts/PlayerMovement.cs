using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;//Controlls how fast the object moves//

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Input based controlls for the player character//
        if (Input.GetKey(KeyCode.W))//If the player pushes down on the W key//
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))//If the player pushes down on the A key//
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))//If the player pushes down on the D key//
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right;
        }
        if (Input.GetKey(KeyCode.S))//If the player pushes down on the S key
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;//
        }
    }
}
