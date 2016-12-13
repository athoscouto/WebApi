using System;
using System.Collections.Generic;

namespace WebStack.QA.Test.OData.DateTimeOffsetSupport
{
    public class File
    {
        public int FileId { get; set; }

        public string Name { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? DeleteDate { get; set; }

        public IList<DateTimeOffset> ModifiedDates { get; set; }
    }
}
