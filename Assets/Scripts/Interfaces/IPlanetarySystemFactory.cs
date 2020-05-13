using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetarySystemFactory
{
    IPlanetarySystem Create(double mass);
}
