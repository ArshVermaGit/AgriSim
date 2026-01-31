using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AgriSim
{
    public class Warehouse : InteractiveObject
    {
        public override void InteractedWith()
        {
            UIHandler.OpenWarehouse();
        }
    }
}
