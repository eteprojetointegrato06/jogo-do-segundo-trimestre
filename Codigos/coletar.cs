using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletar : MonoBehaviour
{
    public int life = 3;
    //public int lifeCount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Laranja"))
        {
            Destroy(collision.gameObject);
        }
    }
}
