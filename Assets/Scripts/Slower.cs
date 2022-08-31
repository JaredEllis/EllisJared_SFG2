using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slower : Enemy
{
    [SerializeField] private float _slowAmount = 0.2f;
    protected override void PlayerImpact(Player player)
    {
        TankController controller = player.GetComponent<TankController>();
        if (controller != null)
        {
            controller.MaxSpeed -= _slowAmount;
            Debug.Log(controller.MaxSpeed);
        }
    }
}
