using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;

    int _currentHealth;

    public TankController _tankController;

    [SerializeField] int _treasureAmount;
    public Text _treasureText;

    private void Awake()
    {
        _tankController = GetComponent<TankController>();
    }

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void IncreaseHealth(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        Debug.Log($"Player's health: {_currentHealth}");
    }

    public void DecreaseHealth(int amount)
    {
        _currentHealth -= amount;
        Debug.Log($"Player's health: {_currentHealth}");
        if (_currentHealth <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        gameObject.SetActive(false);
        //test
    }

    public void IncreaseTreasure(int amount)
    {
        _treasureAmount += amount;
        _treasureText.text = $"Treasure: {_treasureAmount}";
    }
}
