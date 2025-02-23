using UnityEngine;
using UnityEngine.UI;

public class AppleManager : MonoBehaviour
{
    public int appleCount;
    public Text appleText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        appleText.text = "Apple Count: " + appleCount.ToString();
    }
}
