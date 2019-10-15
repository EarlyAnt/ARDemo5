using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField, Range(0.1f, 10f)]
    float speedX = 0.1f;
    [SerializeField, Range(0.1f, 10f)]
    float speedY = 0.1f;
    [SerializeField, Range(0.1f, 10f)]
    float speedZ = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(this.speedX, this.speedY, this.speedZ));
    }
}
