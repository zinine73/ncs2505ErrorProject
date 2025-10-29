using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CongratScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public ParticleSystem SparksParticles;
    
    private List<string> TextToDisplay;
    
    private float RotatingSpeed;
    private float TimeToNextText;

    private int CurrentText;
    
    // Start is called before the first frame update
    void Start()
    {
        TimeToNextText = 0.0f;
        CurrentText = 0;
        
        RotatingSpeed = 30.0f;

        TextToDisplay = new List<string>();
        TextToDisplay.Add("Congratulation");
        TextToDisplay.Add("All Errors Fixed");

        Text.text = TextToDisplay[0];
        
        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        TimeToNextText += Time.deltaTime;

        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;

            CurrentText++;
            if (CurrentText >= TextToDisplay.Count)
            {
                CurrentText = 0;
            }
            Text.text = TextToDisplay[CurrentText];
        }
        //Text.transform.rotation = Quaternion.Euler(0, 0, RotatingSpeed);
        Text.transform.Rotate(0, 0, RotatingSpeed * Time.deltaTime);
        SparksParticles.transform.Rotate(0, 0, RotatingSpeed * Time.deltaTime);
    }
}