using UnityEngine;
using System.Collections.Generic;

public class LevelCreatorByPattern : MonoBehaviour
{
    [SerializeField] private List<Patterns> patterns;
    [SerializeField] private int amount;

    private void Awake()
    {
        int seed= Random.Range(0, patterns.Count);  
        Patterns pattern = patterns[seed];
        for(int i = 0; i < amount; i++)
        {
            GameObject obj = Instantiate(pattern.prefabs[i % pattern.prefabs.Count]);
            obj.transform.position = transform.position + Vector3.forward * i * 10;
        }

    }
}
