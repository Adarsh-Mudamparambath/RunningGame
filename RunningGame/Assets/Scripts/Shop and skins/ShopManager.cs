using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private Transform shopParent;
    [SerializeField] private Transform skinsParent;
    [SerializeField] private Transform Diamond;

    [SerializeField] private GameObject skinsCardPrefab;
    [SerializeField] private List<SkinData> skinDatasList;

    private void Start()
    {
        PopulateSkinsSection();
    }

    private void PopulateSkinsSection()
    {
        foreach (var skinData in skinDatasList)
        {
            // Instantiate the card
            GameObject skinCard = Instantiate(skinsCardPrefab, skinsParent);

            // Find components in the card
            Transform iconTransform = skinCard.transform.Find("Icon");
            Transform nameTransform = skinCard.transform.Find("Name");

            if (iconTransform != null && nameTransform != null)
            {
                // Set the sprite and name
                Image iconImage = iconTransform.GetComponent<Image>();
                TextMeshProUGUI nameText = nameTransform.GetComponent<TextMeshProUGUI>();

                if (iconImage != null)
                    iconImage.sprite = skinData.skinIcon;

                if (nameText != null)
                    nameText.text = skinData.skinName;
            }
        }
    }

}
