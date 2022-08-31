using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : PowerUpBase
{
    [SerializeField] private Material _powerUpMaterial;
    public Material _startingMaterial;

    protected override void PowerUp(Player player)
    {
        GameObject tank = player.gameObject;
        GameObject body = tank.transform.Find("Art").transform.Find("Body").gameObject;
        GameObject turret = tank.transform.Find("Art").transform.Find("Turret").gameObject;
        body.GetComponent<MeshRenderer>().material = _powerUpMaterial;
        turret.GetComponent<MeshRenderer>().material = _powerUpMaterial;
    }

    protected override void PowerDown(Player player)
    {
        GameObject tank = player.gameObject;
        GameObject body = tank.transform.Find("Art").transform.Find("Body").gameObject;
        GameObject turret = tank.transform.Find("Art").transform.Find("Turret").gameObject;
        body.GetComponent<MeshRenderer>().material = _startingMaterial;
        turret.GetComponent<MeshRenderer>().material = _startingMaterial;
    }
}
