using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetaryObject
{
    MassClassEnum massClass { get; }
    double mass { get; }
}
