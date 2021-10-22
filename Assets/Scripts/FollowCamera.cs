using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    private void Update()
    {
        Vector3 playerPos = player.transform.position;
        gameObject.transform.position = new Vector3(playerPos.x, playerPos.y, -10);
    }
}
