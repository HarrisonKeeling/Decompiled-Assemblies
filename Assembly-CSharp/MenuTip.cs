using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuTip : MonoBehaviour
{
	public Text text;

	public LoadingScreen screen;

	public static Translate.TokenisedPhrase[] MenuTips;

	private int currentTipIndex;

	private float nextTipTime;

	static MenuTip()
	{
		MenuTip.MenuTips = new Translate.TokenisedPhrase[] { new Translate.TokenisedPhrase("menutip_bag", "Don't forget to create a sleeping bag! You can pick which one to respawn at on the death screen."), new Translate.TokenisedPhrase("menutip_baggive", "You can give a sleeping bag to a steam friend."), new Translate.TokenisedPhrase("menutip_sneakanimal", "Some animals have blind spots. Sneak up from behind to get close enough to make the kill."), new Translate.TokenisedPhrase("menutip_humanmeat", "Human meat will severely dehydrate you."), new Translate.TokenisedPhrase("menutip_hammerpickup", "You can use the Hammer tool to pick up objects. Providing they are unlocked and/or opened."), new Translate.TokenisedPhrase("menutip_seedsun", "Ensure seeds are placed in full sunlight for faster growth."), new Translate.TokenisedPhrase("menutip_lakeriverdrink", "You can drink from lakes and rivers to recover a portion of your health."), new Translate.TokenisedPhrase("menutip_cookmeat", "Cook meat in a campfire to increase its healing abilities."), new Translate.TokenisedPhrase("menutip_rotatedeployables", "Rotate deployables before placing them by pressing [R]"), new Translate.TokenisedPhrase("menutip_repairblocked", "You cannot repair or upgrade building parts for 30 seconds after they've been damaged."), new Translate.TokenisedPhrase("menutip_hammerrepair", "Hit objects with your hammer to repair them, providing you have the necessary resources."), new Translate.TokenisedPhrase("menutip_altlook", "Hold [+altlook] to check your surroundings."), new Translate.TokenisedPhrase("menutip_upkeepwarning", "The larger you expand your base the more it'll cost to upkeep"), new Translate.TokenisedPhrase("menutip_report", "If you wish to report any in-game issues try pressing F7"), new Translate.TokenisedPhrase("menutip_radwash", "Submerge yourself in water and slosh around to remove radiation"), new Translate.TokenisedPhrase("menutip_switchammo", "Switch between ammo types by holding the [+reload] key"), new Translate.TokenisedPhrase("menutip_riverplants", "Edible plants are commonly found on river sides."), new Translate.TokenisedPhrase("menutip_buildwarnmonument", "Building near monuments may attract unwanted attention."), new Translate.TokenisedPhrase("menutip_vending", "Sell your unwanted items safely by crafting a vending machine."), new Translate.TokenisedPhrase("menutip_switchammo", "Switch between ammo types by holding the [+reload] key."), new Translate.TokenisedPhrase("menutip_oretip", "Stone and Ore Nodes are most commonly found around cliffs, mountains and other rock formations."), new Translate.TokenisedPhrase("menutip_crouchwalk", "Crouching allows you to move silently."), new Translate.TokenisedPhrase("menutip_accuracy", "Standing still or crouching while shooting increases accuracy."), new Translate.TokenisedPhrase("menutip_crashharvest", "You can harvest metal from helicopter and apc crash sites."), new Translate.TokenisedPhrase("menutip_canmelt", "You can melt Empty Cans in a campfire to receive Metal Fragments."), new Translate.TokenisedPhrase("menutip_stacksplit", "You can split a stack of items in half by holding [Middle Mouse] and dragging"), new Translate.TokenisedPhrase("menutip_divesite", "Floating Bottles on the ocean indicate a potential dive site, You may find treasure below") };
	}

	public MenuTip()
	{
	}

	public void OnEnable()
	{
		this.currentTipIndex = UnityEngine.Random.Range(0, (int)MenuTip.MenuTips.Length);
	}

	public void Update()
	{
		if (!LoadingScreen.isOpen)
		{
			return;
		}
		if (Time.realtimeSinceStartup >= this.nextTipTime)
		{
			this.currentTipIndex++;
			if (this.currentTipIndex >= (int)MenuTip.MenuTips.Length)
			{
				this.currentTipIndex = 0;
			}
			this.nextTipTime = Time.realtimeSinceStartup + 6f;
			this.UpdateTip();
		}
	}

	public void UpdateTip()
	{
		this.text.text = MenuTip.MenuTips[this.currentTipIndex].translated;
		base.GetComponent<HorizontalLayoutGroup>().enabled = false;
		base.GetComponent<HorizontalLayoutGroup>().enabled = true;
	}
}