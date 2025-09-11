using TMPro;
using UnityEngine;

namespace CoreModule 
{
    public class GameStartLabel : MonoBehaviour
    {
        private bool hasStarted;
        private TextMeshProUGUI label;

        void Start()
        {
            hasStarted = false;
            label = GetComponent<TextMeshProUGUI>();
            Time.timeScale = 0f;
        }

        void Update()
        {
            if(!hasStarted && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
            {
                Time.timeScale = 1f;
                label.text = "";
                hasStarted = true;
            }
        }
    }
}