using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public int lifeAmount;
    [SerializeField] private int maxLife;
    [SerializeField] private GameObject healthBar;
    
    private void Start()
    {
        healthBar.GetComponent<Slider>().maxValue = maxLife;
        healthBar.GetComponent<Slider>().value = maxLife;
    }

    
    public void UpdateHealthBar()
    {
        healthBar.GetComponent<Slider>().value = lifeAmount;
    }


}