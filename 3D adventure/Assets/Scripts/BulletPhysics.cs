using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    private Transform player;

    private Vector3 playerPosition;
    private Vector3 directionToPlayer;
    private float speed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.LookAt(player);
        player = GameObject.Find("Player").transform;
        playerPosition = player.position;
        transform.rotation = Quaternion.LookRotation(playerPosition);
        Debug.Log(playerPosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
