
#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
public class SpritePostprocessor : AssetPostprocessor
{
    private const string SpritesDefaultMaterialName = "Sprites-Default";
    private const string CustomMaterialPath = "Packages/com.unity.render-pipelines.universal/Runtime/Materials/Sprite-Lit-Default.mat";

    //script to ensure prefabs are imported with the Sprite-Lit-material
    void OnPostprocessPrefab(GameObject prefab)
    {
        // Load the custom material
        Material customMaterial = AssetDatabase.LoadAssetAtPath<Material>(CustomMaterialPath);

        if (customMaterial == null)
        {
            Debug.LogWarning($"Custom material not found at path: {CustomMaterialPath}");
            return;
        }

        // Check all renderers in the prefab
        Renderer[] renderers = prefab.GetComponentsInChildren<Renderer>(true);
        bool materialChanged = false;

        foreach (Renderer renderer in renderers)
        {
            Material[] materials = renderer.sharedMaterials;
            for (int i = 0; i < materials.Length; i++)
            {
                if (materials[i] != null && materials[i].name == SpritesDefaultMaterialName)
                {
                    materials[i] = customMaterial;
                    materialChanged = true;
                }
            }

            if (materialChanged)
            {
                renderer.sharedMaterials = materials;
            }
        }

        if (materialChanged)
        {
            Debug.Log($"Assigned Sprite-Lit material to prefab: {assetPath}");
        }
    }
}
#endif