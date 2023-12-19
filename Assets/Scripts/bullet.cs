using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyBullet", 1f);
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
