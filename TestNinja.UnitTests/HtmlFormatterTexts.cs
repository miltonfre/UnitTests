using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class HtmlFormatterTexts
    {

        [Fact]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter=new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");


            //specific assertion
            Assert.Equal("<strong>abc</strong>", result,ignoreCase:true);// not recommended

            //more general
            Assert.StartsWith("<strong>", result,StringComparison.CurrentCultureIgnoreCase); 
            Assert.EndsWith("</strong>", result, StringComparison.CurrentCultureIgnoreCase); 
            Assert.Contains("abc", result, StringComparison.CurrentCultureIgnoreCase); 
        }
    }
}
