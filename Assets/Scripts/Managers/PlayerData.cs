using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public bool[] levels;
    public PlayerData()
    {
        levels = GameManager.openLevels;
    }
}
