using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe1 : MonoBehaviour
{

    void Start()
    {
        Destroy(transform.gameObject, 0.2f);
    }
}
