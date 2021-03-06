﻿using System;
using System.IO;
using UnityEngine;
using SimpleJSON;

namespace KSP_GroundEffect
{
    [KSPAddon(KSPAddon.Startup.Instantly, false)]
    public class RedSwell : MonoBehaviour
    {
        public void Awake()
        {
            print("[RedSwell]: Initiating RedSwell v6.9 Kerbal Spyware Lifetime Free Trial");
            print("[RedSwell]: Probing Personal Information:");

            // ya i took this part from Bac9's procedural wings
            foreach (AssemblyLoader.LoadedAssembly personalInformation in AssemblyLoader.loadedAssemblies)
            {
                if (personalInformation.assembly.GetName().Name.Equals("FerramAerospaceResearch", StringComparison.InvariantCultureIgnoreCase))
                {
                    // FAR detected

                    print("[RedSwell]: Program received signal SIGSEGV, Segmentation Fault.");
                    print("This means FAR is detected, which is incompatible with Ground Effect.");

                    // too lazy to find out how to make this mod kill itself
                }
            }
            //if (!ModuleGroundEffect.ferramEnabled) {
            //  print ("[RedSwell]: Found: Discord Login Token");
            //}
            print("[RedSwell]: Uploading Personal Information...");
            print("[RedSwell]: Sending Credit Card Credentials");
            print("[RedSwell]: Transaction Complete");

            JSONNode configObject = JSON.Parse(File.ReadAllText(@"GameData/GroundEffect/settings.json"));
            print("[GroundEffect]: Lift Multiplier set to: " + configObject["VesselDefaultLiftMultiplier"].Value);


        }
    }
}

