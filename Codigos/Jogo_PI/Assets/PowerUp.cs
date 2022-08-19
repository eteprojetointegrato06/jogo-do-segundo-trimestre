using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir_PoweUp_life : MonoBehaviour
{
    public int lifeCount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Arbusto"))
        {
            Destroy(collision.gameObject);
            lifeCount++;
        }
    }
}
