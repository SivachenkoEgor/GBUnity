using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform bulletPosition;
    [SerializeField] private Transform bullet;

    private float timePassed = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        transform.Rotate(-90f, 0f, 0f); // модель туррельки почему-то имеет поправку -90, как временно 

        timePassed += Time.deltaTime;

        if (timePassed >= 5)
        {
            Instantiate(bullet, new Vector3(bulletPosition.position.x, bulletPosition.position.y, bulletPosition.position.z), Quaternion.identity);
            timePassed = 0f;

        }
        

    }
    // чуть позже реализую радиус, не хватило немного времени
}
