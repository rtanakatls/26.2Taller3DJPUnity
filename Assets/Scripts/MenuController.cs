using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    [SerializeField] private List<CinemachineCamera> cameras;

    private int index;


    private void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            index++;
            if(index >= cameras.Count)
            {
                index = 0;
            }
            for(int i = 0; i < cameras.Count; i++)
            {
                if (i == index)
                {
                    cameras[i].Priority = 10;
                }
                else
                {
                    cameras[i].Priority = 0;
                }
            }
        }
    }


}
