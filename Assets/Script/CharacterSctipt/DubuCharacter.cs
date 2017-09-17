﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuCharacter : CharacterSuper
{
    /*
    // 생성자 관리
    public DubuCharacter()
    {

        m_CurrentAttack = 0.0f;
        m_TimeAttack = 0.5f;
    }*/

    //public override void Attack()
    //{
    //base.Attack();
    //Debug.Log("두부에서 실행됨");
    //}
    /*
    public override void Move()
    {
        Debug.Log("두부에서 실행됨ㅁㄴㅇ");
    }
    ~DubuCharacter()
    {

    }*/
    // 이팩트 시작 위치나 등등을 잡아줘야 한다.
    public bool AttackIsLeft = false;

    override public void Attack()
    {
        // 공격중이 아닌데 공격 이 시작된다면 - 공격 가능
        if (!IsAttack && !IsReLoad && m_Current_Bullet > 0)
        {
            //공격 시작 코드
            m_Current_Bullet--;
            IsAttack = true;
            // 왼쪽공격이라면
            if (AttackIsLeft)
            {
                Transform temp = Instantiate(effect[0], effectPosition[0].position, effectPosition[0].rotation * effect[0].rotation);
                temp.GetComponent<DestroyMe1>().Target = effectPosition[0];
            }
            else
            {
                Transform temp = Instantiate(effect[1], effectPosition[1].position, effectPosition[1].rotation * effect[1].rotation);
                temp.GetComponent<DestroyMe1>().Target = effectPosition[1];
            }
            ShotBullet();
            AttackIsLeft = !AttackIsLeft;
            //기본 사속을 조금씩 줄인다.
            if((m_CurrentAttack - 0.005f) >= 0.0f)
            {
                m_CurrentAttack -= 0.005f;
            }
        }
        // 공격이 시작될수 있는데 총알이 없다면 - 공격 불가 상태
        else if (!IsAttack && !IsReLoad && m_Current_Bullet == 0)
        {
            IsReLoad = true;
            coroutine.StartReLoad();
        }
        // 
        else
        {
            //m_CurrentAttack = 0.0f;
        }
    }
    public override void StrongAttack()
    {

    }
    public override void SpecialAttack()
    {
    }
    public override void UpAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        CurrentAttack = config.StatusConfigs["Dubu"]["AtttackSpeed"];
    }
}
