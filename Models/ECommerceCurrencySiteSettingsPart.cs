﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orchard.ContentManagement;

namespace Nwazet.Commerce.Models {
    public class ECommerceCurrencySiteSettingsPart : ContentPart {
        [Required,MaxLength(3)]
        public string CurrencyCode
        {
            get {
                string cc = this.Retrieve(p => p.CurrencyCode);
                return string.IsNullOrWhiteSpace(cc) ? "USD" : cc; //default is USD
            }
            set { this.Store(p => p.CurrencyCode, value); }
        }
    }
}
