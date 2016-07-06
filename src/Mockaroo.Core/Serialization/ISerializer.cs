﻿using System;
using System.IO;

namespace Gigobyte.Mockaroo.Serialization
{
    public interface ISerializer
    {
        T ReadObject<T>(Stream stream);

        object ReadObject(Type type, Stream stream);

        void WriteObject(object obj, Stream stream);
    }
}