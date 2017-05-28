﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigClass {
    #region 만두콘피그
    public int ManduHP = 100;
    public float ManduMoveSpeed = 1.0f;
    public int ManduDamege = 10;
    public float ManduAttackSpeed = 0.5f;
    public int ManduBullet = 20;
    public Vector3 ManduFirePosition = new Vector3(0.0f,1.15f,0.8f);
    #endregion

    #region 두부콘피그
    public int DubuHP = 150;
    public float DubuMoveSpeed = 1.5f;
    public int DubuDamage = 15;
    public float DubuAttackSpeed = 0.1f;
    public int DubuBullet = 10;
    public Vector3 DubuFirePosition = new Vector3(0.0f, 1.15f, 0.8f);
    #endregion
}
