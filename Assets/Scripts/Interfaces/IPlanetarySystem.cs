using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetarySystem
{
    IEnumerable<IPlanetaryObject> planetaryObjects { get; }

    void Update(float deltaTime);
}
