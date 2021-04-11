using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UltimateButton : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _cooldownTMPro;
    [SerializeField]
    Image _cooldownSprite;
    [SerializeField]
    Image _ultimateIcon;
    [SerializeField]
    Button _button;

    float _cooldown = 1;
    public event Action OnUltimateCast;
    public void Initialize(float cooldown, Sprite icon)
    {
        _ultimateIcon.sprite = icon;
        _cooldown = cooldown;
    }

    public void CastUltimate()
    {
        _button.interactable = false;
        if (_cooldown > 0)
        {
            StartCoroutine(StartCoolDown());
        }
        OnUltimateCast?.Invoke();
    }

    IEnumerator StartCoolDown()
    {
        _cooldownTMPro.gameObject.SetActive(true);
        _cooldownSprite.fillAmount = 1;
        float cd = _cooldown;
        while (cd > 0)
        {
            _cooldownSprite.fillAmount -= Time.deltaTime / _cooldown;
            _cooldownTMPro.text = cd.ToString("0.0");
            cd -= Time.deltaTime;
            yield return null;
        }
        _cooldownTMPro.gameObject.SetActive(false);
        _button.interactable = true;
    }
}
