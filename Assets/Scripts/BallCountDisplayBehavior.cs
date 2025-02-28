using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class BallCountDisplayBehavior : MonoBehaviour
{
    private TextMeshProUGUI label;
    void Start(){
        label = GetComponent<TextMeshProUGUI>();
    }

    void Update() {
        label.SetText(ClawBehavior.ballCount.ToString());
    }
}
