using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        // works to move cube left by specifying direction (as serialized field) & speed
        transform.Translate(moveDirection * 3);
    }
}
