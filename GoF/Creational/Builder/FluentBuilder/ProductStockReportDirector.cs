using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class ProductStockReportDirector
    {
        private readonly IProductStockReportBuilder _productStockReportBuilder;

        public ProductStockReportDirector(IProductStockReportBuilder productStockReportBuilder)
        {
            _productStockReportBuilder = productStockReportBuilder;
        }
        public void BuildStockReport(string type)
        {
            if (type == "OnlyHeader")
            {
                _productStockReportBuilder.BuildHeader();
            }
            else
            {
                _productStockReportBuilder
                    .BuildHeader()
                    .BuildBody()
                    .BuildFooter();
               
            }
        }
    }
}
