﻿namespace SafakDepoAPI.Models
{
    public class Pallet
    {
        public int Id { get; set; }
        public int PalletNumber { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; } = 0;
        public required string Location { get; set; }
        public List<ShipmentPallet> ShipmentPallets { get; set; } = null!;
        public bool IsActive { get; set; } = true;
    }
}
