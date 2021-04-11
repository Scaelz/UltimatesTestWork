using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "TestWork/Character", order = 0)]
public class Character : ScriptableObject
{
    public string Name;
    public Hero HeroPrefab;
    public Ability Ultimate;
}