using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco
{
    public class KnightRotator : MonoBehaviour
    {
        [SerializeField] float speed;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }
}
