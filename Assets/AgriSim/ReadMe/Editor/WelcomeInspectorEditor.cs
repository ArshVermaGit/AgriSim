using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;


[CustomEditor(typeof(ResourcesDataScriptable))]
public class WelcomeInspectorEditor : Editor
{
    public VisualTreeAsset m_InspectorXML;
    public VisualTreeAsset m_BlockTemplateXML;
    private VisualElement v_Root;
    public ResourcesDataScriptable resourcesSO;
      

    protected override void OnHeaderGUI()
    {
        var data = (ResourcesDataScriptable)target;
        var iconWidth = Mathf.Min(EditorGUIUtility.currentViewWidth / 3f - 20f, 128f);
        GUIStyle m_TitleStyle;
        GUIStyle m_SubTitleStyle;

        m_TitleStyle = new GUIStyle(EditorStyles.label);
        m_TitleStyle.fontSize = 24;
        m_TitleStyle.wordWrap = true;
        m_SubTitleStyle = new GUIStyle(EditorStyles.label);
        m_SubTitleStyle.fontSize = 14;
        m_SubTitleStyle.wordWrap = true;

        GUILayout.BeginHorizontal();
        {    
            GUILayout.Label(data.windowBanner, GUILayout.Width(iconWidth), GUILayout.Height(iconWidth));
            GUILayout.BeginVertical();
            {
                GUILayout.Space(5);
                GUILayout.Label(data.windowTitle, m_TitleStyle, GUILayout.Width(EditorGUIUtility.currentViewWidth/1.5f));
                GUILayout.Label(data.windowSubTitle, m_SubTitleStyle, GUILayout.Width(EditorGUIUtility.currentViewWidth / 1.5f));
            }
            GUILayout.EndVertical();
        }
        GUILayout.EndHorizontal();
    }
    public override VisualElement CreateInspectorGUI()
    {

        // Create a new VisualElement to be the root of our Inspector UI.

        VisualElement myInspector = new VisualElement();
        m_InspectorXML.CloneTree(myInspector);
        myInspector.Q<Label>("intro").dataSource = resourcesSO;

        for (int i = 0; i < resourcesSO.infoBlock.Count; i++)
        {
            BlockDataScriptable b = resourcesSO.infoBlock[i];
            VisualElement v_Block = m_BlockTemplateXML.Instantiate();
            v_Block.Q<Button>("button-block-info").dataSource = b;
            v_Block.Q<Button>("button-block-info").RegisterCallback<ClickEvent>(evt =>
            {
                // Perform actions here for each block data
                Application.OpenURL(b.resourceURL);

            });

            myInspector.Q<VisualElement>("root-resources").Add(v_Block);
        }
           

        /* //option if we wanted to just scan the asset folder for our scriptable objects with block info
        var AllAvailableBlocksData = AssetDatabase.FindAssets("t:BlockDataScriptable");

        foreach (string b in AllAvailableBlocksData)
        {
            //Debug.Log("BlockDataScriptable found: " + b);
            VisualElement v_Block = m_BlockTemplateXML.Instantiate();
            string AssetPath = AssetDatabase.GUIDToAssetPath(b);
            var blockDataSO = (BlockDataScriptable)AssetDatabase.LoadAssetAtPath(AssetPath, typeof(BlockDataScriptable));
               
            v_Block.Q<Button>("button-block-info").dataSource = blockDataSO;
            v_Block.Q<Button>("button-block-info").RegisterCallback<ClickEvent>(evt =>
            {
                // Perform actions here for each block data
                Application.OpenURL(blockDataSO.resourceURL);

            });
               
            myInspector.Q<VisualElement>("root-resources").Add(v_Block);
        }*/



        // Return the finished Inspector UI.
        return myInspector;
    }
    [InitializeOnLoadMethod]
    public static void RegisterConverters()
    {

        ConverterGroup groupSize = new("ConvertToPix","Adjust block size", "Multiplies int x 150px + adding margin pixels, that way blocks take the right pixel space based on the int from the SO, wider blocks start and end aligned with the smaller ones below");
        groupSize.AddConverter((ref int v) => new StyleLength(new Length(v*150 + (v-1)*6, LengthUnit.Pixel))); //size x 150px + adding margin pixels, that way wider blocks start and end aligned with the smaller ones below
        ConverterGroups.RegisterConverterGroup(groupSize);

        ConverterGroup groupUpper = new("Uppercase","Uppercase for binded items", "Converting binded text to uppercase for aesthetic purpose");
        groupUpper.AddConverter((ref string v) => v.ToUpper()); //because the text is binded we need to make it uppercase with a converter or add a richtag
        ConverterGroups.RegisterConverterGroup(groupUpper);

        ConverterGroup groupDisplay = new("Bool to Visibility");
        groupDisplay.AddConverter((ref bool v) => {
            return v switch
            {
                true => new StyleFloat(65f),
                false => new StyleFloat(0f)
            };
        }); //convert from bool to styling
        ConverterGroups.RegisterConverterGroup(groupDisplay);

    }
}

