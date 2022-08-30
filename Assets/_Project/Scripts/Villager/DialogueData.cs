using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue Data", menuName = "自定义窗口/对白文件")]
public class DialogueData : ScriptableObject
{
    [TextArea(4,4)]
    public List<string> conversationBlock;
}
