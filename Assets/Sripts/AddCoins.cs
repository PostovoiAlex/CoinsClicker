using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AddCoins : MonoBehaviour
{
    [SerializeField] int _coins;
    [SerializeField] Button _button;
    [SerializeField] TMPro.TMP_Text _text;

    public void Awake()
    {
        _button.onClick.AddListener(OnClicked);
    }

    private void OnClicked()
    {
        _coins++;
    }

    public void Update()
    {
        _text.text = $"coins\n{_coins.ToString()}";
    }

}
