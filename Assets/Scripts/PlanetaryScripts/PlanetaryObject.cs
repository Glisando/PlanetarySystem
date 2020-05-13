using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaryObject : IPlanetaryObject
{
    private MassClass _massClass;
    private Transform _sun;
    private Transform _planet;

    private float _worldUnits;
    private double _mass;
    private double _radius;
    private float _speed = Random.Range(5, 50);
    public MassClassEnum massClass => _massClass.massClass;
    public double mass => _mass;

    
    public PlanetaryObject(Transform sun, Transform planet, MassClass massClass)
    {
        _worldUnits = 0.005f;
        _sun = sun;
        _planet = planet;
        _massClass = massClass;
        _mass = Random.Range((float)_massClass.minMass, (float)_massClass.maxMass);
        _radius = Random.Range((float)_massClass.minRadius, (float)_massClass.maxRadius);

        _planet.position = Vector3.left * ((float)_radius * 5);
        Vector3 newScale = new Vector3(_worldUnits, _worldUnits, _worldUnits) * (float)_mass;
        _planet.localScale = new Vector3(1f, 1f, 1f) + newScale;
    }

    public void UpdateMethod(float deltaTime)
    {
        _planet.RotateAround(_sun.position, _sun.transform.up, _speed  * deltaTime);
    }
}
