using BepInEx;
using R2API;
using R2API.Utils;
using RoR2;
using UnityEngine;

namespace ExamplePlugin
{
    [BepInDependency(R2API.R2API.PluginGUID)]
	
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
	
    [R2APISubmoduleDependency(nameof(ItemAPI), nameof(LanguageAPI))]
    public class RemoveEgg : BaseUnityPlugin
	{
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "1nsider";
        public const string PluginName = "NoChaoticVolcanic";
        public const string PluginVersion = "1.0.0";

        public void Awake()
        {
            Log.Init(Logger);
        }

        public void Update()
        {
            if (EquipmentCatalog.randomTriggerEquipmentList.Contains(EquipmentCatalog.FindEquipmentIndex("FireBallDash")))
            {
                EquipmentCatalog.randomTriggerEquipmentList.Remove(EquipmentCatalog.FindEquipmentIndex("FireBallDash"));
            }
            if (EquipmentCatalog.randomTriggerEquipmentList.Contains(EquipmentCatalog.FindEquipmentIndex("Gateway")))
            {
                EquipmentCatalog.randomTriggerEquipmentList.Remove(EquipmentCatalog.FindEquipmentIndex("Gateway"));
            }
        }
    }
}
