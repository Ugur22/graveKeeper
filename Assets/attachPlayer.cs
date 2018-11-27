using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachPlayer : MonoBehaviour {



    [SerializeField]
    private Vector3 velocity;
    bool jump = false;
    float horizontalMove = 0f;
    public CharacterController2D controller;
    bool crouch = false;



    // Use this for initialization
    void Start()
    {
     
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        if (collision.gameObject.name == "Player")
        {

            collision.transform.SetParent(transform);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jumped!");
            collision.transform.SetParent(null);
            jump = true;
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        collision.transform.SetParent(null);
        jump = true;
    }
    void LateUpdate()
    {
      
    }

    // Update is called once per frame
    void Update () {
      
    }


}
