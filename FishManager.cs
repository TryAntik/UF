using UnityEngine;
using System.Collections.Generic;


public class FishManager : MonoBehaviour {
    private List<Fish> CurrentFishes = new List<Fish>();

    private void Initiate(Fish fish) {
        
        CurrentFishes.Add(new CrucianCarp("Crucian Carp", 0.5f, 2.99f) );
        CurrentFishes.Add(new Carp("Carp", 0.7f, 5f) );
        CurrentFishes.Add(new Pike("Pike", 0.3f, 3f) );
        
        foreach(Fish _fish in CurrentFishes) {
            _fish.CoutInfo();
        }
        
        /*
        if (fish != null) {
            fish.gameObject.SetActive(true);
            Debug.Log($"{fish._name} was spawned.");
        }
        */
        
    }
}
