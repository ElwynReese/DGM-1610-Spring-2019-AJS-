using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]

public class PowerUpBase : ScriptableObject
{
    public float Value = 10.5f;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Value = 20;
    }

    public void OnPowerUp(float addValue)
    {
        Value += addValue;
    }
}
