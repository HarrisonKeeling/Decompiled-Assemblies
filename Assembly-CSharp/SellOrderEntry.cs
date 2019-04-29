using System;
using UnityEngine;

public class SellOrderEntry : MonoBehaviour, IInventoryChanged
{
	public VirtualItemIcon MerchandiseIcon;

	public VirtualItemIcon CurrencyIcon;

	private ItemDefinition merchandiseInfo;

	private ItemDefinition currencyInfo;

	public GameObject buyButton;

	public GameObject cantaffordNotification;

	public GameObject outOfStockNotification;

	private LootPanelVendingMachine vendingPanel;

	public UIIntegerEntry intEntry;

	public SellOrderEntry()
	{
	}
}