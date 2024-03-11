using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{

    public float spaceInput;
    public float speed = 4000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spaceInput = Input.GetAxis("Jump");

        transform.Rotate(Vector3.forward * Time.deltaTime * speed * spaceInput);

        if(spaceInput == 0)
        {
            transform.Rotate(Vector3.back * Time.deltaTime * (speed / 8));
        }
    }
}
