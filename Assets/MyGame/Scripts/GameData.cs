using UnityEngine;

[CreateAssetMenu(menuName = "GameData")]
public class GameData : ScriptableObject, ISerializationCallbackReceiver
{
    public int collectedEggs = 0;

    public void OnAfterDeserialize()
    {
        collectedEggs = 0;
    }

    public void OnBeforeSerialize(){}

    public bool ThreeEggsCollected()
    {
        return collectedEggs == 3;
    }
}
