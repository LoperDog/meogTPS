using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManduCoroutin : CoroutinClass
{
    public ManduCharacter ManduChar;

    public override void SetCharacterScript(CharacterSuper CharacterClass)
    {
        base.SetCharacterScript(CharacterClass);
        ManduChar = (ManduCharacter)CharacterClass;
    }

    public override void StartStrongAttckSetting()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.StrongAttackCoolTime = config.StatusConfigs["Mandu"]["StrongAttackSpeed"];
        base.StartStrongAttckSetting();
    }
    public override void StartSpecialAttackSetting()
    {

        if (config == null)
        {
            config = new ConfigClass();
        }
        thisMgr.SpecialAttackCoolTime = config.StatusConfigs["Mandu"]["SpecialAttackSpeed"];
        base.StartSpecialAttackSetting();
    }
    //특수기
    public override IEnumerator SetSpecialAttack()
    {
        if (config == null)
        {
            config = new ConfigClass();
        }
        //thisCharacterScript.CanControll = false; 제어불가는 작업 끝난 후에 적용.
        ManduChar.SpecialAttackReady();
        //StartCoroutine(SetSpecialAttackEnd());
        yield return new WaitForSeconds(config.StatusConfigs["Mandu"]["SpecialAttackSpeed"]);
        thisCharacterScript.IsSpecialAttack = false;
    }
    //public IEnumerator SetSpecialAttackEnd()
    //{
    //    if (config == null)
    //    {
    //        config = new ConfigClass();
    //    }
    //    ManduChar.SpecialAttackEnd();
    //    yield return new WaitForSeconds(config.StatusConfigs["Mandu"]["SpecialAttackTime"]);
    //}
}
