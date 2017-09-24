using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduCharacter : CharacterSuper
{
    public DubuAnimation CharAnim;

    override public void Attack()
    {
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if (!IsAttack && !IsReLoad && m_Current_Bullet > 0)
        {
            m_Current_Bullet--;
            IsAttack = true;
            ShotBullet();
        }
        else if (!IsAttack && !IsReLoad && m_Current_Bullet == 0)
        {
            ReLoad();
        }
        else
        {
            //m_CurrentAttack = 0.0f;
        }
    }
    public override void ReLoad()
    {
        base.ReLoad();
        if (config == null)
        {
            config = new ConfigClass();
        }
        CurrentAttack = config.StatusConfigs["Dubu"]["AtttackSpeed"];
    }
}
