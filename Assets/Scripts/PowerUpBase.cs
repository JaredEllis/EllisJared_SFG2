using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] private float _powerUpDuration = 5.0f;
    
    protected abstract void PowerUp(Player player);

    protected abstract void PowerDown(Player player);

    public void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {
            PowerUp(player);
            gameObject.SetActive(false);
            StartCoroutine(PowerUpDelay());
            PowerDown(player);
        }
    }

    IEnumerator PowerUpDelay()
    {
        yield return new WaitForSeconds(_powerUpDuration);
    }
}
