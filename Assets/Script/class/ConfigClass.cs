using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigClass {
    #region 만두콘피그
    public int ManduHP = 100;
    public float ManduMoveSpeed = 5.0f;
    public float ManduRunSpeed = 10.0f;
    public float ManduJumpForce = 300.0f;
    public int ManduDamege = 10;
    public float ManduAttackSpeed = 0.5f;
    public int ManduBullet = 100;
    public float ManduReloadTime = 1.7f;
    public Vector3 ManduFirePosition = new Vector3(0.0f,1.15f,0.8f);
    #endregion

    #region 두부콘피그
    public int DubuHP = 150;
    public float DubuMoveSpeed = 2.8f;
    public float DubuRunSpeed = 7.5f;
    public float DubuJumpForce = 5000.0f;
    public int DubuDamage = 15;
    public float DubuAttackSpeed = 0.4f;
    public int DubuBullet = 30;
    public float DubuReloadTime = 1.7f;
    public Vector3 DubuFirePosition = new Vector3(0.0f, 1.15f, 0.8f);
    #endregion
}
