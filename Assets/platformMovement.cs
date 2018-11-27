using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour {

    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextPos;
    public GameObject player;
    [SerializeField]
    private float speed;
    

    [SerializeField]
    private Vector3 velocity;

    private bool moving;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformB;
 

	// Use this for initialization
	void Start () {
        posA = childTransform.localPosition;
        posB = transformB.localPosition;
        nextPos = posB;
        //player.transform.parent = childTransform;

    }
	
	// Update is called once per frame
	void Update () {
        Move();

    }

    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nextPos, speed * Time.deltaTime);
        if(Vector3.Distance(childTransform.localPosition,nextPos) <= 0.1)
        {
            ChangeDestination();
        }
      
    }

    private void ChangeDestination()
    {
        nextPos = nextPos != posA ? posA : posB;
    }


}
