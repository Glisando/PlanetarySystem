using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetarySystem : IPlanetarySystem
{
    private List<IPlanetaryObject> _planetaryObjects;

    public IEnumerable<IPlanetaryObject> planetaryObjects => _planetaryObjects;

    public PlanetarySystem(List<IPlanetaryObject> planetaryObjects)
    {
        _planetaryObjects = planetaryObjects;
    }

    public void Update(float deltaTime)
    {
        foreach (PlanetaryObject planet in _planetaryObjects)
        {
            planet.UpdateMethod(deltaTime);
        }
    }
}
