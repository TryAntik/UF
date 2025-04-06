// first version

using UnityEngine;

abstract class Fish {
    public string _name { get; private set; }
    private float _minWeight;
    private float _maxWeight;
    
    public float MinWeight
    {
        get { return _minWeight; }
        set { 
            if(value>=0.05f)
                _minWeight = value;
            }
    }
    
    public float MaxWeight
    {
        get { return _maxWeight; }
        set {
            if(value <= 200f)
                _maxWeight = value;
            }
    }

    public Fish(string name, float minWeight, float maxWeight)
    {
        _name = name;
        MinWeight = minWeight >= 0.05f ? minWeight : 0.05f;
        MaxWeight = maxWeight <= 200f ? maxWeight : 200f;
    }
    
    public void CoutInfo() {
        Debug.Log(" 🎣 Information 🎣 ");
        Debug.Log($" 🐟 Name: {_name} ");
        Debug.Log($" 🌊 Weight: {_minWeight} - {_maxWeight} ");
    }       
}

class Carp : Fish { }
class CrucianCarp : Fish { }
class Pike : Fish { }
