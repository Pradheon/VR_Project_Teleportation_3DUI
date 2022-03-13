using UnityEngine;

public class TurnOnOff : MonoBehaviour
{
    bool isActive;

    void Awake()
    {
        isActive = gameObject.activeSelf;
    }

    
    public void SwitchBetweenOnOff()
    {
        isActive = !isActive;
        gameObject.SetActive(isActive);
    }
}
