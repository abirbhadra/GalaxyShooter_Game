using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;

     // Update is called once per frame
    void Update()
    {
        //translate Laser up
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        //if laser position is greater than 8
        //then destroy the gameObject
        if (transform.position.y > 8.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
