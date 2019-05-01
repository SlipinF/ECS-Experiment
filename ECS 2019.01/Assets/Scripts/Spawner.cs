using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct Spawner : IComponentData
{
    public Entity Prefab;
    public int Erows;
    public int Ecols;
}
