using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigClass {
    #region 만두콘피그
    public int ManduHP = 100;
    public float ManduMoveSpeed = 5.0f;
    public float ManduRunSpeed = 10.0f;
    public float ManduJumpForce = 500.0f;
    public int ManduDamege = 10;
    public float ManduAttackSpeed = 0.5f;
    public int ManduBullet = 100;
    public Vector3 ManduFirePosition = new Vector3(0.0f,1.15f,0.8f);
    #endregion

    #region 두부콘피그
    public int DubuHP = 150;
    public float DubuMoveSpeed = 5.5f;
    public float DubuRunSpeed = 11.0f;
    public float DubuJumpForce = 550.0f;
    public int DubuDamage = 15;
    public float DubuAttackSpeed = 0.5f;
    public int DubuBullet = 100;
    public Vector3 DubuFirePosition = new Vector3(0.0f, 1.15f, 0.8f);
    #endregion
}
