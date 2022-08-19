using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XX : MonoBehaviour
{
    caminhão Pulo;
    // Start is called before the first frame update
    void Start()
    {
        Pulo = gameObject.transform.parent.gameObject.GetComponent<caminhão>();
    }
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collisor)
    {
        if (collisor.gameObject.layer == 8)
        {
            Pulo.isJumping = false;
        }
    }

    void OnCollisionExit2D(Collision2D collisor)
    {
        if (collisor.gameObject.layer == 8)
        {
            Pulo.isJumping = true;
        }
    }
}
