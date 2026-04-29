using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
    public class PlayerController1 : MonoBehaviour
    {
        public Spawner1 spawner;
        public CloudController cloudController;
        public List<Refresh1> villagers;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("X key down");
                spawner.Spawn();
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Z key down");
                cloudController.Action();

            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key down");
                foreach (var villager in villagers)
                {
                    villager.ChangeTool();
                }
            }
        }
    }
}