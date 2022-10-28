﻿using ExportServiceDemo.Strategies;

namespace ExportServiceDemo.Contexts
{

    /// <summary>
    /// Context
    /// </summary>
    public class Order
    {
        public string Customer { get; set; }

        public int Amount { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public Order(string customer, int amount, string name)
        {
            Customer = customer;
            Amount = amount;
            Name = name;
        }

        public void Export(IExportService exportService)
        {
            if (exportService is null)
            {
                throw new ArgumentNullException(nameof(exportService));
            }

            exportService.Export(this);
        }
    }

}
