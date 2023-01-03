using Common.Helper.Enums;
using Common.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.Helpers
{
    public class ModelResult<T> where T : class
    {
        public List<ErrorMessageObject> Errors { get; set; }
        public T Result { get; set; }

        public List<T> ResultList { get; set; }

        public ModelResult()
        {
            Errors = new List<ErrorMessageObject>();
        }

        public void AddError(ErrorMessageCode code, string message)
        {
            Errors.Add(new ErrorMessageObject() { Code = code, Message = message });
        }
    }
}
