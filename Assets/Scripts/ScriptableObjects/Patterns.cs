using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Patterns", menuName = "Scriptable Objects/Patterns")]
public class Patterns : ScriptableObject
{
    public List<GameObject> prefabs;
}
