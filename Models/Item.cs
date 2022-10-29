class Item
  {
    protected string itemName;
    protected string itemDescription;
    protected bool useable, sellable;
    protected int itemValue;
    protected int itemID;

    virtual public void UseItem() 
    {
      //Should return the default can't use text. Override in the derived classes for different behavior.
      //Example in the console
      Console.WriteLine("This item cannot be used...");
    }
  }

  class KeyItem : Item 
  {
    public KeyItem(string name, string description, bool canUse)
    {
      itemName = name;
      itemDescription = description;
      useable = canUse;
      sellable = false;
      itemValue = -1;
    }
  }

  class ConsumableItem : Item
  {
    int itemEffect;
    float effectStrength;
    public ConsumableItem(string inName, string inDescription, int inValue, int itemEffectID, float effectStrength)
    {
      this.itemName = inName;
      this.itemDescription = inDescription;
      this.useable = true;
      this.sellable = true;
      this.itemValue = inValue;
      this.itemEffect = itemEffectID;
      this.effectStrength = effectStrength;
    }

    public void UseItem()
    {
      ItemUseEffects.DirectToItemEffect(itemEffect, effectStrength);
    }
  }

  class Equipment : Item
  {

  }

  class ResourceItem : Item
  {

  }

  class ItemUseEffects
  {
    public static void DirectToItemEffect(int effectId, float effectStrength)
    {
      switch (effectId)
      {
        case 0: Heal("[Lazy placeholder]", effectStrength);
          break;
        case 1:
          break;
        case 2:
          break;
        case 3:
          break;
        default:
          break;
      }
    }

    private static void Heal(string target, float strength)
    {

    }
  }

  //item variables..., itemType

  //textId, text

  //conversationOrNot, textId, characterIDs, text ** text ***

  //Example
  //true| 2| Hey what's up? ** Nothing much you? ** Same boring as always. ** Yup life do be that way.