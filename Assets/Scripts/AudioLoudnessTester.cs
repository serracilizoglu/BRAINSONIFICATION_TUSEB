using UnityEngine;

public class AudioLoudnessTester : MonoBehaviour
{

    public AudioSource audioSource;
    public float updateStep = 0.1f;
    public int sampleDataLength = 44100;

    private float currentUpdateTime = 0f;

    public float clipLoudness;
    private float[] clipSampleData;

    public GameObject Cube;
    public float sizeFactor = 1;


    public float minSize = 0;
    public float maxSize = 100;



    private void Awake()
    {
        clipSampleData = new float[sampleDataLength];
    }



    private void Update()
    {
        currentUpdateTime += Time.deltaTime;
        if (currentUpdateTime >= updateStep)
        {
            currentUpdateTime = 0f;
            audioSource.clip.GetData(clipSampleData, audioSource.timeSamples);
            clipLoudness = 0f;


            foreach (var sample in clipSampleData)
            {
                clipLoudness += Mathf.Abs(sample);
            }

            clipLoudness /= sampleDataLength;

            clipLoudness *= sizeFactor;
            clipLoudness = Mathf.Clamp(clipLoudness, minSize, maxSize);
            Cube.transform.localScale = new Vector3(clipLoudness, clipLoudness, clipLoudness);
        }
    }
    private void End()
    {
        clipLoudness = 30; // Ses bitince gelmesini istedigimiz buyukluk parametresi
        clipLoudness *= sizeFactor;

        Cube.transform.localScale = new Vector3(clipLoudness, clipLoudness, clipLoudness);
    }
}