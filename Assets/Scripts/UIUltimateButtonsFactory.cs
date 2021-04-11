using UnityEngine;

public class UIUltimateButtonsFactory
{
    RectTransform _parent;
    UltimateButton _prefab;
    public UIUltimateButtonsFactory(RectTransform parent, UltimateButton prefab)
    {
        _prefab = prefab;
        _parent = parent;
    }

    public UltimateButton Create(Ability abilityData)
    {
        var ultimateButton = GameObject.Instantiate(_prefab, _parent);
        ultimateButton.Initialize(abilityData.CoolDown, abilityData.Icon);
        return ultimateButton;
    }
}
