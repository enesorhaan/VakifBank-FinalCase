﻿using Erp.Base.Enum;

namespace Erp.Dto
{
    public class DealerRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string DealerName { get; set; }
        public string Address { get; set; }
        public string BillingAddress { get; set; }
        public string TaxOffice { get; set; }
        public int TaxNumber { get; set; }
        public decimal? MarginPercentage { get; set; }
    }

    public class DealerResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DealerName { get; set; }
        public string Address { get; set; }
        public string BillingAddress { get; set; }
        public string TaxOffice { get; set; }
        public int TaxNumber { get; set; }
        public decimal? MarginPercentage { get; set; }
    }
}
