using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OogaBoogaMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var direction = new Vector3(horizontal, 0f, vertical);

        transform.position += direction;
    }
}
