using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    
    [SerializeField] float rotateSpeed = 5f;
        void Update()
    {
        transform.Rotate(0,0,1 * rotateSpeed * Time.deltaTime);   
    }
}
