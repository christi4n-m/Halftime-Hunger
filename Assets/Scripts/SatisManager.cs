using UnityEngine;
using UnityEngine.UI;

public class SatisManager : MonoBehaviour
{
    public int satisfaction;
    public Text satisText;

    void Start()
    {

    }

    void Update()
    {
        satisText.text = "Satisfaction: " + satisfaction.ToString();
    }

}
