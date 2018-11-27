using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

    public Transform playerFollow;

    private void FixedUpdate()
    {
        transform.position = new Vector3(playerFollow.position.x, playerFollow.position.y, transform.position.z);
    }
}
