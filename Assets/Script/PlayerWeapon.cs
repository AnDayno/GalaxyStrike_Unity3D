using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;

    bool isFiring = false;

    void Start()
    {
        
    }

    void Update()
    {
        processFiring();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    private void processFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
    }
}
