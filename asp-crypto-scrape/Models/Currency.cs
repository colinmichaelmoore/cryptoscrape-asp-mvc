namespace asp_crypto_scrape.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Currency
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public string Market { get; set; }

        public string Price { get; set; }

        public string Supply { get; set; }

        public string Volume { get; set; }

        public string Hour { get; set; }

        public string Day { get; set; }

        public string Week { get; set; }

        public string DateTime { get; set; }
    }
}
