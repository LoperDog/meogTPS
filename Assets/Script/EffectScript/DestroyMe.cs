﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    
	void Start ()
    {
        Destroy(transform.gameObject, 1.0f);
	}
}
