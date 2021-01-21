using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBonus : MonoBehaviour
{
    public float Scaler;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inX = Time.deltaTime * Scaler * Input.GetAxis("Horizontal");
        float inY = Time.deltaTime * Scaler * Input.GetAxis("Vertical");
        transform.position += new Vector3(inX, inY, 0);
    }
}
