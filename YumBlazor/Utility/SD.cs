﻿using YumBlazor.Data;

namespace YumBlazor.Utility;

public static class SD
{
    //role
    public static string Role_Admin { get; set; } = "Admin";
    public static string Role_Customer { get; set; } = "Customer";

    //koszyk
    public static string StatusPending = "Pending";
    
    public static string StatusReadyForPickUp = "ReadyForPickUp";
    
    public static string StatusCompleted = "Completed";
    
    public static string StatusCancelled = "Cancelled";


    public static List<OrderDetail> ConvertShoppingCartListToOrderDetails(List<ShoppingCart> shoppingCarts)
    {
        List<OrderDetail> orderDetails = new List<OrderDetail>();

        foreach (var cart in shoppingCarts)
        {
            OrderDetail orderDetail = new OrderDetail
            {
                ProductId = cart.ProductId,
                Count = cart.Count,
                Price = Convert.ToDouble(cart.Product.Price)

            };
            orderDetails.Add(orderDetail);
        }
        return orderDetails;
    }
    
}