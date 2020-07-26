﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace MobileBlazorBindingsXaminals.Models
{
    public class Animal
    {
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
    }
}
