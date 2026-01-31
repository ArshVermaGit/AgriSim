using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AgriSim
{
    public class StartAnimation : MonoBehaviour
    {
        public Animation Animation;

        public void Trigger()
        {
            Animation.Play();
        }
    }
}