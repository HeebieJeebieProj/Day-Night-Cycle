using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyColorChangerScript : MonoBehaviour {

    public SkyColorScript[] skyColorScripts;
    public float timeTotal;

    private float speed;

    public int startHour;

    public float time = 0;

    private float fraction;
    private int[] randomIndex;
    private bool[] randomIndexChange;

    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        time = startHour * 60 * 60f;
        speed = 1000f;

        spriteRenderer = GetComponent<SpriteRenderer>();

        randomIndexChange = new bool[12];
        randomIndex = new int[12];

        for (int i = 0; i < 12; i++)
        {
            randomIndexChange[i] = true;
            randomIndex[i] = 0;
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (time >= 86400)
        {
            time = 0f;
        }

        time += Time.deltaTime * speed;

        if (time >= 0 && time < 3600)
        {
            if (randomIndexChange[0])
            {
                randomIndex[0] = Random.Range(0, skyColorScripts[0].colorMid.Length);
                randomIndexChange[0] = false;
                randomIndexChange[1] = true;
            }

            spriteRenderer.color = skyColorScripts[0].colorMid[randomIndex[0]];
        }
        else if (time >= 3600 && time < 7200)
        {
            if (randomIndexChange[1])
            {
                randomIndex[1] = Random.Range(0, skyColorScripts[1].colorMid.Length);
                randomIndexChange[1] = false;
            }

            fraction = (time - 3600) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[0].colorMid[randomIndex[0]], skyColorScripts[1].colorMid[randomIndex[1]], fraction);
        }
        else if (time >= 7200 && time < 10800)
        {
            if (randomIndexChange[1])
            {
                randomIndex[1] = Random.Range(0, skyColorScripts[1].colorMid.Length);
                randomIndexChange[1] = false;
                randomIndexChange[2] = true;
            }

            spriteRenderer.color = skyColorScripts[1].colorMid[randomIndex[1]];
        }
        else if (time >= 10800 && time < 14400)
        {
            if (randomIndexChange[2])
            {
                randomIndex[2] = Random.Range(0, skyColorScripts[2].colorMid.Length);
                randomIndexChange[2] = false;
            }

            fraction = (time - 10800) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[1].colorMid[randomIndex[1]], skyColorScripts[2].colorMid[randomIndex[2]], fraction);
        }
        else if (time >= 14400 && time < 18000)
        {
            if (randomIndexChange[2])
            {
                randomIndex[2] = Random.Range(0, skyColorScripts[2].colorMid.Length);
                randomIndexChange[2] = false;
                randomIndexChange[3] = true;
            }

            spriteRenderer.color = skyColorScripts[2].colorMid[randomIndex[2]];
        }
        else if (time >= 18000 && time < 21600)
        {
            if (randomIndexChange[3])
            {
                randomIndex[3] = Random.Range(0, skyColorScripts[3].colorMid.Length);
                randomIndexChange[3] = false;
            }

            fraction = (time - 18000) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[2].colorMid[randomIndex[2]], skyColorScripts[3].colorMid[randomIndex[3]], fraction);
        }
        else if (time >= 21600 && time < 25200)
        {
            if (randomIndexChange[3])
            {
                randomIndex[3] = Random.Range(0, skyColorScripts[3].colorMid.Length);
                randomIndexChange[3] = false;
                randomIndexChange[4] = true;
            }

            spriteRenderer.color = skyColorScripts[3].colorMid[randomIndex[3]];
        }
        else if (time >= 25200 && time < 28800)
        {
            if (randomIndexChange[4])
            {
                randomIndex[4] = Random.Range(0, skyColorScripts[4].colorMid.Length);
                randomIndexChange[4] = false;
            }

            fraction = (time - 25200) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[3].colorMid[randomIndex[3]], skyColorScripts[4].colorMid[randomIndex[4]], fraction);
        }
        else if (time >= 28800 && time < 32400)
        {
            if (randomIndexChange[4])
            {
                randomIndex[4] = Random.Range(0, skyColorScripts[4].colorMid.Length);
                randomIndexChange[4] = false;
                randomIndexChange[5] = true;
            }

            spriteRenderer.color = skyColorScripts[4].colorMid[randomIndex[4]];
        }
        else if (time >= 32400 && time < 36000)
        {
            if (randomIndexChange[5])
            {
                randomIndex[5] = Random.Range(0, skyColorScripts[5].colorMid.Length);
                randomIndexChange[5] = false;
            }

            fraction = (time - 32400) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[4].colorMid[randomIndex[4]], skyColorScripts[5].colorMid[randomIndex[5]], fraction);
        }
        else if (time >= 36000 && time < 39600)
        {
            if (randomIndexChange[5])
            {
                randomIndex[5] = Random.Range(0, skyColorScripts[5].colorMid.Length);
                randomIndexChange[5] = false;
                randomIndexChange[6] = true;
            }

            spriteRenderer.color = skyColorScripts[5].colorMid[randomIndex[5]];
        }
        else if (time >= 39600 && time < 43200)
        {
            if (randomIndexChange[6])
            {
                randomIndex[6] = Random.Range(0, skyColorScripts[6].colorMid.Length);
                randomIndexChange[6] = false;
            }

            fraction = (time - 39600) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[5].colorMid[randomIndex[5]], skyColorScripts[6].colorMid[randomIndex[6]], fraction);
        }
        else if (time >= 43200 && time < 46800)
        {
            if (randomIndexChange[6])
            {
                randomIndex[6] = Random.Range(0, skyColorScripts[6].colorMid.Length);
                randomIndexChange[6] = false;
                randomIndexChange[7] = true;
            }

            spriteRenderer.color = skyColorScripts[6].colorMid[randomIndex[6]];
        }
        else if (time >= 46800 && time < 50400)
        {
            if (randomIndexChange[7])
            {
                randomIndex[7] = Random.Range(0, skyColorScripts[7].colorMid.Length);
                randomIndexChange[7] = false;
            }

            fraction = (time - 46800) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[6].colorMid[randomIndex[6]], skyColorScripts[7].colorMid[randomIndex[7]], fraction);
        }
        else if (time >= 50400 && time < 54000)
        {
            if (randomIndexChange[7])
            {
                randomIndex[7] = Random.Range(0, skyColorScripts[7].colorMid.Length);
                randomIndexChange[7] = false;
                randomIndexChange[8] = true;
            }

            spriteRenderer.color = skyColorScripts[7].colorMid[randomIndex[7]];
        }
        else if (time >= 54000 && time < 57600)
        {
            if (randomIndexChange[8])
            {
                randomIndex[8] = Random.Range(0, skyColorScripts[8].colorMid.Length);
                randomIndexChange[8] = false;
            }

            fraction = (time - 54000) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[7].colorMid[randomIndex[7]], skyColorScripts[8].colorMid[randomIndex[8]], fraction);
        }
        else if (time >= 57600 && time < 61200)
        {
            if (randomIndexChange[8])
            {
                randomIndex[8] = Random.Range(0, skyColorScripts[8].colorMid.Length);
                randomIndexChange[8] = false;
                randomIndexChange[9] = true;
            }

            spriteRenderer.color = skyColorScripts[8].colorMid[randomIndex[8]];
        }
        else if (time >= 61200 && time < 64800)
        {
            if (randomIndexChange[9])
            {
                randomIndex[9] = Random.Range(0, skyColorScripts[9].colorMid.Length);
                randomIndexChange[9] = false;
            }

            fraction = (time - 61200) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[8].colorMid[randomIndex[8]], skyColorScripts[9].colorMid[randomIndex[9]], fraction);
        }
        else if (time >= 64800 && time < 68400)
        {
            if (randomIndexChange[9])
            {
                randomIndex[9] = Random.Range(0, skyColorScripts[9].colorMid.Length);
                randomIndexChange[9] = false;
                randomIndexChange[10] = true;
            }

            spriteRenderer.color = skyColorScripts[9].colorMid[randomIndex[9]];
        }
        else if (time >= 68400 && time < 72000)
        {
            if (randomIndexChange[10])
            {
                randomIndex[10] = Random.Range(0, skyColorScripts[10].colorMid.Length);
                randomIndexChange[10] = false;
            }

            fraction = (time - 68400) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[9].colorMid[randomIndex[9]], skyColorScripts[10].colorMid[randomIndex[10]], fraction);
        }
        else if (time >= 72000 && time < 75600)
        {
            if (randomIndexChange[10])
            {
                randomIndex[10] = Random.Range(0, skyColorScripts[10].colorMid.Length);
                randomIndexChange[10] = false;
                randomIndexChange[11] = true;
            }

            spriteRenderer.color = skyColorScripts[10].colorMid[randomIndex[10]];
        }
        else if (time >= 75600 && time < 79200)
        {
            if (randomIndexChange[11])
            {
                randomIndex[11] = Random.Range(0, skyColorScripts[11].colorMid.Length);
                randomIndexChange[11] = false;
            }

            fraction = (time - 75600) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[10].colorMid[randomIndex[10]], skyColorScripts[11].colorMid[randomIndex[11]], fraction);
        }
        else if (time >= 79200 && time < 82800)
        {
            if (randomIndexChange[11])
            {
                randomIndex[11] = Random.Range(0, skyColorScripts[11].colorMid.Length);
                randomIndexChange[11] = false;
                randomIndexChange[0] = true;
            }

            spriteRenderer.color = skyColorScripts[11].colorMid[randomIndex[11]];
        }
        else if (time >= 82800 && time < 86400)
        {
            if (randomIndexChange[0])
            {
                randomIndex[0] = Random.Range(0, skyColorScripts[0].colorMid.Length);
                randomIndexChange[0] = false;
            }

            fraction = (time - 82800) / 3600;
            spriteRenderer.color = Color.Lerp(skyColorScripts[11].colorMid[randomIndex[11]], skyColorScripts[0].colorMid[randomIndex[0]], fraction);
        }

    }
}
