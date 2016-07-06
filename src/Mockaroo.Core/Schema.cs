﻿using Gigobyte.Mockaroo.Fields;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gigobyte.Mockaroo
{
    [JsonArray]
    public class Schema : List<IField>
    {
        public Schema() : base()
        {
        }

        public Schema(int capacity) : base(capacity)
        {
        }

        public Schema(params IField[] fields) : base(fields)
        {

        }

        public Schema(IEnumerable<IField> collection) : base(collection)
        {
        }


    }
}
