using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Planet", menuName = "MassClass")]
public class MassClass : ScriptableObject
{
    public MassClassEnum massClass;

    public double minMass;
    public double maxMass;

    public double minRadius;
    public double maxRadius;
}
