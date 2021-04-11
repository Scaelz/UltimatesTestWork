using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFactory
{
    public Hero Create(Character characterData, Vector2 spawnPostion)
    {
        var heroGO = GameObject.Instantiate(characterData.HeroPrefab, spawnPostion, Quaternion.identity);
        var abilityPS = GameObject.Instantiate(characterData.Ultimate.VFXSystem, heroGO.transform);
        heroGO.Initialize(abilityPS);
        return heroGO;
    }
}
