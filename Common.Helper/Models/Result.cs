using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Helper.Enums;

namespace Common.Helper.Models
{
  public  class Result
    {
        public ResultCodeType Code { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
        public string[] ObjectValue { get; set; }

    }
}
