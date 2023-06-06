namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Хранит перечисление статуса заказа
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
