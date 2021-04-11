using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "TestWork/Ability", order = 0)]
public class Ability : ScriptableObject
{
    public Sprite Icon;
    public float CoolDown;
    public ParticleSystem VFXSystem;
}