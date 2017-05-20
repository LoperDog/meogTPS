using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubuCharacter : CharacterSuper {

    // 생성자 관리
    public DubuCharacter()
    {

    }
    public override void Attack()
    {
        Debug.Log("두부에서 실행됨");
    }

    public override void Move()
    {
        Debug.Log("두부에서 실행됨ㅁㄴㅇ");
    }
    ~DubuCharacter()
    {

    }
}
