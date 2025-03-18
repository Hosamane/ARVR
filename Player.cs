using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=100f;
    public float rSpeed=200f;
    public CharacterController controller;
    void Start()
    {
        controller=GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float movex=Input.GetAxis("Horizontal");
        float movez=Input.GetAxis("Vertical");
        Vector3 mov= movex*Vector3.right+movez*Vector3.forward;
        controller.Move(mov*Time.deltaTime*speed);

        float mouse=Input.GetAxis("Mouse X");
        transform.Rotate(0f, mouse*rSpeed*Time.deltaTime,0f);
    }
}
