using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAssets
{
    public class Rotate : MonoBehaviour
    {
        public Vector3 rotateChange;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(rotateChange);
        }
    }
}