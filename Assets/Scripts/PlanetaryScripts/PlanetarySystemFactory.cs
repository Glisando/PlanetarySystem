using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetarySystemFactory : MonoBehaviour, IPlanetarySystemFactory
{
    public static PlanetarySystemFactory instance;
    GameObject planet;
    private Dictionary<MassClassEnum, MassClass> massClasses;
    private string folder = "MassClassScripts/";

    void Awake()
    {
        Debug.Log("Factory is ready");
        if (instance == null)
        {
            instance = this;
            Initialize();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Initialize()
    {
        massClasses = new Dictionary<MassClassEnum, MassClass>();
        planet = Resources.Load<GameObject>("Planet");
        foreach (MassClassEnum massClass in Enum.GetValues(typeof(MassClassEnum)))
        {
            massClasses.Add(massClass,
                    Resources.Load<MassClass>(folder + massClass.ToString()));
        }
    }

    public IPlanetarySystem Create(double mass)
    {
        List<IPlanetaryObject> planetaryObjects = new List<IPlanetaryObject>();
        GameObject sun = Instantiate(planet, Vector3.zero, Quaternion.identity);

        double currentMass = 0f;

        while (currentMass <= mass)
        {
            MassClassEnum currentMassClass = (MassClassEnum)UnityEngine.Random.Range(0, massClasses.Count);
            MassClass massClass = massClasses[currentMassClass];
            GameObject newPlanet = Instantiate(planet, Vector3.zero, Quaternion.identity);
            PlanetaryObject planetaryObject = new PlanetaryObject(sun.transform, newPlanet.transform, massClass);
            planetaryObjects.Add(planetaryObject);

            currentMass += planetaryObject.mass;
        }
        Debug.Log(planetaryObjects.Count);
        return new PlanetarySystem(planetaryObjects);
    }
}
