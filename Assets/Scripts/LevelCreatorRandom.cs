using System.Collections.Generic;
using UnityEngine;

public class LevelCreatorRandom : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabs;
    [SerializeField] private int amount;

    private void Awake()
    {
        for(int i=0;i<amount;i++)
        {
            GameObject obj = Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
            obj.transform.position = transform.position + Vector3.forward * 10 * i;
        }
    }

}
