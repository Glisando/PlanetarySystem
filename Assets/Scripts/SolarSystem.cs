using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    private IPlanetarySystem _planetarySystem;
    private float _mass;
    // Start is called before the first frame update
    private void Start()
    {
        _planetarySystem = PlanetarySystemFactory.instance.Create(100f);
        _mass = Random.Range(1000f, 10000f);
    }

    // Update is called once per frame
    private void Update()
    {
        _planetarySystem.Update(Time.deltaTime);
    }
}
