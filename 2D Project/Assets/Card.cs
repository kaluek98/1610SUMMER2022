using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject 
{
   public new string name;
   public string description;
   public int happyness;

   public void Print ()
   {
      Debug.Log(name + ": " + description + " In terms of happyness he's at a " + happyness + " out of 10.");
   }
}
