﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paylike.NET.ResponseModels
{
    public class ApiResponse<T> where T : class, new()
    {
        public ApiResponse()
        {
            this.Content = new T();
        }

        public bool IsError
        {
            get { return Error != null; }
        }

        public object Error { get; internal set; }

        public T Content { get; internal set; }
    }
}