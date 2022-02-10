using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(prefab,new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        
        //enemyExample.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
