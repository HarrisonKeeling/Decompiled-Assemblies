using Facepunch.Steamworks;
using Newtonsoft.Json;
using System;

namespace Rust.Workshop
{
	public class ItemSchema
	{
		public int appid;

		public ItemSchema.Item[] items;

		public ItemSchema()
		{
		}

		public class Item
		{
			public string name;

			public uint itemdefid;

			public string type;

			public string price_category;

			public string icon_url;

			public string icon_url_large;

			public bool marketable;

			public bool tradable;

			public bool commodity;

			public string market_hash_name;

			public string market_name;

			public string bundle;

			public string description;

			public string workshopid;

			public string itemshortname;

			public string tags;

			public string store_tags;

			public string exchange;

			public bool store_hidden;

			public string background_color;

			public string name_color;

			[NonSerialized]
			public DropChance dropChance;

			public string workshopdownload;

			[JsonIgnore]
			public float Price
			{
				get
				{
					return Inventory.PriceCategoryToFloat(this.price_category);
				}
			}

			public Item()
			{
			}
		}
	}
}