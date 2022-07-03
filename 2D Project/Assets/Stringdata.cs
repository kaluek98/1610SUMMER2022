using UnityEngine;


[CreateAssetMenu]
public class Stringdata : ScriptableObject
{
    public string tag;

    public string car;

    public string hobby;

    public int[] eyecolor = new int[4];

    public void UpdateString(string name)
    {
        car = name;
    }

}
