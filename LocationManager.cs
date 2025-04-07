using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LocationManager : MonoBehaviour {
    [SerializeField] private List<Scene> _locations = new List<Scene>();
    [SerializeField] private List<Button> _buttons = new List<Button>(); 

    public int _currentLocationByIndex;

    private void Travel(int index) {
        if (_currentLocationByIndex != index)
            SceneManager.LoadScene(index);
    } 
    private void Continue() => SceneManager.LoadScene(_currentLocationByIndex);
}
