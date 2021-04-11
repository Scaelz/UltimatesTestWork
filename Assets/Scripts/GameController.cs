using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    RectTransform _ultimateButtonsContainer;
    [SerializeField]
    UltimateButton _ultimateButtonTemplate;
    [SerializeField]
    Character[] _characters;
    [SerializeField]
    Transform[] _spawnPoints;

    private void Start()
    {
        if (_spawnPoints.Length != _characters.Length)
        {
            Debug.LogError("Spawn points count must be equal to characters count!");
        }
        var factory = new HeroFactory();
        var ultimateButtonsFactory = new UIUltimateButtonsFactory(_ultimateButtonsContainer,
                                                                    _ultimateButtonTemplate);
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            var ultimateButton = ultimateButtonsFactory.Create(_characters[i].Ultimate);
            var hero = factory.Create(_characters[i], _spawnPoints[i].position);
            ultimateButton.OnUltimateCast += hero.Cast;
        }
    }
}
