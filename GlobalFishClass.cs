/* lst upd. <07.04.2025> 
 * i changed a access for a lot of vars from private to protected 
 */

using UnityEngine;

internal abstract class Fish {
    public string _name { get; protected set; }
    protected float _minWeight;
    protected float _maxWeight;
    
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
        get { return _maxWeight; } // accessor
        set { // mutator
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
        Debug.Log($" 🐟 Name: " + (_name ?? "Unknown") );
        Debug.Log($" 🌊 Weight: {_minWeight} - {_maxWeight} ");
    }       
}

class Carp : Fish {
    public Carp(string name, float minWeight, float maxWeight) 
        : base(name ?? "Carp", minWeight, maxWeight) { }
}

class Pike : Fish {
    public Pike(string name, float minWeight, float maxWeight) 
        : base(name ?? "Pike", minWeight, maxWeight) { }
}

class CrucianCarp : Fish {
    public CrucianCarp(string name, float minWeight, float maxWeight) 
        : base(name ?? "Crucian Carp", minWeight, maxWeight) { }
}
