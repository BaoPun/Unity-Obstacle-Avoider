using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        // Initially the z position is -8.75 (rounded to 9)
        // 0 the position and then "0" forces the string to be in whole numbers.
        score.text = (player.position.z + 9).ToString("0");
    }
}
