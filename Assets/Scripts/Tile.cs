using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tile
{
    public class Tile : MonoBehaviour
    {
        public int x, y, z; 
        [Range(0, 1)]
        private Collider col;
        void Awake()
        {
            col = GetComponent<Collider>();
        }
        GameObject SpawnChild(GameObject prefab)
        {
            GameObject child = Instantiate(prefab, transform);
            child.transform.localPosition = Vector3.zero;
            child.SetActive(false);
            return child;
        }

    }
}
