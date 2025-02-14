using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject {
    [SerializeField] private string name;
    public string description;
    public Sprite icon;
}