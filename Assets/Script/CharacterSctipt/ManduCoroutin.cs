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
}
