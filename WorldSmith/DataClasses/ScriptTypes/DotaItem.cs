/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.DataClasses.UI;
using WorldSmith.Panels;
using WorldSmith.Dialogs;

namespace WorldSmith.DataClasses
{
	public partial class DotaItem : DotaAbility
	{
		[Category("General")]
		[Description("How much this item costs. This value is overriden by recipe requirements.")]
		[DefaultValue(0)]
		public int ItemCost
		{
			get;
			set;
		}

		[Category("Charges")]
		[Description("How many charges this item starts with.")]
		[DefaultValue(0)]
		public int ItemInitialCharges
		{
			get;
			set;
		}

		[Category("General")]
		[Description("No Description Set")]
		[DefaultValue(true)]
		public bool ItemCombinable
		{
			get;
			set;
		}

		[Category("General")]
		[Description("No Description Set")]
		[DefaultValue(true)]
		public bool ItemPermanent
		{
			get;
			set;
		}

		[Category("General")]
		[Description("If this item is stackable or not. Usually used for consumables.")]
		[DefaultValue(false)]
		public bool ItemStackable
		{
			get;
			set;
		}

		[Category("General")]
		[Description("States if this item is a recipe or not.")]
		[DefaultValue(false)]
		public bool ItemRecipe
		{
			get;
			set;
		}

		[Category("General")]
		[Description("States if you are able to drop this item on the ground.")]
		[DefaultValue(true)]
		public bool ItemDroppable
		{
			get;
			set;
		}

		[Category("Purchase")]
		[Description("States whether or not you can purchase this item.")]
		[DefaultValue(true)]
		public bool ItemPurchasable
		{
			get;
			set;
		}

		[Category("Purchase")]
		[Description("States whether or not you can sell this item.")]
		[DefaultValue(true)]
		public bool ItemSellable
		{
			get;
			set;
		}

		[Category("Charges")]
		[Description("States whether or not this item requires charges.")]
		[DefaultValue(false)]
		public bool ItemRequiresCharges
		{
			get;
			set;
		}

		[Category("General")]
		[Description("States whether or not you can destroy this item by attacking it.")]
		[DefaultValue(true)]
		public bool ItemKillable
		{
			get;
			set;
		}

		[Category("General")]
		[Description("States whether or not you can disassemble this item.")]
		[DefaultValue(false)]
		public bool ItemDisassemblable
		{
			get;
			set;
		}

		public enum ItemShareabilityEnum
		{
			ITEM_PARTIALLY_SHAREABLE,
			ITEM_FULLY_SHAREABLE,
			ITEM_FULLY_SHAREABLE_STACKING,
			ITEM_NOT_SHAREABLE,
		}

		[Category("General")]
		[Description("States whether or not you can share this item.")]
		[DefaultValue(ItemShareabilityEnum.ITEM_NOT_SHAREABLE)]
		public ItemShareabilityEnum ItemShareability
		{
			get;
			set;
		}

		[Category("Purchase")]
		[Description("States whether or not this item displays a notification when bought.")]
		[DefaultValue(false)]
		public bool ItemDeclaresPurchase
		{
			get;
			set;
		}

		[Flags]
		public enum ItemDeclarationsFlags
		{
			DECLARE_PURCHASES_NONE = 0,
			DECLARE_PURCHASES_IN_SPEECH = 1,
			DECLARE_PURCHASES_TO_SPECTATORS = 2,
			DECLARE_PURCHASES_TO_TEAMMATES = 4,
		}

		[Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Purchase")]
		[Description("States the type of notification displayed when this item is purchased.")]
		[DefaultValue(ItemDeclarationsFlags.DECLARE_PURCHASES_NONE)]
		public ItemDeclarationsFlags ItemDeclarations
		{
			get;
			set;
		}

	}
}
