using UnityEngine;

[CreateAssetMenu(fileName = "NewSkin", menuName = "Shop/Skin")]
public class SkinData : ScriptableObject
{
    public string skinName;
    public Sprite skinIcon;        
    public GameObject skinPrefab;  
    public int price;              
    public bool isUnlocked = false; 
}