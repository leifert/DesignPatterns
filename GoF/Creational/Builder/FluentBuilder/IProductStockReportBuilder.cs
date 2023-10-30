﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public interface IProductStockReportBuilder
    {
        IProductStockReportBuilder BuildHeader();
        IProductStockReportBuilder BuildBody();
        IProductStockReportBuilder BuildFooter();
        ProductStockReport GetReport();
    }
}
