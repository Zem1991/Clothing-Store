public enum ItemType
{
    UNSPECIFIED,
    HEAD_CLOTHING,
    TORSO_CLOTHING,
    LEGS_CLOTHING,
    FEET_CLOTHING,
}

public static class ItemTypeEnum
{
    public static bool IsCompatibleWith(this ItemType itemType, Item item)
    {
        if (itemType == ItemType.UNSPECIFIED) return true;
        return itemType == item.itemData.GetItemType();
    }
}