﻿namespace SafakDepoAPI.Models
{
    public class ShipmentPallet
    {
        public int ShipmentId { get; set; }
        public Shipment Shipment { get; set; } = null!;
        public int PalletId { get; set; }
        public Pallet Pallet { get; set; } = null!;
    }
}
