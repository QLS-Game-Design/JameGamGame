using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public PlayerMovement player;
    private UnityEngine.UI.Image Healthbar;
    [SerializeField] private float healthBarSmoothness = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] he = GameObject.FindGameObjectsWithTag("Player");
        player = he[0].GetComponent<PlayerMovement>();
        Healthbar = GetComponent<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Healthbar.fillAmount = Mathf.Lerp(Healthbar.fillAmount,player.currHealth / player.maxHealth,healthBarSmoothness * Time.deltaTime);
    }
}
